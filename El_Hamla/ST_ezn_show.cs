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
    public partial class ST_ezn_show : Form
    {
        public ST_ezn_show()
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
          
            textBox1.Text = DateTime.Now.ToShortDateString();
            //********************************************** load ezn 1111111 *********************************************
            CLSset.cn.Close();
            CLSezn ezn = new CLSezn();
            ezn.load_ezn_1_in_store();
            dvg10.DataSource = ezn.dt_load_ezn_1_in_store;

            dvg10.Columns[0].HeaderText = "رقم الأذن";
            dvg10.Columns[1].HeaderText = "رقم السيارة";
            dvg10.Columns[2].HeaderText = "نوع السيارة";
            dvg10.Columns[3].HeaderText = "جهة السيارة";
            dvg10.Columns[4].HeaderText = "بلوكامين الصيانة";
           

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

            if (e.ColumnIndex ==8 & e.Value != null)
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
            ST_ezn_exctueing frm = new ST_ezn_exctueing();
            frm.text_in_ezn.Text = dvg10.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
            this.Close();
        }
    }
}
