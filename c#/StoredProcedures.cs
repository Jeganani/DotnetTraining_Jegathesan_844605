using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        string constring, qrystring;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            constring = "data source=BLT10135\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlcon = new SqlConnection(constring);
            sqlcom = new SqlCommand();
            sqlcom.CommandText = "GetCustomerByCountry";
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.Connection = sqlcon;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@country";
            param.DbType = DbType.String;
            param.Value = comboBox1.Text;

            sqlcom.Parameters.Add(param);
            da = new SqlDataAdapter(sqlcom);
            ds.Clear();
            da.Fill(ds, "CustomersByCountry");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CustomersByCountry";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constring = "data source=BLT10135\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlcon = new SqlConnection(constring);
            ds = new DataSet();
            using (sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                qrystring = "Select distinct Country from Customers";
                sqlcom = new SqlCommand(qrystring, sqlcon);
                dr = sqlcom.ExecuteReader();
                while(dr.Read())
                {
                    comboBox1.Items.Add(dr["Country"]);
                }
                dr.Close();

            }
        }
    }
}
