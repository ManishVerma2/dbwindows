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
    public partial class tblfee : Form
    {
        public tblfee()
        {
            InitializeComponent();
        }
        SqlCommand comm=new SqlCommand();
        SqlConnection conn= new SqlConnection(Common.conn);
        SqlDataAdapter da=new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet dsclass=new DataSet();
        int id,clsid;
        bool blnclassid=false;

        void getfeedata()
        {
            ds.Tables.Clear();
            comm.CommandText = "Select * from tblfee";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand= comm;
            da.Fill(ds, "a");
            dataGridfee.DataSource = ds.Tables["a"];
        }

        void IUDfee(int op)
        {
            comm.Parameters.Clear();
            comm.CommandText = "IUDfee";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@op", op);
            comm.Parameters.AddWithValue("@feeid", id);
            comm.Parameters.AddWithValue("@headname", txthead.Text);
            comm.Parameters.AddWithValue("@charges",txtcharges.Text);
            comm.Parameters.AddWithValue("@classid", clsid);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();

            getfeedata();
        }

        void getclassid()
        {
            dsclass.Tables.Clear();
            comm.CommandText = "Select * From tblclass";
            comm.CommandType = CommandType.Text;
            comm.Connection= conn;
            da.SelectCommand = comm;
            da.Fill(dsclass, "a");
            coboclsid.DataSource= dsclass.Tables["a"];
            coboclsid.DisplayMember = "ClassName";
            coboclsid.ValueMember = "Classid";
            blnclassid = true;
            if(blnclassid==true)
            {
                if (dsclass.Tables["a"].Rows.Count>0)
                {
                    clsid = Convert.ToInt32(dsclass.Tables["a"].Rows[0]["Classid"].ToString());
                }
            }
        }

        private void coboclsid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blnclassid == true)
            {
                if (dsclass.Tables["a"].Rows.Count > 0)
                {
                    clsid = Convert.ToInt32(dsclass.Tables["a"].Rows[coboclsid.SelectedIndex]["Classid"].ToString());
                }
            }
        }
        void reset()
        {
            txthead.Text = "";
            txtcharges.Text = "";
            coboclsid.Text = "";
        }

        private void feereset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void feedelete_Click(object sender, EventArgs e)
        {
            IUDfee(3);
            getfeedata();
        }

        private void feeupdate_Click(object sender, EventArgs e)
        {
            IUDfee(2);
            getfeedata();
        }

        private void feesave_Click(object sender, EventArgs e)
        {
            IUDfee(1);
            getfeedata();
        }

        private void dataGridfee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >-1)
            {
                id = Convert.ToInt32(dataGridfee.Rows[e.RowIndex].Cells["feeid"].Value.ToString());
                txthead.Text = dataGridfee.Rows[e.RowIndex].Cells["HeadName"].Value.ToString();
                txtcharges.Text = dataGridfee.Rows[e.RowIndex].Cells["Charges"].Value.ToString();
                clsid = Convert.ToInt32(dataGridfee.Rows[e.RowIndex].Cells["Classid"].Value.ToString());
                coboclsid.SelectedValue = clsid;
            }
        }

        private void tblfee_Load(object sender, EventArgs e)
        {
            getfeedata();
            getclassid();
        }
    }
}
