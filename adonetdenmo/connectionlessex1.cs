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
    public partial class connectionlessex1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public connectionlessex1()
        {
            InitializeComponent();
        }

        private void connectionlessex1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-I8O23UC");
            adp = new SqlDataAdapter("select *from deptdata", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "dno");
            txtcombo.DataSource = ds.Tables["dno"];
            txtcombo.ValueMember = "deptno";
            txtcombo.DisplayMember = "dname";

        }

        private void btnextract_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select *from EMPDATA where deptno=@dn",con);
            adp.SelectCommand.Parameters.AddWithValue("@dn", txtcombo.SelectedValue);
            DataSet ds = new DataSet();
            adp.Fill(ds, "emp");
            dgvdata.DataSource = ds.Tables["emp"];
        }

       
    }
}
