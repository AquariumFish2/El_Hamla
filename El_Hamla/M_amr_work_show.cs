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
    public partial class M_amr_work_show : Form
    {
        public M_amr_work_show()
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

        private void M_amr_work_show_Load(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            CLSwork w = new CLSwork();
            w.load_amr1();
            dvg10.DataSource = w.dtamr1;
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



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            FX_Q_Choose_car fX = new FX_Q_Choose_car();
            fX.ShowDialog();

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

            panel1.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void dvg10_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 17 & e.Value != null)
            {
                if (e.Value.ToString() == "تم التسليم")
                {
                    e.CellStyle.BackColor = Color.Green;

                }

                else
                {
                    e.CellStyle.BackColor = Color.Orange;

                }




            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;




            }


            else if (comboBox3.Text == "رقم المركبة")
            {
                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }
            else if (comboBox3.Text == "نوع وشكل المركبة ")
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = true;
                panel7.Visible = false;
                panel8.Visible = false;
            }
            else if (comboBox3.Text == "جهة المركبة")
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = true;
                panel8.Visible = false;
            }
            else if (comboBox3.Text == "حالة السيارة")
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }
            else if (comboBox3.Text == "نوع أمر الشغل")
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = true;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }
            else if (comboBox3.Text == "رقم أمر الشغل")
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = true;
            }
            else if (comboBox3.Text == "تاريخ أمر الشغل")
            {
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }










        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CLSwork m = new CLSwork();
            m.sea_amr_carnum(textBox6.Text);
            dvg10.DataSource = m.dtamr_s_carnum;
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
            dvg10.Columns[16].HeaderText = "العام";
            dvg10.Columns[17].HeaderText = "حالة السيارة";
            dvg10.Columns[18].HeaderText = "تاريخ التسليم ";
            dvg10.Columns[19].HeaderText = "جهة أمر الشغل";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLSwork m = new CLSwork();
            m.sea_amr_kind(comboBox1.Text);
            dvg10.DataSource = m.dtamr_s_kind;
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
            dvg10.Columns[16].HeaderText = "العام";
            dvg10.Columns[17].HeaderText = "حالة السيارة";
            dvg10.Columns[18].HeaderText = "تاريخ التسليم ";
            dvg10.Columns[19].HeaderText = "جهة أمر الشغل";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLSwork m = new CLSwork();
            m.sea_amr_status(comboBox2.Text);
            dvg10.DataSource = m.dtamr_s_status;
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
            dvg10.Columns[16].HeaderText = "العام";
            dvg10.Columns[17].HeaderText = "حالة السيارة";
            dvg10.Columns[18].HeaderText = "تاريخ التسليم ";
            dvg10.Columns[19].HeaderText = "جهة أمر الشغل";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CLSwork m = new CLSwork();
            m.sea_amr_shape(textBox7.Text);
            dvg10.DataSource = m.dtamr_s_shape;
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
            dvg10.Columns[16].HeaderText = "العام";
            dvg10.Columns[17].HeaderText = "حالة السيارة";
            dvg10.Columns[18].HeaderText = "تاريخ التسليم ";
            dvg10.Columns[19].HeaderText = "جهة أمر الشغل";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            CLSwork m = new CLSwork();
            m.sea_amr_add(textBox8.Text);
            dvg10.DataSource = m.dtamr_s_add;
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
            dvg10.Columns[16].HeaderText = "العام";
            dvg10.Columns[17].HeaderText = "حالة السيارة";
            dvg10.Columns[18].HeaderText = "تاريخ التسليم ";
            dvg10.Columns[19].HeaderText = "جهة أمر الشغل";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            CLSwork m = new CLSwork();
            m.sea_amr_num(textBox9.Text);
            dvg10.DataSource = m.dtamr_s_num;
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
            dvg10.Columns[16].HeaderText = "العام";
            dvg10.Columns[17].HeaderText = "حالة السيارة";
            dvg10.Columns[18].HeaderText = "تاريخ التسليم ";
            dvg10.Columns[19].HeaderText = "جهة أمر الشغل";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            CLSwork m = new CLSwork();
            m.sea_amr_wdate(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
            dvg10.DataSource = m.dtamr_s_wdate;
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
            dvg10.Columns[16].HeaderText = "العام";
            dvg10.Columns[17].HeaderText = "حالة السيارة";
            dvg10.Columns[18].HeaderText = "تاريخ التسليم ";
            dvg10.Columns[19].HeaderText = "جهة أمر الشغل";
        }



        private void dvg10_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            M_amr_edit m_Amr_Edit = new M_amr_edit();
            m_Amr_Edit.amr_code_1.Text = dvg10.CurrentRow.Cells[0].Value.ToString();
            m_Amr_Edit.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CLSwork cl = new CLSwork();
            try
            {
                if (MessageBox.Show("هل أنت متأكد من حذف أمر الشغل؟", "حذف أمر الشغل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dvg10.CurrentRow.Cells[0].Value.ToString());
                    cl.delete_row_amr(id);
                    cl.load_amr1();
                    dvg10.DataSource = cl.dtamr1;
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




                }




            }
            catch
            {
                MessageBox.Show("لا يوجد أصناف لحذفها ");

            }


        }

        private void M_amr_work_show_MouseMove(object sender, MouseEventArgs e)
        {
            CLSwork m = new CLSwork();
            m.load_amr_stat();
            dataGridView1.DataSource = m.dt_amr_stat;

            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            textBox10.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            textBox11.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            using (SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh"))
            {
                string query = "SELECT  count(id_work) from amr_work WHERE car_status = @carstat and examine_status=@examine_status and work_kind=@work_kind ";

                using (SqlCommand cmd_car = new SqlCommand(query, cn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd_car.Parameters.AddWithValue("carstat", "تم التسليم");
                    cmd_car.Parameters.AddWithValue("@examine_status", "لم يتم الفحص بعد");
                    cmd_car.Parameters.AddWithValue("@work_kind", "بأمر شغل");
                    SqlDataAdapter da_car = new SqlDataAdapter();
                    da_car.SelectCommand = cmd_car;

                    DataTable dt_hag_EZ = new DataTable();
                    da_car.Fill(dt_hag_EZ);

                    // Now you can work with your DataTable (dt_hag_EZ)
                    dataGridView2.DataSource = dt_hag_EZ;   

                    textBox12.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();




                }


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            __examine_show zz = new __examine_show();
            zz.ShowDialog();

        }
    }
}
