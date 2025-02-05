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
    public partial class ___cars_show : Form
    {
        public ___cars_show()
        {
            InitializeComponent();
            CLScars pro = new CLScars();
            pro.loadcars();
            dvg.DataSource = pro.dtcar;
            dvg.Columns[0].HeaderText = "كود السيارة";
            dvg.Columns[1].HeaderText = "رقم السيارة";
            dvg.Columns[2].HeaderText = "نوع السيارة";
            dvg.Columns[3].HeaderText = "جهة السيارة";
            dvg.Columns[4].HeaderText = "تاريخ دخول السيارة";
            dvg.Columns[5].HeaderText = "تاريخ تسليم السيارة";
            dvg.Columns[6].HeaderText = "الحالة";
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

        private void cars_show_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ___cars f = new ___cars(); 
            f.ShowDialog();
                
        }
    }
}
