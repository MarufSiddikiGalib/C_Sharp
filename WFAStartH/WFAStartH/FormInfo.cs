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
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.txtOutputUsername.Text = this.txtUsername.Text;
            this.lblPassword.Text = this.txtPassword.Text;
            this.lblDepartment.Text = this.cmbDepartment.Text;
            this.lblDOB.Text = this.dtpDOB.Text;
            if (this.rbBachelors.Checked)
                this.lblProgram.Text = "Bachelors";
            else if (this.rbMasters.Checked)
                this.lblProgram.Text = this.rbMasters.Text;

            MessageBox.Show("Showing Data");
            this.pnlOutput.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtOutputUsername.Text = "";
            this.lblPassword.Text = "";
            this.lblDepartment.Text = "";
            this.lblDOB.Text = "dob";
            this.lblProgram.Text = "";

            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.cmbDepartment.SelectedIndex = -1;//this.cmbDepartment.Text = "";
            this.dtpDOB.Text = "";
            this.rbBachelors.Checked = false;
            this.rbMasters.Checked = false;

            MessageBox.Show("Clearing Data");
            this.pnlOutput.Visible = false;

        }
    }
}
