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
    public partial class AddVendor : Form
    {
        public AddVendor()
        {
            InitializeComponent();
        }
        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVendor_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select CUSERNAME from Customer where CUSERNAME ='" + textBox8.Text + "'", cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            SqlDataAdapter da1 = new SqlDataAdapter("select  Username from Vendor where Username ='" + textBox8.Text + "'", cm);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            if (dt.Rows.Count == 0 && dt1.Rows.Count == 0)
            {


                if (textBox1.Text == "")
                    MessageBox.Show("Enter First_Name");
                else if (textBox2.Text == "")
                    MessageBox.Show("Enter LastName");
                else if (textBox3.Text == "")
                    MessageBox.Show("Enter Company name");
                else if (textBox4.Text == "")
                    MessageBox.Show("Enter city");
                else if (textBox5.Text == "")
                    MessageBox.Show("Enter state");
                else if (textBox6.Text == "")
                    MessageBox.Show("Enter pincode");
                else if (textBox7.Text == "")
                    MessageBox.Show("Enter contact no");
                else if (textBox8.Text == "")
                    MessageBox.Show("Enter username");
                else if (textBox9.Text == "")
                    MessageBox.Show("Enter Password");
                else if (textBox10.Text == "")
                    MessageBox.Show("Enter email");
                else
                {
                    addvendordetails();
                }
            }
            else
            {
                MessageBox.Show("Username already in use..");
            }
        }

        private void addvendordetails()
        {
            SqlCommand cmd = new SqlCommand("Addvendor", cm);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", textBox1.Text);
            cmd.Parameters.AddWithValue("@lname", textBox2.Text);
            cmd.Parameters.AddWithValue("@compname", textBox3.Text);
            cmd.Parameters.AddWithValue("@city", textBox4.Text);
            cmd.Parameters.AddWithValue("@state", textBox5.Text);
            cmd.Parameters.AddWithValue("@pincode", textBox6.Text);
            cmd.Parameters.AddWithValue("@cno", textBox7.Text);
            cmd.Parameters.AddWithValue("@email", textBox10.Text);
            cmd.Parameters.AddWithValue("@uname", textBox8.Text);
            cmd.Parameters.AddWithValue("@pword", textBox9.Text);
            cm.Open();
            cmd.ExecuteNonQuery();
            cm.Close();
            MessageBox.Show("Vendor Registered Successfully!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("characters only");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("characters only");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("characters only");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("characters only");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("characters only");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Numericals only");
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Numericals only");
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
