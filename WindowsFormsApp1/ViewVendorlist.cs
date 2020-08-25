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
    public partial class ViewVendorlist : Form
    {
        public ViewVendorlist()
        {
            InitializeComponent();
        }
        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");

        private void ViewVendorlist_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cm.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT  Username,Vendor_company,City,State,ContactNo,PinCode,vendor_Firstname,vendor_Lastname,email_Id from Vendor", cm);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
            cm.Close();
        }
    }
}
