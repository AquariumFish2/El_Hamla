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
    public partial class ST_buyers_show : Form
    {
        public ST_buyers_show()
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

        private void buyers_show_Load(object sender, EventArgs e)
        {
            CLSbuyer pro = new CLSbuyer();
            pro.loadbuyer();
            dvg.DataSource = pro.dtbuyer;
            dvg.Columns[0].HeaderText = "كود المشتري";

            dvg.Columns[1].HeaderText = "اسم المشتري";
            dvg.Columns[2].HeaderText = "الرقم القومي";
            dvg.Columns[3].HeaderText = "الوظيفة";
            dvg.Columns[4].HeaderText = "التفاصيل ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CLSbuyer s = new CLSbuyer();
            try
            {
                if (MessageBox.Show("هل أنت متأكد من حذف هذا المشتري ؟", "حذف مشتري", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    s.delete_buyer(Convert.ToInt32(dvg.CurrentRow.Cells[0].Value.ToString()));
                    s.loadbuyer();
                    dvg.DataSource = s.dtbuyer;
                    dvg.Columns[0].HeaderText = "كود المشتري";

                    dvg.Columns[1].HeaderText = "اسم المشتري";
                    dvg.Columns[2].HeaderText = "الرقم القومي";
                    dvg.Columns[3].HeaderText = "الوظيفة";
                    dvg.Columns[4].HeaderText = "التفاصيل ";




                }
            }
            catch
            {
                MessageBox.Show("لا يوجد مشتريين لحذفهم ");

            }
        }
    }
}
