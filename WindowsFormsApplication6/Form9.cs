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
using System.Configuration;

namespace WindowsFormsApplication6
{
    public partial class Form9 : Form
    {
        string answer;
        SqlConnection con = new SqlConnection("Data Source=uzair-pc;Initial Catalog=pos;Integrated Security=SSPI");
        DataTable table = new DataTable();
        public Form9()
        {
            InitializeComponent();
            table.Columns.Add("product name", typeof(string));
            table.Columns.Add("product price", typeof(float));






            con.Open();





            //string query = "INSERT INTO admin(username,password) VALUES(@username,@password)";
            //SqlCommand sqlCmd = new SqlCommand(query, con);
            //sqlCmd.Parameters.AddWithValue("@username", username);
            //sqlCmd.Parameters.AddWithValue("@password", password);

            SqlCommand cmd = new SqlCommand("select * from items", con);

            SqlDataReader rdr = cmd.ExecuteReader();



            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr["item_name"]);
            }


            rdr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           answer = comboBox1.SelectedItem.ToString();

            SqlCommand cmdd = new SqlCommand("select * from items where item_name = @item", con);
            cmdd.Parameters.AddWithValue("@item", answer);

            SqlDataReader rdrr = cmdd.ExecuteReader();

            rdrr.Read();

            table.Clear();
            table.Rows.Add(rdrr["item_name"], rdrr["item_sale_price"]);



            dataGridView1.DataSource = table;


            rdrr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // dataGridView1.Rows[0].Cells[0].Value.ToString();

            string name = dataGridView1.Rows[0].Cells[0].Value.ToString();
            float price = float.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString());
          

            SqlCommand cmdd = new SqlCommand("update items SET item_name = @name , item_sale_price = @price where item_name = @item", con);
            cmdd.Parameters.AddWithValue("@name", name);
            cmdd.Parameters.AddWithValue("@price",price);
            cmdd.Parameters.AddWithValue("@item", answer);

            cmdd.ExecuteNonQuery();

            

            MessageBox.Show("Item Has Been Updated");

            Form9 frm = new Form9();
            this.Hide();
            frm.Show();


        }
    }
}
