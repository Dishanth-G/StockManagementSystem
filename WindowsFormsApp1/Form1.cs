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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCaptcha();
        }
        public static string check = "no";
        int num = 0;
        private void LoadCaptcha()
        {
            Random r1 = new Random();
            num = r1.Next(1000, 10000);
            var img = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("Arial", 25, FontStyle.Regular, GraphicsUnit.Point);
            var graphics = Graphics.FromImage(img);
            graphics.DrawString(num.ToString(),font,Brushes.Yellow,new Point(0,0));
            pictureBox1.Image = img;

        }


        public static string username;
        public static string recby
        {
            get { return username; }
            set { username = value ; }
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        SqlCommand cmd1;
        SqlDataReader dr1;
        SqlDataAdapter da1;
       
        private void getdata()
        {
            string name = textBox1.Text;
            recby = name;
            string pass = textBox2.Text;
            string adu = "Manager";
            da = new SqlDataAdapter("Select Username FROM Vendor where Username like'" + textBox1.Text + "'and Password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable dt1 = new DataTable();
            
            da1 = new SqlDataAdapter("Select CUSERNAME from Customer where CUSERNAME like'" + textBox1.Text + "'and CPASSWORD='" + textBox2.Text + "'", con);
            da1.Fill(dt1);
            if ((dt.Rows.Count==1) && (textBox3.Text== num.ToString()))
            {
                VendorForm obj = new VendorForm();
                this.Hide();
                obj.Show();
            }
            else if((name.Equals(adu))&& (pass.Equals(adu)) && (textBox3.Text == num.ToString()))
            {
                Form3 obj = new Form3();
                this.Hide();
                obj.Show();
            }
            else if ((dt1.Rows.Count==1)&&(textBox3.Text==num.ToString()))
            {
                
                Form4 obj = new Form4();
                this.Hide();
                obj.Show();
            }
            else if((Addcustomer.recby==textBox1.Text)&& (Addcustomer.recbynew==textBox2.Text)&&(textBox3.Text==num.ToString()))
            {
                Form4 obj = new Form4();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("credentials are wrong or invalid");
            }

        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check = "yes";
            getdata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadCaptcha();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addcustomer obj5 = new Addcustomer();
            obj5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
