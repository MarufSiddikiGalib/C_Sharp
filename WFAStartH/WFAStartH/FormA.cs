using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAStartH
{
    public partial class FormA : Form
    {
        public FormA()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Form B will load now");
            FormB f2 = new FormB(this.txtInput.Text, this);
            f2.Visible = true;
            this.Visible = false;
        }
    }
}
