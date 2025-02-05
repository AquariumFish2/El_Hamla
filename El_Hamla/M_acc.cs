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
    public partial class M_acc : Form
    {
        public M_acc()
        {
            InitializeComponent();
            CLSusres cL = new CLSusres();
            int ID = cL.mIDacc() + 1;
            textBox3.Text = ID.ToString();
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M_acc_Load(object sender, EventArgs e)
        {
            CLSusres cL = new CLSusres();
            cL.loadacc();
            dataGridView1.DataSource = cL.dtacc;
            dataGridView1.Columns[0].HeaderText = "كود الحساب";
            dataGridView1.Columns[1].HeaderText = "اسم المستخدم";
            dataGridView1.Columns[2].HeaderText = "كلمة السر";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CLSusres cl = new CLSusres();
            cl.insacc(Convert.ToInt32(textBox3.Text), textBox1.Text, textBox2.Text);
            CLSusres cL = new CLSusres();
            cL.loadacc();
            dataGridView1.DataSource = cL.dtacc;
            dataGridView1.Columns[0].HeaderText = "كود الحساب";
            dataGridView1.Columns[1].HeaderText = "اسم المستخدم";
            dataGridView1.Columns[2].HeaderText = "كلمة السر";
            
            int ID = cL.mIDacc() + 1;
            textBox3.Text = ID.ToString();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLSusres cl = new CLSusres();
            cl.deleacc(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            CLSusres cL = new CLSusres();
            cL.loadacc();
            dataGridView1.DataSource = cL.dtacc;
            dataGridView1.Columns[0].HeaderText = "كود الحساب";
            dataGridView1.Columns[1].HeaderText = "اسم المستخدم";
            dataGridView1.Columns[2].HeaderText = "كلمة السر";
          
            int ID = cL.mIDacc() + 1;
            textBox3.Text = ID.ToString();
        }
    }
}
