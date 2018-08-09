using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseGenerator
{
    public partial class Form2 : Form
    {
        private SqlConnection Connection;
        private SqlCommand Command;
        private SqlDataAdapter DataAtapter;
        private Form1 form;
        private DataTable table;

        public Form2(Form1 form)
        {
            this.form = form;
            SQL();
            InitializeComponent();
        }

        public void SQL()
        {
            Connection = new SqlConnection(Properties.Settings.Default.DOVIZConnectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOVIZDataSet.tblLicense' table. You can move, or remove it, as needed.
            FillTable();

        }

        private void FillTable(string condition = null)
        {
            string query = "SELECT * " +
                           "FROM tblLicense ";
            if (condition != null)
            {
                query += $"WHERE {condition} ";
            }
            Connection.Open();

            DataAtapter = new SqlDataAdapter(query, Connection);
            table = new DataTable();
            DataAtapter.Fill(table);
            dataGridView1.DataSource = table;

            Connection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form.FillUpdateLicense(((DataGridView)sender).CurrentRow.Cells[0].Value.ToString(),sender, e);
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cbIsUsable.Text == "Usable")
            {
                FillTable("IsUsed = 0");
            }
            else if (cbIsUsable.Text == "Not Usable")
            {
                FillTable("IsUsed = 1");
            }
            else
            {
                FillTable();
            }
        }
    }
}
