using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFALoginDBA
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where Id = '" + this.txtUserId.Text + "' and Password = '" + this.txtPassword.Text + "';";
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-HASIB;Initial Catalog=AFallDB;User ID=sa;Password=P@$$w0rd");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if(ds.Tables[0].Rows.Count == 1)
            {
                this.Hide();
                MessageBox.Show("Valid User");

                if (ds.Tables[0].Rows[0][3].ToString() == "admin")
                    new FormAdmin(ds.Tables[0].Rows[0][1].ToString(), this).Show();
                else if (ds.Tables[0].Rows[0][3].ToString() == "user")
                    new FormUser(ds.Tables[0].Rows[0][1].ToString(), this).Show();
            }
            else
            {
                MessageBox.Show("Inalid User");
            }


            //bool found = false;
            //int count = 0;
            //while(count < ds.Tables[0].Rows.Count)
            //{
            //    if(this.txtUserId.Text == ds.Tables[0].Rows[count][0].ToString() && this.txtPassword.Text == ds.Tables[0].Rows[count][2].ToString())
            //    {
            //        found = true;
            //        MessageBox.Show("Valid User");
            //    }

            //    count++;
            //}

            //if (!found)
            //    MessageBox.Show("Invalid User");

            sqlcon.Close();
        }
    }
}
