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
    public partial class Billing : Form

    {
      
        public Billing()
        {
            InitializeComponent();
        }
      
        private void Billing_Load(object sender, EventArgs e)
        {
            this.Left = 175;
            this.Top = 50;
            this.Width = 1198;
            this.Height = 661;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
        }
    }
}
