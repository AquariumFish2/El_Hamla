using DevExpress.CodeParser;
using DGVPrinterHelper;
using FastReport.DevComponents.DotNetBar.Controls;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Hamla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter dgv = new DGVPrinter();
            dgv.Title = "قسم المركبات ";

            dgv.SubTitle = "بيان بالسيارات قيد العمل";
            dgv.PorportionalColumns = true;
            dgv.Footer = string.Format(DateTime.Now.ToString("dd-MM-yyyy"));





            dgv.PrintDataGridView(dvg10);


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            CLSset.cn.Close();

            CLSproduct pro = new CLSproduct();
            pro.loadproducts();
            dvg10.DataSource = pro.dtproducts;
            dvg10.Columns[0].HeaderText = "رقم الصنف";
            dvg10.Columns[1].HeaderText = "اسم الصنف";
            dvg10.Columns[2].HeaderText = "الباركود";
            dvg10.Columns[3].HeaderText = "الفئة";
            dvg10.Columns[4].HeaderText = "الوحدة";
            dvg10.Columns[5].HeaderText = "جهة الشراء";
            dvg10.Columns[6].HeaderText = "الموديل";
            dvg10.Columns[7].HeaderText = "السعر";
            dvg10.Columns[8].HeaderText = "رصيد المخزن";
            dvg10.Columns[9].HeaderText = "نوع السيارة";
            dvg10.Columns[10].HeaderText = "رقم السيارة";
            dvg10.Columns[11].HeaderText = "رقم السيارة";
            dvg10.Columns[0].Visible = false;
            dvg10.Columns[2].Visible = false;
            dvg10.Columns[3].Visible = false;
            dvg10.Columns[4].Visible = false;
            dvg10.Columns[5].Visible = false;
            dvg10.Columns[6].Visible = false;
            dvg10.Columns[8].Visible = false;
            dvg10.Columns[9].Visible = false;
            dvg10.Columns[10].Visible = false;
            dvg10.Columns[11].Visible = false;


            decimal quan = 0;
            for (int i = 1; i <= dvg10.Rows.Count; ++i)
            {
                if (dvg10.RowCount > i)
                {
                    quan += Convert.ToDecimal(dvg10.Rows[i - 1].Cells[7].Value.ToString());


                }

            }

            textBox1.Text = quan.ToString();
            pro.dtproducts.Rows.Add(null, "الإجمالي", null, null, null, null, null, quan.ToString(), null, null, null);
            foreach (DataGridViewRow row in dvg10.Rows)
            {
                if (row.Index == dvg10.Rows.Count - 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;


                }

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dvg10.Rows.Count > 0)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        var worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                        // Adding headers for visible columns only
                        int headerColumnIndex = 1; // Start from 1 for Excel (1-based index)
                        for (int i = 0; i < dvg10.Columns.Count; i++)
                        {
                            if (dvg10.Columns[i].Visible)
                            {
                                worksheet.Cells[1, headerColumnIndex].Value = dvg10.Columns[i].HeaderText;
                                headerColumnIndex++;
                            }
                        }

                        // Adding rows for visible columns only
                        for (int i = 0; i < dvg10.Rows.Count; i++)
                        {
                            headerColumnIndex = 1; // Reset for each row
                            for (int j = 0; j < dvg10.Columns.Count; j++)
                            {
                                if (dvg10.Columns[j].Visible)
                                {
                                    worksheet.Cells[i + 2, headerColumnIndex].Value = dvg10.Rows[i].Cells[j].Value?.ToString();
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
