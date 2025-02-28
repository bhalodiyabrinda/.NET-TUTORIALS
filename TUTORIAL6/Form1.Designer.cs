namespace TUTORIAL6
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            button1 = new Button();
            groupBox1 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            radioButton2 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            Output = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 49);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(27, 44);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "News Paper ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(341, 94);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(356, 352);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(265, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 125);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Source of Information";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(185, 83);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(74, 24);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "Others";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(27, 83);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(84, 24);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Website";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(185, 44);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(78, 24);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Friends";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(475, 94);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 96);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 7;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 306);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 8;
            label3.Text = "If other, Specify";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(356, 299);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 27);
            textBox2.TabIndex = 9;
            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.Location = new Point(189, 390);
            Output.Name = "Output";
            Output.Size = new Size(53, 20);
            Output.TabIndex = 11;
            Output.Text = "output";
            Output.Click += Output_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Output);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "22SOEIT11037_MANVI";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private Button button1;
        private GroupBox groupBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private RadioButton radioButton2;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label Output;
    }
}
