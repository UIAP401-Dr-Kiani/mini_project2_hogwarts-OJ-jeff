namespace Hogwarts_Project
{
    partial class Form3
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            button3 = new Button();
            button4 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            button5 = new Button();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            button6 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(104, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(558, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 1;
            label1.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 9);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Welcome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 3;
            label3.Text = "Select Units";
            // 
            // button1
            // 
            button1.Location = new Point(694, 67);
            button1.Name = "button1";
            button1.Size = new Size(94, 28);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(307, 20);
            label4.TabIndex = 5;
            label4.Text = "Note that you can select maximum of 4 units.";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 132);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 84);
            listBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(752, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 38);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(202, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Can Teach Simultaneously";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button3
            // 
            button3.Location = new Point(12, 222);
            button3.Name = "button3";
            button3.Size = new Size(256, 29);
            button3.TabIndex = 9;
            button3.Text = "Set homework for botanical courses";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(527, 222);
            button4.Name = "button4";
            button4.Size = new Size(261, 29);
            button4.TabIndex = 10;
            button4.Text = "Set homework for chemistry courses";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(264, 329);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 27);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(264, 283);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(265, 27);
            dateTimePicker2.TabIndex = 12;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 283);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 13;
            label5.Text = "Start time";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 329);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 14;
            label6.Text = "Finish time";
            // 
            // button5
            // 
            button5.Location = new Point(344, 373);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 15;
            button5.Text = "Submit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(275, 329);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(265, 27);
            dateTimePicker3.TabIndex = 16;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(275, 283);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(265, 27);
            dateTimePicker4.TabIndex = 17;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // button6
            // 
            button6.Location = new Point(354, 373);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 18;
            button6.Text = "Submit";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 450);
            Controls.Add(button6);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private ListBox listBox1;
        private Button button2;
        private CheckBox checkBox1;
        private Button button3;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Label label6;
        private Button button5;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Button button6;
    }
}