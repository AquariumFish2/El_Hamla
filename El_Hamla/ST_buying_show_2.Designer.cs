namespace El_Hamla
{
    partial class buying_show_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buying_show_2));
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            com_buyer = new ComboBox();
            dvg10 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvg10).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(888, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.Yes;
            dateTimePicker1.RightToLeftLayout = true;
            dateTimePicker1.Size = new Size(10, 35);
            dateTimePicker1.TabIndex = 33;
            dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(845, 40);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeft = RightToLeft.Yes;
            dateTimePicker2.RightToLeftLayout = true;
            dateTimePicker2.Size = new Size(10, 35);
            dateTimePicker2.TabIndex = 34;
            dateTimePicker2.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(136, 36);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(58, 30);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "الكل";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
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
            button2.Location = new Point(1101, 12);
            button2.Name = "button2";
            button2.Size = new Size(55, 71);
            button2.TabIndex = 36;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.Enabled = false;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Silver;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(23, 34);
            button3.Name = "button3";
            button3.Size = new Size(85, 41);
            button3.TabIndex = 38;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // com_buyer
            // 
            com_buyer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            com_buyer.AutoCompleteSource = AutoCompleteSource.ListItems;
            com_buyer.Enabled = false;
            com_buyer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            com_buyer.FormattingEnabled = true;
            com_buyer.Location = new Point(213, 36);
            com_buyer.Name = "com_buyer";
            com_buyer.RightToLeft = RightToLeft.Yes;
            com_buyer.Size = new Size(10, 33);
            com_buyer.TabIndex = 39;
            com_buyer.Visible = false;
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
            dvg10.Location = new Point(55, 119);
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
            dvg10.Size = new Size(1063, 522);
            dvg10.TabIndex = 40;
            dvg10.RowHeaderMouseDoubleClick += dvg10_RowHeaderMouseDoubleClick;
            dvg10.Click += dvg10_Click;
            // 
            // buying_show_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 680);
            Controls.Add(dvg10);
            Controls.Add(com_buyer);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "buying_show_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "buying_show";
            Load += buying_show_Load;
            ((System.ComponentModel.ISupportInitialize)dvg10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
        private ComboBox com_buyer;
        private DataGridView dvg10;
    }
}