using FastReport.DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class AA_reb7 : Form
    {
        public AA_reb7()
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

        private void AA_reb7_Load(object sender, EventArgs e)
        {



            //***********************************************************************************************************
            CLS_AA_pro cLS = new CLS_AA_pro();
            cLS.loadProjects2(Convert.ToInt32(textBox3.Text));
            dataGridView1.DataSource = cLS.dtProject2;

            cLS.loadProjectsid1(Convert.ToInt32(textBox3.Text));
            dataGridView2.DataSource = cLS.dtProjectid1;

            //***********************************************************************************************************
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // تحقق من محتوى العمود الثاني
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == "ممول")
                {
                    // اذا كانت الكلمة "ممول" موجودة في العمود الثاني, اضف القيمة من العمود الاول الى كمبو بوكس
                    comboBox1.Items.Add(row.Cells[0].Value.ToString());
                }
            }

            // في حالة كانت الكمبو بوكس تحتوي على عنصر واحد فقط، قم باختياره تلقائيا
            if (comboBox1.Items.Count == 1)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedValue = comboBox1.SelectedItem.ToString();

                // البحث في الداتا جريد فيو للحصول على القيمة المناسبة من العمود الثالث
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // التحقق من أن القيمة في العمود الأول تتطابق مع القيمة المختارة من الكمبو بوكس
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == selectedValue)
                    {
                        // وضع قيمة العمود الثالث في التكست بوكس
                        textBox1.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                        break;
                    }
                }
            }
        }
        





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
