using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Proje
{
    public partial class CalısanGiris : Form
    {
        public CalısanGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalısanDetay frs = new CalısanDetay();
            OracleConnection connection = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "Select * From CALISAN Where CTC='" + msktc.Text + "' and CPASSWORD='" + txtsifre.Text + "'";
            OracleDataAdapter adapt = new OracleDataAdapter();
            adapt.SelectCommand = command;
            DataTable tab = new DataTable();
            adapt.Fill(tab);
            int a = tab.Rows.Count;
            
            if (a > 0)
            {
                frs.tcnu = msktc.Text;
                frs.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
            connection.Close();
        }




        
    }
}
