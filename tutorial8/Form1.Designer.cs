namespace tutorial8
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
            TreeNode treeNode1 = new TreeNode("Gujrat");
            TreeNode treeNode2 = new TreeNode("Rajashan");
            treeView1 = new TreeView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(27, 16);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Gujrat";
            treeNode1.Text = "Gujrat";
            treeNode2.Name = "Rajashan";
            treeNode2.Text = "Rajashan";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2 });
            treeView1.Size = new Size(326, 410);
            treeView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(402, 27);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 1;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(402, 85);
            button2.Name = "button2";
            button2.Size = new Size(157, 29);
            button2.TabIndex = 2;
            button2.Text = "Count";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(402, 145);
            button3.Name = "button3";
            button3.Size = new Size(156, 29);
            button3.TabIndex = 3;
            button3.Text = "Collaps";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(402, 202);
            button4.Name = "button4";
            button4.Size = new Size(158, 29);
            button4.TabIndex = 4;
            button4.Text = "Expands";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(402, 276);
            button5.Name = "button5";
            button5.Size = new Size(157, 29);
            button5.TabIndex = 5;
            button5.Text = "Add Root";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(402, 338);
            button6.Name = "button6";
            button6.Size = new Size(156, 29);
            button6.TabIndex = 6;
            button6.Text = "Add Child Root";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(402, 398);
            button7.Name = "button7";
            button7.Size = new Size(155, 29);
            button7.TabIndex = 7;
            button7.Text = "Selected Remove";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(593, 397);
            button8.Name = "button8";
            button8.Size = new Size(145, 29);
            button8.TabIndex = 8;
            button8.Text = "Clear Text";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(593, 338);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(593, 276);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 27);
            textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "22SOEce11067_BRINDA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
