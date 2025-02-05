namespace El_Hamla
{
    partial class AA_trans_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AA_trans_report));
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox5 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dvg10 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg10).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(313, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.Yes;
            dateTimePicker1.RightToLeftLayout = true;
            dateTimePicker1.Size = new Size(254, 27);
            dateTimePicker1.TabIndex = 321;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(313, 137);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeft = RightToLeft.Yes;
            dateTimePicker2.RightToLeftLayout = true;
            dateTimePicker2.Size = new Size(254, 27);
            dateTimePicker2.TabIndex = 322;
            // 
            // comboBox5
            // 
            comboBox5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox5.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(677, 102);
            comboBox5.Margin = new Padding(4, 3, 4, 3);
            comboBox5.Name = "comboBox5";
            comboBox5.RightToLeft = RightToLeft.Yes;
            comboBox5.Size = new Size(257, 29);
            comboBox5.TabIndex = 323;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(677, 138);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(257, 29);
            comboBox1.TabIndex = 324;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(148, 103);
            button1.Name = "button1";
            button1.Size = new Size(102, 53);
            button1.TabIndex = 326;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            dataGridViewCellStyle2.Font = new Font("Andalus", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvg10.DefaultCellStyle = dataGridViewCellStyle2;
            dvg10.Enabled = false;
            dvg10.Location = new Point(53, 200);
            dvg10.Margin = new Padding(4, 3, 4, 3);
            dvg10.Name = "dvg10";
            dvg10.RightToLeft = RightToLeft.Yes;
            dvg10.RowHeadersVisible = false;
            dvg10.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dvg10.Size = new Size(1177, 477);
            dvg10.TabIndex = 327;
            dvg10.CellFormatting += dvg10_CellFormatting_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1210, 12);
            button2.Name = "button2";
            button2.Size = new Size(50, 72);
            button2.TabIndex = 328;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AA_trans_report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1278, 710);
            Controls.Add(button2);
            Controls.Add(dvg10);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(comboBox5);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AA_trans_report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AA_trans_report";
            Load += AA_trans_report_Load;
            ((System.ComponentModel.ISupportInitialize)dvg10).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox5;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dvg10;
        private Button button2;
    }
}