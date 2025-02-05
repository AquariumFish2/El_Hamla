using FastReport.DevComponents.DotNetBar.Controls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class M_products_balance_report : Form
    {
        DataTable dt_pro_re;
        public M_products_balance_report()
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M_products_balance_report_Load(object sender, EventArgs e)
        {
            compare_check.Checked = true;
            type_check.Checked = true;
            add_check.Checked = true;
            hagez_check.Checked = true;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            hagez_combo.Text = null;
            add_combo.Text = null;
            type_combo.Text = null;

            //****************************************************************************************************************************
            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_car = new SqlCommand("Select product_name from product_table ", cn);
            SqlDataAdapter da_car = new SqlDataAdapter();
            da_car.SelectCommand = cmd_car;
            dt_pro_re = new DataTable();
            da_car.Fill(dt_pro_re);
            //*****************************************************************************************************************************
            SqlCommand cmd_t = new SqlCommand("Select ID_type,Type from Type_table ", cn);
            SqlDataAdapter da_t = new SqlDataAdapter();
            da_t.SelectCommand = cmd_t;
            DataTable dt_type = new DataTable();
            da_t.Fill(dt_type);


            type_combo.DataSource = dt_type;
            type_combo.DisplayMember = "Type";
            type_combo.ValueMember = "ID_type";
            //*****************************************************************************************************************************
            SqlCommand cmd_mo = new SqlCommand("Select id_mo,mo_name from _MO_table ", cn);
            SqlDataAdapter da_mo = new SqlDataAdapter();
            da_mo.SelectCommand = cmd_mo;
            DataTable dt_mo = new DataTable();
            da_mo.Fill(dt_mo);


            add_combo.DataSource = dt_mo;
            add_combo.DisplayMember = "mo_name";
            add_combo.ValueMember = "id_mo";

            //*****************************************************************************************************************************
            CLSproduct pro = new CLSproduct();
            pro.loadproducts();
            dataGridView1.DataSource = pro.dtproducts;
            dataGridView1.Columns[0].HeaderText = "رقم الصنف";
            dataGridView1.Columns[1].HeaderText = "اسم الصنف";
            dataGridView1.Columns[2].HeaderText = "الباركود";
            dataGridView1.Columns[3].HeaderText = "الفئة";
            dataGridView1.Columns[4].HeaderText = "الوحدة";
            dataGridView1.Columns[5].HeaderText = "جهة الشراء";
            dataGridView1.Columns[6].HeaderText = "الموديل";
            dataGridView1.Columns[7].HeaderText = "السعر";
            dataGridView1.Columns[8].HeaderText = "رصيد المخزن";
            dataGridView1.Columns[9].HeaderText = "نوع السيارة";
            dataGridView1.Columns[10].HeaderText = "رقم السيارة";
            dataGridView1.Columns[12].HeaderText = "حالة الحجز";
            dataGridView1.Columns[11].Visible = false;
            //dataGridView1.Columns[0].Visible = false;
            compare_check.Checked = true;
            type_check.Checked = true;
            add_check.Checked = true;
            hagez_check.Checked = true;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            hagez_combo.Text = null;
            add_combo.Text = null;
            type_combo.Text = null;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            CLSproduct pro = new CLSproduct();

            pro.sea_pro_fillter(
                textBox1.Text,
                add_combo.Text,
                hagez_combo.Text,
                type_combo.Text,
                textBox2.Text, // Pass the text directly to handle parsing inside the method
                textBox3.Text
            );

            dataGridView1.DataSource = pro.dt_pro_fillter;
            dataGridView1.Columns[0].HeaderText = "رقم الصنف";
            dataGridView1.Columns[1].HeaderText = "اسم الصنف";
            dataGridView1.Columns[2].HeaderText = "الباركود";
            dataGridView1.Columns[3].HeaderText = "الفئة";
            dataGridView1.Columns[4].HeaderText = "الوحدة";
            dataGridView1.Columns[5].HeaderText = "جهة الشراء";
            dataGridView1.Columns[6].HeaderText = "الموديل";
            dataGridView1.Columns[7].HeaderText = "السعر";
            dataGridView1.Columns[8].HeaderText = "رصيد المخزن";
            dataGridView1.Columns[9].HeaderText = "نوع السيارة";
            dataGridView1.Columns[10].HeaderText = "رقم السيارة";

            dataGridView1.Columns[11].HeaderText = "حالة الحجز";

            dataGridView1.Columns[0].Visible = false;


        }

        private void add_check_CheckedChanged(object sender, EventArgs e)
        {
            if (add_check.Checked == false)
            {
                add_combo.Enabled = true;
            }
            else
            {
                add_combo.Enabled = false;

                add_combo.Text = null;

            }
        }

        private void type_check_CheckedChanged(object sender, EventArgs e)
        {
            if (type_check.Checked == false)
            {
                type_combo.Enabled = true;
            }
            else
            {
                type_combo.Enabled = false;
                type_combo.Text = null;
            }
        }

        private void hagez_check_CheckedChanged(object sender, EventArgs e)
        {
            if (hagez_check.Checked == false)
            {
                hagez_combo.Enabled = true;
            }
            else
            {
                hagez_combo.Enabled = false;
                hagez_combo.Text = null;


            }
        }

        private void compare_check_CheckedChanged(object sender, EventArgs e)
        {
            if (compare_check.Checked == false)
            {
                compare_combo.Enabled = true;
                textBox2.Enabled = true;

            }
            else
            {
                compare_combo.Enabled = false;
                textBox2.Enabled = false;
                compare_combo.Text = null;
                textBox3.Text = null;
                textBox2.Text = null;


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
                        worksheet.Cells["A1"].Value = "  أرصدة الأصناف  "; // Main Title
                        worksheet.Cells["A1"].Style.Font.Size = 18; // Bigger font for title
                        worksheet.Cells["A1"].Style.Font.Bold = true;
                        worksheet.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Center the text
                        worksheet.Cells["A1"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                        worksheet.Cells["A1"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells["A1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.YellowGreen); // Title background color

                        // Merge title row across all visible columns
                        int visibleColumnsCount = dataGridView1.Columns.Cast<DataGridViewColumn>().Count(c => c.Visible);
                        worksheet.Cells[1, 1, 1, visibleColumnsCount].Merge = true;

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

        private void compare_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (compare_combo.Text == "أكبر من")
            {
                textBox3.Text = ">";

            }
            else if (compare_combo.Text == "أصغر من")
            {
                textBox3.Text = "<";

            }
            else if (compare_combo.Text == "يساوي")
            {
                textBox3.Text = "=";

            }
            else if (compare_combo.Text == "أكبرمن أو يساوي")
            {
                textBox3.Text = ">=";

            }
            else if (compare_combo.Text == "أصغر من أو يساوي")
            {

                textBox3.Text = "<=";
            }







        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Filter DataTable based on search text using Contains to match anywhere in the string
                var filteredRows = dt_pro_re.AsEnumerable()
                                            .Where(row => row.Field<string>("product_name")
                                            .Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                            .Select(row => row.Field<string>("product_name"))
                                            .ToList();

                // Populate the suggestionBox
                if (filteredRows.Any())
                {
                    suggestionBox2.Visible = true;
                    suggestionBox2.DataSource = filteredRows;
                }
                else
                {
                    suggestionBox2.Visible = false;
                }

            }
            else
            {
                suggestionBox2.Visible = false;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Enter && suggestionBox2.Visible && suggestionBox2.Focused)
            {
                textBox1.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
                return true;
            }



            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && suggestionBox2.Items.Count > 0)
            {
                suggestionBox2.Focus();
                suggestionBox2.SelectedIndex = 0;
            }
        }

        private void suggestionBox2_Click(object sender, EventArgs e)
        {
            if (suggestionBox2.SelectedItem != null)
            {
                textBox1.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8 & e.Value != null)
            {
                if (Convert.ToDecimal(e.Value.ToString()) <= 0)
                {
                    e.CellStyle.BackColor = Color.Red;

                }
                else if (Convert.ToDecimal(e.Value.ToString()) > 0 && Convert.ToDecimal(e.Value.ToString()) <= 3)
                {
                    e.CellStyle.BackColor = Color.Yellow;

                }

            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            parcode p = new parcode();
            p.barcode.Text = "*" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "*";
            p.name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " ----- " + dataGridView1.CurrentRow.Cells[10].Value.ToString();
            p.ShowDialog();
        }

        
    }
}
