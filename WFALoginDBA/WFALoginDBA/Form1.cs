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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-HASIB;Initial Catalog=AFallDB;User ID=sa;Password=P@$$w0rd");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand("select * from UserInfo;", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            this.label1.Text = ds.Tables[0].Rows[0][0].ToString();
            this.label2.Text = ds.Tables[0].Rows[0][1].ToString();
            this.label3.Text = ds.Tables[0].Rows[0][2].ToString();
            this.label4.Text = ds.Tables[0].Rows[0][3].ToString();

            //----------
            //----------

            sqlcon.Close();
        }
    }
}
