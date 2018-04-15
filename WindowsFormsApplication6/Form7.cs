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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

            SqlConnection cony = new SqlConnection("Data Source=uzair-pc;Initial Catalog=pos;Integrated Security=SSPI");
            cony.Open();
            SqlCommand cmdd = new SqlCommand("select * from customers", cony);



            SqlDataReader rddr = cmdd.ExecuteReader();

 

   


           
            DataTable table = new DataTable();

            table.Columns.Add("Customer name", typeof(string));
            table.Columns.Add("Cell No", typeof(float));
         
            



            while (rddr.Read())
            {
              
                table.Rows.Add(rddr["cus_name"], rddr["cus_no"]);


            }

            dataGridView1.DataSource = table;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }
    }
}
