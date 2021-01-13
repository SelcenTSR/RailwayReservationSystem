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
    public partial class UyelikFormu : Form
    {
        public UyelikFormu()
        {
            InitializeComponent();
        }
        public bool uyeExist()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("UYE_GIRISI", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value=txtAd.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = txtSoyad.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = mskdTc.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = txtSifre.Text;
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = mskdTel.Text;
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "EXIST";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int x = dt.Rows.Count;
            if (x > 0) return true;
            else return false;

        }
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (!uyeExist())
            {
                OracleConnection connection1 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
                connection1.Open();
                OracleCommand command = new OracleCommand("UYE_GIRISI", connection1);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = txtAd.Text;
                command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = txtSoyad.Text;
                command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = mskdTc.Text;
                command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = txtSifre.Text;
                command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = mskdTel.Text;
                command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "INSERT";
                command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                MessageBox.Show("Kaydınız gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aynı bilgilerde kullanıcı bulunmaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 
     

        }
    }

