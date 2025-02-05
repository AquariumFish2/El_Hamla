namespace El_Hamla
{
    partial class FX_cars_show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FX_cars_show));
            button3 = new Button();
            button1 = new Button();
            car_num_in_car_show = new TextBox();
            car_name_in_car_show = new TextBox();
            car_add_in_car_show = new TextBox();
            SuspendLayout();
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
            button3.Location = new Point(844, 21);
            button3.Name = "button3";
            button3.Size = new Size(67, 91);
            button3.TabIndex = 251;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            button1.Location = new Point(29, 447);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 252;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // car_num_in_car_show
            // 
            car_num_in_car_show.Enabled = false;
            car_num_in_car_show.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            car_num_in_car_show.Location = new Point(234, 181);
            car_num_in_car_show.Name = "car_num_in_car_show";
            car_num_in_car_show.Size = new Size(270, 43);
            car_num_in_car_show.TabIndex = 254;
            car_num_in_car_show.TextAlign = HorizontalAlignment.Center;
            // 
            // car_name_in_car_show
            // 
            car_name_in_car_show.Enabled = false;
            car_name_in_car_show.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            car_name_in_car_show.Location = new Point(236, 256);
            car_name_in_car_show.Name = "car_name_in_car_show";
            car_name_in_car_show.Size = new Size(268, 43);
            car_name_in_car_show.TabIndex = 255;
            car_name_in_car_show.TextAlign = HorizontalAlignment.Center;
            // 
            // car_add_in_car_show
            // 
            car_add_in_car_show.Enabled = false;
            car_add_in_car_show.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            car_add_in_car_show.Location = new Point(234, 331);
            car_add_in_car_show.Name = "car_add_in_car_show";
            car_add_in_car_show.Size = new Size(270, 43);
            car_add_in_car_show.TabIndex = 256;
            car_add_in_car_show.TextAlign = HorizontalAlignment.Center;
            // 
            // FX_cars_show
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(923, 521);
            Controls.Add(car_add_in_car_show);
            Controls.Add(car_name_in_car_show);
            Controls.Add(car_num_in_car_show);
            Controls.Add(button1);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FX_cars_show";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FX_cars_show";
            Load += FX_cars_show_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button1;
        public TextBox car_num_in_car_show;
        public TextBox car_name_in_car_show;
        public TextBox car_add_in_car_show;
    }
}