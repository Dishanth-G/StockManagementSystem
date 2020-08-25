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
    public partial class Insertproduct : Form
    {
        public Insertproduct()
        {
            InitializeComponent();
        }

        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;

        public void fillvendorCombo(ComboBox combo,string query,string displayMember)
        {
            command = new SqlCommand(query, cm);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
        }

        public void filltypeCombo(ComboBox combo, string query1, string displayMember)
        {
            command = new SqlCommand(query1, cm);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
        }




        private void Insertproduct_Load(object sender, EventArgs e)
        {
            string query = "select vendor_Firstname from Vendor";
            fillvendorCombo(comboBox1, query, "vendor_Firstname");
            comboBox1_SelectedIndexChanged(null, null);
            string query1 = "select Type_name from Type";
            filltypeCombo(comboBox2, query1, "Type_name");
            comboBox2_SelectedIndexChanged(null, null);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        public void insertproductdetails()
        {
            SqlCommand cmd = new SqlCommand("InsertProduct", cm);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommand cmd1 = new SqlCommand("set_details", cm);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tname", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Vname", comboBox1.Text);
            cmd1.Parameters.AddWithValue("@Gname", textBox1.Text);
            cmd1.Parameters.AddWithValue("@Bname", textBox2.Text);
            cmd1.Parameters.AddWithValue("@price", textBox5.Text);
            cm.Open();
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cm.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Enter  Product Name");
            else if (textBox2.Text == "")
                MessageBox.Show("Enter Brand Name");


            else if (textBox5.Text == "")
                MessageBox.Show("Enter Price");
            else
            {
                insertproductdetails();
                SqlCommand cmd = new SqlCommand("InsertProductquan", cm);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlCommand cmd1 = new SqlCommand("setquantity", cm);
                cm.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cm.Close();
                MessageBox.Show("Product is Inserted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch!=46)
                {
                e.Handled = true;
                MessageBox.Show("Numericals only");
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
