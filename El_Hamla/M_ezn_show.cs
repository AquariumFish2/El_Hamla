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
    public partial class M_ezn_show : Form
    {
        public M_ezn_show()
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

        private void dvg10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ezn_show_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(2021, 1, 1); // تعيين التاريخ الافتراضي إلى 2021
            dateTimePicker2.Value = DateTime.Today; // تعيين التاريخ الافتراضي إلى اليوم الحالي

            dateTimePicker2.Value = DateTime.Now.AddDays(+1);
            //********************************************** load ezn 1111111 *********************************************
            CLSset.cn.Close();
            CLSezn ezn = new CLSezn();
            ezn.load_ezn1(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
            dvg10.DataSource = ezn.dt_ezn;
            dvg10.Columns[0].HeaderText = "رقم الأذن";
            dvg10.Columns[1].HeaderText = "تاريخ الأذن";
            dvg10.Columns[2].HeaderText = "رقم السيارة";
            dvg10.Columns[3].HeaderText = "نوع السيارة";
            dvg10.Columns[4].HeaderText = "جهة السيارة";
            dvg10.Columns[5].HeaderText = "بلوكامين الصيانة";
            dvg10.Columns[6].HeaderText = "المستخدم";
            dvg10.Columns[7].HeaderText = "الموافقة";
            dvg10.Columns[8].HeaderText = "الصرف";
            dvg10.Columns[9].HeaderText = "حالة أمر الشغل";
            dvg10.Columns[10].HeaderText = "رقم أمر الشغل";
            dvg10.Columns[11].HeaderText = "أسم المستلم";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvg10_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 & e.Value != null)
            {
                if (e.Value.ToString() == "قيد الإنتظار")
                {
                    e.CellStyle.BackColor = Color.Yellow;

                }
                else if (e.Value.ToString() == "تمت الموافقة")
                {
                    e.CellStyle.BackColor = Color.Green;

                }
                else
                {
                    e.CellStyle.BackColor = Color.Red;

                }




            }

            if (e.ColumnIndex == 8 & e.Value != null)
            {
                if (e.Value.ToString() == "لم يتم الصرف بعد")
                {
                    e.CellStyle.BackColor = Color.Yellow;

                }
                else if (e.Value.ToString() == "تم الصرف")
                {
                    e.CellStyle.BackColor = Color.Green;

                }
                else
                {
                    e.CellStyle.BackColor = Color.Red;

                }




            }


        }



        private void dvg10_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            M_ezn_accepting frm = new M_ezn_accepting();
            frm.text_in_ezn.Text = dvg10.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            CLSezn ezn = new CLSezn();
            ezn.load_ezn1(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
            dvg10.DataSource = ezn.dt_ezn;
            dvg10.Columns[0].HeaderText = "رقم الأذن";
            dvg10.Columns[1].HeaderText = "تاريخ الأذن";
            dvg10.Columns[2].HeaderText = "رقم السيارة";
            dvg10.Columns[3].HeaderText = "نوع السيارة";
            dvg10.Columns[4].HeaderText = "جهة السيارة";
            dvg10.Columns[5].HeaderText = "بلوكامين الصيانة";
            dvg10.Columns[6].HeaderText = "المستخدم";
            dvg10.Columns[7].HeaderText = "الموافقة";
            dvg10.Columns[8].HeaderText = "الصرف";
            dvg10.Columns[9].HeaderText = "حالة أمر الشغل";
            dvg10.Columns[10].HeaderText = "رقم أمر الشغل";
            dvg10.Columns[11].HeaderText = "أسم المستلم";
        }
        

    }
}
