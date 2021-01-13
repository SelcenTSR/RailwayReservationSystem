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
    public partial class YolcuGiris : Form
    {
        public YolcuGiris()
        {
            InitializeComponent();
        }
       

        private void YolcuGiris_Load(object sender, EventArgs e)
        {

        }

        private void linkUye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyelikFormu fr = new UyelikFormu();
            fr.Show();
            

               
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            YolcuSistemi fr = new YolcuSistemi();

            OracleConnection connection = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "Select * From YOLCU Where TC='" + mskdTc.Text + "' and PASSWORD='" + YolcuSifre.Text + "'";
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = command;
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            int x = tablo.Rows.Count;
            connection.Close();
            if (x > 0)
            {
                fr.tc = mskdTc.Text;
                fr.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }


        }
    }
}
