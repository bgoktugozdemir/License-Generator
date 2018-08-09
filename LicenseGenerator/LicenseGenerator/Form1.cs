using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LicenseGenerator.Properties;

namespace LicenseGenerator
{
    public partial class Form1 : Form
    {
        public SqlConnection Connection;
        public SqlCommand Command;
        private bool error = false;
        private bool isChangedUsername = false;
        private bool isChangedStartingDate = false;
        private bool isChangedExpirationDate = false;
        private int _error = 0;
        private bool isOpened = false;
        private const string _version = "1.0.3";

        public Form1()
        {
            InitializeComponent();
            SQL();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string password = GenerateLicense();
            SaveLicense(password, Convert.ToInt32(tbDateLimit.Text));
            tbLicenseKey.Text = password;
        }

        private void SQL()
        {
            Connection = new SqlConnection(Properties.Settings.Default.DOVIZConnectionString);
        }

        private string GenerateLicense()
        {
            const string UPPERCASE_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NUMERIC_CHARACTERS = "0123456789";
            const string SPECIAL_CHARACTERS = @"?!#$%&*@\";
            const int PASSWORD_LENGTH = 25 + 4;

            string allowedChars = UPPERCASE_CHARACTERS + NUMERIC_CHARACTERS;
            char[] pass = new char[PASSWORD_LENGTH];

            Random rd = new Random();

            for (int i = 0; i < PASSWORD_LENGTH; i++)
            {
                //4'LÜ BLOKLAR
                //if (i % 5 == 4)
                //{
                //    pass[i] = '-';
                //}
                //5'Lİ BLOKLAR
                if (i % 6 == 5)
                {
                    pass[i] = '-';
                }
                else
                {
                    pass[i] = allowedChars[rd.Next(0, allowedChars.Length)];
                }
            }

            return new string(pass);
        }

        #region GetFromDB

        private DateTime GetStartingDateFromDB()
        {
            Connection.Open();
        
            string query = "SELECT StartingDate " +
                           "FROM tblLicense " +
                           "WHERE LicenseKey = @LicenseKey";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseKey", tbLicenseKeyUpdate.Text);

            object StartingDate = Command.ExecuteScalar();
            Connection.Close();

            if (StartingDate == DBNull.Value)
            {
                return DateTime.Now;
            }

            return (DateTime)StartingDate;
        }

        private DateTime GetExpirationDateFromDB()
        {
            Connection.Open();

            string query = "SELECT ExpirationDate " +
                           "FROM tblLicense " +
                           "WHERE LicenseKey = @LicenseKey";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseKey", tbLicenseKeyUpdate.Text);

            object ExpirationDate = Command.ExecuteScalar();
            Connection.Close();

            if (ExpirationDate == DBNull.Value)
            {
                return DateTime.Now;
            }

            return (DateTime)ExpirationDate;

        }

        private int GetDateLimitFromDB()
        {
            Connection.Open();

            string query = "SELECT DateLimit " +
                           "FROM tblLicense " +
                           "WHERE LicenseKey = @LicenseKey";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseKey", tbLicenseKeyUpdate.Text);

            int DateLimit = (int)Command.ExecuteScalar();

            Connection.Close();
        
            return DateLimit;
        }

        private string GetUsernameFromDB()
        {
            Connection.Open();

            string query = "SELECT Username " +
                           "FROM tblLicense " +
                           "WHERE LicenseKey = @LicenseKey";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseKey", tbLicenseKeyUpdate.Text);

            object tbUsernameUpdate = Command.ExecuteScalar();

            Connection.Close();
            if (tbUsernameUpdate != DBNull.Value)
            {
                return tbUsernameUpdate.ToString();
            }

            return DBNull.Value.ToString();
        }

        private bool GetIsUsableFromDB()
        {
            Connection.Open();

            string query = "SELECT IsUsed " +
                           "FROM tblLicense " +
                           "WHERE LicenseKey = @LicenseKey";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseKey", tbLicenseKeyUpdate.Text);

            bool IsUsed = !(bool)Command.ExecuteScalar();

            Connection.Close();
            return IsUsed;
        }

        #endregion

        #region SetToDB

        private void SetDatasToTB(string licenseKey)
        {
            string query = "UPDATE tblLicense " +
                           "SET IsUsed = @IsUsed , DateLimit = @DateLimit";

            if (isChangedStartingDate)
            {
                query += " , StartingDate = @StartingDate";
            }
            if (isChangedExpirationDate)
            {
                query += " , ExpirationDate = @ExpirationDate";
            }
            if (isChangedUsername)
            {
                query += " , Username = @Username";
            }

            query += " WHERE LicenseKey = @LicenseKey";

            Connection.Open();

            Command = new SqlCommand(query, Connection);
            if (cbIsUsableUpdate.Text == "Usable")
            {
                Command.Parameters.AddWithValue("@IsUsed", 0);
            }
            else
            {
                Command.Parameters.AddWithValue("@IsUsed", 1);
            }

            Command.Parameters.AddWithValue("@StartingDate", dtpStartingDateUpdate.Value);
            Command.Parameters.AddWithValue("@ExpirationDate", dtpExpirationDateUpdate.Value);
            Command.Parameters.AddWithValue("@Username", tbUsernameUpdate.Text);
            Command.Parameters.AddWithValue("@DateLimit", tbDateLimitUpdate.Text);
            Command.Parameters.AddWithValue("@LicenseKey", licenseKey);

            Command.ExecuteNonQuery();

            Connection.Close();
        }

        #endregion

        private void SaveLicense(string licenseKey, int dateLimit)
        {
            Connection.Open();

            try
            {
                string query = "INSERT INTO tblLicense(LicenseKey, DateLimit) " +
                               "VALUES (@LicenseKey, @DateLimit)";

                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@LicenseKey", licenseKey);
                Command.Parameters.AddWithValue("@DateLimit", dateLimit);

                Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (_error >= 5)
                {
                    MessageBox.Show("ŞİFRE OLUŞTURULAMADI!", "İşlem Başarısız Oldu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                    return;
                }
                SaveLicense(licenseKey, dateLimit);
                _error++;
            }
            finally
            {
                Connection.Close();
            }
        }

        private void RemoveLicense(string licenseKey)
        {
            string query = "DELETE FROM tblLicense " +
                          "WHERE LicenseKey = @LicenseKey";
            try
            {
                Connection.Open();
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@LicenseKey", licenseKey);
                Command.ExecuteNonQuery();
                MessageBox.Show($"'{tbLicenseKeyUpdate.Text}' numaralı lisans silindi.", "Lisans Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbLicenseKeyUpdate.Text = String.Empty;
                tbUsernameUpdate.Text = String.Empty;
                tbDateLimitUpdate.Text = String.Empty;
                cbIsUsableUpdate.Text = String.Empty;
                dtpStartingDateUpdate.Value = DateTime.Now;
                dtpExpirationDateUpdate.Value = DateTime.Now;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Connection.Close();
            }
        }

        private void tbDateLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += $" [v{_version}]";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isOpened)
            {
                this.Width = 506;
                this.Height = 154;
                btnOpen.Text = ">>";
                isOpened = false;
            }
            else if (!isOpened)
            {
                this.Width = 999;
                this.Height = 154;
                btnOpen.Text = "<<";
                isOpened = true;
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (tbLicenseKeyUpdate.Text.Length == tbLicenseKeyUpdate.MaxLength)
            {
                try
                {
                    tbDateLimitUpdate.Text = GetDateLimitFromDB().ToString();
                    tbUsernameUpdate.Text = GetUsernameFromDB();
                    cbIsUsableUpdate.Text = GetIsUsableFromDB() ? cbIsUsableUpdate.Items[0].ToString() : cbIsUsableUpdate.Items[1].ToString();
                    dtpStartingDateUpdate.Value = GetStartingDateFromDB();
                    dtpExpirationDateUpdate.Value = GetExpirationDateFromDB();
                    this.Width = 999;
                    this.Height = 271;
                }
                catch
                {
                    MessageBox.Show(string.Format(Resources.Lisans_Bilgisine_Ulasilamadi, tbLicenseKeyUpdate.Text), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveLicense(tbLicenseKeyUpdate.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SetDatasToTB(tbLicenseKeyUpdate.Text);
                MessageBox.Show(string.Format(Resources.Lisans_Bilgileri_Güncellendi, tbLicenseKeyUpdate.Text),
                    "Lisans Güncellemesi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                MessageBox.Show(string.Format(Resources.Lisans_Bilgileri_Güncellenemedi, tbLicenseKeyUpdate.Text),
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isChangedStartingDate = false;
                isChangedExpirationDate = false;
                isChangedUsername = false;
            }
        }
        
        private void DtpStartingDateUpdate_DropDown(object sender, EventArgs e) => isChangedStartingDate = true;

        private void dtpExpirationDateUpdate_DropDown(object sender, EventArgs e) => isChangedExpirationDate = true;

        private void tbUsernameUpdate_TextChanged(object sender, EventArgs e) => isChangedUsername = true;

        private void btnNULL_1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tblLicense " +
                           " SET StartingDate = @StartingDate " +
                           " WHERE LicenseKey = '" + tbLicenseKeyUpdate.Text + "'";

            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@StartingDate", DBNull.Value);
            Command.ExecuteNonQuery();
            Connection.Close();
            isChangedStartingDate = false;
        }

        private void btnNULL_2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tblLicense " +
                           "SET ExpirationDate = " + DBNull.Value +
                           "WHERE LicenseKey = " + tbLicenseKeyUpdate.Text;

            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Command.ExecuteNonQuery();
            Connection.Close();
            isChangedExpirationDate = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        public void FillUpdateLicense(string license, object sender, EventArgs e)
        {
            tbLicenseKeyUpdate.Text = license;
            btnGetir_Click(sender, e);
        }
    }
}
