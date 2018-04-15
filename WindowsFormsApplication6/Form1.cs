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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.AutoSize = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=uzair-pc;Initial Catalog=pos;Integrated Security=SSPI");


           




            con.Open();


            string username = textBox1.Text;
            string password = textBox2.Text;


            //string query = "INSERT INTO admin(username,password) VALUES(@username,@password)";
            //SqlCommand sqlCmd = new SqlCommand(query, con);
            //sqlCmd.Parameters.AddWithValue("@username", username);
            //sqlCmd.Parameters.AddWithValue("@password", password);

            SqlCommand cmd = new SqlCommand("select * from admin where username = @username and password = @password", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
     
            SqlDataReader rdr = cmd.ExecuteReader();

            int count = 0; 
            while(rdr.Read())
            {
                count++;
            }


            if(count == 1)
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("sorry !!! brother better luck next time");
            }

         
            }
    }
}
