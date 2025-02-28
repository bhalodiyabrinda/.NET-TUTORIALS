namespace WinFormsApp1
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(82, 393);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(370, 27);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 27);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 53);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 7;
            label2.Text = "Number1";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 114);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 8;
            label1.Text = "Number2";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(152, 349);
            button1.Name = "button1";
            button1.Size = new Size(165, 29);
            button1.TabIndex = 10;
            button1.Text = "Answer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(72, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 176);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operation";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(228, 105);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(79, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Divison";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(34, 105);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(118, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Mulitipliction";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(228, 42);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(112, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Substraction";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(34, 42);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(79, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Addion";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "BRINDA_22SOECE11067";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
    }
}
