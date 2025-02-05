using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace El_Hamla
{
    public partial class SearchForm : Form
    {
        DataTable dataTable;

        public SearchForm()
        {
            InitializeComponent();

            // Simulate data in DataTable
            dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Rows.Add("Apple");
            dataTable.Rows.Add("Banana");
            dataTable.Rows.Add("Cherry");
            dataTable.Rows.Add("Date");
            dataTable.Rows.Add("Elderberry");
            dataTable.Rows.Add("Fig");
            dataTable.Rows.Add("Grape");
            dataTable.Rows.Add("Grape2");
            dataTable.Rows.Add("Grape3");
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Filter DataTable based on search text using Contains to match anywhere in the string
                var filteredRows = dataTable.AsEnumerable()
                                            .Where(row => row.Field<string>("Name")
                                            .Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                            .Select(row => row.Field<string>("Name"))
                                            .ToList();

                // Populate the suggestionBox
                if (filteredRows.Any())
                {
                    suggestionBox.Visible = true;
                    suggestionBox.DataSource = filteredRows;
                }
                else
                {
                    suggestionBox.Visible = false;
                }
            }
            else
            {
                suggestionBox.Visible = false;
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && suggestionBox.Items.Count > 0)
            {
                suggestionBox.Focus();
                suggestionBox.SelectedIndex = 0;
            }
        }

        private void suggestionBox_Click(object sender, EventArgs e)
        {
            if (suggestionBox.SelectedItem != null)
            {
                searchTextBox.Text = suggestionBox.SelectedItem.ToString();
                suggestionBox.Visible = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && suggestionBox.Visible && suggestionBox.Focused)
            {
                searchTextBox.Text = suggestionBox.SelectedItem.ToString();
                suggestionBox.Visible = false;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
