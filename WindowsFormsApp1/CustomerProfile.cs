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

namespace WindowsFormsApp1
{
    public partial class CustomerProfile : Form
    {
        public CustomerProfile()
        {
            InitializeComponent();
        }

        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            cm.Open();
            if (Form1.check == "yes")
            {
                string rec = Form1.recby;
                string query = "select * from Customer where CUSERNAME='" + Form1.recby.ToString() + "'";
                SqlCommand com = new SqlCommand(query, cm);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();
                label9.Text = reader["FIRSTNAME"].ToString();
                label10.Text = reader["LASTNAME"].ToString();
                label12.Text = reader["CCITY"].ToString();
                label13.Text = reader["CSTATE"].ToString();
                label14.Text = reader["CPINCODE"].ToString();
                label15.Text = reader["CCONTACTNO"].ToString();
                label16.Text = reader["CEMAILID"].ToString();
                cm.Close();
            }
            else
            {
                string rec = Form1.recby;
                string query = "select * from Customer where CUSERNAME='" + Addcustomer.recby.ToString() + "'";
                SqlCommand com = new SqlCommand(query, cm);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();
                label9.Text = reader["FIRSTNAME"].ToString();
                label10.Text = reader["LASTNAME"].ToString();
                label12.Text = reader["CCITY"].ToString();
                label13.Text = reader["CSTATE"].ToString();
                label14.Text = reader["CPINCODE"].ToString();
                label15.Text = reader["CCONTACTNO"].ToString();
                label16.Text = reader["CEMAILID"].ToString();
                cm.Close();
            }
        }
    }
}
