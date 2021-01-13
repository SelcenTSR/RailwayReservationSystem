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
    public partial class YolcuSistemi : Form
    {
        public YolcuSistemi()
        {
            InitializeComponent();
        }
        public string tc;
        public static string tc1 = "";
       
        private void YolcuSistemi_Load(object sender, EventArgs e)
        {
            
            OracleConnection connection = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            lbltc.Text = tc;
            tc1 = tc;
            command.CommandText = "Select fName,lName,Phone from YOLCU where TC='" + tc+ "'";
            DataTable dt1 = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = command;
            da.Fill(dt1);
            lbladsoyad.Text = dt1.Rows[0].ItemArray[0].ToString() + " " + dt1.Rows[0].ItemArray[1].ToString();
            lbltel.Text = dt1.Rows[0].ItemArray[2].ToString();

            command.CommandText = "SELECT BILET.BID,BILET.TC,BILET.vagon,bılet.koltuk,TRENBILGI.* FROM BILET,TRENBILGI WHERE BILET.trenbılgııd=trenbılgı.trenbılgııd AND BILET.TC='" + tc + "' ";
            DataTable dt2 = new DataTable();
            OracleDataAdapter da1 = new OracleDataAdapter();
            da1.SelectCommand = command;
            da1.Fill(dt2);
            dataGridView1.DataSource = dt2;

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BiletAlma fr = new BiletAlma();
            fr.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyelikDuzenle fr = new UyelikDuzenle();
            fr.Tcno = lbltc.Text;
            fr.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM BILET WHERE BID=" + lblid.Text + " ";
            command.ExecuteNonQuery();
            command.CommandText = "SELECT BILET.BID,BILET.TC,BILET.vagon,bılet.koltuk,TRENBILGI.* FROM BILET,TRENBILGI WHERE BILET.trenbılgııd=trenbılgı.trenbılgııd AND BILET.TC='" + tc + "' ";
            DataTable dt2 = new DataTable();
            OracleDataAdapter da1 = new OracleDataAdapter();
            da1.SelectCommand = command;
            da1.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
