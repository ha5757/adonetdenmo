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
    public partial class Form4 : Form
    {

        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-I8O23UC");
            adp = new SqlDataAdapter("select *from deptdata", con);
            ds = new DataSet();
            adp.Fill(ds, "d");
            cbbdeptno.DataSource = ds.Tables["d"];
            cbbdeptno.ValueMember = "deptno";
            cbbdeptno.DisplayMember = "dname";
        }

        private void txtempno_Leave(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select *from empdata where empno=@d",con);
            adp.SelectCommand.Parameters.AddWithValue("@d",int.Parse(txtempno.Text));
            ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow R = ds.Tables["E"].Rows[0];
            txtename.Text = R[1].ToString();
            txtjob.Text = R[2].ToString();
            txtmgr.Text = R[3].ToString();
            dpthiredate.Text = R[4].ToString();
            txtsal.Text = R[5].ToString();
            txtcommission.Text = R[6].ToString();
            cbbdeptno.Text = R[7].ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select *from empdata where empno=@d", con);
            adp.SelectCommand.Parameters.AddWithValue("@d", int.Parse(txtempno.Text));
            ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow R = ds.Tables["E"].Rows[0];
            R[2] = txtjob.Text;
            R[3] = txtmgr.Text;
            R[5] = int.Parse(txtsal.Text);
            R[6] = int.Parse(txtcommission.Text);
            R[7] =cbbdeptno.SelectedValue;
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            adp.UpdateCommand = cmb.GetUpdateCommand();
            adp.Update(ds, "E");
            MessageBox.Show("1 row updated");
        }
    }
}
