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
    public partial class Ven_Profile : Form
    {
        public Ven_Profile()
        {
            InitializeComponent();
        }
        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");

        public void viewprofile()
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Ven_Profile_Load(object sender, EventArgs e)
        {
            cm.Open();
            string rec = Form1.recby;
            string query = "select * from Vendor where Username='" + Form1.recby.ToString() + "'";
            SqlCommand com = new SqlCommand(query,cm);
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            label9.Text = reader["vendor_Firstname"].ToString();
            label10.Text = reader["vendor_Lastname"].ToString();
            label11.Text = reader["Vendor_company"].ToString();
            label12.Text = reader["City"].ToString();
            label13.Text = reader["State"].ToString();
            label14.Text = reader["Pincode"].ToString();
            label15.Text = reader["ContactNo"].ToString();
            label16.Text = reader["email_Id"].ToString();
            cm.Close();
        }
    }
}
