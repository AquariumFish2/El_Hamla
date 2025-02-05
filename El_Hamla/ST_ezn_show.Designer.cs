namespace El_Hamla
{
    partial class ST_ezn_show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ST_ezn_show));
            dvg10 = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvg10).BeginInit();
            SuspendLayout();
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
            dvg10.Location = new Point(65, 95);
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
            dvg10.Size = new Size(1087, 531);
            dvg10.TabIndex = 56;
            dvg10.CellContentClick += dvg10_CellContentClick;
            dvg10.CellFormatting += dvg10_CellFormatting;
            dvg10.RowHeaderMouseDoubleClick += dvg10_RowHeaderMouseDoubleClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Silver;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(343, 90);
            button3.Name = "button3";
            button3.Size = new Size(97, 45);
            button3.TabIndex = 55;
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
            button1.Location = new Point(46, 28);
            button1.Name = "button1";
            button1.Size = new Size(39, 61);
            button1.TabIndex = 54;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Silver;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1143, 12);
            button2.Name = "button2";
            button2.Size = new Size(46, 71);
            button2.TabIndex = 53;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(821, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 25);
            textBox1.TabIndex = 264;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Visible = false;
            // 
            // ST_ezn_show
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1210, 675);
            Controls.Add(textBox1);
            Controls.Add(dvg10);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ST_ezn_show";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ezn_show";
            Load += ezn_show_Load;
            ((System.ComponentModel.ISupportInitialize)dvg10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dvg10;
        private Button button3;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}