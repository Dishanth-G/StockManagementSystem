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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer2.Start();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVendor obj = new AddVendor();
            obj.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripStatusLabel2.Text = Form1.recby;

               
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            this.Hide();
            obj1.Show();
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertproduct obj2 = new Insertproduct();
            obj2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        private void insertQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertquantitycustom obj3 = new Insertquantitycustom();
            obj3.Show();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProduct obj4 = new ViewProduct();
            obj4.Show();
        }

        private void viewStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewQuantity obj5 = new ViewQuantity();
            obj5.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Location = new Point(label2.Location.X - 5, label2.Location.Y);
            if(label2.Location.X < -this.Width)
            {
                label2.Location = new Point(label2.Width, label2.Location.Y);
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fefewfefdafdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProduct obj6 = new SearchProduct();
            obj6.Show();
        }

        private void viewVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewVendorlist obj8 = new ViewVendorlist();
            obj8.Show();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomerlist obj9 = new ViewCustomerlist();
            obj9.Show();
        }

        private void fadffewrerffafereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
