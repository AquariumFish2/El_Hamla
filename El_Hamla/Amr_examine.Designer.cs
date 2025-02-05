namespace El_Hamla
{
    partial class Amr_examine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amr_examine));
            work_code = new TextBox();
            button1 = new Button();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // work_code
            // 
            work_code.Enabled = false;
            work_code.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            work_code.Location = new Point(25, 12);
            work_code.Name = "work_code";
            work_code.Size = new Size(131, 43);
            work_code.TabIndex = 259;
            work_code.TextAlign = HorizontalAlignment.Center;
            work_code.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(238, 242);
            button1.Name = "button1";
            button1.Size = new Size(110, 34);
            button1.TabIndex = 258;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button3.Location = new Point(554, 2);
            button3.Name = "button3";
            button3.Size = new Size(42, 62);
            button3.TabIndex = 257;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(210, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 32);
            dateTimePicker1.TabIndex = 256;
            // 
            // Amr_examine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(608, 309);
            Controls.Add(work_code);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Amr_examine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Amr_examine";
            Load += Amr_examine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox work_code;
        private Button button1;
        private Button button3;
        private DateTimePicker dateTimePicker1;
    }
}