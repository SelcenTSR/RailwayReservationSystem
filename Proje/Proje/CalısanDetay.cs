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
    public partial class CalısanDetay : Form
    {
        public CalısanDetay()
        {
            InitializeComponent();
        }
        
        public string tcnu;
        private void CalısanDetay_Load(object sender, EventArgs e)
        {
            
            OracleConnection connection = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            lbltc.Text = tcnu;

            command.CommandText = "Select FNAME,LNAME from CALISAN where CTC='" + tcnu + "'";
            DataTable dt1 = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = command;
            da.Fill(dt1);
            lbladsoyad.Text = dt1.Rows[0].ItemArray[0].ToString() + " " + dt1.Rows[0].ItemArray[1].ToString();
            command.CommandText = "SELECT FNAME,LNAME,TC,PHONE FROM YOLCU";
            OracleDataAdapter da1 = new OracleDataAdapter();
            DataTable dt2 = new DataTable();
            da1.SelectCommand = command;
            da1.Fill(dt2);
            dataGridView1.DataSource = dt2;

            command.CommandText = "SELECT * FROM BILET";
            OracleDataAdapter da2 = new OracleDataAdapter();
            DataTable dt3 = new DataTable();
            da2.SelectCommand = command;
            da2.Fill(dt3);
            dataGridView2.DataSource = dt3;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
