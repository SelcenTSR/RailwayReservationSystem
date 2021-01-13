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
    public partial class YoneticiDetay : Form
    {
        public YoneticiDetay()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public string tcnumara;
        private void YoneticiDetay_Load(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            lbltc.Text = tcnumara;

            command.CommandText = "Select fName,lName from YONETİCİ where YTC='" + tcnumara + "'";
            DataTable dt1 = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = command;
            da.Fill(dt1);
            lbladsoyad.Text = dt1.Rows[0].ItemArray[0].ToString() + " " + dt1.Rows[0].ItemArray[1].ToString();

            trenSelect();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtno.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            txtnereden.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            txtnereye.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            msktarih.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            msksaat.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            txtid.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("TREN_BILGIDUZENLE", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = txtno.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = txtnereden.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = txtnereye.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = msktarih.Text;
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = msksaat.Text;
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = txtid.Text;
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "BILGIDELETE";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
              MessageBox.Show("Tren Kaydı Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            trenSelect();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TRENBILGI fs = new TRENBILGI();
            fs.Show();

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("TREN_BILGIDUZENLE", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = txtno.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = txtnereden.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = txtnereye.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = msktarih.Text;
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = msksaat.Text;
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = txtid.Text;
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "BILGIUPDATE";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            trenSelect();
            

            MessageBox.Show("Tren Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void YoneticiDetay_Shown(object sender, EventArgs e)
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("TREN_DUZENLE", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "BILGSELECT";

            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int x = dt.Rows.Count;
            txtno.Items.Clear();
            for (int i = 0; i < x; i++)
            {
                txtno.Items.Add(dt.Rows[i].ItemArray[0]);


            }
        }

        private void YoneticiDetay_Enter(object sender, EventArgs e)
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("TREN_DUZENLE", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "BILGSELECT";

            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int x = dt.Rows.Count;
            txtno.Items.Clear();
            for (int i = 0; i < x; i++)
            {
                txtno.Items.Add(dt.Rows[i].ItemArray[0]);


            }
        }

        private void txtno_DropDown(object sender, EventArgs e)
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("TREN_DUZENLE", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "BILGSELECT";

            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int x = dt.Rows.Count;
            txtno.Items.Clear();
            for (int i = 0; i < x; i++)
            {
                txtno.Items.Add(dt.Rows[i].ItemArray[0]);


            }
        }
        public bool trenExist()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("TREN_BILGIDUZENLE", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = txtno.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = txtnereden.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = txtnereye.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = msktarih.Text;
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = msksaat.Text;
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = txtid.Text;
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "BILGIEXIST";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int x = dt.Rows.Count;
            if (x > 0) return true;
            else return false;

        }
        public void trenSelect()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("TREN_BILGIDUZENLE", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = txtno.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = txtnereden.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = txtnereye.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = msktarih.Text;
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = msksaat.Text;
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = txtid.Text;
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "BILGISELECT";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!trenExist())
            {
                OracleConnection connection1 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
                connection1.Open();
                OracleCommand command = new OracleCommand("TREN_BILGIDUZENLE", connection1);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = txtno.Text;
                command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = txtnereden.Text;
                command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = txtnereye.Text;
                command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = msktarih.Text;
                command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = msksaat.Text;
                command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = txtid.Text;

                command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "BILGIINSERT";
                command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                trenSelect();
                MessageBox.Show("Tren Bilgisi Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtno_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}