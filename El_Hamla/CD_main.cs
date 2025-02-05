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
    public partial class CD_main : Form
    {
        public CD_main()
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
        private void main_repair_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CD_cars repair_Cars = new CD_cars();
            repair_Cars.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CD_oil repair_Oil = new CD_oil();
            repair_Oil.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CD__repair repair_Repair = new CD__repair();
            repair_Repair.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CD_Query_q f = new CD_Query_q();
            f.ShowDialog(); 
        }
    }
}
