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

namespace GST
{
    public partial class Login : Form
    {
        string spName = "";
        DataTable dt = null;
        string strmsg = "";
        string operation = "";
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            logincode();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpassword.Text = "";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == ASCIIEncoding.Enter || e.PlatformKeyCode == 0x0A)
                if ((e.KeyValue)==13)
                {
                txtpassword.Focus();   
                }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue) == 13)
            {
                logincode();
            }
        }
       private void  logincode()
        {
            SqlParameter[] objsqlparam = new SqlParameter[4];
            if (txtuser.Text != "" && txtpassword.Text != "")
            {
                // strmsg = "Record Inserted Successfully";
                spName = "sp_login";
                operation = "loginstr";
                objsqlparam[0] = new SqlParameter("@Operation", operation);
                objsqlparam[1] = new SqlParameter("@username ",txtuser.Text.ToUpper());
                objsqlparam[2] = new SqlParameter("@password", txtpassword.Text.ToLower());
                objsqlparam[3] = new SqlParameter("@hint", txtpassword.Text);
            }

            dt = connection.GetData(spName, objsqlparam);
            if (dt != null)
            {
                strmsg = ("Login Successfully");

                MessageBox.Show(strmsg, "login..");
                // Master frmmaster = new Master();
                //frmmaster.Show();
                string userid = dt.Rows[0]["id"].ToString();

                Choose_Firm frmchoose_firm = new Choose_Firm(userid);
                frmchoose_firm.Show();
                this.Hide();


                // objFrmStudent.txtname.Text = dt.Rows[0]["St_Fname"].ToString();

            }
            else
            {
                strmsg = " Invaild Uaername And Password";
                MessageBox.Show(strmsg);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
