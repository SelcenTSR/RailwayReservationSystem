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
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            YoneticiDetay frs = new YoneticiDetay();
            OracleConnection connection = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText="Select * From YONETİCİ Where YTC='"+ msktc.Text+"' and YPASSWORD='"+ txtsifre.Text+"'";
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = command;
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            int x=tablo.Rows.Count;
            connection.Close();
            if (x > 0)
            {
                frs.tcnumara = msktc.Text;
                frs.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }


        }
    }
}
