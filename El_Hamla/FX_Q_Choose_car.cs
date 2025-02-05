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
    public partial class FX_Q_Choose_car : Form
    {
        public FX_Q_Choose_car()
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repair_Q_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FX_cars2 repair = new FX_cars2();
            repair.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FX_cars3 repair_Repair_Q = new FX_cars3();
            repair_Repair_Q.ShowDialog();
        }
    }
}
