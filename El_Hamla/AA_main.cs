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
    public partial class AA_main : Form
    {
        public AA_main()
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
        private void AA_main_Load(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AA_transaction aA = new AA_transaction();
            aA.ShowDialog();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            AA_trans_report aA = new AA_trans_report();
            aA.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AA_acc aA = new AA_acc();
            aA.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AA_check_add aA = new AA_check_add();
            aA.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AA_pro_show_reb7 mm = new AA_pro_show_reb7();
            mm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AA_pro_show aA_Pro_Show = new AA_pro_show();    
            aA_Pro_Show.ShowDialog();   

        }
    }
}
