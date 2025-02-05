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
    public partial class M_choose_3_BK : Form
    {
        public M_choose_3_BK()
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

        private void button1_Click(object sender, EventArgs e)
        {
            ST_main b = new ST_main();
            b.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FX_main fX = new FX_main();
            fX.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            M_main_BK m_Main_BK = new M_main_BK();
            m_Main_BK.ShowDialog();

        }
    }
}
