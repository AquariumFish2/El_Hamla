using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace El_Hamla
{
    public partial class M_maghood_report : Form
    {
        public M_maghood_report()
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

        private void M_maghood_report_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_ch = new SqlCommand("Select id_perchasing,perchasing_name from add_perchasing_table", cn);
            SqlDataAdapter da_ch = new SqlDataAdapter();
            da_ch.SelectCommand = cmd_ch;
            DataTable dt_ch = new DataTable();
            da_ch.Fill(dt_ch);
            comboBox2.DataSource = dt_ch;
            comboBox2.DisplayMember = "perchasing_name";
            comboBox2.ValueMember = "id_perchasing";
            comboBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                CLSezn_report cL = new CLSezn_report();
                cL.load_magg_re_add(comboBox2.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
                dataGridView1.DataSource = cL.dt_magg_re_add;

                dataGridView1.Columns[0].HeaderText = "رقم المركبة";
                dataGridView1.Columns[1].HeaderText = "نوع المركبة";
                dataGridView1.Columns[2].HeaderText = "نوع الإصلاح";
                dataGridView1.Columns[3].HeaderText = "العدد";
                dataGridView1.Columns[4].HeaderText = "من تاريخ";
                dataGridView1.Columns[5].HeaderText = "إلى تاريخ";
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }
                textBox5.Text = sum.ToString();
            }
            else if (checkBox2.Checked)
            {
                CLSezn_report cL = new CLSezn_report();
                cL.load_magg2_re_add(comboBox2.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
                dataGridView1.DataSource = cL.dt_magg2_re_add;


                dataGridView1.Columns[0].HeaderText = "نوع الإصلاح";
                dataGridView1.Columns[1].HeaderText = "عدد الإصلاحات الكلي";
                dataGridView1.Columns[2].HeaderText = "عدد المركبات";

                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                textBox5.Text = sum.ToString();


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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        var worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                        // Set worksheet to Right-to-Left
                        worksheet.View.RightToLeft = true;

                        // --- Add a Big Title Row ---
                        worksheet.Cells["A1"].Value = "بيان مجهود من الفترة "; // Main Title
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
                        worksheet.Cells["A2"].Value = "  من  "+dateTimePicker1.Text + "  إلى  " + dateTimePicker2.Text; // Subtitle
                        worksheet.Cells["A2"].Style.Font.Size = 12; // Smaller font for subtitle
                        //worksheet.Cells["A2"].Style.Font.Italic = true; // Italic text
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

                        // Adding headers for visible columns only
                        int headerColumnIndex = 1; // Start from 1 for Excel (1-based index)
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            if (dataGridView1.Columns[i].Visible)
                            {
                                worksheet.Cells[3, headerColumnIndex].Value = dataGridView1.Columns[i].HeaderText; // Shift headers to row 3
                                headerColumnIndex++;
                            }
                        }

                        // --- Adding rows for visible columns only with alternating row colors ---
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            headerColumnIndex = 1; // Reset for each row
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                if (dataGridView1.Columns[j].Visible)
                                {
                                    var cell = worksheet.Cells[i + 4, headerColumnIndex]; // Shift data rows to start at row 4
                                    cell.Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();

                                    // Apply alternating row colors
                                    if (i % 2 == 0)
                                    {
                                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightYellow); // Row color for even rows
                                    }
                                    else
                                    {
                                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.WhiteSmoke); // Row color for odd rows
                                    }

                                    // Add borders to the data cells
                                    cell.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                                    cell.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                                    cell.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                                    cell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

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
