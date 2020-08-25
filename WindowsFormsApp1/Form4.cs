using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            timer2.Start();
        }

        private void buyProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyProducts obj = new BuyProducts();
            obj.Show();
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if(Form1.check=="yes")
            {
                toolStripStatusLabel2.Text = Form1.recby;
            }
            else
            {
                toolStripStatusLabel2.Text = Addcustomer.recby;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerProfile obj2 = new CustomerProfile();
            obj2.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            this.Hide();
            obj1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void orderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderHistoryform obj3 = new OrderHistoryform();
            obj3.Show();
        }

        private void trackStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X - 5, label1.Location.Y);
            if (label1.Location.X < -this.Width)
            {
                label1.Location = new Point(label1.Width, label1.Location.Y);
            }
        }
    }
}
