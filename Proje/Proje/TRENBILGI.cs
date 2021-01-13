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
    public partial class TRENBILGI : Form
    {
        public TRENBILGI()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool trenExıst()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("TREN_DUZENLE", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = txtno.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = textBox1.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = textBox2.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "BILGEXIST";
           
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int x = dt.Rows.Count;
            if (x > 0) return true;
            else return false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!trenExıst()){


                OracleConnection connection = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
                connection.Open();
                OracleCommand cmd = new OracleCommand("TREN_DUZENLE", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("x1", OracleDbType.NVarchar2).Value = txtno.Text;
                cmd.Parameters.Add("x2", OracleDbType.NVarchar2).Value = textBox1.Text;
                cmd.Parameters.Add("x3", OracleDbType.NVarchar2).Value = textBox2.Text;
                cmd.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "BILGINSERT";
                cmd.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                trenSelect();
                MessageBox.Show("Tren bilgisi eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void TRENBILGI_Load(object sender, EventArgs e)
        {
            trenSelect();
        }
        public void trenSelect()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("TREN_DUZENLE", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = txtno.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = textBox1.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = textBox2.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "BILGSELECT";

            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection.Open();
            OracleCommand cmd = new OracleCommand("TREN_DUZENLE", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("x1", OracleDbType.NVarchar2).Value = txtno.Text;
            cmd.Parameters.Add("x2", OracleDbType.NVarchar2).Value = textBox1.Text;
            cmd.Parameters.Add("x3", OracleDbType.NVarchar2).Value = textBox2.Text;
            cmd.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "BILGDELETE";
            cmd.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tren bilgisi silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            trenSelect();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtno.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
        }
    }
}
