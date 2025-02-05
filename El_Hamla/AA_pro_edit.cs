using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraRichEdit.Model;
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
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace El_Hamla
{
    public partial class AA_pro_edit : Form
    {
        DataTable dt_MO;
        DataTable dt_car;
        DataTable dt_max;
        public AA_pro_edit()
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


        private void AA_pro_add_Load(object sender, EventArgs e)
        {
            //********************************************** cars TEXTBOX *************************************************

            SqlConnection cn = new SqlConnection(@"Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_car = new SqlCommand("Select distinct car_num from amr_work where examine_status='تم الفحص' ", cn);
            SqlDataAdapter da_car = new SqlDataAdapter();
            da_car.SelectCommand = cmd_car;
            dt_car = new DataTable();
            da_car.Fill(dt_car);


            //********************************************** MO TEXTBOX *************************************************


            SqlCommand cmd_pro = new SqlCommand("Select  mo_name from _MO_table where acc_type='ممول' ", cn);
            SqlDataAdapter da_pro = new SqlDataAdapter();
            da_pro.SelectCommand = cmd_pro;
            dt_MO = new DataTable();
            da_pro.Fill(dt_MO);
            //***********************************************************************************************************


            CLS_AA_pro cLS = new CLS_AA_pro();
            cLS.loadProjects2(Convert.ToInt32(textBox3.Text));
            dataGridView1.DataSource = cLS.dtProject2;
            cLS.loadProjectsid1(Convert.ToInt32(textBox3.Text));
            dataGridView2.DataSource = cLS.dtProjectid1;
            textBox1.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
            textBox7.Text = dataGridView2.Rows[0].Cells[5].Value.ToString();
            textBox5.Text = dataGridView2.Rows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();



        }
        // تعيين البيانات في الـ TextBox بناءً على الشروط في DataGridView
        private void CalculateSums()
        {
            decimal sumColumn3 = 0;
            decimal sumColumn33 = 0;
            decimal sumColumn4 = 0;

            // تمر عبر جميع الصفوف في DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // التأكد أن الصف غير فارغ لتجنب الأخطاء
                if (row.Cells[0].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null)
                {
                    // الحصول على قيمة العمود الأول كمفتاح التحقق
                    string type = row.Cells[1].Value.ToString();
                    decimal column3Value = Convert.ToDecimal(row.Cells[2].Value);
                    decimal column4Value = Convert.ToDecimal(row.Cells[3].Value);

                    // تحقق من القيم وإضافتها حسب الشروط
                    if (type == "مركبة")
                    {
                        sumColumn3 += column3Value;
                        sumColumn4 += column4Value;
                    }
                    else if (type == "ممول")
                    {
                        sumColumn33 += column3Value;
                    }
                }
            }

            // تخصيص النتائج في TextBoxes
            textBox4.Text = sumColumn3.ToString();
            textBox7.Text = sumColumn33.ToString();
            textBox5.Text = sumColumn4.ToString();
            textBox6.Text = (sumColumn4 - sumColumn3).ToString(); // الفرق بين المجموعين
        }





        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Enter && suggestionBox2.Visible && suggestionBox2.Focused)
            {
                textBox9.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
                return true;
            }



            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void suggestionBox2_Click(object sender, EventArgs e)
        {
            if (suggestionBox2.SelectedItem != null)
            {
                textBox9.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CLS_AA_pro cLS = new CLS_AA_pro();
            try
            {
                cLS.updateProject(Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value.ToString()), textBox1.Text, Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox7.Text));

            }
            catch
            {
                MessageBox.Show("ادخل القيم بشكل صحيح");
            }
            MessageBox.Show("تم التعديل بنجاح");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLS_AA_pro cLS = new CLS_AA_pro();

            try
            {
                cLS.insertProject2(Convert.ToInt32(textBox3.Text), textBox9.Text, comboBox2.Text, Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox2.Text));

            }
            catch
            {
                MessageBox.Show("ادخل القيم بشكل صحيح");
            }
            cLS.loadProjects2(Convert.ToInt32(textBox3.Text));
            dataGridView1.DataSource = cLS.dtProject2;
            CalculateSums();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLS_AA_pro bLS = new CLS_AA_pro();

            try
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف ؟", "حذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    bLS.deleteProject2(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    bLS.loadProjects2(Convert.ToInt32(textBox3.Text));
                    dataGridView1.DataSource = bLS.dtProject2;
                    CalculateSums();
                }
            }
            catch
            {
                MessageBox.Show("لا يوجد عناصر لحذفها ");

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "مركبة")
            {
                string searchText = textBox9.Text;

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    // Filter DataTable based on search text using Contains to match anywhere in the string
                    var filteredRows = dt_car.AsEnumerable()
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
            else if (comboBox2.Text == "ممول")
            {
                string searchText = textBox9.Text;

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    // Filter DataTable based on search text using Contains to match anywhere in the string
                    var filteredRows = dt_MO.AsEnumerable()
                                                .Where(row => row.Field<string>("mo_name")
                                                .Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                                .Select(row => row.Field<string>("mo_name"))
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
            if (comboBox2.Text == "مركبة")
            {

                CLSezn_report mm = new CLSezn_report();
                dataGridView3.DataSource = mm.FilterEznData222(textBox9.Text, "", "", "", ""); ;
                dataGridView3.Columns[0].HeaderText = "تاريخ العملية";
                dataGridView3.Columns[1].HeaderText = "رقم المركبة";
                dataGridView3.Columns[1].Visible = false;
                dataGridView3.Columns[2].HeaderText = "اسم الصنف";
                dataGridView3.Columns[3].HeaderText = "الكمية";
                dataGridView3.Columns[4].HeaderText = "السعر";
                dataGridView3.Columns[5].HeaderText = "الإجمالي";
                CalculateColumnSum();

            }
        }
        private void CalculateColumnSum()
        {
            // التأكد من وجود صفوف في DataGridView
            if (dataGridView3.Rows.Count > 0)
            {
                // تعريف متغير لتخزين المجموع
                decimal sum = 0;

                // المرور على جميع الصفوف
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    // التأكد من أن الصف غير فارغ وأن العمود يحتوي على قيمة
                    if (row.Cells[5].Value != null && decimal.TryParse(row.Cells[5].Value.ToString(), out decimal value))
                    {
                        // جمع القيم
                        sum += value;
                    }
                }

                // تعيين المجموع في TextBox
                textBox8.Text = sum.ToString();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && suggestionBox2.Items.Count > 0)
            {
                suggestionBox2.Focus();
                suggestionBox2.SelectedIndex = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
