namespace El_Hamla
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox suggestionBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.suggestionBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(260, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);

            // 
            // suggestionBox
            // 
            this.suggestionBox.FormattingEnabled = true;
            this.suggestionBox.Location = new System.Drawing.Point(12, 38);
            this.suggestionBox.Name = "suggestionBox";
            this.suggestionBox.Size = new System.Drawing.Size(260, 95);
            this.suggestionBox.TabIndex = 1;
            this.suggestionBox.Visible = false;
            this.suggestionBox.Click += new System.EventHandler(this.suggestionBox_Click);

            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.suggestionBox);
            this.Controls.Add(this.searchTextBox);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}