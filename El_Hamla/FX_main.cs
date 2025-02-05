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
    public partial class FX_main : Form
    {
        public FX_main()
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
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FX_ezn_sending f = new FX_ezn_sending();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FX_Q_Choose_car f = new FX_Q_Choose_car();
            f.ShowDialog();
        }

        private void FX_main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FX_cars_sea fX = new FX_cars_sea();
            fX.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _perchasing PP = new _perchasing();
            PP.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
