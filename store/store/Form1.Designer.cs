namespace store
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
            colour = new ComboBox();
            style = new ComboBox();
            size = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // colour
            // 
            colour.FormattingEnabled = true;
            colour.Items.AddRange(new object[] { "black", "white", "pink" });
            colour.Location = new Point(70, 62);
            colour.Name = "colour";
            colour.Size = new Size(121, 23);
            colour.TabIndex = 0;
            colour.Text = "Colour";
            // 
            // style
            // 
            style.FormattingEnabled = true;
            style.Items.AddRange(new object[] { "modern", "classic" });
            style.Location = new Point(228, 62);
            style.Name = "style";
            style.Size = new Size(121, 23);
            style.TabIndex = 1;
            style.Text = "Style";
            // 
            // size
            // 
            size.FormattingEnabled = true;
            size.Items.AddRange(new object[] { "S", "M" });
            size.Location = new Point(386, 62);
            size.Name = "size";
            size.Size = new Size(121, 23);
            size.TabIndex = 2;
            size.Text = "Size";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(134, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(428, 188);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(134, 357);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(286, 357);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(441, 357);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 6;
            button3.Text = "Book Consultation";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "unisex", "female", "male" });
            comboBox1.Location = new Point(551, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "For";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(size);
            Controls.Add(style);
            Controls.Add(colour);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox colour;
        private ComboBox style;
        private ComboBox size;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
    }
}