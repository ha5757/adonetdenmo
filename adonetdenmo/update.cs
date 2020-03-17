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
    
    public partial class update : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=adodb;Data Source=DESKTOP-I8O23UC");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update emp set ename=@en,deptno=@d where empno=@e", con);
                cmd.Parameters.AddWithValue("@en", txtename.Text);
                cmd.Parameters.AddWithValue("@d", int.Parse(txtdeptno.Text));
                cmd.Parameters.AddWithValue("@e", int.Parse(txtempno.Text));
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                    MessageBox.Show(R + "ROWS UPDATED");
                else
                    MessageBox.Show("no emp exists");
            }
            catch(SqlException E)
            {
                MessageBox.Show("ename must be given within size");
            }
            catch(FormatException E)
            {
                MessageBox.Show("enter details in deptno");
            }
            catch(InvalidOperationException E)
            {
                MessageBox.Show("no emp exists");
            }
            finally
            {
                con.Close();
            }
            
        }

        private void btnextract_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select *from emp where empno=@eno", con);
                cmd.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
                SqlDataReader R = cmd.ExecuteReader();
                R.Read();
                txtename.Text = R[1].ToString();
                txtgender.Text = R[2].ToString();
                dtpdob.Text = R[3].ToString();
                txtdeptno.Text = R[4].ToString();
                con.Close();
            }
            catch(InvalidOperationException E)
            {
                MessageBox.Show("NO EMPLOYEES exists with this number");
                txtename.Text = "";
                txtempno.Text = "";
                txtgender.Text = "";
                txtdeptno.Text = "";
            }
            catch(FormatException E)
            {
                MessageBox.Show("enter only empno");
            }
            finally
            {
                con.Close();
            }
        }

        private void txtdelete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from emp where empno=@p", con);
            cmd.Parameters.AddWithValue("@p", int.Parse(txtempno.Text));
            int R = cmd.ExecuteNonQuery();
            MessageBox.Show(R + "ROWS DELETED");
            con.Close();
        }
    }
}
