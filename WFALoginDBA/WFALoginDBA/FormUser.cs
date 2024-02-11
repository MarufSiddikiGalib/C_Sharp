using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFALoginDBA
{
    public partial class FormUser : Form
    {
        private FormLogin Fl { get; set; }

        public FormUser()
        {
            InitializeComponent();
        }

        public FormUser(string username, FormLogin fl) : this()
        {
            this.lblWelcome.Text += username;
            this.Fl = fl;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logout complete");
            this.Fl.Show();
        }

        private void FormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit()
;        }
    }
}
