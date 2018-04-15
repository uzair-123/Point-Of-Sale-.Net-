using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string item_n = i_name.Text;
            string buy_price = i_buy_price.Text;
            string sale_price = i_sale_price.Text;



            SqlConnection con = new SqlConnection("Data Source=uzair-pc;Initial Catalog=pos;Integrated Security=SSPI");
            con.Open();
            string query = "INSERT INTO items(item_name,item_buy_price,item_sale_price) VALUES(@name,@b_price,@s_price)";
            SqlCommand sqlCmd = new SqlCommand(query, con);
            sqlCmd.Parameters.AddWithValue("@name", item_n);
            sqlCmd.Parameters.AddWithValue("@b_price", buy_price);
            sqlCmd.Parameters.AddWithValue("@s_price", sale_price);

            sqlCmd.ExecuteNonQuery();


            MessageBox.Show(" Congrats !!! Item Has Been Added ");

            Form3 f = new Form3();
            this.Hide();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            this.Hide();
            frm.Show();

        }
    }
}
