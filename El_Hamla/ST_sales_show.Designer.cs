namespace El_Hamla
{
    partial class ST_sales_show
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ST_sales_show));
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            com = new ComboBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            dvg10 = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvg10).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(739, 96);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeft = RightToLeft.Yes;
            dateTimePicker2.RightToLeftLayout = true;
            dateTimePicker2.Size = new Size(137, 29);
            dateTimePicker2.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(966, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.Yes;
            dateTimePicker1.RightToLeftLayout = true;
            dateTimePicker1.Size = new Size(137, 29);
            dateTimePicker1.TabIndex = 35;
            // 
            // com
            // 
            com.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            com.AutoCompleteSource = AutoCompleteSource.ListItems;
            com.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            com.FormattingEnabled = true;
            com.Items.AddRange(new object[] { "اسم المستلم", "نوع الحساب", "رقم السيارة", "نوع السيارة ", "طريقة الدفع ", "جهة السيارة" });
            com.Location = new Point(538, 96);
            com.Name = "com";
            com.RightToLeft = RightToLeft.Yes;
            com.Size = new Size(176, 29);
            com.TabIndex = 40;
            com.SelectedIndexChanged += com_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(249, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(265, 29);
            comboBox1.TabIndex = 41;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(168, 97);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(58, 30);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "الكل";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Silver;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1108, 12);
            button2.Name = "button2";
            button2.Size = new Size(46, 71);
            button2.TabIndex = 43;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Silver;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(55, 94);
            button3.Name = "button3";
            button3.Size = new Size(85, 41);
            button3.TabIndex = 45;
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(36, 12);
            button1.Name = "button1";
            button1.Size = new Size(39, 61);
            button1.TabIndex = 44;
            button1.UseVisualStyleBackColor = false;
            // 
            // dvg10
            // 
            dvg10.AllowUserToAddRows = false;
            dvg10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg10.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Andalus", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvg10.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvg10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Andalus", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvg10.DefaultCellStyle = dataGridViewCellStyle2;
            dvg10.Location = new Point(55, 154);
            dvg10.Name = "dvg10";
            dvg10.RightToLeft = RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dvg10.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dvg10.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvg10.Size = new Size(1067, 477);
            dvg10.TabIndex = 46;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(544, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 47;
            // 
            // sales_show
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 680);
            Controls.Add(textBox1);
            Controls.Add(dvg10);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(com);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sales_show";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sales_show";
            Load += sales_show_Load;
            ((System.ComponentModel.ISupportInitialize)dvg10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox com;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
        private Button button1;
        private DataGridView dvg10;
        private TextBox textBox1;
    }
}