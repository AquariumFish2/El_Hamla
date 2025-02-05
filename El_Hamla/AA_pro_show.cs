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
    public partial class AA_pro_show : Form
    {
        public AA_pro_show()
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
            dvg10.Columns[0].HeaderText = "كود المشروع";
            dvg10.Columns[1].HeaderText = "اسم المشروع";
            dvg10.Columns[2].HeaderText = "التكلفة الفعلية";
            dvg10.Columns[3].HeaderText = "الربح";
            dvg10.Columns[4].HeaderText = "إجمالي المقايسة";
            dvg10.Columns[5].HeaderText = "إجمالي التمويل";
   

        }

        private void dvg10_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AA_pro_edit frm = new AA_pro_edit();
            frm.textBox3.Text = dvg10.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AA_pro_add aA_Pro_Add = new AA_pro_add();
            aA_Pro_Add.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
