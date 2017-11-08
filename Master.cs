using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST
{
    public partial class Master : Form
    {
        string regtype,welcomestring,formcap;
        public Master()
        {
            InitializeComponent();
        }
        public Master(string firmname)
        {
            InitializeComponent();
            welcomestring = firmname;
            lblfactoryname.Text = welcomestring;

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Master_Load(object sender, EventArgs e)
        {
            lbldays.Text = DateTime.Now.ToString("dddd");
            timer1.Enabled = true;
            //lbltime.Text = DateTime.Now.ToString("HH:MM");
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void lbldays_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:MM:ss");
        }

        private void btncustomer_reg_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btncustomer_reg_MouseMove(object sender, MouseEventArgs e)
        {
            //panel2.Visible = true;
        }

        private void btncustomer_reg_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btncustomer_reg_MouseLeave(object sender, EventArgs e)
        {
            timer3.Enabled = true;

        }

        private void btnediting_MouseHover(object sender, EventArgs e)
        {
            panel4.Visible = true;

        }

        

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel2.Visible = false;
            timer3.Enabled = false;
        }

        private void btnbilling_Click(object sender, EventArgs e)
        {
            
            Billing frmbilling = new Billing();
            frmbilling.Show();

        }

        private void btnstock_Click(object sender, EventArgs e)
        {
          
            Stock frmstock = new Stock();
            frmstock.Show();

        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
       
            Purchase frmpurchase = new Purchase();
            frmpurchase.Show();

        }

        private void btnsale_Click(object sender, EventArgs e)
        {
            
            Sales frmsale = new Sales();
            frmsale.Show();

        }

        private void btnediting_Click(object sender, EventArgs e)
        {
            regtype = "Firm Registration Editing";
            FormMaster frmregi = new FormMaster(regtype);
            frmregi.Show();


        }

        private void btncustreg_Click(object sender, EventArgs e)
        {
            regtype = "Customer";
            FormMaster frmformmaster = new FormMaster(regtype);
            frmformmaster.Show();
        }

        private void btnsuppedit_Click(object sender, EventArgs e)
        {
            

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGST_details_Click(object sender, EventArgs e)
        {

        }

        private void btnsupreg_Click(object sender, EventArgs e)
        {
            regtype = "Supplier";
            FormMaster frmformmaster = new FormMaster(regtype);
            frmformmaster.Show();
        }
    }

}

