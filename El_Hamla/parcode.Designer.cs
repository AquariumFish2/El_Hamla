namespace El_Hamla
{
    partial class parcode
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
            barcode = new TextBox();
            button1 = new Button();
            name = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // barcode
            // 
            barcode.Enabled = false;
            barcode.Font = new Font("CCode39", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barcode.Location = new Point(220, 147);
            barcode.Name = "barcode";
            barcode.Size = new Size(316, 82);
            barcode.TabIndex = 0;
            barcode.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(272, 322);
            button1.Name = "button1";
            button1.Size = new Size(228, 77);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.Enabled = false;
            name.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(220, 238);
            name.Name = "name";
            name.Size = new Size(316, 32);
            name.TabIndex = 3;
            name.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(220, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 32);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // parcode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(name);
            Controls.Add(button1);
            Controls.Add(barcode);
            Name = "parcode";
            Text = "parcode";
            Load += parcode_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        public TextBox barcode;
        public TextBox name;
    }
}