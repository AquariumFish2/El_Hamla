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
    public partial class AA_check_add : Form
    {
        public AA_check_add()
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void CalculateDiscount()
        {
            try
            {
                // الحصول على القيم من مربعات النص
                decimal amount = Convert.ToDecimal(textBox1.Text);
                decimal percentage = Convert.ToDecimal(textBox5.Text);

                // حساب المبلغ بعد الخصم
                decimal discountAmount = amount * (percentage / 100);

                // طرح المبلغ المخصوم وكتابة النتيجة في المربع الثالث
                textBox4.Text = (amount - discountAmount).ToString("F2");
            }
            catch (FormatException)
            {

            }
        }

        private void AA_check_add_Load(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            CLS_AA cL = new CLS_AA();
            int ID = cL.maxIDcheck() + 1;
            textBox3.Text = ID.ToString();
            cL.loadcheck();
            dvg10.DataSource = cL.dtcheck;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox2.Text = "";
            total.Text = Convert.ToString(cL.loadallbalance());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            CLS_AA cL = new CLS_AA();
            try
            {
                cL.insert_check(Convert.ToInt32(textBox3.Text), textBox2.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox4.Text), comboBox2.Text);

            }
            catch
            {
                MessageBox.Show("ادخل القيم بشكل صحيح");
            }

            cL.loadcheck();
            dvg10.DataSource = cL.dtcheck;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox2.Text = "";
            int ID = cL.maxIDcheck() + 1;
            textBox3.Text = ID.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLS_AA cL = new CLS_AA();
            try
            {
                if (MessageBox.Show("هل أنت متأكد من حذف هذا الشيك؟", "حذف شيك", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cL.delete_check(Convert.ToInt32(dvg10.CurrentRow.Cells[0].Value.ToString()));

                    cL.loadcheck();
                    dvg10.DataSource = cL.dtcheck;

                }
            }
            catch
            {
                MessageBox.Show("لا يوجد شيكات لحذفها ");

            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox2.Text = "";
            int ID = cL.maxIDcheck() + 1;
            textBox3.Text = ID.ToString();

            cL.loadallbalance();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
