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
    public partial class VendorForm : Form
    {
        public VendorForm()
        {
            InitializeComponent();
            timer2.Start();
        }

        private void VendorForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripStatusLabel2.Text = Form1.recby;
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ven_Viewproduct obj = new Ven_Viewproduct();
            obj.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ven_Viewquantity obj5 = new Ven_Viewquantity();
            obj5.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            this.Hide();
            obj1.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Location = new Point(label2.Location.X - 5, label2.Location.Y);
            if (label2.Location.X < -this.Width)
            {
                label2.Location = new Point(label2.Width, label2.Location.Y);
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ven_Profile obj1 = new Ven_Profile();
            obj1.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
