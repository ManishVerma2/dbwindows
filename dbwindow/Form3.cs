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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlCommand comm=new SqlCommand();
        SqlConnection conn= new SqlConnection(Common.conn);
        SqlDataAdapter da= new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet dsname=new DataSet();
        int id,nameid;
        bool blnfname=false;    

        void getdata()
        {
            ds.Tables.Clear();
            comm.CommandText = "Select * From tblname";
            comm.CommandType=CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "a");
            dataGridView1.DataSource = ds.Tables["a"];
        }
        void getFname()
        {
            dsname.Tables.Clear();
            comm.CommandText = "Select * From tblname";
            comm.CommandType=CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(dsname, "a");
            cbm.DataSource = dsname.Tables["a"];
            cbm.DisplayMember = "firstname";
            cbm.ValueMember = "id";
            blnfname = true;
            if(blnfname== true)
            {
                if (dsname.Tables["a"].Rows.Count > 0)
                {
                    nameid = Convert.ToInt32(dsname.Tables["a"].Rows[0]["id"].ToString());
                    cbmtxt.Text = nameid.ToString();
                }
            }
        }
        void IUDname(int op)
        {
            comm.Parameters.Clear();
            comm.CommandText = "IUDname";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@op",op);
            comm.Parameters.AddWithValue("@id",id);
            comm.Parameters.AddWithValue("@Firstname",txtfname.Text);
            comm.Parameters.AddWithValue("@Lastname",txtlname.Text);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();

            getdata();

            reset();
        }
        void reset()
        {
            txtfname.Text = "";
            txtlname.Text = "";
            txtfname.Focus();
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();    
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            IUDname(3);
            getFname();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            IUDname(2);
            getFname();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            IUDname(1);
            getFname();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            getdata();
            getFname();
        }

        private void cbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blnfname == true)
            {
                if (dsname.Tables["a"].Rows.Count > 0)
                {
                    nameid = Convert.ToInt32(dsname.Tables["a"].Rows[cbm.SelectedIndex]["id"].ToString());
                    cbmtxt.Text=nameid.ToString();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>= -1)
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
                txtlname.Text = dataGridView1.Rows[e.RowIndex].Cells["Lastname"].Value.ToString();
            }
        }
    }
}
