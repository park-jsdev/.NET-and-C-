﻿namespace PersonAndCustomerClasses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_getDiscount = new System.Windows.Forms.Button();
            this.lbl_cNum = new System.Windows.Forms.Label();
            this.lbl_pAmount = new System.Windows.Forms.Label();
            this.lbl_cDiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Purchase Amount:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Purchase Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Customer Discount:";
            // 
            // btn_getDiscount
            // 
            this.btn_getDiscount.Location = new System.Drawing.Point(260, 278);
            this.btn_getDiscount.Name = "btn_getDiscount";
            this.btn_getDiscount.Size = new System.Drawing.Size(75, 44);
            this.btn_getDiscount.TabIndex = 7;
            this.btn_getDiscount.Text = "Get Discount";
            this.btn_getDiscount.UseVisualStyleBackColor = true;
            this.btn_getDiscount.Click += new System.EventHandler(this.btn_getDiscount_Click);
            // 
            // lbl_cNum
            // 
            this.lbl_cNum.AutoSize = true;
            this.lbl_cNum.Location = new System.Drawing.Point(260, 151);
            this.lbl_cNum.Name = "lbl_cNum";
            this.lbl_cNum.Size = new System.Drawing.Size(0, 13);
            this.lbl_cNum.TabIndex = 9;
            // 
            // lbl_pAmount
            // 
            this.lbl_pAmount.AutoSize = true;
            this.lbl_pAmount.Location = new System.Drawing.Point(260, 180);
            this.lbl_pAmount.Name = "lbl_pAmount";
            this.lbl_pAmount.Size = new System.Drawing.Size(0, 13);
            this.lbl_pAmount.TabIndex = 10;
            // 
            // lbl_cDiscount
            // 
            this.lbl_cDiscount.AutoSize = true;
            this.lbl_cDiscount.Location = new System.Drawing.Point(260, 211);
            this.lbl_cDiscount.Name = "lbl_cDiscount";
            this.lbl_cDiscount.Size = new System.Drawing.Size(0, 13);
            this.lbl_cDiscount.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_cDiscount);
            this.Controls.Add(this.lbl_pAmount);
            this.Controls.Add(this.lbl_cNum);
            this.Controls.Add(this.btn_getDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_getDiscount;
        private System.Windows.Forms.Label lbl_cNum;
        private System.Windows.Forms.Label lbl_pAmount;
        private System.Windows.Forms.Label lbl_cDiscount;
    }
}