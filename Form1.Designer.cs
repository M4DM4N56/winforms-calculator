namespace calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button1 = new Button();
            btn_seven = new Button();
            display_box = new TextBox();
            btn_nine = new Button();
            btn_eight = new Button();
            btn_add = new Button();
            btn_subtract = new Button();
            btn_five = new Button();
            btn_six = new Button();
            btn_four = new Button();
            btn_divide = new Button();
            btn_two = new Button();
            btn_three = new Button();
            btn_one = new Button();
            btn_multiply = new Button();
            btn_zero = new Button();
            btn_decimal = new Button();
            btn_clear = new Button();
            btn_equals = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(722, 124);
            button1.Name = "button1";
            button1.Size = new Size(90, 8);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_seven
            // 
            btn_seven.BackColor = SystemColors.Window;
            btn_seven.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_seven.Location = new Point(35, 248);
            btn_seven.Name = "btn_seven";
            btn_seven.Size = new Size(170, 170);
            btn_seven.TabIndex = 1;
            btn_seven.Text = "7";
            btn_seven.UseVisualStyleBackColor = false;
            btn_seven.Click += btn_seven_Click;
            // 
            // display_box
            // 
            display_box.BackColor = SystemColors.Window;
            display_box.BorderStyle = BorderStyle.FixedSingle;
            display_box.Font = new Font("Segoe UI", 24F);
            display_box.Location = new Point(35, 20);
            display_box.Multiline = true;
            display_box.Name = "display_box";
            display_box.Size = new Size(763, 200);
            display_box.TabIndex = 2;
            display_box.TextChanged += display_box_TextChanged;
            // 
            // btn_nine
            // 
            btn_nine.BackColor = SystemColors.Window;
            btn_nine.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_nine.Location = new Point(429, 248);
            btn_nine.Name = "btn_nine";
            btn_nine.Size = new Size(170, 170);
            btn_nine.TabIndex = 3;
            btn_nine.Text = "9";
            btn_nine.UseVisualStyleBackColor = false;
            btn_nine.Click += btn_nine_Click;
            // 
            // btn_eight
            // 
            btn_eight.BackColor = SystemColors.Window;
            btn_eight.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_eight.Location = new Point(230, 248);
            btn_eight.Name = "btn_eight";
            btn_eight.Size = new Size(170, 170);
            btn_eight.TabIndex = 4;
            btn_eight.Text = "8";
            btn_eight.UseVisualStyleBackColor = false;
            btn_eight.Click += btn_eight_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.Control;
            btn_add.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_add.Location = new Point(628, 248);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(170, 170);
            btn_add.TabIndex = 5;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_subtract
            // 
            btn_subtract.BackColor = SystemColors.Control;
            btn_subtract.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_subtract.Location = new Point(628, 450);
            btn_subtract.Name = "btn_subtract";
            btn_subtract.Size = new Size(170, 170);
            btn_subtract.TabIndex = 9;
            btn_subtract.Text = "-";
            btn_subtract.UseVisualStyleBackColor = false;
            btn_subtract.Click += btn_subtract_Click;
            // 
            // btn_five
            // 
            btn_five.BackColor = SystemColors.Window;
            btn_five.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_five.Location = new Point(230, 450);
            btn_five.Name = "btn_five";
            btn_five.Size = new Size(170, 170);
            btn_five.TabIndex = 8;
            btn_five.Text = "5";
            btn_five.UseVisualStyleBackColor = false;
            btn_five.Click += btn_five_Click;
            // 
            // btn_six
            // 
            btn_six.BackColor = SystemColors.Window;
            btn_six.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_six.Location = new Point(429, 450);
            btn_six.Name = "btn_six";
            btn_six.Size = new Size(170, 170);
            btn_six.TabIndex = 7;
            btn_six.Text = "6";
            btn_six.UseVisualStyleBackColor = false;
            btn_six.Click += btn_six_Click;
            // 
            // btn_four
            // 
            btn_four.BackColor = SystemColors.Window;
            btn_four.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_four.Location = new Point(35, 450);
            btn_four.Name = "btn_four";
            btn_four.Size = new Size(170, 170);
            btn_four.TabIndex = 6;
            btn_four.Text = "4";
            btn_four.UseVisualStyleBackColor = false;
            btn_four.Click += btn_four_Click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = SystemColors.Control;
            btn_divide.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_divide.Location = new Point(628, 652);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(170, 170);
            btn_divide.TabIndex = 13;
            btn_divide.Text = "÷";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_two
            // 
            btn_two.BackColor = SystemColors.Window;
            btn_two.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_two.Location = new Point(230, 652);
            btn_two.Name = "btn_two";
            btn_two.Size = new Size(170, 170);
            btn_two.TabIndex = 12;
            btn_two.Text = "2";
            btn_two.UseVisualStyleBackColor = false;
            btn_two.Click += btn_two_Click;
            // 
            // btn_three
            // 
            btn_three.BackColor = SystemColors.Window;
            btn_three.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_three.Location = new Point(429, 652);
            btn_three.Name = "btn_three";
            btn_three.Size = new Size(170, 170);
            btn_three.TabIndex = 11;
            btn_three.Text = "3";
            btn_three.UseVisualStyleBackColor = false;
            btn_three.Click += btn_three_Click;
            // 
            // btn_one
            // 
            btn_one.BackColor = SystemColors.Window;
            btn_one.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_one.Location = new Point(35, 652);
            btn_one.Name = "btn_one";
            btn_one.Size = new Size(170, 170);
            btn_one.TabIndex = 10;
            btn_one.Text = "1";
            btn_one.UseVisualStyleBackColor = false;
            btn_one.Click += btn_one_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.BackColor = SystemColors.Control;
            btn_multiply.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_multiply.Location = new Point(628, 859);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(170, 170);
            btn_multiply.TabIndex = 17;
            btn_multiply.Text = "×";
            btn_multiply.UseVisualStyleBackColor = false;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_zero
            // 
            btn_zero.BackColor = SystemColors.Window;
            btn_zero.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_zero.Location = new Point(230, 859);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(170, 170);
            btn_zero.TabIndex = 16;
            btn_zero.Text = "0";
            btn_zero.UseVisualStyleBackColor = false;
            btn_zero.Click += btn_zero_Click;
            // 
            // btn_decimal
            // 
            btn_decimal.BackColor = SystemColors.Control;
            btn_decimal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_decimal.Location = new Point(429, 859);
            btn_decimal.Name = "btn_decimal";
            btn_decimal.Size = new Size(170, 170);
            btn_decimal.TabIndex = 15;
            btn_decimal.Text = ".";
            btn_decimal.UseVisualStyleBackColor = false;
            btn_decimal.Click += btn_decimal_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.Control;
            btn_clear.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_clear.Location = new Point(35, 859);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(170, 170);
            btn_clear.TabIndex = 14;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_equals
            // 
            btn_equals.BackColor = SystemColors.Window;
            btn_equals.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_equals.ForeColor = SystemColors.ControlText;
            btn_equals.Location = new Point(35, 1059);
            btn_equals.Name = "btn_equals";
            btn_equals.Size = new Size(763, 170);
            btn_equals.TabIndex = 18;
            btn_equals.Text = "=";
            btn_equals.UseVisualStyleBackColor = false;
            btn_equals.Click += btn_equals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(837, 1271);
            Controls.Add(btn_equals);
            Controls.Add(btn_multiply);
            Controls.Add(btn_zero);
            Controls.Add(btn_decimal);
            Controls.Add(btn_clear);
            Controls.Add(btn_divide);
            Controls.Add(btn_two);
            Controls.Add(btn_three);
            Controls.Add(btn_one);
            Controls.Add(btn_subtract);
            Controls.Add(btn_five);
            Controls.Add(btn_six);
            Controls.Add(btn_four);
            Controls.Add(btn_add);
            Controls.Add(btn_eight);
            Controls.Add(btn_nine);
            Controls.Add(display_box);
            Controls.Add(btn_seven);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btn_seven;
        private TextBox display_box;
        private Button btn_nine;
        private Button btn_eight;
        private Button btn_add;
        private Button btn_subtract;
        private Button btn_five;
        private Button btn_six;
        private Button btn_four;
        private Button btn_divide;
        private Button btn_two;
        private Button btn_three;
        private Button btn_one;
        private Button btn_multiply;
        private Button btn_zero;
        private Button btn_decimal;
        private Button btn_clear;
        private Button btn_equals;
    }
}
