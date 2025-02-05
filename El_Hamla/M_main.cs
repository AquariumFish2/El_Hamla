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
    public partial class M_main : Form
    {
        public M_main()
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
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            M_ezn_show m_Ezn_Show = new M_ezn_show();
            m_Ezn_Show.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            M_reports_choose fff = new M_reports_choose();
            fff.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            M_acc mmmmmmmm=new M_acc();
            mmmmmmmm.ShowDialog();

        }

        private void M_main_Load(object sender, EventArgs e)
        {

        }

        private void M_main_MouseMove(object sender, MouseEventArgs e)
        {
            CLSset.cn.Close();
            CLSezn ezn = new CLSezn();
            ezn.load_ezn1_status();
            dvg10.DataSource = ezn.dt_ezn_status;
            dvg10.Columns[0].HeaderText = "رقم الأذن";
            textBox1.Text = dvg10.Rows.Count.ToString();


            ezn.load_ezn1_status22();
            dataGridView1.DataSource = ezn.dt_ezn_status22;
            dataGridView1.Columns[0].HeaderText = "رقم الأذن";
            textBox2.Text = dataGridView1.Rows.Count.ToString();
            if (dataGridView1.Rows.Count == 0)
            {

                textBox2.ForeColor = Color.White;


            }
            else
            {
                textBox2.ForeColor = Color.Red;

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            M_amr_work_show f = new M_amr_work_show();  
            f.ShowDialog();

        }
    }
}
