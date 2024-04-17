namespace app_design
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
            groupBox1 = new GroupBox();
            button4 = new Button();
            label2 = new Label();
            button2 = new Button();
            mentes_label = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listBox4 = new ListBox();
            label4 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label1 = new Label();
            Név = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 340);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button4
            // 
            button4.Location = new Point(40, 296);
            button4.Name = "button4";
            button4.Size = new Size(28, 21);
            button4.TabIndex = 18;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 296);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 17;
            label2.Text = "Kép";
            // 
            // button2
            // 
            button2.Location = new Point(286, 274);
            button2.Name = "button2";
            button2.Size = new Size(89, 37);
            button2.TabIndex = 16;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            listBox4.Location = new Point(0, 114);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(477, 154);
            listBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 94);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Description";
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
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(390, 274);
            button1.Name = "button1";
            button1.Size = new Size(101, 37);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 362);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Label mentes_label;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox4;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label1;
        private Label Név;
        private Button button4;
        private Label label2;
    }
}