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
    public partial class ___cars : Form
    {
        public ___cars()
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

        private void cars_Load(object sender, EventArgs e)
        {
            CLScars cL = new CLScars();
            int ID = cL.mIDcarr() + 1;
            textBox1.Text = ID.ToString();
            textBox5.Text = dateTimePicker1.Text;
           
            textBox7.Text = "لم يتم تسليم السيارة بعد";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLScars cL = new CLScars();
            cL.insert_cars(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text,Convert.ToDateTime(textBox5.Text), textBox7.Text);
            MessageBox.Show("تمت الاضافة بنجاح");
            this.Close();
        }

        private void dateTimePicker1_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker1.Text;
        }
    }
}
