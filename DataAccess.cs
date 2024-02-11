using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACRUD
{
    public class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        //internal DataTable dt;

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=LAPTOP-HASIB;Initial Catalog=DSummerDB;Persist Security Info=True;User ID=sa;Password=P@$$w0rd");
            Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }

        public int ExecuteDMLQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}
