using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST
{
    public partial class search : UserControl
    {
        public search()
        {
            InitializeComponent();
        }

        public String btnsearch_Click(object sender, EventArgs e)
        {
            string operation = "";
            if (rbid.Checked)
            {
                operation = "byid";
            }
            else if(rbname.Checked)
            {
                operation = "byname";
            }
            else
            {
                MessageBox.Show("Pelase Choose Any One Option");
            }
            return (operation);
        }
    }
}
