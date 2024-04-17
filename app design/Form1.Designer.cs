namespace app_design
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
            listBox1 = new ListBox();
            label1 = new Label();
            Név = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            mentes_label = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listBox4 = new ListBox();
            label4 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(35, 45);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 259);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "SKU";
            // 
            // Név
            // 
            Név.AutoSize = true;
            Név.Location = new Point(179, 30);
            Név.Name = "Név";
            Név.Size = new Size(28, 15);
            Név.TabIndex = 4;
            Név.Text = "Név";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(340, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mentes_label);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(listBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Név);
            groupBox1.Location = new Point(35, 310);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(495, 340);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // mentes_label
            // 
            mentes_label.AutoSize = true;
            mentes_label.Location = new Point(388, 321);
            mentes_label.Name = "mentes_label";
            mentes_label.Size = new Size(0, 15);
            mentes_label.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 13;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(6, 114);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(466, 154);
            listBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 94);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 9;
            label4.Text = "Leírás";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 30);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Ár (Ft)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(369, 48);
            numericUpDown1.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(388, 274);
            button1.Name = "button1";
            button1.Size = new Size(101, 37);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 47);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 7;
            label2.Text = "Kép";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(236, 45);
            button2.Name = "button2";
            button2.Size = new Size(42, 45);
            button2.TabIndex = 9;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(236, 96);
            button3.Name = "button3";
            button3.Size = new Size(85, 45);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(502, 38);
            button4.Name = "button4";
            button4.Size = new Size(28, 21);
            button4.TabIndex = 11;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 655);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label Név;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox4;
        private Label label4;
        private Label mentes_label;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
