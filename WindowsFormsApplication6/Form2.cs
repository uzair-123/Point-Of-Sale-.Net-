using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            this.Hide();
            frm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            this.Hide();
            frm.Show();

        }

        private void p_order_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();

        }

        private void add_c_Click(object sender, EventArgs e)
        {

            Form5 f = new Form5();
            this.Hide();
            f.Show();
        }

        private void v_customers_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            this.Hide();
            frm.Show();
        }
    }
}
