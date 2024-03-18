namespace AppTestControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            domainUpDown1 = new DomainUpDown();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            listView1 = new ListView();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            label10 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button
            // 
            button.BackColor = SystemColors.GradientActiveCaption;
            button.Cursor = Cursors.Hand;
            button.Location = new Point(12, 32);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 0;
            button.Text = "Click Here";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Button";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(124, 32);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "True/False";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 9);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "CheckBox";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCoral;
            textBox1.Location = new Point(237, 34);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "False";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 9);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 5;
            label3.Text = "TextBox";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Option1", "Option2", "Option3", "Option4", "Option5" });
            checkedListBox1.Location = new Point(396, 32);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(118, 114);
            checkedListBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 9);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 7;
            label4.Text = "ChechedListBox";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Long", "Short", "Time" });
            comboBox1.Location = new Point(534, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(551, 9);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "ComboBox";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(712, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(783, 11);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 11;
            label6.Text = "DataTimePicker";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(975, 35);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(150, 27);
            domainUpDown1.TabIndex = 12;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(534, 72);
            label7.Name = "label7";
            label7.Size = new Size(137, 40);
            label7.TabIndex = 13;
            label7.Text = "Elige el formato de\r\nDataTimePicker";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(986, 9);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 14;
            label8.Text = "DomainUpDown";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(33, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(312, 104);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 16;
            label9.Text = "label";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ButtonFace;
            linkLabel1.LinkArea = new LinkArea(0, 23);
            linkLabel1.Location = new Point(126, 289);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(149, 25);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Tecnologic Monclova";
            linkLabel1.UseCompatibleTextRendering = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(312, 187);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 18;
            // 
            // listView1
            // 
            listView1.Location = new Point(500, 187);
            listView1.Name = "listView1";
            listView1.Size = new Size(151, 121);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 323);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 145);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(712, 104);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 29);
            progressBar1.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(733, 81);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 22;
            label10.Text = "ProgressBar";
            // 
            // button1
            // 
            button1.Location = new Point(726, 149);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 23;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.Enabled = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 480);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(domainUpDown1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private Label label1;
        private CheckBox checkBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private DomainUpDown domainUpDown1;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private Label label9;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
        private ListView listView1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label label10;
        private Button button1;
    }
}
