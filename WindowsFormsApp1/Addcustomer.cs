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
    public partial class Addcustomer : Form
    {
        public Addcustomer()
        {
            InitializeComponent();
        }
        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");

        public static string username;
        public static string recby
        {
            get { return username; }
            set { username = value; }
        }
        public static string password;
        public static string recbynew
        {
            get { return password; }
            set { password = value; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select CUSERNAME from Customer where CUSERNAME ='"+textBox8.Text+"'",cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            SqlDataAdapter da1 = new SqlDataAdapter("select  Username from Vendor where Username ='" + textBox8.Text + "'", cm);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            if (dt.Rows.Count==0 && dt1.Rows.Count==0)
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Enter First_Name");
                else if (textBox2.Text == "")
                    MessageBox.Show("Enter LastName");
                else if (textBox3.Text == "")
                    MessageBox.Show("Enter City");
                else if (textBox4.Text == "")
                    MessageBox.Show("Enter State");
                else if (textBox5.Text == "")
                    MessageBox.Show("Enter Pincode");
                else if (textBox6.Text == "")
                    MessageBox.Show("Enter contact no");
                else if (textBox7.Text == "")
                    MessageBox.Show("Enter EmailID");
                else if (textBox8.Text == "")
                    MessageBox.Show("Enter username");
                else if (textBox9.Text == "")
                    MessageBox.Show("Enter Password");
                else
                {
                    addcustomerdetails();
                    //MessageBox.Show("Signed up successfully.Please Login after 5 minutes");
                    //Application.Exit();
                    //Form4 obj9 = new Form4();
                    // obj9.Show();
                    MessageBox.Show("Now login..");
                    Form1 obj = new Form1();
                    obj.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("Username already in use...");
            }

          
           
        }
        private void addcustomerdetails()
        {
            SqlCommand cmd = new SqlCommand("Addcustomers", cm);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("@firname", textBox1.Text);
            cmd.Parameters.AddWithValue("@lasname", textBox2.Text);
            cmd.Parameters.AddWithValue("@cuscity", textBox3.Text);
            cmd.Parameters.AddWithValue("@cusstate", textBox4.Text);
            cmd.Parameters.AddWithValue("@cuspin", textBox5.Text);
            cmd.Parameters.AddWithValue("@cuscontact", textBox6.Text);
            cmd.Parameters.AddWithValue("@cusemail", textBox7.Text);
            cmd.Parameters.AddWithValue("@cuser", textBox8.Text);
            string name = textBox8.Text;
            recby = name;
            string pass = textBox9.Text;
            recbynew = pass;
            cmd.Parameters.AddWithValue("@cpass", textBox9.Text);
            cm.Open();
            cmd.ExecuteNonQuery();
            cm.Close();

            //Form1 obj12 = new Form1();
            //obj12.Hide();
            //this.Hide();
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

        private void Addcustomer_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Numericals only");
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj8 = new Form1();
            obj8.Show();
            this.Hide();
        }
    }
}
