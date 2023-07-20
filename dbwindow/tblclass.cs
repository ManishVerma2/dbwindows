using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbwindow
{
    public partial class tblclass : Form
    {
        public tblclass()
        {
            InitializeComponent();
        }
        SqlCommand comm = new SqlCommand();
        SqlConnection conn = new SqlConnection(Common.conn);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        int id;

        void getclsdata()
        {
            ds.Tables.Clear();
            comm.CommandText = "Select * From tblclass";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "a");
            dataGridclass.DataSource = ds.Tables["a"];

        }
        void reset()
        {
            txtaddcls.Text = "";
            txtaddcls.Focus();
        }

        void IUDclass(int op)
        {
            comm.Parameters.Clear();
            comm.CommandText = "IUDclass";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@op", op);
            comm.Parameters.AddWithValue("@classid", id);
            comm.Parameters.AddWithValue("@classname", txtaddcls.Text);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            getclsdata();
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            IUDclass(3);
            getclsdata();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            IUDclass(2);
            getclsdata();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            IUDclass(1);
            getclsdata();
        }
        private void dataGridclass_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = Convert.ToInt32(dataGridclass.Rows[e.RowIndex].Cells["Classid"].Value.ToString());
                txtaddcls.Text = dataGridclass.Rows[e.RowIndex].Cells["ClassName"].Value.ToString();
            }
        }

        private void tblclass_Load(object sender, EventArgs e)
        {
            getclsdata();
        }
    }
}
