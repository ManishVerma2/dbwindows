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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlCommand comm=new SqlCommand();
        SqlConnection conn=new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=first_db;Integrated Security=True;Pooling=False");
        SqlDataAdapter da=new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if(conn.State==ConnectionState.Open)
            {
                MessageBox.Show("Connection successfull");
            }
            conn.Close();   
        }
        void getdata()
        {
            ds.Tables.Clear();
            comm.CommandText = "Select * From tblname";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand=comm;
            da.Fill(ds, "a");
            dataGridView1.DataSource = ds.Tables["a"];
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb=new SqlCommandBuilder(da);
            da.Update(ds.Tables["a"]);
            MessageBox.Show("Saved");
            ds.Tables["a"].Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
