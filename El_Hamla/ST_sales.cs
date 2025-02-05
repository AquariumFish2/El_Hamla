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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class ST_sales : Form
    {
        public ST_sales()
        {
            InitializeComponent();
            CLSsales cL = new CLSsales();
            int ID = cL.mIDsaless() + 1;
            textBox7.Text = ID.ToString();
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

        private void sales_Load(object sender, EventArgs e)
        {
            tcash.Text = "نقدي";
            textBox18.Text = dateTimePicker1.Text;
            textBox14.Text = comboBox10.Text;
            textBox15.Text = comboBox1.Text;
            textBox16.Text = comboBox2.Text;

            //********************************************** pro combooooooooooo *************************************************
            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");




            SqlCommand cmd_pro = new SqlCommand("Select Id_pro,product_name from product_table", cn);
            SqlDataAdapter da_pro = new SqlDataAdapter();
            da_pro.SelectCommand = cmd_pro;
            DataTable dt_pro = new DataTable();
            da_pro.Fill(dt_pro);
            DataRow dr_pro = dt_pro.NewRow();
            dr_pro[1] = "";
            dt_pro.Rows.InsertAt(dr_pro, 0);



            com_name.DataSource = dt_pro;
            com_name.DisplayMember = "product_name";
            com_name.ValueMember = "Id_pro";
            com_name.SelectedIndex = 0;


            //********************************************** Acc combo *************************************************
          
            SqlCommand cmd_a = new SqlCommand("Select id_acc,acc_name,percentage from acc_table", cn);
            SqlDataAdapter da_acc = new SqlDataAdapter();
            da_acc.SelectCommand = cmd_a;
            DataTable dt_acc = new DataTable();
            da_acc.Fill(dt_acc);
     
            comboBox1.DataSource = dt_acc;
            comboBox1.SelectedIndex = 0;
            comboBox1.DisplayMember = "acc_name";
            comboBox1.ValueMember = "percentage";


            //********************************************** receivers combo *************************************************

            SqlCommand cmd_r = new SqlCommand("Select id_re,re_name from receiver_table", cn);
            SqlDataAdapter da_re = new SqlDataAdapter();
            da_re.SelectCommand = cmd_r;
            DataTable dt_re = new DataTable();
            da_re.Fill(dt_re);
            DataRow dr_re = dt_re.NewRow();
            dr_re[1] = "من فضلك أدخل المستلم";
            dt_re.Rows.InsertAt(dr_re, 0);

            comboBox10.DataSource = dt_re;
            comboBox10.DisplayMember = "re_name";
            comboBox10.ValueMember = "id_re";
            comboBox10.SelectedIndex = 0;

            //********************************************** cars combo *************************************************

            SqlCommand cmd_car = new SqlCommand("Select ID_car,car_num from cars_table", cn);
            SqlDataAdapter da_car = new SqlDataAdapter();
            da_car.SelectCommand = cmd_car;
            DataTable dt_car = new DataTable();
            da_car.Fill(dt_car);
          
            comboBox2.DataSource = dt_car;
            comboBox2.DisplayMember = "car_num";
            comboBox2.ValueMember = "ID_car";
            comboBox2.SelectedIndex = 0;

            //******************************************* load s2 ****************************************************
            CLSsales ss2 = new CLSsales();
            ss2.load_s211(Convert.ToInt32(textBox7.Text));
            dvg10.DataSource = ss2.dt_s2;

            dvg10.Columns[0].HeaderText = "أسم الصنف";
            dvg10.Columns[1].HeaderText = "الوحدة";
            dvg10.Columns[2].HeaderText = "السعر";
            dvg10.Columns[3].HeaderText = "الكمية";
            dvg10.Columns[4].HeaderText = "الإجمالي";
            dvg10.Columns[0].Width = 337;
            dvg10.Columns[1].Width = 156;
            dvg10.Columns[2].Width = 167;
            dvg10.Columns[3].Width = 160;
            dvg10.Columns[4].Width = 140;

            dvg10.ColumnHeadersVisible = false;
            dvg10.RowHeadersVisible = false;



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox14.Text = comboBox10.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox15.Text = comboBox1.Text;

            textBox8.Text = comboBox1.SelectedValue.ToString();
            try
            {
                decimal c = (Convert.ToDecimal(textBox12.Text) * (Convert.ToDecimal(textBox8.Text) / 100)) + Convert.ToDecimal(textBox12.Text);
                textBox3.Text = Convert.ToString(string.Format("{0:N1}", c));


            }
            catch
            {
                textBox3.Text = "0";
            }

            try
            {

                decimal b = Convert.ToDecimal(textBox3.Text) * Convert.ToDecimal(textBox4.Text);

                textBox5.Text = Convert.ToString(string.Format("{0:N1}", b));


            }
            catch
            {
                textBox4.Text = "0";
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox15.Text = comboBox1.Text;

            textBox8.Text = comboBox1.SelectedValue.ToString();
            try
            {
                decimal c = (Convert.ToDecimal(textBox12.Text) * (Convert.ToDecimal(textBox8.Text) / 100)) + Convert.ToDecimal(textBox12.Text);
                textBox3.Text = Convert.ToString(string.Format("{0:N1}", c));


            }
            catch
            {
                textBox3.Text = "0";
            }

            try
            {

                decimal b = Convert.ToDecimal(textBox3.Text) * Convert.ToDecimal(textBox4.Text);

                textBox5.Text = Convert.ToString(string.Format("{0:N1}", b));


            }
            catch
            {
                textBox4.Text = "0";
            }

            CLSsales CARLOO = new CLSsales();
            CARLOO.loocar(comboBox2.Text);
            dvg_car.DataSource = CARLOO.dtloo;

            dvg_car.Columns[0].HeaderText = "أسم الصنف";
            dvg_car.Columns[1].HeaderText = "الجهة";
            textBox11.Text = dvg_car.Rows[0].Cells[0].Value.ToString();
            textBox19.Text = dvg_car.Rows[0].Cells[1].Value.ToString();



            textBox16.Text = comboBox2.Text;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                com_name.Visible = false;
                com_bar.Visible = true;

            }
            else
            {
                com_name.Visible = true;
                com_bar.Visible = false;
            }



        }

        private void com_name_Enter(object sender, EventArgs e)
        {

           

        }
        public DataTable dt_u_p = new DataTable();
        private void com_name_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void com_name_SelectedValueChanged(object sender, EventArgs e)
        {

            textBox4.Text = "";
            textBox4.Focus();
            textBox5.Text = "";
            CLSset.cn.Close();
            textBox2.Text = com_name.SelectedValue.ToString();

            try
            {

                CLSsales u_p = new CLSsales();
                u_p.load_u_p(Convert.ToInt32(textBox2.Text));
                dataGridView1.DataSource = u_p.dt_u_p;
                dataGridView1.Columns[0].HeaderText = "الوحدة";
                dataGridView1.Columns[1].HeaderText = "السعر";
                dataGridView1.Columns[2].HeaderText = "الرصيد";

                textBox2.Text = com_name.SelectedValue.ToString();
                textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                textBox12.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                textBox6.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();


            }
            catch
            {
                textBox2.Text = "0";


            }
            try
            {
                decimal c = (Convert.ToDecimal(textBox12.Text) * (Convert.ToDecimal(textBox8.Text) / 100)) + Convert.ToDecimal(textBox12.Text);
                textBox3.Text = Convert.ToString(string.Format("{0:N1}", c));


            }
            catch
            {
                textBox3.Text = "0";
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            try
            {
                decimal a = Convert.ToDecimal(textBox6.Text) - Convert.ToDecimal(textBox4.Text);
                decimal b = Convert.ToDecimal(textBox3.Text) * Convert.ToDecimal(textBox4.Text);

                textBox13.Text = Convert.ToString(string.Format("{0:N1}", a));
                textBox5.Text = Convert.ToString(string.Format("{0:N1}", b));


            }
            catch
            {
                textBox4.Text = "0";
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            CLSsales cL = new CLSsales();
            cL.insert_sales1(Convert.ToInt32(textBox7.Text), Convert.ToDateTime(textBox18.Text), textBox14.Text, textBox15.Text, textBox16.Text, textBox11.Text, textBox19.Text, Convert.ToDecimal(textBox17.Text), tcash.Text);
            MessageBox.Show("تمت الاضافة بنجاح");
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox18.Text = dateTimePicker1.Text;

        }
        //**********************************************************************************   اضافة  صنف لجدول الاصناف *************************************       
        private void button4_Click(object sender, EventArgs e)
        {



            try
            {
                CLSsales cL = new CLSsales();
            cL.insert_sales2(Convert.ToInt32(textBox7.Text), com_name.Text, textBox1.Text, Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text));


            cL.load_s211(Convert.ToInt32(textBox7.Text));
            dvg10.DataSource = cL.dt_s2;

            dvg10.Columns[0].HeaderText = "أسم الصنف";
            dvg10.Columns[1].HeaderText = "الوحدة";
            dvg10.Columns[2].HeaderText = "السعر";
            dvg10.Columns[3].HeaderText = "الكمية";
            dvg10.Columns[4].HeaderText = "الإجمالي";
            dvg10.ColumnHeadersVisible = false;
            dvg10.RowHeadersVisible = false;
            dvg10.Columns[0].Width = 337;
            dvg10.Columns[1].Width = 156;
            dvg10.Columns[2].Width = 167;
            dvg10.Columns[3].Width = 160;
            dvg10.Columns[4].Width = 140;


            //*************************************************** الأجمالي *********************************************************************

            decimal sum = 0;
            for (int i = 0; i < dvg10.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dvg10.Rows[i].Cells[4].Value);
            }
            textBox17.Text = sum.ToString();
            //*************************************************** تحديث صنف **************************************************************
            CLSbuying cl = new CLSbuying();
            cl.update_pro(Convert.ToInt32(textBox2.Text), Convert.ToDecimal(textBox13.Text));
            textBox13.Text = "";
            textBox4.Text = "";
            textBox4.Focus();
            textBox5.Text = "";
            }
            catch
            {
                MessageBox.Show(" أدخل بيانات الصنف كاملة");
            }





        }


        //**********************************************************************************   حذف  صنف من جدول الاصناف *************************************     

        private void button6_Click(object sender, EventArgs e)
        {
            CLSsales cl = new CLSsales();
            try
            {
                string proo = dvg10.CurrentRow.Cells[0].Value.ToString();
                cl.delete_row_s2(proo);
                cl.load_s211(Convert.ToInt32(textBox7.Text));
                dvg10.DataSource = cl.dt_s2;

                dvg10.Columns[0].HeaderText = "أسم الصنف";
                dvg10.Columns[1].HeaderText = "الوحدة";
                dvg10.Columns[2].HeaderText = "السعر";
                dvg10.Columns[3].HeaderText = "الكمية";
                dvg10.Columns[4].HeaderText = "الإجمالي";
                dvg10.ColumnHeadersVisible = false;
                dvg10.RowHeadersVisible = false;
                dvg10.Columns[0].Width = 337;
                dvg10.Columns[1].Width = 156;
                dvg10.Columns[2].Width = 167;
                dvg10.Columns[3].Width = 160;
                dvg10.Columns[4].Width = 140;

            }
            catch
            {
                MessageBox.Show("لا يوجد أصناف لحذفها ");

            }
            textBox4.Text = "";
            textBox4.Focus();
            textBox5.Text = "";



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                tcash.Text = "آجل";

            }
            else
            {
                tcash.Text = "نقدي";
            }

        }

       
    }
}
