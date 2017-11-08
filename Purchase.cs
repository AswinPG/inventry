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
    public partial class Purchase : Masterfrm
    {
        validation v = new validation();
        public Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.charonly(e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
