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
    public partial class Choose_Firm : Form
    {
        int uid;
        string spName = "", operation = "", strmsg="";
        public Choose_Firm()
        {
            InitializeComponent();
        }
        public Choose_Firm(string userid)
        {
            InitializeComponent();
            uid = Convert.ToInt32(userid);
            SqlParameter[] objsqlparam = new SqlParameter[2];
            //    // strmsg = "Record Inserted Successfully";
             spName = "sp_Regi_firm";
            operation = "loadfirmbyid";
              objsqlparam[0] = new SqlParameter("@Operation", operation);
              objsqlparam[1] = new SqlParameter("@id ", uid);


            //    DataTable dt = connection.GetData(spName, objsqlparam);
            //    if (dt != null)
            //    {
            //        if (dt.Rows[0]["name"] != null)

            //        {
            //            cmbfirm.Items.Add (dt.Rows[0]["name"].ToString());
            //        }

            //    }
            DataTable dt = connection.GetData(spName, objsqlparam);
            cmbfirm.DataSource = dt;
            cmbfirm.DisplayMember = "name";
            cmbfirm.ValueMember = "id";
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (cmbfirm.Text == "")
            {
                MessageBox.Show("Please Choose Firm Name ?", "Firm Name Not Select", MessageBoxButtons.OK);
            }
            else
            {
                Master frmmaster = new Master(cmbfirm.Text);
                frmmaster.Show();
                this.Hide();

            }
        }

        private void Choose_Firm_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbfirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            FormMaster frmformmaster = new FormMaster(uid);
            frmformmaster.Show();
            this.Hide();
        }

        private void btnexitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
