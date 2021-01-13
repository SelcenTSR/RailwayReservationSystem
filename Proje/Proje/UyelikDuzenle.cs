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
    public partial class UyelikDuzenle : Form
    {
        public UyelikDuzenle()
        {
            InitializeComponent();
        }
        public string Tcno;
        OracleConnection connection1 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");

        private void UyelikDuzenle_Load(object sender, EventArgs e)
        {
            connection1.Open();
            mskTC.Text = Tcno;
            OracleCommand komut = new OracleCommand();
            komut.Connection = connection1;
            komut.CommandText = "Select * from YOLCU where TC='" + Tcno + "'";
            DataTable dt1 = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = komut;
            da.Fill(dt1);

            txtad.Text = dt1.Rows[0].ItemArray[0].ToString();
            txtsoyad.Text = dt1.Rows[0].ItemArray[1].ToString();
            txtsifre.Text = dt1.Rows[0].ItemArray[3].ToString();
            msktel.Text = dt1.Rows[0].ItemArray[4].ToString();



            connection1.Close();
        }
        public void uyeUpdate()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("UYE_GIRISI", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = txtad.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = txtsoyad.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = mskTC.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = txtsifre.Text;
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = msktel.Text;
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "UYE_UPDATE";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                uyeUpdate();
            }
        }
    }
}
