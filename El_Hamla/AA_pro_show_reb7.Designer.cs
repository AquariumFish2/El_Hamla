namespace El_Hamla
{
    partial class AA_pro_show_reb7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AA_pro_show_reb7));
            dvg10 = new DataGridView();
            button3 = new Button();
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvg10.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvg10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvg10.DefaultCellStyle = dataGridViewCellStyle2;
            dvg10.Location = new Point(50, 119);
            dvg10.Margin = new Padding(4, 3, 4, 3);
            dvg10.Name = "dvg10";
            dvg10.RightToLeft = RightToLeft.Yes;
            dvg10.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvg10.Size = new Size(1030, 475);
            dvg10.TabIndex = 319;
            dvg10.RowHeaderMouseDoubleClick += dvg10_RowHeaderMouseDoubleClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.CheckedBackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1060, 12);
            button3.Name = "button3";
            button3.Size = new Size(42, 60);
            button3.TabIndex = 353;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AA_pro_show_reb7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1126, 635);
            Controls.Add(button3);
            Controls.Add(dvg10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AA_pro_show_reb7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AA_pro_show_reb7";
            Load += AA_pro_show_Load;
            ((System.ComponentModel.ISupportInitialize)dvg10).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvg10;
        private Button button3;
    }
}