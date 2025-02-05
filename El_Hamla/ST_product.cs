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
    public partial class ST_product : Form
    {
        public ST_product()
        {
            InitializeComponent();

            //*********************************************************

            CLSproduct cLSproduct = new CLSproduct();
            decimal bar = cLSproduct.maxbarcode() + 1;
            textBox3.Text = bar.ToString();

            //*********************************************************

            int ID = cLSproduct.maxID() + 1;
            textBox1.Text = ID.ToString();
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
            CLSset.cn.Close();
            this.Close();
        }

        private void product_Load(object sender, EventArgs e)
        {
            textBox7.Text = "";
            //***********************************************************************************************************
            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_u = new SqlCommand("Select ID_unit,Unit from Unit_table", cn);
            SqlDataAdapter da_unit = new SqlDataAdapter();
            da_unit.SelectCommand = cmd_u;
            DataTable dt_unit = new DataTable();
            da_unit.Fill(dt_unit);
            DataRow dr_unit = dt_unit.NewRow();
            dr_unit[1] = "من فضلك أدخل الوحدة";
            dt_unit.Rows.InsertAt(dr_unit, 0);

            comboBox2.DataSource = dt_unit;
            comboBox2.DisplayMember = "unit";
            comboBox2.ValueMember = "ID_unit";
            textBox7.Text = "";
            //**********************************************************************************************************
            SqlCommand cmd_t = new SqlCommand("Select ID_type,Type from Type_table", cn);
            SqlDataAdapter da_type = new SqlDataAdapter();
            da_type.SelectCommand = cmd_t;
            DataTable dt_type = new DataTable();
            da_type.Fill(dt_type);
            DataRow dr_type = dt_type.NewRow();
            dr_type[1] = "من فضلك أدخل الفئة";
            dt_type.Rows.InsertAt(dr_type, 0);

            comboBox1.DataSource = dt_type;
            comboBox1.DisplayMember = "Type";
            comboBox1.ValueMember = "ID_type";
            textBox7.Text = "";
            //*******************************************************************************************************
            SqlCommand cmd_mo = new SqlCommand(@"Select id_mo,mo_name from _MO_table WHERE acc_type='مورد' ", cn);
            SqlDataAdapter da_mo = new SqlDataAdapter();
            da_mo.SelectCommand = cmd_mo;
            DataTable dt_mo = new DataTable();
            da_mo.Fill(dt_mo);
            DataRow dr_mo = dt_mo.NewRow();
            dr_mo[1] = "من فضلك أدخل المورد أو الجهة";
            dt_mo.Rows.InsertAt(dr_mo, 0);

            comboBox10.DataSource = dt_mo;
            comboBox10.DisplayMember = "mo_name";
            comboBox10.ValueMember = "id_mo";
            textBox7.Text = "";
            //*******************************************************************************************************
            SqlCommand cmd_c_k = new SqlCommand("Select id_cars_combo,cars_combo_name from cars_combo_table", cn);
            SqlDataAdapter da_c_k = new SqlDataAdapter();
            da_c_k.SelectCommand = cmd_c_k;
            DataTable dt_c_k = new DataTable();
            da_c_k.Fill(dt_c_k);
            DataRow dr_c_k = dt_c_k.NewRow();
            dr_c_k[1] = "";
            dt_c_k.Rows.InsertAt(dr_c_k, 0);

            comboBox3.DataSource = dt_c_k;
            comboBox3.DisplayMember = "cars_combo_name";
            comboBox3.ValueMember = "id_cars_combo";
            textBox7.Text = "";
            //*******************************************************************************************************
            SqlCommand cmd_car = new SqlCommand(@"Select distinct car_num from amr_work where car_status='لم يتم التسليم بعد' ", cn);
            SqlDataAdapter da_car = new SqlDataAdapter();
            da_car.SelectCommand = cmd_car;
            DataTable dt_car = new DataTable();
            da_car.Fill(dt_car);
          



            comboBox4.DataSource = dt_car;
            comboBox4.DisplayMember = "car_num";
            comboBox4.ValueMember = "car_num";
            textBox7.Text = "";



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tex3.Text = comboBox2.Text;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tex2.Text = comboBox10.Text;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                CLSset.cn.Close();
                CLSproduct cL = new CLSproduct();
                cL.insert_pro(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToDecimal(textBox3.Text), tex1.Text, tex2.Text, tex3.Text, textBox6.Text, Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox8.Text), textBox4.Text, textBox7.Text,"");
                MessageBox.Show("تمت الاضافة بنجاح");
                this.Close();
                CLSset.cn.Close();  
            
            
            }
            catch { MessageBox.Show("أدخل البيانات بشكل صحيح"); }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox4.Enabled = true;
                textBox7.Text = comboBox4.Text;
            }
            else
            {
                
                comboBox4.Enabled = false;
                textBox7.Text = "";
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "قطع غيار ")
            {
                comboBox3.Enabled = true;
                textBox4.Text = comboBox3.Text;
            }
            else
            {
                comboBox3.Enabled = false;
                textBox4.Text = "";
            }
            tex1.Text = comboBox1.Text;

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox4.Text = comboBox3.Text;

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox7.Text = comboBox4.Text;
        }
    }
}
