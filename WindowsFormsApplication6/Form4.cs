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
    public partial class Form4 : Form
    {



        class product
        {
            public string name { get; set; }
            public float price { get; set; }
            public int quantity { get; set; }
        }


        List<product> products = new List<product>();

        SqlConnection con = new SqlConnection("Data Source=uzair-pc;Initial Catalog=pos;Integrated Security=SSPI");
        DataTable table = new DataTable();
        public Form4()
        {
            InitializeComponent();


 

     
            table.Columns.Add("product name", typeof(string));
            table.Columns.Add("product price", typeof(string));
            table.Columns.Add("product quantity", typeof(string));





            con.Open();


  


            //string query = "INSERT INTO admin(username,password) VALUES(@username,@password)";
            //SqlCommand sqlCmd = new SqlCommand(query, con);
            //sqlCmd.Parameters.AddWithValue("@username", username);
            //sqlCmd.Parameters.AddWithValue("@password", password);

            SqlCommand cmd = new SqlCommand("select * from items", con);
        
            SqlDataReader rdr = cmd.ExecuteReader();

            

            while(rdr.Read())
            {
                comboBox1.Items.Add(rdr["item_name"]);
            }


            rdr.Close();

            SqlCommand cmdd = new SqlCommand("select * from customers", con);

            SqlDataReader rddr = cmdd.ExecuteReader();

            int count = 0;

            while(rddr.Read())
            {
                count++;
            }

            if(count>0)
            {
                rddr.Close();

                rddr = cmdd.ExecuteReader();

                while (rddr.Read())
                {
                    comboBox2.Items.Add(rddr["cus_name"]);
                }

            }

            rddr.Close(); 


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {














            //string query = "INSERT INTO admin(username,password) VALUES(@username,@password)";
            //SqlCommand sqlCmd = new SqlCommand(query, con);
            //sqlCmd.Parameters.AddWithValue("@username", username);
            //sqlCmd.Parameters.AddWithValue("@password", password);


            string answer = comboBox1.SelectedItem.ToString();

            SqlCommand cmdd = new SqlCommand("select * from items where item_name = @item", con);
            cmdd.Parameters.AddWithValue("@item", answer);

            SqlDataReader rdrr = cmdd.ExecuteReader();

            rdrr.Read();

            table.Rows.Add(rdrr["item_name"],rdrr["item_sale_price"],"1");



            dataGridView1.DataSource = table;

          

            //  MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString());


            rdrr.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            string selected_customer = comboBox2.SelectedItem.ToString();










            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               


                SqlConnection cony = new SqlConnection("Data Source=uzair-pc;Initial Catalog=pos;Integrated Security=SSPI");
                cony.Open();
                SqlCommand cmdd = new SqlCommand("select * from orders order by order_no desc", cony);
                
               

                SqlDataReader rddr = cmdd.ExecuteReader();

                int count = 0;

                while (rddr.Read())
                {
                    count++;
                }

                if(count == 0)
                {
                    int x = 1;
                    string invoice_no = "B" + x; 
                    string now = DateTime.Now.ToString("M/d/yyyy"); 
                    string query = "INSERT INTO orders(item_name,item_price,cus_name,invoice_no,quantity,date) VALUES(@item_name,@item_price,@cus_name,@invoice_no,@quantity,@now)";
                    SqlCommand sqlCmd = new SqlCommand(query, con);
                    sqlCmd.Parameters.AddWithValue("@item_name", row.Cells["product name"].Value);
                    sqlCmd.Parameters.AddWithValue("@item_price", row.Cells["product price"].Value);

                    sqlCmd.Parameters.AddWithValue("@cus_name", selected_customer);
                    sqlCmd.Parameters.AddWithValue("@invoice_no", invoice_no);

                    sqlCmd.Parameters.AddWithValue("@quantity", row.Cells["product quantity"].Value);
                    sqlCmd.Parameters.AddWithValue("@now", now);


                    sqlCmd.ExecuteNonQuery();

                   


                }

                count = 0;

                rddr.Close();

              

                //More code here

            }


            MessageBox.Show("Congrats !!! your order has been placed now");
            MessageBox.Show(DateTime.Now.ToString("M/d/yyyy"));
            Form6 frm = new Form6();
            this.Hide();
            frm.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }
    }
}
