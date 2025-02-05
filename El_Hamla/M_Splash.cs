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
    public partial class M_Splash : Form
    {
        public M_Splash()
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
        private void Splash_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 56;
            
            if (panel2.Width >= 1051)
            {
                timer1.Stop();
                all_Login frm = new all_Login();    
                frm.ShowDialog();   
                this.Close();
             

            }
            


        }
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
