using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LicenseGenerator
{
    public partial class Form1 : Form
    {
        public SqlConnection Connection;
        public SqlCommand Command;
        private int _error = 0;
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

        private void tbDateLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
