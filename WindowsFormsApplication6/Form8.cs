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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string d = dateTimePicker1.Value.Date.ToShortDateString();

         

            SqlConnection cony = new SqlConnection("Data Source=uzair-pc;Initial Catalog=pos;Integrated Security=SSPI");
            cony.Open();
            SqlCommand cmdd = new SqlCommand("select * from orders where date = @date", cony);
            cmdd.Parameters.AddWithValue("@date", d);


            SqlDataReader rddr = cmdd.ExecuteReader();

         


            DataTable table = new DataTable();

            table.Columns.Add("product name", typeof(string));
            table.Columns.Add("product price", typeof(float));
            table.Columns.Add("product quantity", typeof(int));
            table.Columns.Add("sub total", typeof(float));
            table.Columns.Add("customer name", typeof(string));


            float grand = 0;

            while (rddr.Read())
            {
                float s = float.Parse(rddr["item_price"].ToString());
                int da = int.Parse(rddr["quantity"].ToString());

                float sub = s * da;

                grand += sub;
                table.Rows.Add(rddr["item_name"], rddr["item_price"], rddr["quantity"], sub, rddr["cus_name"]);

            }


            dataGridView1.DataSource = table;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
