namespace El_Hamla
{
    partial class ST_tool_pro
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(444, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(106, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(444, 71);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(218, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(270, 205);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(260, 40);
            comboBox2.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(270, 267);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 40);
            comboBox1.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(270, 337);
            button1.Name = "button1";
            button1.Size = new Size(260, 51);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = false;
            // 
            // tool_pro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "tool_pro";
            Text = "tool_pro";
            Load += tool_pro_Load;
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
    }
}