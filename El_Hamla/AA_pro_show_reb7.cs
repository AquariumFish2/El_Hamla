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
    public partial class AA_pro_show_reb7 : Form
    {
        public AA_pro_show_reb7()
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
        private void AA_pro_show_Load(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            CLS_AA_pro cLS_AA_Pro = new CLS_AA_pro();
            cLS_AA_Pro.loadProjects();
            dvg10.DataSource = cLS_AA_Pro.dtProject;

        }

        private void dvg10_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AA_reb7 frm = new AA_reb7();
            frm.textBox3.Text = dvg10.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
