using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class FX_cars3 : Form
    {
        public FX_cars3()
        {
            InitializeComponent();
            //LoadComboBoxItems();

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
        //private void LoadComboBoxItems()
        //{
        //    SqlConnection connectionString = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");

        //    using (SqlConnection connection = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh"))
        //    {
        //        try
        //        {
        //            connection.Open(); // فتح الاتصال بقاعدة البيانات

        //            // تعريف الإجراء المخزن
        //            SqlCommand command = new 
        //            command.CommandType = CommandType.StoredProcedure;

        //            SqlDataReader reader = command.ExecuteReader();

        //            // مسح العناصر الحالية في ComboBox قبل الإضافة (اختياري)
        //            comboBox1.Items.Clear();

        //            // قراءة البيانات من القارئ وإضافتها إلى ComboBox
        //            while (reader.Read())
        //            {
        //                comboBox1.Items.Add(reader["ProductName"].ToString());
        //            }

        //            reader.Close(); // إغلاق القارئ
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("خطأ أثناء تحميل البيانات إلى ComboBox: " + ex.Message);
        //        }
        //    }
        //}

    private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repair_cars2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "لم يتم الفحص بعد";
            textBox4.Text = "لم يتم التسليم بعد";
            textBox7.Text = "الإدارة العامة لمركبات الشرطة";
            textBox8.Text = "0";
            textBox9.Text = "0";

            CLSwork cL = new CLSwork();
            int ID = cL.mIDworkk() + 1;
            amr_code_1.Text = ID.ToString();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_pro_for_2mr f = new add_pro_for_2mr();
            f.amr_code_1.Text = amr_code_1.Text;

            f.ShowDialog();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }



        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "بأمر شغل ")
            {
                work_num_num.Enabled = true;
                textBox6.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                comboBox6.Enabled = true;
                dateTimePicker2.Enabled = true;



            }
            else if(comboBox5.Text == "بدون امر شغل")
            {
                work_num_num.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                comboBox6.Enabled = false;
                dateTimePicker2.Enabled = false;

            }
            else
            {
                work_num_num.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                comboBox6.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (car_num_num.Text == "")
            {
                MessageBox.Show("يجب إدخال رقم المركبة");

            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("يجب إدخال نوع المركبة");

            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("يجب إدخال شكل المركبة");

            }
            else if (comboBox4.Text == "")
            {
                MessageBox.Show("يجب إدخال جهةالمركبة");

            }
            else if (comboBox5.Text == "")
            {
                MessageBox.Show("يجب إدخال حالة أمر الشغل");

            }
            else
            {

                CLSwork cL = new CLSwork();
                cL.insert_amr_work(Convert.ToInt32(amr_code_1.Text), car_num_num.Text, textBox3.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, Convert.ToDateTime(dateTimePicker1.Text), comboBox5.Text, work_num_num.Text, Convert.ToDateTime(dateTimePicker2.Text), textBox6.Text, Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox9.Text), textBox10.Text, Convert.ToDateTime(dateTimePicker3.Text), comboBox6.Text, textBox4.Text, textBox7.Text, textBox1.Text);
                MessageBox.Show("تمت الاضافة بنجاح");
                this.Close();


            }


        }

       
    }
}
