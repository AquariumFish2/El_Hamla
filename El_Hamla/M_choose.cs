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
    public partial class M_choose : Form
    {
        public M_choose()
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

        private void button2_Click(object sender, EventArgs e)
        {
            ST_main main_Form = new ST_main();
            main_Form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CD_main main_Repair = new CD_main();
            main_Repair.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FX_main main_Repair = new FX_main();
            main_Repair.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            M_main f = new M_main();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AA_main main = new AA_main();
            main.ShowDialog();
        }
    }
}
