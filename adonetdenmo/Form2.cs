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
    public partial class Form2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-I8O23UC");
            adp = new SqlDataAdapter("select *from empdata",con);
            DataSet ds = new DataSet();
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            SqlCommand cmd = cmb.GetInsertCommand();
            MessageBox.Show(cmd.CommandText);
        }
    }
}
