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
    public partial class BuyProducts : Form
    {
        public BuyProducts()
        {
            InitializeComponent();
        }

        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;


        public void filltypesCombo(ComboBox combo, string query1, string displayMember)
        {
            command = new SqlCommand(query1, cm);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuyProducts_Load(object sender, EventArgs e)
        {
            string query1 = "select Type_name from Type";
            filltypesCombo(comboBox1, query1, "Type_name");
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cm.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT a.Product_id,v.vendor_Firstname,a.General_name,a.Brand_name,a.Price,t.Type_name,q.quantityup from Product a, Vendor v, quantity q, Type t where t.Type_id = a.Type1_id AND a.Product_id = q.Product3_id AND v.Vendor_id = a.Vendor1_id and t.Type_name like '%"+ comboBox1.Text+ "'", cm);

            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
            cm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cm.Open();

            string user = Form1.recby;





            string query = "select * from quantity where Product3_id='" + textBox2.Text + "'";
            
            SqlCommand com = new SqlCommand(query, cm);
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();

           string quantitytable = reader["quantityup"].ToString();
           string quantitytxtbox = textBox1.Text;
            
           
           int quantity_table = Int32.Parse(quantitytable);
           int quantity_txtbox = Int32.Parse(textBox1.Text);
            reader.Close();
            if ((quantity_table>=quantity_txtbox)&&(quantity_txtbox>0))
            {
                SqlCommand cmd = new SqlCommand("updatequantityc", cm);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductID", textBox2.Text);
                cmd.Parameters.AddWithValue("@Quantity", textBox1.Text);
                
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("orderhistory", cm);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.AddWithValue("@CUST_name",user);

                SqlCommand cmd2 = new SqlCommand("updateorders", cm);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@ProductID", textBox2.Text);
                cmd2.Parameters.AddWithValue("@Quantity", textBox1.Text);









                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();





                MessageBox.Show("Product successfully purchased");
            }
            else
            {if (quantity_txtbox == 0)
                {
                    MessageBox.Show("Enter value greater than zero");
                }
                else
                {
                    MessageBox.Show("Enter less quantity");
                }
            }
            cm.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Numericals only");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Numericals only");
            }
        }
    }
}
