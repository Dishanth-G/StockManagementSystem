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
    public partial class Ven_Viewproduct : Form
    {
        public Ven_Viewproduct()
        {
            InitializeComponent();
        }

        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");



        private void button1_Click(object sender, EventArgs e)
        {
            cm.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT T.Type_name,P.General_name,P.Brand_name,V.vendor_Firstname,V.vendor_Lastname,V.Vendor_company,P.price FROM Product P,Type T,Vendor V where T.Type_id=P.Type1_id and V.Vendor_id=P.Vendor1_id and V.Username like '%" +Form1.recby+ "'", cm);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
            cm.Close();
        }

        private void Ven_Viewproduct_Load(object sender, EventArgs e)
        {

        }
    }
}
