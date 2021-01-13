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
    public partial class BiletAlma : Form
    {
        public BiletAlma()
        {
            InitializeComponent();
        }
       
        private void BiletAlma_Load(object sender, EventArgs e)
        {
            
            NeredenDoldur();
          

        }
        public void NeredenDoldur()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("BILET_DOLDUR", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x8", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x9", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x10", OracleDbType.NVarchar2).Value = "NEREDENDOLDUR";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmbnereden.Items.Clear();
            int x = dt.Rows.Count;
            for(int i=0; i < x; i++)
            {
                cmbnereden.Items.Add(dt.Rows[i].ItemArray[0]);

            }
            cmbnereye.Items.Clear();
            cmbnereye.SelectedIndex=-1;
        }
        public void NereyeDoldur()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("BILET_DOLDUR", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = cmbnereden.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x8", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x9", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x10", OracleDbType.NVarchar2).Value = "NEREYEDOLDUR";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmbnereye.Items.Clear();
            int x = dt.Rows.Count;
            for (int i = 0; i < x; i++)
            {
                cmbnereye.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }
        public void TarihDoldur()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("BILET_DOLDUR", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = cmbnereden.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = cmbnereye.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x8", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x9", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x10", OracleDbType.NVarchar2).Value = "TARIHDOLDUR";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmbtarih.Items.Clear();
            int x = dt.Rows.Count;
            for (int i = 0; i < x; i++)
            {
                cmbtarih.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }
        public void SaatDoldur()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("BILET_DOLDUR", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = cmbnereden.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = cmbnereye.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = cmbtarih.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x8", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x9", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x10", OracleDbType.NVarchar2).Value = "SAATDOLDUR";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmbsaat.Items.Clear();
            int x = dt.Rows.Count;
            for (int i = 0; i < x; i++)
            {
                cmbsaat.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }
        public string smartstring(Object obj)
        {
            if (obj == null) return "";
            else return obj.ToString();
        }
        public string  TrenBul()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("BILET_DOLDUR", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = cmbnereden.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = cmbnereye.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = cmbtarih.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = cmbsaat.Text;
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x8", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x9", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x10", OracleDbType.NVarchar2).Value = "TRENBUL";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if(dt.Rows.Count!=0)   
            return smartstring(dt.Rows[0].ItemArray[0]);
            return " ";
          
        }
        public void VagonDoldur()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("BILET_DOLDUR", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x", OracleDbType.NVarchar2).Value = TrenBul();
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = cmbnereden.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = cmbnereye.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = cmbtarih.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = cmbsaat.Text;
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x8", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x9", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x10", OracleDbType.NVarchar2).Value = "VAGONDOLDUR";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmbvagon.Items.Clear();
            int x;
            if (dt.Rows.Count != 0)
                x = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            else x = 0;
            for (int i = 1; i <= x; i++)
            {
                cmbvagon.Items.Add(i.ToString());
            }
        }
        public string TrenBilgiIdBul()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("BILET_DOLDUR", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = cmbnereden.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = cmbnereye.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = cmbtarih.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = cmbsaat.Text;
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x8", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x9", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x10", OracleDbType.NVarchar2).Value = "TRENIDBUL";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt.Rows[0].ItemArray[0].ToString();

        }
        public bool KoltukBul(int x)
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("BILET_DOLDUR", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = cmbvagon.Text;
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = x.ToString();
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = TrenBilgiIdBul();
            command.Parameters.Add("x8", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x9", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x10", OracleDbType.NVarchar2).Value = "KOLTUKBUL";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int y=dt.Rows.Count;
            if (y > 0) return false;
            else return true;
        }
        
        public void KoltukDoldur()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("BILET_DOLDUR", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x", OracleDbType.NVarchar2).Value = TrenBul();
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x8", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x9", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x10", OracleDbType.NVarchar2).Value = "KOLTUKDOLDUR";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int x;
            cmbkoltuk.Items.Clear();
            if (dt.Rows.Count != 0)
                x = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            else x = 0;
            for (int i = 1; i <= x; i++)
            {
                if(KoltukBul(i))
                cmbkoltuk.Items.Add(i.ToString());
            }
        }
        public int BiletSay()
        {
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("BILET_DOLDUR", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x8", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x9", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x10", OracleDbType.NVarchar2).Value = "BILETSAY";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter ad = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt.Rows.Count;
        }
        public void BiletInsert()
        {
           
            OracleConnection connection2 = new OracleConnection("User Id=USER;Password=1234;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand command = new OracleCommand("BILET_DOLDUR", connection2);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = "";
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = cmbvagon.Text;
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value =cmbkoltuk.Text;
            command.Parameters.Add("x7", OracleDbType.NVarchar2).Value = TrenBilgiIdBul();
            command.Parameters.Add("x8", OracleDbType.Int64).Value = BiletSay();
            command.Parameters.Add("x9", OracleDbType.NVarchar2).Value = YolcuSistemi.tc1 ;
            command.Parameters.Add("x10", OracleDbType.NVarchar2).Value = "BILETINSERT";
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
         
            BiletInsert();
            cmbnereden.SelectedIndex = -1;
            MessageBox.Show("Biletiniz alınmıştır, iyi yolculuklar dileriz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmbnereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbnereye.SelectedIndex = -1;
            NereyeDoldur();
        }

        private void cmbnereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbtarih.SelectedIndex = -1;
            TarihDoldur();
        }

        private void cmbtarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbsaat.SelectedIndex = -1;
            SaatDoldur();
        }

        private void cmbsaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbvagon.SelectedIndex = -1;
            VagonDoldur();
        }

        private void cmbvagon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbkoltuk.SelectedIndex = -1;
            KoltukDoldur();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            
        }
    }
}
