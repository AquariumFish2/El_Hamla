using FastReport.DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class M_ezn_accepting : Form
    {
        public M_ezn_accepting()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void ezn_accepting_Load(object sender, EventArgs e)
        {
            CLSezn pro = new CLSezn();
            int eznId;

            // 🔹 التحقق من صحة الإدخال قبل أي عمليات تحويل
            if (int.TryParse(text_in_ezn.Text, out eznId))
            {
                pro.load_ezn_by_id(eznId);
            }
            else
            {
                MessageBox.Show($"القيمة المدخلة '{text_in_ezn.Text}' غير صالحة. الرجاء إدخال رقم صحيح!",
                                "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 🔹 إيقاف التنفيذ إذا كان الإدخال غير صحيح
            }

            dataGridView2.DataSource = pro.dtezn_id;

            // 🔹 تأكد من أن الجدول يحتوي على بيانات قبل الوصول إلى الخلايا
            if (dataGridView2.Rows.Count > 0)
            {
                textBox1.Text = dataGridView2.Rows[0].Cells[1].Value?.ToString() ?? "";
                textBox2.Text = dataGridView2.Rows[0].Cells[2].Value?.ToString() ?? "";
                textBox3.Text = dataGridView2.Rows[0].Cells[3].Value?.ToString() ?? "";
                textBox4.Text = dataGridView2.Rows[0].Cells[4].Value?.ToString() ?? "";
                textBox5.Text = dataGridView2.Rows[0].Cells[5].Value?.ToString() ?? "";
                textBox6.Text = dataGridView2.Rows[0].Cells[6].Value?.ToString() ?? "";
                textBox7.Text = dataGridView2.Rows[0].Cells[7].Value?.ToString() ?? "";
                textBox8.Text = dataGridView2.Rows[0].Cells[8].Value?.ToString() ?? "";
                textBox12.Text = dataGridView2.Rows[0].Cells[9].Value?.ToString() ?? "";
                textBox11.Text = dataGridView2.Rows[0].Cells[10].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("لا توجد بيانات متاحة!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 🔹 إيقاف التنفيذ إذا كان الجدول فارغًا
            }

            // 🔹 تحميل بيانات `load_ezn2_by_id` باستخدام `eznId`
            pro.load_ezn2_by_id(eznId);
            dvg10.DataSource = pro.dtezn2_id;

            if (dvg10.Columns.Count > 1)
            {
                dvg10.Columns[0].HeaderText = "أسم الصنف";
                dvg10.Columns[1].HeaderText = "الكمية";
                dvg10.Columns[2].Visible = false;
            }

            decimal sum = 0;
            for (int i = 0; i < dvg10.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dvg10.Rows[i].Cells[1].Value ?? 0);
            }
            textBox9.Text = sum.ToString();
            textBox10.Text = dvg10.Rows.Count.ToString();

            // 🔹 تحميل بيانات `load_amr2_bring_id` باستخدام بيانات صحيحة
            CLSwork wk = new CLSwork();
            wk.load_amr2_bring_id(textBox2.Text, textBox11.Text);
            dataGridView3.DataSource = wk.dtamr2_bring_id;

            if (dataGridView3.Rows.Count > 0)
            {
                dataGridView3.Columns[0].HeaderText = "الكود";
                textBox13.Text = dataGridView3.Rows[0].Cells[0].Value?.ToString() ?? "0";

                // 🔹 تحويل `textBox13.Text` فقط إذا كان رقمًا صالحًا
                int amrId;
                if (int.TryParse(textBox13.Text, out amrId))
                {
                    wk.load_amr2_by_id(amrId);
                    dataGridView1.DataSource = wk.dtamr2_id;
                    dataGridView1.Columns[0].HeaderText = "قطعة الغيار بأمر الشغل";
                    dataGridView1.Columns[1].HeaderText = "الكمية";
                }
                else
                {
                    MessageBox.Show($"القيمة '{textBox13.Text}' غير صالحة كرقم أمر الشغل!",
                                    "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CLS_perchasing p = new CLS_perchasing();
            bool conditionMet = false;

            for (int i = 1; i <= dvg10.Rows.Count; ++i)
            {
                p.load_pro_by_proname2(dvg10.Rows[i - 1].Cells[2].Value.ToString());
                dataGridView4.DataSource = p.dt_pro_by_proname2;

                if (textBox2.Text != dataGridView4.Rows[i - 1].Cells[10].Value.ToString() && dataGridView4.Rows[i - 1].Cells[10].Value.ToString() != "")
                {
                    MessageBox.Show("قطعة الغيار " + dataGridView4.Rows[i - 1].Cells[1].Value.ToString() + " محجوزة للسيارة " + dataGridView4.Rows[i - 1].Cells[10].Value.ToString());
                    conditionMet = true; // الشرط تحقق
                }
            }

            // تحقق إذا كان الشرط تحقق مرة واحدة أو أكثر
            if (conditionMet)
            {
                // عرض رسالة تحذير بنعم أو لا
                DialogResult result = MessageBox.Show("هل تريد الموافقة رغم ذلك ؟", "هناك بعض القطع محجوزة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // الكود الذي تريد تنفيذه إذا تم اختيار نعم
                    textBox7.Text = "تمت الموافقة";
                    CLSezn cL = new CLSezn();
                    cL.update_status1(Convert.ToInt32(text_in_ezn.Text), textBox7.Text);
                    MessageBox.Show("تمت الموافقة");
                    M_ezn_show f = new M_ezn_show();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    // إذا تم اختيار لا
                    MessageBox.Show("تم الغاء الموافقة");
                }
            }
            else
            {
                // إذا لم يتحقق الشرط يمكنك متابعة الكود بدون الرسالة التحذيرية
                textBox7.Text = "تمت الموافقة";
                CLSezn cL = new CLSezn();
                cL.update_status1(Convert.ToInt32(text_in_ezn.Text), textBox7.Text);
                MessageBox.Show("تمت الموافقة");
                M_ezn_show f = new M_ezn_show();
                f.ShowDialog();
                this.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = "تم الرفض";
            CLSezn cL = new CLSezn();
            cL.update_status1(Convert.ToInt32(text_in_ezn.Text), textBox7.Text);
            MessageBox.Show("تم الرفض");
            M_ezn_show f = new M_ezn_show();
            f.ShowDialog();
            this.Close();
            
        }
    }
}
