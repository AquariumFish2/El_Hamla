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
    public partial class FX_cars_sea : Form
    {
        public FX_cars_sea()
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
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CLSwork cLSwork = new CLSwork();
            cLSwork.Search_cars_new(textBox1.Text);
            dvg10.DataSource = cLSwork.dtcar_new;

        }

        private void FX_cars_sea_Load(object sender, EventArgs e)
        {
            CLSset.cn.Close();

            CLSwork cLSwork = new CLSwork();
            cLSwork.loadcars_new();
            dvg10.DataSource = cLSwork.dtcar_new;

            dvg10.Columns[0].HeaderText = "رقم السيارة";
            dvg10.Columns[1].HeaderText = "نوع السيارة";
            dvg10.Columns[2].HeaderText = "جهة السيارة";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvg10_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FX_cars_show frm = new FX_cars_show();
            frm.car_num_in_car_show.Text = dvg10.CurrentRow.Cells[0].Value.ToString();
            frm.car_name_in_car_show.Text = dvg10.CurrentRow.Cells[1].Value.ToString();
            frm.car_add_in_car_show.Text = dvg10.CurrentRow.Cells[2].Value.ToString();
            frm.ShowDialog();
            this.Close();
        }
    }
}
