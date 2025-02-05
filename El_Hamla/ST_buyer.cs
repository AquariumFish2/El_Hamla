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
    public partial class ST_buyer : Form
    {
        public ST_buyer()
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

        private void buyer_Load(object sender, EventArgs e)
        {
            CLSbuyer cL = new CLSbuyer();
            int ID = cL.mIDbuyere() + 1;
            textBox1.Text = ID.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLSbuyer cL = new CLSbuyer();
            cL.insert_receivers(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text);
            MessageBox.Show("تمت الاضافة بنجاح");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.Text;
        }
    }
}
