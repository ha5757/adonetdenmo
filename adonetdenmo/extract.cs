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
    public partial class extract : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public extract()
        {
            InitializeComponent();
        }

        private void extract_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-I8O23UC");
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select *from empdata where deptno=@d", con);//if here datetime command is taken
            cmd.Parameters.AddWithValue("@d", int.Parse(txtdeptno.Text));//Datetime.parse(datetimepicker)
           SqlDataReader R= cmd.ExecuteReader();
            DataSet Ds = new DataSet();
            Ds.Tables.Add("Deptdata");
            Ds.Tables["Deptdata"].Load(R);
            dgvdata.DataSource = Ds.Tables["Deptdata"];
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select *from emp_v", con);
            //cmd.Parameters.AddWithValue("@d", int.Parse(txtdeptno.Text));
            SqlDataReader R = cmd.ExecuteReader();
            DataSet Ds = new DataSet();
            Ds.Tables.Add("Deptdata");
            Ds.Tables["Deptdata"].Load(R);
            dgvdata.DataSource = Ds.Tables["Deptdata"];
            con.Close();

        }
    }
}
