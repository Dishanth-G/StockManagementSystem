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
    public partial class ViewQuantity : Form
    {
        public ViewQuantity()
        {
            InitializeComponent();
        }
        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");

        private void ViewQuantity_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cm.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select o.Order_id,p.General_name,p.Brand_name,c.FIRSTNAME,c.LASTNAME,v.vendor_Firstname,v.Vendor_company,o.quan1,o.price1 from orders o,Product p,Vendor v,Customer c where o.p_id = p.Product_id AND p.Vendor1_id = v.Vendor_id AND c.CUST_ID=o.cust1_id", cm);

            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
            cm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
