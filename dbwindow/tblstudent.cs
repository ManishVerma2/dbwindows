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
    public partial class tblstudent : Form
    {
        public tblstudent()
        {
            InitializeComponent();
        }
        SqlCommand comm=new SqlCommand();
        SqlConnection conn = new SqlConnection(Common.conn);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet dsclass = new DataSet();
        int id,classid;
        bool blnclassid=false;
        string Gender;
        bool isbpl=false;

        void getdata()
        {
            ds.Tables.Clear();
            comm.CommandText = "Select * From tblstudent";
            comm.CommandType = CommandType.Text;
            comm.Connection= conn;
            da.SelectCommand = comm;
            da.Fill(ds, "a");
            dataGridcls.DataSource = ds.Tables["a"];
        }
        void getclassid()
        {
            dsclass.Tables.Clear();
            comm.CommandText = "Select * From tblclass";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(dsclass, "a");
            coboclsid.DataSource = dsclass.Tables["a"];
            coboclsid.DisplayMember = "ClassName";
            coboclsid.ValueMember = "ClassId";
            blnclassid = true;
            if (blnclassid == true)
            {
                if (dsclass.Tables["a"].Rows.Count > 0)
                {
                    classid = Convert.ToInt32(dsclass.Tables["a"].Rows[0]["ClassId"].ToString());
                }
            }
        }
        void IUDstudent(int op)
        {

            comm.Parameters.Clear();
            comm.CommandText = "IUDstudent";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@op", op);
            comm.Parameters.AddWithValue("@studentid", id);
            comm.Parameters.AddWithValue("@sname", txtsname.Text);
            comm.Parameters.AddWithValue("@fname", txtfname.Text);
            comm.Parameters.AddWithValue("@mname", txtmname.Text);
            comm.Parameters.AddWithValue("@dob", dob.Value);
            comm.Parameters.AddWithValue("@classid", classid);
            comm.Parameters.AddWithValue("@gender", Gender);
            comm.Parameters.AddWithValue("@bpl", isbpl);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();

            getdata();
        }
        void reset()
        {
            txtsname.Text = "";
            txtsname.Focus();
            txtfname.Text = "";
            txtmname.Text = "";
            dob.Value = System.DateTime.Today;
            coboclsid.Text = "";

        }
        private void tblstudent_Load(object sender, EventArgs e)
        {
            getdata();
            getclassid();
        }

        private void clsreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void clsdelete_Click(object sender, EventArgs e)
        {
            IUDstudent(3);
            getdata();
        }

        private void clsupdate_Click(object sender, EventArgs e)
        {
            IUDstudent(2);
            getdata();
        }
        private void clssave_Click(object sender, EventArgs e)
        {
            IUDstudent(1);
            getdata();
        }

        private void coboclsid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blnclassid == true)
            {
                if (dsclass.Tables["a"].Rows.Count > 0)
                {
                    classid = Convert.ToInt32(dsclass.Tables["a"].Rows[coboclsid.SelectedIndex]["ClassId"].ToString());
                }
            }
        }

        private void other_CheckedChanged(object sender, EventArgs e)
        {
            if(male.Checked==true)
            {
                Gender = "Male";
            }
            else if(female.Checked==true)
            {
                Gender = "Female";
            }
            else if(other.Checked==true)
            {
                Gender = "Other";
            }
        }

        private void dataGridcls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = Convert.ToInt32(dataGridcls.Rows[e.RowIndex].Cells["studentId"].Value.ToString());
                txtsname.Text = dataGridcls.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                txtfname.Text = dataGridcls.Rows[e.RowIndex].Cells["FatherName"].Value.ToString();
                txtmname.Text = dataGridcls.Rows[e.RowIndex].Cells["MotherName"].Value.ToString();
                dob.Value = Convert.ToDateTime(dataGridcls.Rows[e.RowIndex].Cells["DateOfBirth"].Value);
                classid = Convert.ToInt32(dataGridcls.Rows[e.RowIndex].Cells["ClassId"].Value.ToString());
                coboclsid.SelectedValue = classid;
                Gender = dataGridcls.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                if (Gender == "Male")
                {
                    male.Checked = true;
                }
                else if (Gender == "Female")
                {
                    female.Checked = true;
                }
                else if (Gender == "Other")
                {
                    other.Checked = true;
                }
                isbpl = Convert.ToBoolean(dataGridcls.Rows[e.RowIndex].Cells["BPL"].Value.ToString());
                if (isbpl == true)
                {
                    chboxyes.Checked = true;
                    chboxno.Checked = false;
                }
                else
                {
                    chboxno.Checked = true;
                    chboxyes.Checked = false;
                }
            }
        }

        private void chboxno_CheckedChanged(object sender, EventArgs e)
        {
            if(chboxyes.Checked==true)
            {
                isbpl=true;
            }
            else if(chboxno.Checked==true)
            {
                isbpl =false;
            }
        }

        
    }
}
