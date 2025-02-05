using FastReport.DevComponents.DotNetBar.Controls;
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
using DGVPrinterHelper;
using OfficeOpenXml;
using DevExpress.PivotGrid.OLAP.SchemaEntities;
using DevExpress.XtraRichEdit.Model;
using FastReport.Data;
using DevExpress.CodeParser;


namespace El_Hamla
{
    public partial class M_ezn_Report : Form
    {


        DataTable dt_amr_EZ_re;
        DataTable dt_car_EZ_re;
        DataTable dt_add_EZ_re;

        public M_ezn_Report()
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

        private void M_ezn_Report_Load(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            textBox4.Text = "0";
            //*****************************************************************************************************************************
            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_car = new SqlCommand("Select distinct car_num from amr_work ", cn);
            SqlDataAdapter da_car = new SqlDataAdapter();
            da_car.SelectCommand = cmd_car;
            dt_car_EZ_re = new DataTable();
            da_car.Fill(dt_car_EZ_re);
            //*****************************************************************************************************************************
            SqlCommand cmd_amr = new SqlCommand("Select distinct work_num from amr_work ", cn);
            SqlDataAdapter da_amr = new SqlDataAdapter();
            da_amr.SelectCommand = cmd_amr;
            dt_amr_EZ_re = new DataTable();
            da_amr.Fill(dt_amr_EZ_re);
            //*****************************************************************************************************************************
            SqlCommand cmd_add = new SqlCommand("Select distinct car_add from amr_work ", cn);
            SqlDataAdapter da_add = new SqlDataAdapter();
            da_add.SelectCommand = cmd_add;
            dt_add_EZ_re = new DataTable();
            da_add.Fill(dt_add_EZ_re);
            //*****************************************************************************************************************************
            SqlCommand cmd_t = new SqlCommand("Select ID_type,Type from Type_table ", cn);
            SqlDataAdapter da_t = new SqlDataAdapter();
            da_t.SelectCommand = cmd_t;
            DataTable dt_type = new DataTable();
            da_t.Fill(dt_type);


            comboBox1.DataSource = dt_type;
            comboBox1.DisplayMember = "Type";
            comboBox1.ValueMember = "ID_type";
            //*****************************************************************************************************************************
            SqlCommand cmd_mo = new SqlCommand("Select id_mo,mo_name from _MO_table ", cn);
            SqlDataAdapter da_mo = new SqlDataAdapter();
            da_mo.SelectCommand = cmd_mo;
            DataTable dt_mo = new DataTable();
            da_mo.Fill(dt_mo);


            comboBox2.DataSource = dt_mo;
            comboBox2.DisplayMember = "mo_name";
            comboBox2.ValueMember = "id_mo";
            comboBox1.Text = "";
            comboBox2.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                string searchText = textBox1.Text;

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    // Filter DataTable based on search text using Contains to match anywhere in the string
                    var filteredRows = dt_car_EZ_re.AsEnumerable()
                                                .Where(row => row.Field<string>("car_num")
                                                .Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                                .Select(row => row.Field<string>("car_num"))
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
            else if (checkBox1.Checked == true)
            {
                string searchText = textBox1.Text;

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    // Filter DataTable based on search text using Contains to match anywhere in the string
                    var filteredRows = dt_amr_EZ_re.AsEnumerable()
                                                .Where(row => row.Field<string>("work_num")
                                                .Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                                .Select(row => row.Field<string>("work_num"))
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
            else if (checkBox3.Checked == true)
            {

                string searchText = textBox1.Text;

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    // Filter DataTable based on search text using Contains to match anywhere in the string
                    var filteredRows = dt_add_EZ_re.AsEnumerable()
                                                .Where(row => row.Field<string>("car_add")
                                                .Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                                .Select(row => row.Field<string>("car_add"))
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

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && suggestionBox2.Items.Count > 0)
            {
                suggestionBox2.Focus();
                suggestionBox2.SelectedIndex = 0;
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

        private void suggestionBox2_Click(object sender, EventArgs e)
        {
            if (suggestionBox2.SelectedItem != null)
            {
                textBox1.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            //DGVPrinter dgv = new DGVPrinter();
            //dgv.Title = "قسم المركبات ";

            //dgv.SubTitle = "رقم السيارة: " + textBox1.Text + " نوع السيارة: " + "نيسان صني" + " الجهة: " + "مديرية أمن القاهرة";

            //dgv.PorportionalColumns = true;
            //dgv.Footer = string.Format(DateTime.Now.ToString("dd-MM-yyyy"));

            //dgv.PrintDataGridView(dvg10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
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
                            worksheet.Cells["A1"].Value = "  بيان القطع المصروفة للمركبة  " + textBox1.Text; // Main Title
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
            else if (checkBox1.Checked == true)
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
                            worksheet.Cells["A1"].Value = "  بيان القطع المصروفة لأمر الشغل  " + textBox1.Text; // Main Title
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
            else if (checkBox3.Checked == true)
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
                            worksheet.Cells["A1"].Value = "  بيان القطع المصروفة لجهة  " + textBox1.Text; // Main Title
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.Text = string.Empty;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == false)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox2.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLSezn_report mm = new CLSezn_report();
            if (checkBox2.Checked == true)
            {

                dataGridView1.DataSource = mm.FilterEznData(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text), textBox1.Text, "", comboBox1.Text, comboBox2.Text, ""); ;
                dataGridView1.Columns[0].HeaderText = "تاريخ العملية";
                dataGridView1.Columns[1].HeaderText = "رقم المركبة";
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].HeaderText = "اسم الصنف";
                dataGridView1.Columns[3].HeaderText = "الكمية";
                dataGridView1.Columns[4].HeaderText = "السعر";
                dataGridView1.Columns[5].HeaderText = "الإجمالي";
            }
            else if (checkBox1.Checked == true)
            {
                dataGridView1.DataSource = mm.FilterEznData(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text), "", textBox1.Text, comboBox1.Text, comboBox2.Text, "");
                dataGridView1.Columns[0].HeaderText = "تاريخ العملية";
                dataGridView1.Columns[1].HeaderText = "رقم المركبة";
                dataGridView1.Columns[2].HeaderText = "اسم الصنف";
                dataGridView1.Columns[3].HeaderText = "الكمية";
                dataGridView1.Columns[4].HeaderText = "السعر";
                dataGridView1.Columns[5].HeaderText = "الإجمالي";
                dataGridView1.Columns[1].Visible = true;
            }
            else if (checkBox3.Checked == true)
            {
                dataGridView1.DataSource = mm.FilterEznData(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text), "", "", comboBox1.Text, comboBox2.Text, textBox1.Text);
                dataGridView1.Columns[0].HeaderText = "تاريخ العملية";
                dataGridView1.Columns[1].HeaderText = "رقم المركبة";
                dataGridView1.Columns[2].HeaderText = "اسم الصنف";
                dataGridView1.Columns[3].HeaderText = "الكمية";
                dataGridView1.Columns[4].HeaderText = "السعر";
                dataGridView1.Columns[5].HeaderText = "الإجمالي";
                dataGridView1.Columns[1].Visible = true;
            }
            else { MessageBox.Show("يجب اختيار المركبة أو أمر الشغل أو الجهة"); }

            decimal totalSum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // تحقق من أن الخلية غير فارغة وأنها تحتوي على قيمة يمكن تحويلها إلى decimal
                if (row.Cells[5].Value != null && decimal.TryParse(row.Cells[5].Value.ToString(), out decimal cellValue))
                {
                    if (textBox4.Text != "")
                    {
                        row.Cells[5].Value = (Convert.ToDecimal(textBox4.Text) / 100 + 1) * Convert.ToDecimal(row.Cells[5].Value);
                        row.Cells[4].Value = (Convert.ToDecimal(textBox4.Text) / 100 + 1) * Convert.ToDecimal(row.Cells[4].Value);

                        totalSum += Convert.ToDecimal(row.Cells[5].Value);
                    }
                    else
                    {
                        totalSum += cellValue;
                    }
                }
            }
            textBox5.Text = totalSum.ToString();
        }

       
    }





}
