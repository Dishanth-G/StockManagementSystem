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
    public partial class InsertQuantity : Form
    {
        public InsertQuantity()
        {
            InitializeComponent();
        }

        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InsertQuantity_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void insertquantitydetails()
        {
            SqlCommand cmd = new SqlCommand("Addquantity", cm);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommand cmd1 = new SqlCommand("set_detailsQuantity", cm);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pname", textBox1.Text);
            cmd1.Parameters.AddWithValue("@quan", textBox2.Text);
            cmd1.Parameters.AddWithValue("@qdate", dateTimePicker1.Text);
            cm.Open();
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cm.Close();
            MessageBox.Show("Quantity is updated");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Enter product name");
            else if (textBox2.Text == "")
                MessageBox.Show("Enter quantity");
            else
                insertquantitydetails();
        }
    }
}
