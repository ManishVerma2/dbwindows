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
using System.Xml.Linq;

namespace dbwindow
{
    public partial class first_program : Form
    {
        public first_program()
        {
            InitializeComponent();
        }
        SqlCommand comm = new SqlCommand();
        SqlConnection conn = new SqlConnection(Common.conn);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet dsclass= new DataSet();
        int id,clsid;
        bool blnclassid = false;
        string Gender;
        bool isbpl = false;
        void getdata()
        {
            ds.Tables.Clear();
            comm.CommandText = "Select StudentID,StudentName,FatherName,MotherName,[Date of Birth],s.ClassID,ClassName,Gender,BPL From tblstudenet s Left Outer Join tblClass cls on s.ClassID=cls.ClassID";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "a");
            dgtbl.DataSource = ds.Tables["a"];
            dgtbl.Columns["ClassID"].Visible = false;
        }
        void getclsdata()
        {
            ds.Tables.Clear();
            comm.CommandText = "Select * From Tblclass";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "a");
            dataGridclass.DataSource = ds.Tables["a"];
        }

        void IUDaddcls(int op)
        {

            comm.Parameters.Clear();
            comm.CommandText = "IUDaddcls";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@op", op);
            comm.Parameters.AddWithValue("@classid", id);
            comm.Parameters.AddWithValue("@classname", txtaddcls.Text);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();

            getclsdata();
        }

        void getclassid()
        {
            dsclass.Tables.Clear();
            comm.CommandText = "Select * From Tblclass";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(dsclass, "a");
            classid.DataSource = dsclass.Tables["a"];
            classid.DisplayMember = "ClassName";
            classid.ValueMember = "ClassId";
            blnclassid = true;
            if (blnclassid == true)
            {
                if (dsclass.Tables["a"].Rows.Count > 0)
                {
                    clsid = Convert.ToInt32(dsclass.Tables["a"].Rows[0]["ClassId"].ToString());
                    label9.Text = clsid.ToString();
                }
            }
        }
        void clsrest()
        {
            txtaddcls.Text = "";
        }
        private void clsdelete_Click(object sender, EventArgs e)
        {
            IUDaddcls(3);
            getclsdata();
            getclassid();
            clsrest();
        }

        private void clsupdate_Click(object sender, EventArgs e)
        {
            IUDaddcls(2);
            getclsdata();
            getclassid();
            clsrest();
        }

        private void clssave_Click(object sender, EventArgs e)
        {
            IUDaddcls(1);
            getclsdata();
            getclassid();
            clsrest();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            getclsdata();
            getclassid();
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
            comm.Parameters.AddWithValue("@classid", clsid);
            comm.Parameters.AddWithValue("@gender", Gender);
            comm.Parameters.AddWithValue("@bpl", isbpl);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            getdata();
        }
        private void first_program_Load(object sender, EventArgs e)
        {
            getdata();
            getclassid();
            reset();
        }

        void reset()
        {
            txtsname.Text = "";
            txtsname.Focus();
            txtfname.Text = "";
            txtmname.Text = "";
            dob.Value = System.DateTime.Today ;
            classid.Text = "";

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            IUDstudent(1);
            getdata();
            getclassid();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            IUDstudent(3);
            getdata();
            getclassid();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            IUDstudent(2);
            getdata();
            getclassid();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgtbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >-1)
            {
                id = Convert.ToInt32(dgtbl.Rows[e.RowIndex].Cells["studentId"].Value.ToString());
                txtsname.Text = dgtbl.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                txtfname.Text = dgtbl.Rows[e.RowIndex].Cells["FatherName"].Value.ToString();
                txtmname.Text = dgtbl.Rows[e.RowIndex].Cells["MotherName"].Value.ToString();
                dob.Value =Convert.ToDateTime(dgtbl.Rows[e.RowIndex].Cells["Date of birth"].Value);
                clsid = Convert.ToInt32(dgtbl.Rows[e.RowIndex].Cells["ClassId"].Value.ToString());
                classid.SelectedValue = clsid;
                Gender =dgtbl.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                if (Gender =="Male")
                {
                    male.Checked = true;
                }
                else if(Gender=="Female")
                {
                    female.Checked= true;
                }
                else if(Gender=="Other")
                {
                    other.Checked = true;
                }
                isbpl = Convert.ToBoolean(dgtbl.Rows[e.RowIndex].Cells["BPL"].Value.ToString());
                if (isbpl == true)
                {
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                }
                else
                {
                    checkBox2.Checked = true;
                    checkBox1.Checked = false;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void classid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blnclassid == true)
            {
                if (dsclass.Tables["a"].Rows.Count > 0)
                {
                    clsid = Convert.ToInt32(dsclass.Tables["a"].Rows[classid.SelectedIndex]["ClassId"].ToString());
                    label9.Text = clsid.ToString();
                }
            }
        }

        private void Chk(object sender, EventArgs e)
        {
            if (male.Checked == true)
                Gender = "Male";
            else if (female.Checked == true)
                Gender = "Female";
            else if (other.Checked == true)
                Gender = "Other";
        }

        private void BPLChk(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
                isbpl= true;
            else if(checkBox2.Checked == true)
                isbpl = false;
        }

        private void dataGridclass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = Convert.ToInt32(dataGridclass.Rows[e.RowIndex].Cells["ClassId"].Value.ToString());
                txtaddcls.Text = dataGridclass.Rows[e.RowIndex].Cells["ClassName"].Value.ToString();
            }
        }
    }
}
