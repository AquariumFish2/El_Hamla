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

namespace El_Hamla
{
    public partial class M_product_follow_report : Form
    {
        DataTable dt_pro_EZ;
        public M_product_follow_report()
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



        private void M_product_follow_report_Load(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_pro = new SqlCommand("Select distinct product_name from product_table", cn);
            SqlDataAdapter da_pro = new SqlDataAdapter();
            da_pro.SelectCommand = cmd_pro;
            dt_pro_EZ = new DataTable();
            da_pro.Fill(dt_pro_EZ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string connectionString = @"Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh";

        // دالة لاستدعاء الإجراء المخزن وتنفيذ الاستعلام
        public DataTable TrackProductByDateRange(string productName, DateTime startDate, DateTime endDate)
        {
            DataTable resultTable = new DataTable();

            // إنشاء اتصال مع قاعدة البيانات
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // فتح الاتصال
                    connection.Open();

                    // إعداد الأمر لاستدعاء الإجراء المخزن
                    using (SqlCommand command = new SqlCommand("TrackProductByDateRange", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // إضافة المعلمات المطلوبة للإجراء المخزن
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        // استخدام DataAdapter لتنفيذ الاستعلام والحصول على النتائج
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // ملء النتائج في DataTable
                            adapter.Fill(resultTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return resultTable; // إرجاع النتائج كجدول بيانات
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // قيم البحث من واجهة المستخدم
            string productName = textBox13.Text;
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;


            // استدعاء الدالة والحصول على النتائج
            DataTable resultTable = TrackProductByDateRange(productName, startDate, endDate);

            // ربط النتائج بـ DataGridView
            dataGridView1.DataSource = resultTable;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox13.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Filter DataTable based on search text using Contains to match anywhere in the string
                var filteredRows = dt_pro_EZ.AsEnumerable()
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

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
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

                textBox13.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
                return true;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void suggestionBox2_Click(object sender, EventArgs e)
        {
            if (suggestionBox2.SelectedItem != null)
            {
                textBox13.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "نوع الحركة")
            {
                string movementType = e.Value.ToString();

                // تلوين الصف بناءً على نوع الحركة
                if (movementType == "صادر")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                }
                else if (movementType == "وارد")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
    }
}
