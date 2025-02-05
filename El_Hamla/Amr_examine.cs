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
    public partial class Amr_examine : Form
    {
        public Amr_examine()
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
        private void Amr_examine_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLSwork ww = new CLSwork();
            ww.update_examine_status(Convert.ToInt32( work_code.Text), Convert.ToDateTime(dateTimePicker1.Text));
            MessageBox.Show("تم تسجيل الفحص");
            this.Close();   
        }
    }
}
