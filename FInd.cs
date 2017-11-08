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
    public partial class FInd : Form
    {
        string spname = "",operation="";
        search usesearch = new search();
        public FInd()
        {
            InitializeComponent();
        }
        public FInd(string tyspname,string op)
        {
            InitializeComponent();
            spname = tyspname;
            operation = op;
        }

        private void FInd_Load(object sender, EventArgs e)
        {
            loaddetails();
        }

        private void search1_Load(object sender, EventArgs e)
        {
            
        }

        private void loaddetails()
        {
            try
            {
                SqlParameter []objsqlpram = new SqlParameter[1];
                objsqlpram[0] = new SqlParameter("@operation", operation);
                //objsqlpram[1] = new SqlParameter("@id", label1.Text);
                DataTable dt = null;
                dt = connection.GetData(spname, objsqlpram);
                if (dt != null)
                {
                foreach (DataRow dr in dt.Rows)
                {

                    ListViewItem li = new ListViewItem(dr["id"].ToString());
                    li.SubItems.Add(dr["name"].ToString());
                    li.SubItems.Add(dr["landmark"].ToString());
                    li.SubItems.Add(dr["city"].ToString());
                    li.SubItems.Add(dr["country"].ToString());
                    li.SubItems.Add(dr["pincode"].ToString());
                    li.SubItems.Add(dr["mob"].ToString());
                    li.SubItems.Add(dr["email"].ToString());
                    li.SubItems.Add(dr["bank_name"].ToString());
                    li.SubItems.Add(dr["account_no"].ToString());
                    li.SubItems.Add(dr["phone"].ToString());
                    li.SubItems.Add(dr["mob"].ToString());
                    li.SubItems.Add(dr["email"].ToString());
                    li.SubItems.Add(dr["bank_name"].ToString());
                    li.SubItems.Add(dr["account_no"].ToString());
                    li.SubItems.Add(dr["phone"].ToString());
                    li.SubItems.Add(dr["ifsc"].ToString());
                    li.SubItems.Add(dr["pan"].ToString());
                    li.SubItems.Add(dr["gst"].ToString());
                    li.SubItems.Add(dr["rdate"].ToString());
                    li.SubItems.Add(dr["gst_per"].ToString());
                    li.SubItems.Add(dr["gst_per"].ToString());


                    listView1.Items.Add(li);
                }
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
}
    }
}
