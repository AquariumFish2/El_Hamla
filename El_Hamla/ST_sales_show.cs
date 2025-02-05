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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class ST_sales_show : Form
    {
        public ST_sales_show()
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


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sales_show_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            com.Enabled = false;
            comboBox1.Enabled = false;


            //**********************************************load buying1 11 111 1 1 *************************************************

            CLSsales pro = new CLSsales();
            pro.load_s1();
            dvg10.DataSource = pro.dt_s1;
            dvg10.Columns[0].HeaderText = "رقم الفاتورة";
            dvg10.Columns[1].HeaderText = "تاريخ الفاتورة";
            dvg10.Columns[2].HeaderText = "اسم المشتري";
            dvg10.Columns[3].HeaderText = "نوع الحساب";
            dvg10.Columns[4].HeaderText = "رقم السيارة";
            dvg10.Columns[5].HeaderText = "نوع السيارة";
            dvg10.Columns[6].HeaderText = "الإجمالي";
            dvg10.Columns[7].HeaderText = "طريقة الدفع";
            //*******************************************************************************************************************
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                com.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                com.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void com_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = com.Text;
            if (textBox1.Text == "اسم المستلم")
            {
                SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
                SqlCommand cmd_r = new SqlCommand("Select id_re,re_name from receiver_table", cn);
                SqlDataAdapter da_re = new SqlDataAdapter();
                da_re.SelectCommand = cmd_r;
                DataTable dt_re = new DataTable();
                da_re.Fill(dt_re);
                DataRow dr_re = dt_re.NewRow();
                dr_re[1] = "";
                dt_re.Rows.InsertAt(dr_re, 0);

                comboBox1.DataSource = dt_re;
                comboBox1.DisplayMember = "re_name";
                comboBox1.ValueMember = "id_re";
                comboBox1.SelectedIndex = 0;

            }
            else if (textBox1.Text == "نوع الحساب")
            {
                SqlConnection cn = new SqlConnection(@"Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
                SqlCommand cmd_a = new SqlCommand("Select id_acc,acc_name,percentage from acc_table", cn);
                SqlDataAdapter da_acc = new SqlDataAdapter();
                da_acc.SelectCommand = cmd_a;
                DataTable dt_acc = new DataTable();
                da_acc.Fill(dt_acc);
                DataRow dr_acc = dt_acc.NewRow();
                dr_acc[1] = "";
                dt_acc.Rows.InsertAt(dr_acc, 0);

                comboBox1.DataSource = dt_acc;
                comboBox1.SelectedIndex = 0;
                comboBox1.DisplayMember = "acc_name";
                comboBox1.ValueMember = "percentage";


            }
            else if (textBox1.Text == "رقم السيارة")
            {

                SqlConnection cn = new SqlConnection(@"Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
                SqlCommand cmd_car = new SqlCommand("Select ID_car,car_num,car_name from cars_table", cn);
                SqlDataAdapter da_car = new SqlDataAdapter();
                da_car.SelectCommand = cmd_car;
                DataTable dt_car = new DataTable();
                da_car.Fill(dt_car);
                DataRow dr_car = dt_car.NewRow();
                dr_car[1] = "";
                dt_car.Rows.InsertAt(dr_car, 0);

                comboBox1.DataSource = dt_car;
                comboBox1.DisplayMember = "car_num";
                comboBox1.ValueMember = "car_name";
                comboBox1.SelectedIndex = 0;

            }
            else if (textBox1.Text == "نوع السيارة")
            {







            }



        }
    }
}
