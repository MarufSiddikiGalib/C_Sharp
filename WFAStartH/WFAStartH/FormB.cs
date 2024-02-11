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
    public partial class FormB : Form
    {
        private FormA F1 { get; set; }

        public FormB()
        {
            InitializeComponent();
        }

        public FormB(string info, FormA f1) : this()
        {
            this.lblOutput.Text += info;
            this.F1 = f1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FormA f1 = new FormA();
            this.F1.Show();
        }

        private void FormB_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            this.Hide();
            this.F1.Show();
        }
    }
}
