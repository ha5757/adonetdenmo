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


namespace adonetdenmo
{
    public partial class Form3 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-I8O23UC");
            adp = new SqlDataAdapter("select *from deptdata", con);
            ds = new DataSet();
            adp.Fill(ds, "d");
            cbbdeptno.DataSource = ds.Tables["d"];
            cbbdeptno.ValueMember = "deptno";
            cbbdeptno.DisplayMember = "dname";
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                adp = new SqlDataAdapter("select *from empdata", con);
                ds = new DataSet();
                adp.Fill(ds, "E");
                DataRow R = ds.Tables["E"].NewRow();
                R[0] = int.Parse(txtempno.Text);
                R[1] = txtename.Text;
                R[2] = txtjob.Text;
                R[3] = int.Parse(txtmgr.Text);
                R[4] = DateTime.Parse(dpthiredate.Text);
                R[5] = int.Parse(txtsal.Text);
                R[6] = int.Parse(txtcommission.Text);
                ds.Tables["E"].Rows.Add(R);//this command is used to establish link between dataset and t
                SqlCommandBuilder cmb = new SqlCommandBuilder(adp);//from here this code is used to add row into database
                adp.InsertCommand = cmb.GetInsertCommand();
                adp.Update(ds, "E");
                MessageBox.Show("1 row inserted");
                clear();
            }
            catch(SqlException E)
            {
                MessageBox.Show(E.Message);
            }
           
        }
        private void clear()
        {
            txtempno.Text = "";
            txtename.Text = "";
            txtsal.Text = "";
            txtmgr.Text = "";
            txtjob.Text = "";
            txtcommission.Text = "";
            cbbdeptno.Text = "";
        }
    }
}
 