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
    public partial class FX_cars_finish : Form
    {
        public FX_cars_finish()
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

        private void button1_Click(object sender, EventArgs e)
        {
            CLSwork cc = new CLSwork();
            cc.update_car_status(car_num_in_car_show.Text, Convert.ToDateTime(dateTimePicker1.Text));
        
            MessageBox.Show("تم تسليم السيارة بنجاح");
            this.Close();


        }

        private void FX_cars_finish_Load(object sender, EventArgs e)
        {

        }
    }
}
