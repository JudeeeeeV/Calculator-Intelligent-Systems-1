namespace Calculator
{
    partial class Calculator
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
            this.textbox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.button_ce = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_c = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_decimal = new System.Windows.Forms.Button();
            this.button_zero = new System.Windows.Forms.Button();
            this.button_negate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.ForeColor = System.Drawing.Color.White;
            this.textbox.Location = new System.Drawing.Point(11, 27);
            this.textbox.MaximumSize = new System.Drawing.Size(307, 64);
            this.textbox.MinimumSize = new System.Drawing.Size(307, 64);
            this.textbox.Name = "textbox";
            this.textbox.ReadOnly = true;
            this.textbox.Size = new System.Drawing.Size(307, 64);
            this.textbox.TabIndex = 0;
            this.textbox.TabStop = false;
            this.textbox.Text = "0";
            this.textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.label.Location = new System.Drawing.Point(11, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(307, 23);
            this.label.TabIndex = 1;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_ce
            // 
            this.button_ce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_ce.FlatAppearance.BorderSize = 0;
            this.button_ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ce.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ce.ForeColor = System.Drawing.Color.White;
            this.button_ce.Location = new System.Drawing.Point(11, 110);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(152, 56);
            this.button_ce.TabIndex = 2;
            this.button_ce.Text = "CE";
            this.button_ce.UseVisualStyleBackColor = false;
            this.button_ce.Click += new System.EventHandler(this.button_ce_Click);
            // 
            // button_c
            // 
            this.button_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_c.FlatAppearance.BorderSize = 0;
            this.button_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_c.ForeColor = System.Drawing.Color.White;
            this.button_c.Location = new System.Drawing.Point(168, 110);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(73, 56);
            this.button_c.TabIndex = 3;
            this.button_c.Text = "C";
            this.button_c.UseVisualStyleBackColor = false;
            this.button_c.Click += new System.EventHandler(this.button_c_Click);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_divide.FlatAppearance.BorderSize = 0;
            this.button_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_divide.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.ForeColor = System.Drawing.Color.White;
            this.button_divide.Location = new System.Drawing.Point(245, 110);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(73, 56);
            this.button_divide.TabIndex = 4;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_multiply.FlatAppearance.BorderSize = 0;
            this.button_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_multiply.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multiply.ForeColor = System.Drawing.Color.White;
            this.button_multiply.Location = new System.Drawing.Point(245, 172);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(73, 56);
            this.button_multiply.TabIndex = 5;
            this.button_multiply.Tag = "";
            this.button_multiply.Text = "x";
            this.button_multiply.UseVisualStyleBackColor = false;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_minus.FlatAppearance.BorderSize = 0;
            this.button_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.ForeColor = System.Drawing.Color.White;
            this.button_minus.Location = new System.Drawing.Point(246, 234);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(73, 56);
            this.button_minus.TabIndex = 6;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_plus.FlatAppearance.BorderSize = 0;
            this.button_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.ForeColor = System.Drawing.Color.White;
            this.button_plus.Location = new System.Drawing.Point(245, 296);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(73, 56);
            this.button_plus.TabIndex = 7;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_equal
            // 
            this.button_equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(165)))), ((int)(((byte)(161)))));
            this.button_equal.FlatAppearance.BorderSize = 0;
            this.button_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_equal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_equal.Location = new System.Drawing.Point(245, 358);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(73, 56);
            this.button_equal.TabIndex = 8;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = false;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_8.FlatAppearance.BorderSize = 0;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.ForeColor = System.Drawing.Color.White;
            this.button_8.Location = new System.Drawing.Point(90, 172);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(73, 56);
            this.button_8.TabIndex = 10;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_9.FlatAppearance.BorderSize = 0;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.ForeColor = System.Drawing.Color.White;
            this.button_9.Location = new System.Drawing.Point(168, 172);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(73, 56);
            this.button_9.TabIndex = 11;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_5.FlatAppearance.BorderSize = 0;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.ForeColor = System.Drawing.Color.White;
            this.button_5.Location = new System.Drawing.Point(90, 234);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(73, 56);
            this.button_5.TabIndex = 12;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_6.FlatAppearance.BorderSize = 0;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.ForeColor = System.Drawing.Color.White;
            this.button_6.Location = new System.Drawing.Point(168, 234);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(73, 56);
            this.button_6.TabIndex = 13;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_7.FlatAppearance.BorderSize = 0;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.ForeColor = System.Drawing.Color.White;
            this.button_7.Location = new System.Drawing.Point(11, 172);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(73, 56);
            this.button_7.TabIndex = 14;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_4.FlatAppearance.BorderSize = 0;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.ForeColor = System.Drawing.Color.White;
            this.button_4.Location = new System.Drawing.Point(11, 234);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(73, 56);
            this.button_4.TabIndex = 15;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_3.FlatAppearance.BorderSize = 0;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.ForeColor = System.Drawing.Color.White;
            this.button_3.Location = new System.Drawing.Point(169, 296);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(73, 56);
            this.button_3.TabIndex = 16;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_2.FlatAppearance.BorderSize = 0;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.ForeColor = System.Drawing.Color.White;
            this.button_2.Location = new System.Drawing.Point(90, 296);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(73, 56);
            this.button_2.TabIndex = 17;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_1.FlatAppearance.BorderSize = 0;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.ForeColor = System.Drawing.Color.White;
            this.button_1.Location = new System.Drawing.Point(11, 296);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(73, 56);
            this.button_1.TabIndex = 18;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_decimal
            // 
            this.button_decimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_decimal.FlatAppearance.BorderSize = 0;
            this.button_decimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_decimal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_decimal.ForeColor = System.Drawing.Color.White;
            this.button_decimal.Location = new System.Drawing.Point(168, 358);
            this.button_decimal.Name = "button_decimal";
            this.button_decimal.Size = new System.Drawing.Size(73, 56);
            this.button_decimal.TabIndex = 19;
            this.button_decimal.Text = ".";
            this.button_decimal.UseVisualStyleBackColor = false;
            this.button_decimal.Click += new System.EventHandler(this.button_decimal_Click);
            // 
            // button_zero
            // 
            this.button_zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_zero.FlatAppearance.BorderSize = 0;
            this.button_zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zero.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_zero.ForeColor = System.Drawing.Color.White;
            this.button_zero.Location = new System.Drawing.Point(90, 358);
            this.button_zero.Name = "button_zero";
            this.button_zero.Size = new System.Drawing.Size(73, 56);
            this.button_zero.TabIndex = 20;
            this.button_zero.Text = "0";
            this.button_zero.UseVisualStyleBackColor = false;
            this.button_zero.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_negate
            // 
            this.button_negate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_negate.FlatAppearance.BorderSize = 0;
            this.button_negate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_negate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_negate.ForeColor = System.Drawing.Color.White;
            this.button_negate.Location = new System.Drawing.Point(11, 358);
            this.button_negate.Name = "button_negate";
            this.button_negate.Size = new System.Drawing.Size(73, 56);
            this.button_negate.TabIndex = 21;
            this.button_negate.Text = "+/-";
            this.button_negate.UseVisualStyleBackColor = false;
            this.button_negate.Click += new System.EventHandler(this.button_negate_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(329, 424);
            this.Controls.Add(this.button_negate);
            this.Controls.Add(this.button_zero);
            this.Controls.Add(this.button_decimal);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_c);
            this.Controls.Add(this.button_ce);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 463);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button_ce;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_decimal;
        private System.Windows.Forms.Button button_zero;
        private System.Windows.Forms.Button button_negate;
    }
}

