namespace WindowsFormsApplication6
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.v_customers = new System.Windows.Forms.Button();
            this.v_daily = new System.Windows.Forms.Button();
            this.a_shop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.p_order = new System.Windows.Forms.Button();
            this.add_c = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // v_customers
            // 
            this.v_customers.Location = new System.Drawing.Point(287, 199);
            this.v_customers.Name = "v_customers";
            this.v_customers.Size = new System.Drawing.Size(200, 23);
            this.v_customers.TabIndex = 0;
            this.v_customers.Text = "VIEW CUSTOMERS";
            this.v_customers.UseVisualStyleBackColor = true;
            this.v_customers.Click += new System.EventHandler(this.v_customers_Click);
            // 
            // v_daily
            // 
            this.v_daily.Location = new System.Drawing.Point(287, 242);
            this.v_daily.Name = "v_daily";
            this.v_daily.Size = new System.Drawing.Size(200, 23);
            this.v_daily.TabIndex = 1;
            this.v_daily.Text = "VIEW DAILY REPORT";
            this.v_daily.UseVisualStyleBackColor = true;
            this.v_daily.Click += new System.EventHandler(this.button2_Click);
            // 
            // a_shop
            // 
            this.a_shop.Location = new System.Drawing.Point(287, 114);
            this.a_shop.Name = "a_shop";
            this.a_shop.Size = new System.Drawing.Size(200, 23);
            this.a_shop.TabIndex = 2;
            this.a_shop.Text = "ADD ITEMS TO SHOP";
            this.a_shop.UseVisualStyleBackColor = true;
            this.a_shop.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 71);
            this.label1.TabIndex = 3;
            this.label1.Text = "POINT OF SALE";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApplication6.Properties.Resources.arr;
            this.button4.Location = new System.Drawing.Point(93, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 33);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // p_order
            // 
            this.p_order.Location = new System.Drawing.Point(287, 155);
            this.p_order.Name = "p_order";
            this.p_order.Size = new System.Drawing.Size(200, 23);
            this.p_order.TabIndex = 5;
            this.p_order.Text = "PLACE ORDER";
            this.p_order.UseVisualStyleBackColor = true;
            this.p_order.Click += new System.EventHandler(this.p_order_Click);
            // 
            // add_c
            // 
            this.add_c.Location = new System.Drawing.Point(287, 283);
            this.add_c.Name = "add_c";
            this.add_c.Size = new System.Drawing.Size(200, 23);
            this.add_c.TabIndex = 6;
            this.add_c.Text = "ADD CUSTOMER";
            this.add_c.UseVisualStyleBackColor = true;
            this.add_c.Click += new System.EventHandler(this.add_c_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "MANAGE ITEMS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_c);
            this.Controls.Add(this.p_order);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a_shop);
            this.Controls.Add(this.v_daily);
            this.Controls.Add(this.v_customers);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button v_customers;
        private System.Windows.Forms.Button v_daily;
        private System.Windows.Forms.Button a_shop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button p_order;
        private System.Windows.Forms.Button add_c;
        private System.Windows.Forms.Button button1;
    }
}