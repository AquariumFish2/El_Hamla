namespace El_Hamla
{
    partial class FX_cars_sea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FX_cars_sea));
            button4 = new Button();
            textBox1 = new TextBox();
            dvg10 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvg10).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.CheckedBackColor = Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(1172, 12);
            button4.Name = "button4";
            button4.Size = new Size(59, 66);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(305, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(513, 39);
            textBox1.TabIndex = 41;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox4_TextChanged;
            // 
            // dvg10
            // 
            dvg10.AllowUserToAddRows = false;
            dvg10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg10.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Andalus", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            dvg10.Location = new Point(78, 146);
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
            dvg10.Size = new Size(1112, 471);
            dvg10.TabIndex = 233;
            dvg10.RowHeaderMouseDoubleClick += dvg10_RowHeaderMouseDoubleClick;
            // 
            // FX_cars_sea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1249, 667);
            Controls.Add(dvg10);
            Controls.Add(textBox1);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FX_cars_sea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FX_cars_sea";
            Load += FX_cars_sea_Load;
            ((System.ComponentModel.ISupportInitialize)dvg10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private TextBox textBox1;
        private DataGridView dvg10;
    }
}