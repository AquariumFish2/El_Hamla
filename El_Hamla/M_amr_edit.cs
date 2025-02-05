using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class M_amr_edit : Form
    {
        public M_amr_edit()
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repair_cars2_Load(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            CLSwork w = new CLSwork();
            w.load_amr_by_id(Convert.ToInt32(amr_code_1.Text));
            dvg10.DataSource = w.dtamr_w_id;
            dvg10.Columns[0].HeaderText = "الكود";
            dvg10.Columns[1].HeaderText = "رقم المركبة";
            dvg10.Columns[2].HeaderText = "الرقم السري";
            dvg10.Columns[3].HeaderText = "نوع المركبة";
            dvg10.Columns[4].HeaderText = "شكل المركبة ";
            dvg10.Columns[5].HeaderText = "موديل المركبة";
            dvg10.Columns[6].HeaderText = "جهة المركبة";
            dvg10.Columns[7].HeaderText = "تاريخ استلام السيارة";
            dvg10.Columns[8].HeaderText = "رقم أمر الشغل";
            dvg10.Columns[9].HeaderText = "تاريخ أمر الشغل";
            dvg10.Columns[10].HeaderText = "رقم الأذن";
            dvg10.Columns[11].HeaderText = "السعر الإبتدائي ";
            dvg10.Columns[12].HeaderText = "السعر النهائي";
            dvg10.Columns[13].HeaderText = "اسم المستخدم";
            dvg10.Columns[14].HeaderText = "تاريخ ادخال البيانات";
            dvg10.Columns[15].HeaderText = "نوع أمر الشغل";
            dvg10.Columns[16].HeaderText = " العام المالي";
            dvg10.Columns[17].HeaderText = "حالة السيارة";
            dvg10.Columns[18].HeaderText = "تاريخ التسليم ";
            dvg10.Columns[19].HeaderText = "جهة أمر الشغل";
            //*************************************************************
            car_num_num.Text = dvg10.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dvg10.Rows[0].Cells[2].Value.ToString();
            comboBox1.Text = dvg10.Rows[0].Cells[3].Value.ToString();
            comboBox2.Text = dvg10.Rows[0].Cells[4].Value.ToString();
            comboBox3.Text = dvg10.Rows[0].Cells[5].Value.ToString();
            comboBox4.Text = dvg10.Rows[0].Cells[6].Value.ToString();
            dateTimePicker1.Text= dvg10.Rows[0].Cells[7].Value.ToString();
            work_num_num.Text= dvg10.Rows[0].Cells[8].Value.ToString();
            dateTimePicker2.Text = dvg10.Rows[0].Cells[9].Value.ToString();
            textBox6.Text = dvg10.Rows[0].Cells[10].Value.ToString();
            textBox8.Text = dvg10.Rows[0].Cells[11].Value.ToString();
            textBox9.Text = dvg10.Rows[0].Cells[12].Value.ToString();
            textBox10.Text = dvg10.Rows[0].Cells[13].Value.ToString();
            dateTimePicker3.Text = dvg10.Rows[0].Cells[14].Value.ToString();
            comboBox5.Text = dvg10.Rows[0].Cells[15].Value.ToString();
            comboBox6.Text = dvg10.Rows[0].Cells[16].Value.ToString();
            textBox4.Text = dvg10.Rows[0].Cells[17].Value.ToString();
            dateTimePicker4.Text = dvg10.Rows[0].Cells[18].Value.ToString();
            textBox7.Text = dvg10.Rows[0].Cells[19].Value.ToString();





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

        private void button6_Click(object sender, EventArgs e)
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
                cL.update_amr_work(Convert.ToInt32(amr_code_1.Text), car_num_num.Text, textBox3.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, Convert.ToDateTime(dateTimePicker1.Text), comboBox5.Text, work_num_num.Text, Convert.ToDateTime(dateTimePicker2.Text), textBox6.Text, Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox9.Text), textBox10.Text, Convert.ToDateTime(dateTimePicker3.Text), comboBox6.Text, textBox4.Text, Convert.ToDateTime(dateTimePicker3.Text), textBox7.Text);
                MessageBox.Show("تم التعديل بنجاح");
                this.Close();


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            add_pro_for_2mr f = new add_pro_for_2mr();
            f.amr_code_1.Text = amr_code_1.Text;

            f.ShowDialog();
        }
    }
}
