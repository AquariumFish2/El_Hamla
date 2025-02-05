using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Hamla
{
    public partial class _perchasing_report : Form
    {
        public _perchasing_report()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;

            }
        }
        private void _perchasing_report_Load(object sender, EventArgs e)
        {
            type_check.Checked = true;
            checkBox2.Checked = true;
            hagez_check.Checked = true;

            //------------------------------------------- buyer -------------------------------------

            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_b = new SqlCommand("Select id_buyer,buyer_name from buyer_table", cn);
            SqlDataAdapter da_b = new SqlDataAdapter();
            da_b.SelectCommand = cmd_b;
            DataTable dt_b = new DataTable();
            da_b.Fill(dt_b);


            comboBox1.DataSource = dt_b;
            comboBox1.DisplayMember = "buyer_name";
            comboBox1.ValueMember = "id_buyer";
            comboBox1.SelectedIndex = 0;

            //------------------------------------------- add_perchasing_table -------------------------------------
            SqlCommand cmd_ch = new SqlCommand("Select id_perchasing,perchasing_name from add_perchasing_table", cn);
            SqlDataAdapter da_ch = new SqlDataAdapter();
            da_ch.SelectCommand = cmd_ch;
            DataTable dt_ch = new DataTable();
            da_ch.Fill(dt_ch);
            comboBox2.DataSource = dt_ch;
            comboBox2.DisplayMember = "perchasing_name";
            comboBox2.ValueMember = "id_perchasing";


            comboBox1.Text = "";
            comboBox2.Text = "";
        }
        string connectionString = "Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh";

        private DataTable FilterPurchases(string purchaseType, string buyerName, DateTime? startDate, DateTime? endDate)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("FilterPurchasesByTypeAndBuyer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command, using DBNull.Value for nulls
                    command.Parameters.AddWithValue("@PurchaseType", (object)purchaseType ?? DBNull.Value);
                    command.Parameters.AddWithValue("@BuyerName", (object)buyerName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@StartDate", (object)startDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EndDate", (object)endDate ?? DBNull.Value);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return dataTable;
        }
        private DataTable FilterPurchases_all(DateTime? startDate, DateTime? endDate)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetPurchasingReport", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command, using DBNull.Value for nulls
                    command.Parameters.AddWithValue("@StartDate", (object)startDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EndDate", (object)endDate ?? DBNull.Value);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return dataTable;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void type_check_CheckedChanged(object sender, EventArgs e)
        {
            if (type_check.Checked == false)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox2.Text = null;
            }
        }

        private void hagez_check_CheckedChanged(object sender, EventArgs e)
        {
            if (hagez_check.Checked == false)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.Text = null;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)//مفصل
            {

                string purchaseType = comboBox2.Text;  // Assume you have a TextBox for the purchase type
                string buyerName = comboBox1.Text;          // Assume you have a TextBox for the buyer name
                DateTime? startDate = Convert.ToDateTime(dateTimePicker1.Text.ToString());     // Assume you have a DateTimePicker for start date
                DateTime? endDate = Convert.ToDateTime(dateTimePicker2.Text.ToString());        // Assume you have a DateTimePicker for end date

                DataTable results = FilterPurchases(purchaseType, buyerName, startDate, endDate);

                // Bind the results to a DataGridView
                dataGridView1.DataSource = results;
                dataGridView1.DataSource = results;
                dataGridView1.Columns[0].HeaderText = "التاريخ";
                dataGridView1.Columns[1].HeaderText = "اسم الصنف";
                dataGridView1.Columns[2].HeaderText = "السعر";
                dataGridView1.Columns[3].HeaderText = "الكمية";
                dataGridView1.Columns[4].HeaderText = "الإجمالي";
                dataGridView1.Columns[5].HeaderText = "نوع الشراء";
                dataGridView1.Columns[6].HeaderText = "رقم المركبة";
                dataGridView1.Columns[7].HeaderText = "أمر الشغل";
                dataGridView1.Columns[8].HeaderText = "رقم أمر الشغل";
                dataGridView1.Columns[9].HeaderText = "اسم المشتري";



            }
            else if (checkBox2.Checked)//كلي
            {
                DateTime? startDate = dateTimePicker1.Value; // Assume you have a DateTimePicker for start date
                DateTime? endDate = dateTimePicker2.Value;   // Assume you have a DateTimePicker for end date

                DataTable results = FilterPurchases_all(startDate, endDate);

                // Bind the results to a DataGridView
                dataGridView1.DataSource = results;


                // Change the column name
                if (results.Columns.Contains("buying2_perchasing_add")) // Check if the column exists
                {
                    results.Columns["buying2_perchasing_add"].ColumnName = "نوع المشتريات"; // Change column name

                }
                if (results.Columns.Contains("total_purchases")) // Check if the column exists
                {
                    results.Columns["total_purchases"].ColumnName = "المبلغ عن اليوم"; // Change column name

                }

                // Change the color of the last row
                if (results.Rows.Count > 0)
                {
                    int lastRowIndex = results.Rows.Count - 1; // Get the index of the last row
                    dataGridView1.Rows[lastRowIndex].DefaultCellStyle.BackColor = Color.LightCoral; // Change background color
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        var worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                        worksheet.View.RightToLeft = true;
                        // --- Add a Big Title Row ---
                        worksheet.Cells["A1"].Value = "  تقرير المشتريات  " ; // Main Title
                        worksheet.Cells["A1"].Style.Font.Size = 18; // Bigger font for title
                        worksheet.Cells["A1"].Style.Font.Bold = true;
                        worksheet.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Center the text
                        worksheet.Cells["A1"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                        worksheet.Cells["A1"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells["A1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.YellowGreen); // Title background color

                        // Merge title row across all visible columns
                        int visibleColumnsCount = dataGridView1.Columns.Cast<DataGridViewColumn>().Count(c => c.Visible);
                        worksheet.Cells[1, 1, 1, visibleColumnsCount].Merge = true;

                        // --- Add a Subtitle Row ---
                        worksheet.Cells["A2"].Value = "  من  " + dateTimePicker1.Text + "  إلى  " + dateTimePicker2.Text; // Subtitle
                        worksheet.Cells["A2"].Style.Font.Size = 12; // Smaller font for subtitle
                        worksheet.Cells["A2"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Center the subtitle
                        worksheet.Cells["A2"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                        worksheet.Cells["A2"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells["A2"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue); // Subtitle background color
                        worksheet.Cells["A2"].Style.Font.Color.SetColor(System.Drawing.Color.Black); // Subtitle font color

                        // Merge subtitle row across all visible columns
                        worksheet.Cells[2, 1, 2, visibleColumnsCount].Merge = true;

                        // --- Header Styling ---
                        var headerStyle = worksheet.Cells[3, 1, 3, visibleColumnsCount].Style; // Shift headers to row 3
                        headerStyle.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        headerStyle.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray); // Header background color
                        headerStyle.Font.Bold = true; // Bold headers
                        headerStyle.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin; // Border for headers
                        headerStyle.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        headerStyle.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        headerStyle.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        headerStyle.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Center header text

                        // --- Adding headers for visible columns only ---
                        int headerColumnIndex = 1; // Start from 1 for Excel (1-based index)
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            if (dataGridView1.Columns[i].Visible)
                            {
                                worksheet.Cells[3, headerColumnIndex].Value = dataGridView1.Columns[i].HeaderText; // Shift headers to row 3
                                headerColumnIndex++;
                            }
                        }

                        // --- Adding rows for visible columns only ---
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            headerColumnIndex = 1; // Reset for each row
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                if (dataGridView1.Columns[j].Visible)
                                {
                                    worksheet.Cells[i + 4, headerColumnIndex].Value = dataGridView1.Rows[i].Cells[j].Value?.ToString(); // Shift data rows to start at row 4
                                    headerColumnIndex++;
                                }
                            }
                        }

                        // Auto fit columns
                        worksheet.Cells.AutoFitColumns();

                        // Save to a file
                        using (SaveFileDialog sfd = new SaveFileDialog())
                        {
                            sfd.Filter = "Excel Files|*.xlsx";
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                FileInfo fi = new FileInfo(sfd.FileName);
                                excelPackage.SaveAs(fi);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while exporting to Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
