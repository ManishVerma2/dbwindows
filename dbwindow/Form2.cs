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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlCommand comm = new SqlCommand();
        SqlConnection conn = new SqlConnection(Common.conn);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet dsdept = new DataSet();
        int ID,DeptID;
        bool blndept=false;
        private void Form2_Load(object sender, EventArgs e)
        {
            getdata();
            getDept();
        }
        void getdata()
        {
            ds.Tables.Clear();
            comm.CommandText = "Select * From tblDept";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "a");
            dataGridView1.DataSource = ds.Tables["a"];
        }

        void getDept()
        {
            dsdept.Tables.Clear();
            comm.CommandText = "Select * From tblDept";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(dsdept, "a");
            cmb.DataSource = dsdept.Tables["a"];
            cmb.DisplayMember = "DeptName";
            cmb.ValueMember="ID";
            blndept = true;
            if(blndept==true)
            {
                if (dsdept.Tables["a"].Rows.Count>0)
                {
                    DeptID = Convert.ToInt32(dsdept.Tables["a"].Rows[0]["ID"].ToString());
                    label3.Text = DeptID.ToString();
                }
            }
        }

        void IUDDept(int op)
        {
            comm.Parameters.Clear();
            comm.CommandText = "IUDDept";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@op", op);
            comm.Parameters.AddWithValue("@id", ID);
            comm.Parameters.AddWithValue("@deptname", txtDeptName.Text);
            comm.Parameters.AddWithValue("@loc", txtLoc.Text);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();

            getdata();

            Reset();
        }
        void Reset()
        {
            txtDeptName.Text = "";
            txtLoc.Text = "";
            txtDeptName.Focus();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            IUDDept(3);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IUDDept(2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IUDDept(1);
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blndept == true)
            {
                if (dsdept.Tables["a"].Rows.Count > 0)
                {
                    DeptID = Convert.ToInt32(dsdept.Tables["a"].Rows[cmb.SelectedIndex]["ID"].ToString());
                    label3.Text = DeptID.ToString();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                txtDeptName.Text = dataGridView1.Rows[e.RowIndex].Cells["DeptName"].Value.ToString();
                txtLoc.Text = dataGridView1.Rows[e.RowIndex].Cells["Location"].Value.ToString();
            }
        }
    }
}
