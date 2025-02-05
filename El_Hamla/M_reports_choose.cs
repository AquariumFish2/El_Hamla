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
    public partial class M_reports_choose : Form
    {
        public M_reports_choose()
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            M_maghood_report mm = new M_maghood_report();
            mm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            M_ezn_Report m = new M_ezn_Report();
            m.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            M_products_balance_report mmmm = new M_products_balance_report();
            mmmm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            M_hagez_report nnn = new M_hagez_report();
            nnn.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            M_product_follow_report mmmmm = new M_product_follow_report();
            mmmmm.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            _perchasing_report mm10 = new _perchasing_report();
            mm10.ShowDialog();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            _perchasing_report mm10 = new _perchasing_report();
            mm10.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            buying_show mmm = new buying_show();
            mmm.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            buying_show mmm = new buying_show();
            mmm.ShowDialog();
        }

        private void M_reports_choose_Load(object sender, EventArgs e)
        {

        }

        private void M_reports_choose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }
    }
}
