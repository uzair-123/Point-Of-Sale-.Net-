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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cname = textBox1.Text;
            string cno = textBox2.Text;

            SqlConnection con = new SqlConnection("Data Source=uzair-pc;Initial Catalog=pos;Integrated Security=SSPI");
            con.Open();
            string query = "INSERT INTO customers(cus_name,cus_no) VALUES(@name,@no)";
            SqlCommand sqlCmd = new SqlCommand(query, con);
            sqlCmd.Parameters.AddWithValue("@name", cname);
            sqlCmd.Parameters.AddWithValue("@no", cno);


            sqlCmd.ExecuteNonQuery();


            MessageBox.Show(" Congrats !!! Item Has Been Added ");

            Form5 f = new Form5();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }
    }
}
