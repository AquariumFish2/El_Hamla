namespace El_Hamla
{
    partial class M_products_balance_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_products_balance_report));
            suggestionBox2 = new ListBox();
            textBox1 = new TextBox();
            add_combo = new ComboBox();
            add_check = new CheckBox();
            type_combo = new ComboBox();
            type_check = new CheckBox();
            hagez_combo = new ComboBox();
            hagez_check = new CheckBox();
            compare_combo = new ComboBox();
            compare_check = new CheckBox();
            textBox2 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // suggestionBox2
            // 
            suggestionBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suggestionBox2.FormattingEnabled = true;
            suggestionBox2.ItemHeight = 25;
            suggestionBox2.Location = new Point(898, 128);
            suggestionBox2.Margin = new Padding(4, 3, 4, 3);
            suggestionBox2.Name = "suggestionBox2";
            suggestionBox2.Size = new Size(208, 79);
            suggestionBox2.TabIndex = 274;
            suggestionBox2.Visible = false;
            suggestionBox2.Click += suggestionBox2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(898, 98);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 273;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // add_combo
            // 
            add_combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            add_combo.AutoCompleteSource = AutoCompleteSource.ListItems;
            add_combo.Enabled = false;
            add_combo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_combo.FormattingEnabled = true;
            add_combo.Location = new Point(942, 143);
            add_combo.Name = "add_combo";
            add_combo.RightToLeft = RightToLeft.Yes;
            add_combo.Size = new Size(162, 28);
            add_combo.TabIndex = 282;
            // 
            // add_check
            // 
            add_check.AutoSize = true;
            add_check.BackColor = Color.Transparent;
            add_check.Font = new Font("Andalus", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_check.Location = new Point(895, 143);
            add_check.Margin = new Padding(4, 3, 4, 3);
            add_check.Name = "add_check";
            add_check.RightToLeft = RightToLeft.No;
            add_check.Size = new Size(54, 28);
            add_check.TabIndex = 284;
            add_check.Text = "الكل";
            add_check.TextAlign = ContentAlignment.MiddleCenter;
            add_check.UseVisualStyleBackColor = false;
            add_check.CheckedChanged += add_check_CheckedChanged;
            // 
            // type_combo
            // 
            type_combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            type_combo.AutoCompleteSource = AutoCompleteSource.ListItems;
            type_combo.Enabled = false;
            type_combo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_combo.FormattingEnabled = true;
            type_combo.Location = new Point(609, 96);
            type_combo.Name = "type_combo";
            type_combo.RightToLeft = RightToLeft.Yes;
            type_combo.Size = new Size(162, 28);
            type_combo.TabIndex = 281;
            // 
            // type_check
            // 
            type_check.AutoSize = true;
            type_check.BackColor = Color.Transparent;
            type_check.Font = new Font("Andalus", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_check.Location = new Point(562, 97);
            type_check.Margin = new Padding(4, 3, 4, 3);
            type_check.Name = "type_check";
            type_check.RightToLeft = RightToLeft.No;
            type_check.Size = new Size(54, 28);
            type_check.TabIndex = 283;
            type_check.Text = "الكل";
            type_check.TextAlign = ContentAlignment.MiddleCenter;
            type_check.UseVisualStyleBackColor = false;
            type_check.CheckedChanged += type_check_CheckedChanged;
            // 
            // hagez_combo
            // 
            hagez_combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            hagez_combo.AutoCompleteSource = AutoCompleteSource.ListItems;
            hagez_combo.Enabled = false;
            hagez_combo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hagez_combo.FormattingEnabled = true;
            hagez_combo.Items.AddRange(new object[] { "تم الحجز", "غير محجوز" });
            hagez_combo.Location = new Point(609, 142);
            hagez_combo.Name = "hagez_combo";
            hagez_combo.RightToLeft = RightToLeft.Yes;
            hagez_combo.Size = new Size(162, 28);
            hagez_combo.TabIndex = 285;
            // 
            // hagez_check
            // 
            hagez_check.AutoSize = true;
            hagez_check.BackColor = Color.Transparent;
            hagez_check.Font = new Font("Andalus", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hagez_check.Location = new Point(562, 142);
            hagez_check.Margin = new Padding(4, 3, 4, 3);
            hagez_check.Name = "hagez_check";
            hagez_check.RightToLeft = RightToLeft.No;
            hagez_check.Size = new Size(54, 28);
            hagez_check.TabIndex = 286;
            hagez_check.Text = "الكل";
            hagez_check.TextAlign = ContentAlignment.MiddleCenter;
            hagez_check.UseVisualStyleBackColor = false;
            hagez_check.CheckedChanged += hagez_check_CheckedChanged;
            // 
            // compare_combo
            // 
            compare_combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            compare_combo.AutoCompleteSource = AutoCompleteSource.ListItems;
            compare_combo.Enabled = false;
            compare_combo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            compare_combo.FormattingEnabled = true;
            compare_combo.Items.AddRange(new object[] { "أكبر من", "أصغر من", "يساوي", "أكبرمن أو يساوي", "أصغر من أو يساوي" });
            compare_combo.Location = new Point(250, 96);
            compare_combo.Name = "compare_combo";
            compare_combo.RightToLeft = RightToLeft.Yes;
            compare_combo.Size = new Size(162, 28);
            compare_combo.TabIndex = 287;
            compare_combo.SelectedIndexChanged += compare_combo_SelectedIndexChanged;
            // 
            // compare_check
            // 
            compare_check.AutoSize = true;
            compare_check.BackColor = Color.Transparent;
            compare_check.Font = new Font("Andalus", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            compare_check.Location = new Point(202, 96);
            compare_check.Margin = new Padding(4, 3, 4, 3);
            compare_check.Name = "compare_check";
            compare_check.RightToLeft = RightToLeft.No;
            compare_check.Size = new Size(54, 28);
            compare_check.TabIndex = 288;
            compare_check.Text = "الكل";
            compare_check.TextAlign = ContentAlignment.MiddleCenter;
            compare_check.UseVisualStyleBackColor = false;
            compare_check.CheckedChanged += compare_check_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(314, 143);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(98, 27);
            textBox2.TabIndex = 289;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Silver;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(30, 8);
            button4.Name = "button4";
            button4.Size = new Size(49, 72);
            button4.TabIndex = 293;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Silver;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(85, 8);
            button3.Name = "button3";
            button3.Size = new Size(49, 72);
            button3.TabIndex = 292;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Silver;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(196, 141);
            button2.Name = "button2";
            button2.Size = new Size(109, 32);
            button2.TabIndex = 291;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1196, 9);
            button1.Name = "button1";
            button1.Size = new Size(49, 72);
            button1.TabIndex = 290;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Andalus", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Andalus", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(30, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(1215, 456);
            dataGridView1.TabIndex = 294;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(232, 53);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 27);
            textBox3.TabIndex = 295;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Visible = false;
            // 
            // M_products_balance_report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1273, 699);
            Controls.Add(textBox3);
            Controls.Add(suggestionBox2);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(compare_combo);
            Controls.Add(compare_check);
            Controls.Add(hagez_combo);
            Controls.Add(hagez_check);
            Controls.Add(add_combo);
            Controls.Add(add_check);
            Controls.Add(type_combo);
            Controls.Add(type_check);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "M_products_balance_report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "M_products_balance_report";
            Load += M_products_balance_report_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox suggestionBox2;
        private TextBox textBox1;
        private ComboBox add_combo;
        private CheckBox add_check;
        private ComboBox type_combo;
        private CheckBox type_check;
        private ComboBox hagez_combo;
        private CheckBox hagez_check;
        private ComboBox compare_combo;
        private CheckBox compare_check;
        private TextBox textBox2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox3;
    }
}