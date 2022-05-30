namespace WindowsFormsApp3
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgoodname = new System.Windows.Forms.TextBox();
            this.txtgoodsales = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgoodOutPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgoodprofit = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtgoodcount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgoodinprice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "商品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品销量";
            // 
            // txtgoodname
            // 
            this.txtgoodname.Location = new System.Drawing.Point(140, 32);
            this.txtgoodname.Name = "txtgoodname";
            this.txtgoodname.Size = new System.Drawing.Size(100, 25);
            this.txtgoodname.TabIndex = 3;
            // 
            // txtgoodsales
            // 
            this.txtgoodsales.Location = new System.Drawing.Point(140, 131);
            this.txtgoodsales.Name = "txtgoodsales";
            this.txtgoodsales.Size = new System.Drawing.Size(100, 25);
            this.txtgoodsales.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "售价";
            // 
            // txtgoodOutPrice
            // 
            this.txtgoodOutPrice.Location = new System.Drawing.Point(140, 239);
            this.txtgoodOutPrice.Name = "txtgoodOutPrice";
            this.txtgoodOutPrice.Size = new System.Drawing.Size(100, 25);
            this.txtgoodOutPrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "利润";
            // 
            // txtgoodprofit
            // 
            this.txtgoodprofit.Location = new System.Drawing.Point(140, 302);
            this.txtgoodprofit.Name = "txtgoodprofit";
            this.txtgoodprofit.Size = new System.Drawing.Size(100, 25);
            this.txtgoodprofit.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtgoodcount
            // 
            this.txtgoodcount.Location = new System.Drawing.Point(140, 83);
            this.txtgoodcount.Name = "txtgoodcount";
            this.txtgoodcount.Size = new System.Drawing.Size(100, 25);
            this.txtgoodcount.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "商品库存";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "查找";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "进价";
            // 
            // txtgoodinprice
            // 
            this.txtgoodinprice.Location = new System.Drawing.Point(140, 188);
            this.txtgoodinprice.Name = "txtgoodinprice";
            this.txtgoodinprice.Size = new System.Drawing.Size(100, 25);
            this.txtgoodinprice.TabIndex = 14;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 492);
            this.Controls.Add(this.txtgoodinprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgoodcount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtgoodprofit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtgoodOutPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgoodsales);
            this.Controls.Add(this.txtgoodname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "商品销售";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgoodname;
        private System.Windows.Forms.TextBox txtgoodsales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgoodOutPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgoodprofit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtgoodcount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgoodinprice;
    }
}