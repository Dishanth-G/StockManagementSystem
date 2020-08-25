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
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }
        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            
            
                SqlCommand cmd = new SqlCommand("select General_name from Product", cm);
                cm.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                textBox1.AutoCompleteCustomSource = MyCollection;
                cm.Close();
          

            searchData("");
        }

        public void searchData(string valueToSearch)
        {
            string query = "select P.General_name,P.Brand_name,T.Type_name,P.price,Q.quantityup,V.Vendor_company from Product P,Type T,quantity Q,Vendor V where P.Type1_id=T.Type_id and P.Vendor1_id=V.Vendor_id and P.Product_id=Q.Product3_id and General_name like '%" + valueToSearch + "'";
            command = new SqlCommand(query, cm);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBox1.Text.ToString();
            searchData(valueToSearch);
        }
    }
}
