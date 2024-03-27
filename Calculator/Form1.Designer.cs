namespace Calculator
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
        private void InitializeComponent()
        {
            labelCurrentOperation = new Label();
            textBox_result = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonCE = new Button();
            buttonDivide = new Button();
            buttonMultiply = new Button();
            buttonClear = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            buttonMinus = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonPlus = new Button();
            buttonEquals = new Button();
            buttonDot = new Button();
            button0 = new Button();
            SuspendLayout();
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.Location = new Point(5, 23);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 15);
            labelCurrentOperation.TabIndex = 0;
            // 
            // textBox_result
            // 
            textBox_result.Location = new Point(12, 44);
            textBox_result.Name = "textBox_result";
            textBox_result.Size = new Size(229, 23);
            textBox_result.TabIndex = 1;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(12, 99);
            button7.Name = "button7";
            button7.Size = new Size(41, 35);
            button7.TabIndex = 2;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(59, 99);
            button8.Name = "button8";
            button8.Size = new Size(41, 35);
            button8.TabIndex = 3;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(106, 99);
            button9.Name = "button9";
            button9.Size = new Size(41, 35);
            button9.TabIndex = 4;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_click;
            // 
            // buttonCE
            // 
            buttonCE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCE.Location = new Point(200, 99);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(41, 35);
            buttonCE.TabIndex = 5;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDivide.Location = new Point(153, 99);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(41, 35);
            buttonDivide.TabIndex = 6;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += operator_click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMultiply.Location = new Point(153, 140);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(41, 35);
            buttonMultiply.TabIndex = 11;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += operator_click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.Location = new Point(200, 140);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(41, 35);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(106, 140);
            button6.Name = "button6";
            button6.Size = new Size(41, 35);
            button6.TabIndex = 9;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(59, 140);
            button5.Name = "button5";
            button5.Size = new Size(41, 35);
            button5.TabIndex = 8;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 140);
            button4.Name = "button4";
            button4.Size = new Size(41, 35);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinus.Location = new Point(153, 181);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(41, 35);
            buttonMinus.TabIndex = 16;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += operator_click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(106, 181);
            button3.Name = "button3";
            button3.Size = new Size(41, 35);
            button3.TabIndex = 14;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(59, 181);
            button2.Name = "button2";
            button2.Size = new Size(41, 35);
            button2.TabIndex = 13;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 181);
            button1.Name = "button1";
            button1.Size = new Size(41, 35);
            button1.TabIndex = 12;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_click;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlus.Location = new Point(153, 222);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(41, 35);
            buttonPlus.TabIndex = 21;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += operator_click;
            // 
            // buttonEquals
            // 
            buttonEquals.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEquals.Location = new Point(200, 181);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(41, 76);
            buttonEquals.TabIndex = 20;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonDot
            // 
            buttonDot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDot.Location = new Point(106, 222);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(41, 35);
            buttonDot.TabIndex = 19;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += button_click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button0.Location = new Point(12, 222);
            button0.Name = "button0";
            button0.Size = new Size(88, 35);
            button0.TabIndex = 17;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(257, 270);
            Controls.Add(buttonPlus);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDot);
            Controls.Add(button0);
            Controls.Add(buttonMinus);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonClear);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonDivide);
            Controls.Add(buttonCE);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBox_result);
            Controls.Add(labelCurrentOperation);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCurrentOperation;
        private TextBox textBox_result;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonCE;
        private Button buttonDivide;
        private Button buttonMultiply;
        private Button buttonClear;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button buttonMinus;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonPlus;
        private Button buttonEquals;
        private Button buttonDot;
        private Button button0;
    }
}