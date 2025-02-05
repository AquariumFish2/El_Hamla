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
    public partial class AA_trans_report : Form
    {
        public AA_trans_report()
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
        public class TransactionFilter
        {
            private string _connectionString = @"Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh";

            public DataTable FilterTransactions(DateTime? startDate, DateTime? endDate, string kind, string name)
            {
                DataTable resultTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("FilterTransactions", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // إضافة المعاملات مع التحقق من القيم الفارغة
                        command.Parameters.AddWithValue("@StartDate", startDate.HasValue ? (object)startDate.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@EndDate", endDate.HasValue ? (object)endDate.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@Kind", !string.IsNullOrEmpty(kind) ? (object)kind : DBNull.Value);
                        command.Parameters.AddWithValue("@Name", !string.IsNullOrEmpty(name) ? (object)name : DBNull.Value);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            resultTable.Load(reader); // تحميل البيانات إلى DataTable
                        }
                    }
                }

                return resultTable;
            }
        }
        private void AA_trans_report_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");

            // الاستعلام عن أنواع الحسابات من جدول _MO_table
            SqlCommand cmd_u = new SqlCommand(@"Select distinct acc_type from _MO_table", cn);
            SqlDataAdapter da_unit = new SqlDataAdapter();
            da_unit.SelectCommand = cmd_u;
            DataTable dt_unit = new DataTable();
            da_unit.Fill(dt_unit);
            DataRow dr_unit = dt_unit.NewRow();
            dr_unit[0] = "شيك";
            dt_unit.Rows.InsertAt(dr_unit, 0);
            comboBox5.DataSource = dt_unit;
            comboBox5.DisplayMember = "acc_type";
            comboBox5.ValueMember = "acc_type";
            comboBox5.Text = "";
          
            

        }
        private void UpdateComboBox2Options(string selectedValue)
        {
            comboBox1.Items.Clear();

            // إذا كانت القيمة المختارة هي "اختيار مخصص"
            if (selectedValue == "شيك")
            {
                // استعلام جديد يعتمد على جدول مختلف
                string query = @"Select  AA_check_id from _AA_check_table";

                using (SqlConnection connection = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh"))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // إضافة النتائج إلى ComboBox1
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["AA_check_id"].ToString());
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            else
            {
                // تنفيذ الاستعلام الأصلي بناءً على القيمة المختارة من قاعدة البيانات
                string query = @"SELECT DISTINCT mo_name FROM _MO_table WHERE acc_type = @SelectedValue";

                using (SqlConnection connection = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedValue", selectedValue);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // إضافة كل نتيجة من الاستعلام إلى ComboBox1
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["mo_name"].ToString());
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void dvg10_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            TransactionFilter m = new TransactionFilter();
            dvg10.DataSource = m.FilterTransactions(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text), comboBox5.Text, comboBox1.Text);
            dvg10.Columns[0].HeaderText = "رقم العملية";
            dvg10.Columns[1].HeaderText = "تاريخ العملية";
            dvg10.Columns[2].HeaderText = "من";
            dvg10.Columns[3].HeaderText = "اسم الحساب";
            dvg10.Columns[4].HeaderText = "إلى";
            dvg10.Columns[5].HeaderText = "اسم الحساب";
            dvg10.Columns[6].HeaderText = "المبلغ";
            dvg10.Columns[7].HeaderText = "التفاصيل";
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedValue != null)
            {
                // جلب القيمة المختارة من ComboBox5
                string selectedValue = comboBox5.SelectedValue.ToString();

                // تحديث الخيارات في ComboBox1 بناءً على القيمة المختارة
                UpdateComboBox2Options(selectedValue);
            }
        }

        private void dvg10_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0) // تأكد من أن الصف هو صف بيانات
            {
                string senderName = dvg10.Rows[e.RowIndex].Cells["SenderName"].Value?.ToString();
                string receiverName = dvg10.Rows[e.RowIndex].Cells["ReceiverName"].Value?.ToString();
                string filterName = comboBox1.Text; // الاسم الذي تريد التحقق منه

                // تحقق مما إذا كان الاسم موجودًا في المرسلين أو المستلمين
                if (senderName == filterName)
                {
                    // لون الصف باللون الأصفر إذا كان في المرسلين
                    dvg10.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                }
                else if (receiverName == filterName)
                {
                    // لون الصف باللون الأخضر إذا كان في المستلمين
                    dvg10.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    // إذا لم يتطابق، استعادة لون الخلفية الافتراضي
                    dvg10.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // أو أي لون آخر تريده
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
