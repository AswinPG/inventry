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
    public partial class FormMaster : Form
    {
        string frmlbl = "";
        string spName = "";
        string strmsg = "";
        string operation = "";
        int iResult = 0;
        string useid = "";
        validation v = new validation();

        public FormMaster()
        {
            InitializeComponent();
        }
        public FormMaster(string lblregi)
        {
            InitializeComponent();
            frmlbl = lblregi; ;
            //lblfirmregi.Text = lblregi;
            lblfirmregi.Text = "new" + frmlbl + "Registration";
            if (frmlbl == "Supplier")
            {
                spName = "sp_Regi_supplier";

                operation = "insert";


            }
            else if (frmlbl == "Customer")
            {
                spName = "sp_Regi_customer";
                operation = "insert";

            }

        }
        public FormMaster(int uid)
        {
            InitializeComponent();
            int userid = uid;
            lblfirmregi.Text = "New Firm Registration";
            spName = "sp_Regi_firm";
            operation = "insert";
            useid = uid.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            this.Left = 175;
            this.Top = 50;
            this.Width = 1198;
            this.Height = 661;
            // lblfirmregi.Text = frmlbl + "Registration...";

            //dtp1.Value = DateTime.Now.ToShortDateString();
            for (int i = 0; i < 101; i++)
            {
                cmbper.Items.Add(i);
            }

            SqlParameter[] objsqlparam = new SqlParameter[1];
            string spcity = "sp_city";
            string op = "loadstate";

            objsqlparam[0] = new SqlParameter("@operation", op);
            DataTable dt = connection.GetData(spcity, objsqlparam);
            combostate.DataSource = dt;
            combostate.DisplayMember = "state";
            //combostate.ValueMember = "id";





        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtlandmark.Text = "";
            combocity.Text = "";
            combostate.Text = "";
            combocountry.Text = "";
            txtpin.Text = "";
            txtmob.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";

            txtbankname.Text = "";
            txtacno.Text = "";
            txtifsc.Text = "";

            txtpan.Text = "";
            txtgst.Text = "";
            //pictureBox1.Image ;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            SqlParameter[] objsqlparam = new SqlParameter[18];
            objsqlparam[0] = new SqlParameter("@operation", operation);
            objsqlparam[1] = new SqlParameter("@name", txtname.Text);
            objsqlparam[2] = new SqlParameter("@landmark", txtlandmark.Text);
            objsqlparam[3] = new SqlParameter("@city", combocity.Text);
            objsqlparam[4] = new SqlParameter("@state", combostate.Text);
            objsqlparam[5] = new SqlParameter("@country", combocountry.Text);
            objsqlparam[6] = new SqlParameter("@pan", txtpin.Text);
            objsqlparam[7] = new SqlParameter("@mob", txtmob.Text);
            objsqlparam[8] = new SqlParameter("@phone", txtphone.Text);
            objsqlparam[9] = new SqlParameter("@email", txtemail.Text);
            objsqlparam[10] = new SqlParameter("@bank_name", txtbankname.Text);
            objsqlparam[11] = new SqlParameter("@account_no", txtacno.Text);
            objsqlparam[12] = new SqlParameter("@ifsc", txtifsc.Text);
            objsqlparam[13] = new SqlParameter("@gst", txtgst.Text);
            objsqlparam[14] = new SqlParameter("@img", imgpath.Text);
            objsqlparam[15] = new SqlParameter("@rdate", dtp1.Value);
            objsqlparam[16] = new SqlParameter("@gst_per", Convert.ToInt32(cmbper.Text));
            objsqlparam[17] = new SqlParameter("@userid", useid);

            // objsqlparam[1] = new SqlParameter(" @name", txtname.Text);





            iResult = connection.ExecuteQuery(spName, objsqlparam);
            if (iResult > 0)
            {
                strmsg = "record Inserted";
                MessageBox.Show(strmsg);


            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void combostate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlParameter[] objsqlparam = new SqlParameter[2];
            string spcity = "sp_city";
            string op = "loadcitybystate";

            objsqlparam[0] = new SqlParameter("@operation", op);
            objsqlparam[1] = new SqlParameter("@state", combostate.Text);
            DataTable dt = connection.GetData(spcity, objsqlparam);
            combocity.DataSource = dt;
            combocity.DisplayMember = "city";
            combocity.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Images only.|*.jpg;*.jpeg;*.png;*.gif;";
            DialogResult dr = openfd.ShowDialog();
            image1.Image = Image.FromFile(openfd.FileName);
            imgpath.Text = openfd.FileName;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmob_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlandmark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlandmark_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.charonly(e);
        }

        private void txtacno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtacno_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.digitonly(e);
        }

        private void txtpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.digitonly(e);
        }

        private void txtmob_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.digitonly(e);
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.digitonly(e);
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string tyspname = "",op="";
            if(spName == "sp_Regi_firm")
            {
                tyspname = "sp_Regi_firm";
                op = "loadall";
            }
            else if(spName == "sp_Regi_customer")
            {
                tyspname = "sp_Regi_customer";
                op = "loadall";
            }
            else if(spName == "sp_Regi_supplier")
            {
                tyspname = "sp_Regi_supplier";
                op = "loadall";
            }
            FInd frmfind = new FInd(tyspname,op);
            frmfind.Show();
        }
        
    }
}
    

