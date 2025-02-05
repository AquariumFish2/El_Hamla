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
    public partial class CD_Query_q : Form
    {
        public CD_Query_q()
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
            CD_car_q repair_Car_Q = new CD_car_q();
            repair_Car_Q.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CD_Repair_q repair_Repair_Q = new CD_Repair_q();
            repair_Repair_Q.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CD_oil_q repair=new CD_oil_q();
            repair.ShowDialog();    
        }
    }
}
