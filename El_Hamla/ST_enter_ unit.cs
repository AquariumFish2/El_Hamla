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
    public partial class enter__unit : Form
    {
        public enter__unit()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLSproduct cL = new CLSproduct();
            cL.insert_unit(Convert.ToInt32(textBox1.Text), textBox2.Text);
            MessageBox.Show("تمت الاضافة بنجاح");
            this.Close();
        }

        private void enter__unit_Load(object sender, EventArgs e)
        {
            CLSproduct cLSproduct = new CLSproduct();
            int ID = cLSproduct.mIDunitt() + 1;
            textBox1.Text = ID.ToString();
        }
    }
}
