namespace El_Hamla
{
    partial class M_choose_3_BK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_choose_3_BK));
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(354, 6);
            button5.Name = "button5";
            button5.Size = new Size(463, 649);
            button5.TabIndex = 10;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(823, 6);
            button1.Name = "button1";
            button1.Size = new Size(336, 649);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 6);
            button2.Name = "button2";
            button2.Size = new Size(336, 649);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // M_choose_3_BK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1159, 667);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "M_choose_3_BK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "M_choose_3_BK";
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private Button button1;
        private Button button2;
    }
}