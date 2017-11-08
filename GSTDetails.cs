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
    public partial class GSTDetails : Form
    {
        public GSTDetails()
        {
            InitializeComponent();
        }

        private void GSTDetails_Load(object sender, EventArgs e)
        {
            this.Left = 175;
            this.Top = 50;
            this.Width = 1198;
            this.Height = 661;
        }
    }
}
