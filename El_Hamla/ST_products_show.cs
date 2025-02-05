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
    public partial class ST_products_show : Form
    {
        public ST_products_show()
        {
            InitializeComponent();
            CLSproduct pro = new CLSproduct();
            pro.loadproducts();
            dvg.DataSource = pro.dtproducts;
            dvg.Columns[0].HeaderText = "رقم الصنف";
            dvg.Columns[1].HeaderText = "اسم الصنف";
            dvg.Columns[2].HeaderText = "الباركود";
            dvg.Columns[3].HeaderText = "الفئة";
            dvg.Columns[4].HeaderText = "الوحدة";
            dvg.Columns[5].HeaderText = "جهة الشراء";
            dvg.Columns[6].HeaderText = "الموديل";
            dvg.Columns[7].HeaderText = "السعر";
            dvg.Columns[8].HeaderText = "رصيد المخزن";
            dvg.Columns[9].HeaderText = "نوع السيارة";
            dvg.Columns[10].HeaderText = "رقم السيارة";
            dvg.Columns[11].Visible = false;

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

        private void products_show_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
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
            //**********************************************************************************************
            SqlCommand cmd_a = new SqlCommand("Select id_mo,mo_name from _MO_table", cn);
            SqlDataAdapter da_badd = new SqlDataAdapter();
            da_badd.SelectCommand = cmd_a;
            DataTable dt_badd = new DataTable();
            da_badd.Fill(dt_badd);
            DataRow dr_badd = dt_badd.NewRow();
            dr_badd[1] = "من فضلك أدخل الجهة";
            dt_badd.Rows.InsertAt(dr_badd, 0);

            comboBox2.DataSource = dt_badd;
            comboBox2.DisplayMember = "mo_name";
            comboBox2.ValueMember = "id_mo";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
