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
using System.Reflection.Emit;
using System.Security.Claims;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace dbwindow
{
    public partial class tblfeereceipt : Form
    {
        public tblfeereceipt()
        {
            InitializeComponent();
        }
        SqlCommand comm = new SqlCommand();
        SqlConnection conn = new SqlConnection(Common.conn);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet dsstudent = new DataSet();
        int id,studentid;
        bool blnstudentid=false;

        void getdata()
        {
            ds.Tables.Clear();
            comm.CommandText = "Select * From tblfeereceipt";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "a");
            dataGridree.DataSource = ds.Tables["a"];
        }

        void getstudentid()
        {
            dsstudent.Tables.Clear();
            comm.CommandText = "Select * From tblstudent";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(dsstudent, "a");
            cobostudentid.DataSource = dsstudent.Tables["a"];
            cobostudentid.DisplayMember = "Studentid";
            cobostudentid.ValueMember = "Studentid";
            blnstudentid = true;
            if (blnstudentid == true)
            {
                if (dsstudent.Tables["a"].Rows.Count > 0)
                {
                    studentid = Convert.ToInt32(dsstudent.Tables["a"].Rows[0]["Studentid"].ToString());
                }
            }
        }
         
        void IUDfeereceipt(int op)
        {
            comm.Parameters.Clear();
            comm.CommandText = "IUDfeereceipt";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@op", op);
            comm.Parameters.AddWithValue("@recepitno", id);
            comm.Parameters.AddWithValue("@studentid", cobostudentid.Text);
            comm.Parameters.AddWithValue("@receiptdate", receiptdate.Value);
            comm.Parameters.AddWithValue("@amount", txtamount.Text);
            comm.Parameters.AddWithValue("@peyment", txtpayment.Text);
            comm.Parameters.AddWithValue("@receiptby", txtreceiptby.Text);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();

            getdata();
        }

        void reset()
        {
            cobostudentid.Text = "";
            cobostudentid.Focus();
            receiptdate.Value = System.DateTime.Today;
            txtamount.Text = "";
            txtpayment.Text = "";
            txtreceiptby.Text = "";
        }
        private void reereset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reedelete_Click(object sender, EventArgs e)
        {
            IUDfeereceipt(3);
            getdata();
        }

        private void reeupdate_Click(object sender, EventArgs e)
        {
            IUDfeereceipt(2);
            getdata();
        }

        private void reesave_Click(object sender, EventArgs e)
        {
            IUDfeereceipt(1);
            getdata();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cobostudentid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blnstudentid == true)
            {
                if (dsstudent.Tables["a"].Rows.Count > 0)
                {
                    studentid = Convert.ToInt32(dsstudent.Tables["a"].Rows[cobostudentid.SelectedIndex]["Studentid"].ToString());
                }
            }
        }

        private void dataGridree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = Convert.ToInt32(dataGridree.Rows[e.RowIndex].Cells["ReceipNo."].Value.ToString());
                studentid =Convert.ToInt32( dataGridree.Rows[e.RowIndex].Cells["Studentid"].Value.ToString());
                cobostudentid.SelectedValue = studentid;
                txtamount.Text = dataGridree.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                txtpayment.Text = dataGridree.Rows[e.RowIndex].Cells["Peyment"].Value.ToString();
                receiptdate.Value = Convert.ToDateTime(dataGridree.Rows[e.RowIndex].Cells["ReceiptDate"].Value);
                txtreceiptby.Text = dataGridree.Rows[e.RowIndex].Cells["ReceiptBy"].Value.ToString();
            }
        }

        private void tblfeereceipt_Load(object sender, EventArgs e)
        {
            getdata();
            getstudentid();
        }
    }
}
