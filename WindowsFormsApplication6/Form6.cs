using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();


            SqlConnection cony = new SqlConnection("Data Source=uzair-pc;Initial Catalog=pos;Integrated Security=SSPI");
            cony.Open();
            SqlCommand cmdd = new SqlCommand("select * from orders order by order_no desc", cony);



            SqlDataReader rddr = cmdd.ExecuteReader();

            rddr.Read();

            label6.Text = rddr["invoice_no"].ToString();
            label5.Text = rddr["cus_name"].ToString();


            string invoice = rddr["invoice_no"].ToString();


            rddr.Close();

            cmdd = new SqlCommand("select * from orders where invoice_no = @inv", cony);
            cmdd.Parameters.AddWithValue("@inv",invoice);


            rddr = cmdd.ExecuteReader();

            DataTable table = new DataTable();

            table.Columns.Add("product name", typeof(string));
            table.Columns.Add("product price", typeof(float));
            table.Columns.Add("product quantity", typeof(int));
            table.Columns.Add("sub total", typeof(float));


            float grand = 0;

            while (rddr.Read())
            {
                float s = float.Parse(rddr["item_price"].ToString());
                int d = int.Parse(rddr["quantity"].ToString());

                float sub = s * d;

                grand += sub;
                table.Rows.Add(rddr["item_name"], rddr["item_price"], rddr["quantity"], sub);

            }


            dataGridView1.DataSource = table;

            label7.Text = grand.ToString();




        }

        private void Form6_Load(object sender, EventArgs e)
        {

       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
