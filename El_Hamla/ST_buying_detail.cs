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
    public partial class ST_buying_detail : Form
    {
        public ST_buying_detail()
        {
            InitializeComponent();
            buying_code.Visible = false;
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


        private void ST_buying_detail_Load(object sender, EventArgs e)
        {
            CLSbuying cLSbuying = new CLSbuying();
            cLSbuying.load_b211(Convert.ToInt32(buying_code.Text));
            dvg10.DataSource = cLSbuying.dt_b2;
            dvg10.Columns[0].HeaderText = "الكود";
            dvg10.Columns[1].HeaderText = "الصنف";
            dvg10.Columns[2].HeaderText = "السعر";
            dvg10.Columns[3].HeaderText = "الكمية";
            dvg10.Columns[4].HeaderText = "الإجمالي";
            dvg10.Columns[5].HeaderText = "الوحدة";
            dvg10.Columns[6].HeaderText = "تاريخ الشراء";
            dvg10.Columns[7].HeaderText = "جهة الشراء";
            dvg10.Columns[8].HeaderText = "المورد";
            dvg10.Columns[9].HeaderText = "رقم السيارة";
            dvg10.Columns[10].HeaderText = "حالة أمر الشغل";
            dvg10.Columns[11].HeaderText = "رقم أمر الشغل";
            dvg10.Columns[12].HeaderText = "حالة الحجز";
            dvg10.Columns[13].HeaderText = "الفئة";
            dvg10.Columns[0].Visible = false;
            dvg10.Columns[6].Visible = false;
            dvg10.Columns[12].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
