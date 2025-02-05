using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class ST_buying : Form
    {
        public ST_buying()
        {
            InitializeComponent();
            CLSbuying cL = new CLSbuying();
            int ID = cL.mIDbuyingg() + 1;
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

        private void buying_Load(object sender, EventArgs e)
        {
            textBox18.Text = dateTimePicker1.Text;
            textBox14.Text = com_buyer.Text;
            textBox3.Text = "0";

            //********************************************** com name *************************************************
            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_pro = new SqlCommand("Select Id_pro,product_name,unit,price from product_table", cn);
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


            //********************************************** buyer combo *************************************************
          
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



            //******************************************* load b2 ****************************************************
            CLSbuying bb2 = new CLSbuying();
            bb2.load_b211(Convert.ToInt32(textBox7.Text));
            dvg10.DataSource = bb2.dt_b2;

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox14.Text = com_buyer.Text;
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

        
        public DataTable dt_u_p = new DataTable(); 
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
                dataGridView1.Columns[3].HeaderText = "اسم الصنف";
                dataGridView1.Columns[4].HeaderText = "كود الصنف";

                textBox2.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                textBox6.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();


            }
            catch
            {
                textBox2.Text = "0";


            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            try
            {
                decimal a = Convert.ToDecimal(textBox6.Text) + Convert.ToDecimal(textBox4.Text);
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
            CLSbuying cL = new CLSbuying();
            cL.insert_buying1(Convert.ToInt32(textBox7.Text), Convert.ToDateTime(textBox18.Text), textBox14.Text, Convert.ToDecimal(textBox17.Text));
            MessageBox.Show("تمت الاضافة بنجاح");
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox18.Text = dateTimePicker1.Text;

        }
        //************************************************************************* إضافة صف إلى الجدول    *******************************
        private void button4_Click(object sender, EventArgs e)
        {
           try
            {
                

                CLSbuying cL = new CLSbuying();
                //cL.insert_buying2(Convert.ToInt32(textBox7.Text), com_name.Text, textBox1.Text, Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text));


                cL.load_b211(Convert.ToInt32(textBox7.Text));
                dvg10.DataSource = cL.dt_b2;

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

                decimal sum = 0;
                for (int i = 0; i < dvg10.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dvg10.Rows[i].Cells[4].Value);
                }
                textBox17.Text = sum.ToString();
                //******************************************************* تحديث قيمة الأصناف ******************************************
                cL.update_pro(Convert.ToInt32(textBox2.Text), Convert.ToDecimal(textBox13.Text));
                textBox13.Text = "";
                textBox4.Text = "";
                textBox4.Focus();
                textBox5.Text = "";
            }
            catch 
            {
                MessageBox.Show(" أدخل بيانات الصنف كاملة");            
            }

            //******************************************************* تحديث قيمة الأصناف ******************************************
         
           
            try
            {

                CLSsales u_p = new CLSsales();
                u_p.load_u_p(Convert.ToInt32(textBox2.Text));
                dataGridView1.DataSource = u_p.dt_u_p;
                dataGridView1.Columns[0].HeaderText = "الوحدة";
                dataGridView1.Columns[1].HeaderText = "السعر";
                dataGridView1.Columns[2].HeaderText = "الرصيد";
                dataGridView1.Columns[3].HeaderText = "اسم الصنف";
                dataGridView1.Columns[4].HeaderText = "كود الصنف";

                textBox2.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                textBox6.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();


            }
            catch
            {
                textBox2.Text = "0";


            }


        }






        //************************************************************************* حذف صف من الجدول    *******************************
        private void button6_Click(object sender, EventArgs e)
        {
         
            try
            {
                textBox8.Text = dvg10.SelectedRows[0].Cells[0].Value.ToString();



                CLSbuying u_p = new CLSbuying();
                u_p.load_u_p2(textBox8.Text);
                dataGridView2.DataSource = u_p.dt_u_p2;
                dataGridView2.Columns[0].HeaderText = "الوحدة";
                dataGridView2.Columns[1].HeaderText = "السعر";
                dataGridView2.Columns[2].HeaderText = "الرصيد";
                dataGridView2.Columns[3].HeaderText = "اسم الصنف";
                dataGridView2.Columns[4].HeaderText = "كود الصنف";

                textBox15.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                textBox12.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();

                CLSbuying cl = new CLSbuying();


                decimal quant = Convert.ToDecimal(dvg10.CurrentRow.Cells[3].Value);
                decimal a = Convert.ToDecimal(textBox12.Text) - quant;


                textBox11.Text = Convert.ToString(string.Format("{0:N1}", a));
                string proo = dvg10.CurrentRow.Cells[0].Value.ToString();
               // cl.delete_row_b2(proo);
                cl.load_b211(Convert.ToInt32(textBox7.Text));
                dvg10.DataSource = cl.dt_b2;

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
                //******************************************************* تحديث قيمة الأصناف ******************************************

                cl.update_pro(Convert.ToInt32(textBox15.Text), Convert.ToDecimal(textBox11.Text));
                decimal sum = 0;
                for (int i = 0; i < dvg10.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dvg10.Rows[i].Cells[4].Value);
                }
                textBox17.Text = sum.ToString();


            }
            catch
            {
                MessageBox.Show("لا يوجد أصناف لحذفها ");

            }




        }

        

        
    }
}
