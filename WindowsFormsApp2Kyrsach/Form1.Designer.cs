﻿namespace WindowsFormsApp2Kyrsach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_plus_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_minus_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(19, 21);
            this.button3.TabIndex = 2;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_plus_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(498, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(19, 20);
            this.button4.TabIndex = 3;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_minus_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(245, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "1+2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_1_plus_2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Matrix1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(455, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Matrix2";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(245, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 30);
            this.button6.TabIndex = 7;
            this.button6.Text = "1-2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_1_minus_2_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(245, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 30);
            this.button7.TabIndex = 8;
            this.button7.Text = "1*2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_1_multiply_2_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(118, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Rank1";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_rank_1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(350, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "Rank2";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_rank_2_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(118, 41);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Transpon1";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_transpon_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(350, 41);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 12;
            this.button11.Text = "Transpon2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_transpon_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(118, 70);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 13;
            this.button12.Text = "Opr1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Opr_1_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(350, 81);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 14;
            this.button13.Text = "Opr2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Opr_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 842);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}

