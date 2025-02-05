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

namespace El_Hamla
{
    public partial class buying_show : Form
    {
        public buying_show()
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


        private void buying_show_Load(object sender, EventArgs e)
        {

            checkBox1.Checked = true;
            com_buyer.Enabled = false;
            //********************************************** buyer combo *************************************************
            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_b = new SqlCommand("Select id_buyer,buyer_name from buyer_table", cn);
            SqlDataAdapter da_b = new SqlDataAdapter();
            da_b.SelectCommand = cmd_b;
            DataTable dt_b = new DataTable();
            da_b.Fill(dt_b);
            DataRow dr_b = dt_b.NewRow();
            dr_b[1] = "من فضلك أدخل المشتري";
            dt_b.Rows.InsertAt(dr_b, 0);

            com_buyer.DataSource = dt_b;
            com_buyer.DisplayMember = "buyer_name";
            com_buyer.ValueMember = "id_buyer";
            com_buyer.SelectedIndex = 0;

            //********************************************** load buying 111111 *************************************************

            CLSbuying pro = new CLSbuying();
            pro.loadb1();
            dvg10.DataSource = pro.dtb1;
            dvg10.Columns[0].HeaderText = "رقم الفاتورة";
            dvg10.Columns[1].HeaderText = "تاريخ الفاتورة";
            dvg10.Columns[2].HeaderText = "اسم المشتري";
            dvg10.Columns[3].HeaderText = "الإجمالي";






        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvg10_Click(object sender, EventArgs e)
        {

        }

        private void dvg10_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ST_buying_detail frm = new ST_buying_detail();
            frm.buying_code.Text = dvg10.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {

                CLSbuying sea = new CLSbuying();
                sea.Sea_date(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
                dvg10.DataSource = sea.dtsea;
                dvg10.Columns[0].HeaderText = "رقم الفاتورة";
                dvg10.Columns[1].HeaderText = "تاريخ الفاتورة";
                dvg10.Columns[2].HeaderText = "اسم المشتري";
                dvg10.Columns[3].HeaderText = "الإجمالي";


            }
            else
            {
                CLSbuying sea2 = new CLSbuying();
                sea2.Sea_date2(com_buyer.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
                dvg10.DataSource = sea2.dtsea2;
                dvg10.Columns[0].HeaderText = "رقم الفاتورة";
                dvg10.Columns[1].HeaderText = "تاريخ الفاتورة";
                dvg10.Columns[2].HeaderText = "اسم المشتري";
                dvg10.Columns[3].HeaderText = "الإجمالي";




            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                com_buyer.Enabled = true;

            }
            else
            {
                com_buyer.Enabled = false;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            buying_show f = new buying_show();
            f.ShowDialog();   
        }
    }
}
