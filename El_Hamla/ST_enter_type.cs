using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class ST_enter_type : Form
    {
        public ST_enter_type()
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
            cL.insert_type(Convert.ToInt32(textBox1.Text), textBox2.Text);
            MessageBox.Show("تمت الاضافة بنجاح");
            this.Close();
        }

        private void enter_type_Load(object sender, EventArgs e)
        {
            CLSproduct cLSproduct = new CLSproduct();
            int ID = cLSproduct.mIDtypee() + 1;
            textBox1.Text = ID.ToString();
        }
    }
}
