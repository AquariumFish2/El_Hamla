using DevExpress.Office.Utils;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class add_pro_for_2mr : Form
    {
        public add_pro_for_2mr()
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

        private void add_pro_for_2mr_Load(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_k = new SqlCommand("Select id,car_fix_kind from car_fix_kind_table ", cn);
            SqlDataAdapter da_k = new SqlDataAdapter();
            da_k.SelectCommand = cmd_k;
            DataTable dt_k = new DataTable();
            da_k.Fill(dt_k);
            DataRow dr_k = dt_k.NewRow();
            dr_k[1] = "";
            dt_k.Rows.InsertAt(dr_k, 0);


            comboBox2.DataSource = dt_k;
            comboBox2.DisplayMember = "car_fix_kind";
            comboBox2.ValueMember = "id";
            CLSset.cn.Close();
            CLSwork cL = new CLSwork();
            cL.load_amr2_by_id(Convert.ToInt32(amr_code_1.Text));
            dvg10.DataSource = cL.dtamr2_id;

            dvg10.Columns[0].HeaderText = "أسم الصنف";
            dvg10.Columns[1].HeaderText = "الكمية";

            dvg10.ColumnHeadersVisible = false;
            dvg10.RowHeadersVisible = false;


            cL.load_car_fix_kind_id(Convert.ToInt32(amr_code_1.Text));
            dataGridView1.DataSource = cL.dtcar_fix_kind_id;

            dataGridView1.Columns[0].HeaderText = "أسم الصنف";
            dataGridView1.Columns[1].HeaderText = "الكمية";
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            CLSwork cl = new CLSwork();
            try
            {
                string proo = dvg10.CurrentRow.Cells[0].Value.ToString();
                cl.delete_row_amr2(proo);
                cl.load_amr2_by_id(Convert.ToInt32(amr_code_1.Text));
                dvg10.DataSource = cl.dtamr2_id;

                dvg10.Columns[0].HeaderText = "أسم الصنف";
                dvg10.Columns[1].HeaderText = "الوحدة";

                dvg10.ColumnHeadersVisible = false;
                dvg10.RowHeadersVisible = false;


            }
            catch
            {
                MessageBox.Show("لا يوجد أصناف لحذفها ");

            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            try
            {
                CLSwork cL = new CLSwork();
                cL.insert_amr22(Convert.ToInt32(amr_code_1.Text), textBox1.Text, Convert.ToDecimal(textBox3.Text));


                cL.load_amr2_by_id(Convert.ToInt32(amr_code_1.Text));
                dvg10.DataSource = cL.dtamr2_id;

                dvg10.Columns[0].HeaderText = "أسم الصنف";


                dvg10.Columns[1].HeaderText = "الكمية";

                dvg10.ColumnHeadersVisible = false;
                dvg10.RowHeadersVisible = false;


            }
            catch
            {
                MessageBox.Show(" أدخل بيانات الصنف كاملة");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            textBox3.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            try
            {
                CLSwork cL = new CLSwork();
                cL.insert_car_fix_kind(Convert.ToInt32(amr_code_1.Text), comboBox2.Text, textBox2.Text);


                cL.load_car_fix_kind_id(Convert.ToInt32(amr_code_1.Text));
                dataGridView1.DataSource = cL.dtcar_fix_kind_id;

                dataGridView1.Columns[0].HeaderText = "أسم الصنف";
                dataGridView1.Columns[1].HeaderText = "الكمية";

                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.RowHeadersVisible = false;
                if(textBox2.Text=="" || comboBox2.Text=="")
                {
                    MessageBox.Show(" أدخل نوع الإصلاح و العدد");
                }

            }
            catch
            {
                MessageBox.Show(" أدخل نوع الإصلاح و العدد");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            CLSwork cl = new CLSwork();
            try
            {
                string proo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cl.delete_row_car_fix_kind(proo);
                cl.load_car_fix_kind_id(Convert.ToInt32(amr_code_1.Text));
                dataGridView1.DataSource = cl.dtcar_fix_kind_id;

                dataGridView1.Columns[0].HeaderText = "أسم الصنف";
                dataGridView1.Columns[1].HeaderText = "الكمية";

                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.RowHeadersVisible = false;

            }
            catch
            {
                MessageBox.Show("لا يوجد أصناف لحذفها ");

            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
        }
    }
}
