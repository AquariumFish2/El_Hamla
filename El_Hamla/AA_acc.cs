using FastReport.DevComponents.DotNetBar;
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
    public partial class AA_acc : Form
    {
        public AA_acc()
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
        private void AA_acc_Load(object sender, EventArgs e)
        {
            CLS_AA cL = new CLS_AA();
            int ID = cL.maxIDaccc() + 1;
            textBox3.Text = ID.ToString();
            cL.loadacc();
            dvg10.DataSource = cL.dtaccc;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLS_AA cL = new CLS_AA();




            try
            {
                cL.insert_MO_table(Convert.ToInt32(textBox3.Text), textBox2.Text, comboBox2.Text, Convert.ToDecimal(textBox4.Text));

            }
            catch
            {
                MessageBox.Show("ادخل القيم بشكل صحيح");
            }

            cL.loadacc();
            dvg10.DataSource = cL.dtaccc;

            textBox2.Text = "";
            textBox4.Text = "";

            comboBox2.Text = "";
            int ID = cL.maxIDaccc() + 1;
            textBox3.Text = ID.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLS_AA cL = new CLS_AA();
            try
            {
                if (MessageBox.Show("هل أنت متأكد من حذف هذا الحساب؟", "حذف حساب", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cL.delete_MO_table(Convert.ToInt32(dvg10.CurrentRow.Cells[0].Value.ToString()));

                    cL.loadacc();
                    dvg10.DataSource = cL.dtaccc;

                }
            }
            catch
            {
                MessageBox.Show("لا يوجد حسابات لحذفها ");

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
            string connectionString = @"Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh";

            // SQL query لاسترجاع القيمة المطلوبة
            string query = @"SELECT balance FROM _MO_table WHERE mo_name='الخزينة الشخصية' ";

            // إنشاء اتصال بقاعدة البيانات
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // إنشاء أمر SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // تنفيذ الأمر وجلب القيمة
                        object result = command.ExecuteScalar();

                        // التحقق من أن القيمة ليست null قبل عرضها
                        if (result != null)
                        {
                            // تحويل القيمة إلى عدد وإزالة الإشارة السالبة إذا كانت موجودة
                            decimal value = Convert.ToDecimal(result);
                            textBox1.Text = Math.Abs(value).ToString();
                        }
                        else
                        {
                            MessageBox.Show("لم يتم العثور على أي بيانات.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ: " + ex.Message);
                }
            }
        }

        
    }
}
