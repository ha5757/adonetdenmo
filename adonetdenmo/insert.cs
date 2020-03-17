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
    public partial class insert : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public insert()
        {
            InitializeComponent();
        }

        private void insert_Load(object sender, EventArgs e)
        {
           //step1
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=adodb;Data Source=DESKTOP-I8O23UC");

        }

        private void txtinsert_Click(object sender, EventArgs e)
        {
            try
            {
                //step2
                con.Open();
                //step3
                cmd = new SqlCommand("insert into emp values(@eno,@en,@g,@d)", con);
                cmd.Parameters.AddWithValue("@eno", txtempno.Text);
                cmd.Parameters.AddWithValue("@en", txtename.Text);
                cmd.Parameters.AddWithValue("@g", txtgender.Text);
                cmd.Parameters.AddWithValue("@d", DateTime.Parse(dtpdob.Text));
                //STEP4
                int R = cmd.ExecuteNonQuery();
                MessageBox.Show(R + "ROW INSERTED");
            }
            catch(SqlException E)
            {
                if (E.Message.Contains("PK_empno")) ;
                MessageBox.Show("EMPNO CANNOT BE DUPLICATE");
                if (E.Message.Contains("CK_dob")) ;
                MessageBox.Show("AGE MUST BE MINIMUM 21");
                if (E.Message.Contains("CK_gender")) ;
                MessageBox.Show("AGE MUST BE SELECTED");
            }
            finally
            {
                con.Close();
            }
            //step
        
        }
    }
}
