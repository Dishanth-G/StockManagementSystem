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
    public partial class Insertquantitycustom : Form
    {
        public Insertquantitycustom()
        {
            InitializeComponent();
        }

        SqlConnection cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\disha\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf';Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;


        public void fillProductCombo(ComboBox combo, string query, string displayMember)
        {
            command = new SqlCommand(query, cm);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
        }



        private void Insertquantitycustom_Load(object sender, EventArgs e)
        {
            string query = "select General_name from Product";
            fillProductCombo(comboBox1, query, "General_name");
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("updatequantity", cm);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommand cmd1 = new SqlCommand("Insertstock", cm);
            cmd1.CommandType = CommandType.StoredProcedure;
            SqlCommand cmd2 = new SqlCommand("Updatestock", cm);
            cmd2.CommandType = CommandType.StoredProcedure;
            string details = DateTime.Now.ToLongDateString();
            cmd.Parameters.AddWithValue("@productname", comboBox1.Text);
            cmd.Parameters.AddWithValue("@quantity1", textBox2.Text);
            cmd1.Parameters.AddWithValue("@Productname", comboBox1.Text);
            cmd2.Parameters.AddWithValue("@quantity", textBox2.Text);
            cmd2.Parameters.AddWithValue("@details", details);
            cm.Open();
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cm.Close();
            MessageBox.Show("Quantity is updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
