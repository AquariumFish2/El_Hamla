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
    public partial class ST_receivers_show : Form
    {
        public ST_receivers_show()
        {
            InitializeComponent();
            CLSreceivers pro = new CLSreceivers();
            pro.loadreceivers();
            dvg.DataSource = pro.dtreceivers;
            dvg.Columns[0].HeaderText = "كود المستلم";
            dvg.Columns[1].HeaderText = "اسم المستلم";
            dvg.Columns[2].HeaderText = "الوظيفة";
            dvg.Columns[3].HeaderText = "الرقم القومي";
            dvg.Columns[4].HeaderText = "الجهة التابع لها ";

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

        private void receivers_show_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CLSreceivers s = new CLSreceivers();
            try
            {
                if (MessageBox.Show("هل أنت متأكد من حذف هذا المستلم ؟", "حذف مستلم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLSreceivers pro = new CLSreceivers();
                    pro.delete_receivers(Convert.ToInt32(dvg.CurrentRow.Cells[0].Value.ToString()));
                    pro.loadreceivers();
                    dvg.DataSource = pro.dtreceivers;
                    dvg.Columns[0].HeaderText = "كود المستلم";
                    dvg.Columns[1].HeaderText = "اسم المستلم";
                    dvg.Columns[2].HeaderText = "الوظيفة";
                    dvg.Columns[3].HeaderText = "الرقم القومي";
                    dvg.Columns[4].HeaderText = "الجهة التابع لها ";






                }
            }
            catch
            {
                MessageBox.Show("لا يوجد مستلمين لحذفهم ");

            }
        }
    }
}
