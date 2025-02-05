using DevExpress.DataProcessing.InMemoryDataProcessor;
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
using static El_Hamla.CLSusres;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class _perchasing : Form
    {
        DataTable dt_pro;
        DataTable dt_car;
        public _perchasing()
        {
            InitializeComponent();
            CLSbuying cL = new CLSbuying();
            int ID = cL.mIDbuyingg() + 1;
            textBox1.Text = ID.ToString();
            //*******************************************************
            CLSproduct cLSproduct = new CLSproduct();
            decimal bar = cLSproduct.maxbarcode() + 1;
            textBox4.Text = bar.ToString();
            int ID2 = cLSproduct.maxID() + 1;
            textBox3.Text = ID2.ToString();
            //*******************************************************
            CLSezn cm = new CLSezn();
            int ID3 = cm.mIDeznn() + 1;
            textBox5.Text = ID3.ToString();
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

        private void _perchasing_Load(object sender, EventArgs e)
        {
            CLS_perchasing p = new CLS_perchasing();
            p.load_pro_by_proname(searchTextBox.Text, car_sea.Text);
            dataGridView1.DataSource = p.dt_pro_by_proname;

            //------------------------------------------- date --------------------------------------
            textBox2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //------------------------------------------- buyer -------------------------------------

            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_b = new SqlCommand("Select id_buyer,buyer_name from buyer_table", cn);
            SqlDataAdapter da_b = new SqlDataAdapter();
            da_b.SelectCommand = cmd_b;
            DataTable dt_b = new DataTable();
            da_b.Fill(dt_b);


            com_buyer.DataSource = dt_b;
            com_buyer.DisplayMember = "buyer_name";
            com_buyer.ValueMember = "id_buyer";
            com_buyer.SelectedIndex = 0;
            //------------------------------------------- car num -------------------------------------

            SqlCommand cmd_car = new SqlCommand("Select distinct car_num from amr_work where car_status='لم يتم التسليم بعد' ", cn);
            SqlDataAdapter da_car = new SqlDataAdapter();
            da_car.SelectCommand = cmd_car;
            dt_car = new DataTable();
            da_car.Fill(dt_car);
            //------------------------------------------- product name -------------------------------------

            SqlCommand cmd_pro = new SqlCommand("Select distinct product_name from product_table", cn);
            SqlDataAdapter da_pro = new SqlDataAdapter();
            da_pro.SelectCommand = cmd_pro;
            dt_pro = new DataTable();
            da_pro.Fill(dt_pro);
            //------------------------------------------- unit -------------------------------------
            SqlCommand cmd_u = new SqlCommand("Select ID_unit,Unit from Unit_table", cn);
            SqlDataAdapter da_unit = new SqlDataAdapter();
            da_unit.SelectCommand = cmd_u;
            DataTable dt_unit = new DataTable();
            da_unit.Fill(dt_unit);


            comboBox2.DataSource = dt_unit;
            comboBox2.DisplayMember = "unit";
            comboBox2.ValueMember = "ID_unit";

            //------------------------------------------- type -------------------------------------
            SqlCommand cmd_t = new SqlCommand("Select ID_type,Type from Type_table", cn);
            SqlDataAdapter da_type = new SqlDataAdapter();
            da_type.SelectCommand = cmd_t;
            DataTable dt_type = new DataTable();
            da_type.Fill(dt_type);

            comboBox1.DataSource = dt_type;
            comboBox1.DisplayMember = "Type";
            comboBox1.ValueMember = "ID_type";


            //------------------------------------------- add_perchasing_table -------------------------------------
            SqlCommand cmd_ch = new SqlCommand("Select id_perchasing,perchasing_name from add_perchasing_table", cn);
            SqlDataAdapter da_ch = new SqlDataAdapter();
            da_ch.SelectCommand = cmd_ch;
            DataTable dt_ch = new DataTable();
            da_ch.Fill(dt_ch);
            comboBox5.DataSource = dt_ch;
            comboBox5.DisplayMember = "perchasing_name";
            comboBox5.ValueMember = "id_perchasing";
            //------------------------------------------- add_mo_table -------------------------------------
            SqlCommand cmd_mo = new SqlCommand("Select id_mo,mo_name from _MO_table where acc_type = 'مورد'", cn);
            SqlDataAdapter da_mo = new SqlDataAdapter();
            da_mo.SelectCommand = cmd_mo;
            DataTable dt_mo = new DataTable();
            da_mo.Fill(dt_mo);

            comboBox6.DataSource = dt_mo;
            comboBox6.DisplayMember = "mo_name";
            comboBox6.ValueMember = "id_mo";
            //----------------------------------------- load buying 2222 -------------------------------------
            CLSbuying b = new CLSbuying();

            b.load_b211(Convert.ToInt32(textBox1.Text));
            dvg10.DataSource = b.dt_b2;
            dvg10.DataSource = b.dt_b2;
            dvg10.Columns[0].HeaderText = "رقم العملية";
            dvg10.Columns[1].HeaderText = "اسم قطعة الغيار أو الإصلاح";
            dvg10.Columns[2].HeaderText = "السعر";
            dvg10.Columns[3].HeaderText = "الكمية";
            dvg10.Columns[4].HeaderText = "الإجمالي";
            dvg10.Columns[5].HeaderText = "الوحدة";
            dvg10.Columns[6].HeaderText = "تاريخ العملية";
            dvg10.Columns[7].HeaderText = "جهة الشراء";
            dvg10.Columns[8].HeaderText = "المورد";
            dvg10.Columns[9].HeaderText = "رقم السيارة";
            dvg10.Columns[10].HeaderText = "نوع أمر الشغل";
            dvg10.Columns[11].HeaderText = "رقم أمر الشغل";
            dvg10.Columns[12].HeaderText = "القطعة حجز";
            dvg10.Columns[13].HeaderText = "الفئة";
            dvg10.Columns["id_buying2"].Visible = false;
            dvg10.Columns["buying2_date"].Visible = false;
            dvg10.Columns["buying2_car_num"].Visible = false;
            dvg10.Columns["buying2_work_kind"].Visible = false;
            dvg10.Columns["buying2_work_num"].Visible = false;
            dvg10.Columns["buying2_hagez_type"].Visible = false;
            dvg10.Columns["buying2_pro_type"].DisplayIndex = 2;
            dvg10.Columns["unit_b"].DisplayIndex = 3;

            //****************************************************************************
            decimal sum = 0;
            for (int i = 0; i < dvg10.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dvg10.Rows[i].Cells[4].Value);
            }
            textBox15.Text = sum.ToString();
            //****************************************************************************

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            com_buyer.Text = "";
            textBox12.Text = "غير محجوز";



        }

        private void _perchasing_MouseMove(object sender, MouseEventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            textBox9.Text = CurrentUser.UserName;



        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

            string searchText = searchTextBox.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Filter DataTable based on search text using Contains to match anywhere in the string
                var filteredRows = dt_pro.AsEnumerable()
                                            .Where(row => row.Field<string>("product_name")
                                            .Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                            .Select(row => row.Field<string>("product_name"))
                                            .ToList();

                // Populate the suggestionBox
                if (filteredRows.Any())
                {
                    suggestionBox.Visible = true;
                    suggestionBox.DataSource = filteredRows;
                }
                else
                {
                    suggestionBox.Visible = false;
                }

            }
            else
            {
                suggestionBox.Visible = false;
            }
            CLS_perchasing p = new CLS_perchasing();
            p.load_pro_by_proname(searchTextBox.Text, car_sea.Text);
            dataGridView1.DataSource = p.dt_pro_by_proname;
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    comboBox1.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    comboBox2.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();

                    textBox6.Focus();
                }


            }
            catch
            {



            }



        }
        public void load_dvg10()
        {
            CLSbuying cl = new CLSbuying();
            cl.load_b211(Convert.ToInt32(textBox1.Text));
            dvg10.DataSource = cl.dt_b2;

            dvg10.Columns[0].HeaderText = "رقم العملية";
            dvg10.Columns[1].HeaderText = "اسم قطعة الغيار أو الإصلاح";
            dvg10.Columns[2].HeaderText = "السعر";
            dvg10.Columns[3].HeaderText = "الكمية";
            dvg10.Columns[4].HeaderText = "الإجمالي";
            dvg10.Columns[5].HeaderText = "الوحدة";
            dvg10.Columns[6].HeaderText = "تاريخ العملية";
            dvg10.Columns[7].HeaderText = "جهة الشراء";
            dvg10.Columns[8].HeaderText = "المورد";
            dvg10.Columns[9].HeaderText = "رقم السيارة";
            dvg10.Columns[10].HeaderText = "نوع أمر الشغل";
            dvg10.Columns[11].HeaderText = "رقم أمر الشغل";
            dvg10.Columns[12].HeaderText = "القطعة حجز";
            dvg10.Columns[13].HeaderText = "الفئة";
            dvg10.Columns["id_buying2"].Visible = false;
            dvg10.Columns["buying2_date"].Visible = false;
            dvg10.Columns["buying2_car_num"].Visible = false;
            dvg10.Columns["buying2_work_kind"].Visible = false;
            dvg10.Columns["buying2_work_num"].Visible = false;
            dvg10.Columns["buying2_hagez_type"].Visible = false;
            dvg10.Columns["buying2_pro_type"].DisplayIndex = 2;
            dvg10.Columns["unit_b"].DisplayIndex = 3;
            //****************************************************************************
            decimal sum = 0;
            for (int i = 0; i < dvg10.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dvg10.Rows[i].Cells[4].Value);
            }
            textBox15.Text = sum.ToString();


        }
        public void clean()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            searchTextBox.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            checkBox2.Checked = false;


        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && suggestionBox.Items.Count > 0)
            {
                suggestionBox.Focus();
                suggestionBox.SelectedIndex = 0;
            }
        }

        private void suggestionBox_Click(object sender, EventArgs e)
        {
            if (suggestionBox.SelectedItem != null)
            {
                searchTextBox.Text = suggestionBox.SelectedItem.ToString();
                suggestionBox.Visible = false;
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && suggestionBox.Visible && suggestionBox.Focused)
            {
                CLS_perchasing p = new CLS_perchasing();
                p.load_pro_by_proname(searchTextBox.Text, car_sea.Text);
                dataGridView1.DataSource = p.dt_pro_by_proname;
                try
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        comboBox1.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                        comboBox2.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();





                    }


                }
                catch
                {



                }




                searchTextBox.Text = suggestionBox.SelectedItem.ToString();
                suggestionBox.Visible = false;
                return true;

            }
            if (keyData == Keys.Enter && suggestionBox2.Visible && suggestionBox2.Focused)
            {
                car_sea.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
                return true;
            }



            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (textBox7.Text != "" && textBox6.Text != "")
            {
                decimal b = Convert.ToDecimal(textBox7.Text) * Convert.ToDecimal(textBox6.Text);
                textBox8.Text = Convert.ToString(string.Format("{0:N1}", b));

            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            if (textBox7.Text != "" && textBox6.Text != "")
            {
                decimal b = Convert.ToDecimal(textBox7.Text) * Convert.ToDecimal(textBox6.Text);
                textBox8.Text = Convert.ToString(string.Format("{0:N1}", b));

            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                car_sea.Enabled = true;
                textBox12.Text = "تم الحجز";

            }
            else
            {

                car_sea.Enabled = false;
                textBox12.Text = "غير محجوز";
                car_sea.Text = "";
                comboBox4.Text = "";
                comboBox3.Text = "";


            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

            string searchText = car_sea.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Filter DataTable based on search text using Contains to match anywhere in the string
                var filteredRows = dt_car.AsEnumerable()
                                            .Where(row => row.Field<string>("car_num")
                                            .Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                            .Select(row => row.Field<string>("car_num"))
                                            .ToList();

                // Populate the suggestionBox
                if (filteredRows.Any())
                {
                    suggestionBox2.Visible = true;
                    suggestionBox2.DataSource = filteredRows;
                }
                else
                {
                    suggestionBox2.Visible = false;
                }
            }
            else
            {
                suggestionBox2.Visible = false;
            }
            CLS_perchasing p = new CLS_perchasing();
            p.load_pro_by_proname(searchTextBox.Text, car_sea.Text);
            dataGridView1.DataSource = p.dt_pro_by_proname;
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    comboBox1.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    comboBox2.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();


                }



            }
            catch
            {



            }
            try
            {
                CLSwork u_p = new CLSwork();
                u_p.loadcars_ezn(car_sea.Text);
                dvg_car.DataSource = u_p.dtcar_ezn;

                comboBox3.DataSource = u_p.dtcar_ezn;
                comboBox3.DisplayMember = "work_num";
                comboBox3.SelectedIndex = 0;
                comboBox4.DataSource = u_p.dtcar_ezn;
                comboBox4.DisplayMember = "work_kind";
                comboBox4.SelectedIndex = 0;


                if (dvg_car.Rows.Count > 2)
                {
                    comboBox3.Enabled = true;
                    comboBox4.Enabled = true;

                }
                else
                {
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                }

            }
            catch
            {


            }









        }

        private void suggestionBox2_Click(object sender, EventArgs e)
        {
            if (suggestionBox2.SelectedItem != null)
            {
                car_sea.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
            }

        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && suggestionBox2.Items.Count > 0)
            {
                suggestionBox2.Focus();
                suggestionBox2.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //************************************************************************************************************************
        //************************************************************* زر الإضافة ************************************************
        //************************************************************************************************************************

        
        private void button4_Click(object sender, EventArgs e)

        {
            string user_name = CurrentUser.UserName;
            
            if (comboBox1.Text == "مصنعيات" || comboBox1.Text == "تصليحات")
            {
                if (car_sea.Text == "")
                {
                    MessageBox.Show("يجب ادخال رقم السيارة التي تم تصليحها");
                }
                else
                {
                    try
                    {

                        CLSbuying b = new CLSbuying();
                        b.insert_buying2(Convert.ToInt32(textBox1.Text), searchTextBox.Text, comboBox1.Text, comboBox2.Text, Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDateTime(textBox2.Text), comboBox5.Text, comboBox6.Text, car_sea.Text, comboBox4.Text, comboBox3.Text, textBox12.Text, user_name);

                    }
                    catch { MessageBox.Show(" 1 أدخل كل البيانات بشكل صحيح"); }
                    load_dvg10();
                    clean();
                }
            }
            else
            {

                try
                {
                    CLSbuying b = new CLSbuying();
                    b.insert_buying2(Convert.ToInt32(textBox1.Text), searchTextBox.Text, comboBox1.Text, comboBox2.Text, Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDateTime(textBox2.Text), comboBox5.Text, comboBox6.Text, car_sea.Text, comboBox4.Text, comboBox3.Text, textBox12.Text, user_name);

                }
                catch { MessageBox.Show("أدخل كل البيانات بشكل صحيح 2"); }
                load_dvg10();
                clean();
            }
        }
        //************************************************************************************************************************
        //************************************************************* زر الحذف ************************************************
        //************************************************************************************************************************
        private void button6_Click(object sender, EventArgs e)
        {
            CLSproduct cLSproduct = new CLSproduct();
            decimal bar = cLSproduct.maxbarcode() + 1;
            textBox4.Text = bar.ToString();
            int ID2 = cLSproduct.maxID() + 1;
            textBox3.Text = ID2.ToString();
            CLSbuying cl = new CLSbuying();

            DateTime date = Convert.ToDateTime(dvg10.CurrentRow.Cells[6].Value.ToString());

            cl.delete_row_b2(date);
            load_dvg10();
            clean();

        }
        //************************************************************************************************************************
        //************************************************************* زر الحفظ ************************************************
        //************************************************************************************************************************
        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox3.Text);
            decimal brr = Convert.ToDecimal(textBox4.Text);
            int id_ezn = Convert.ToInt32(textBox5.Text);
            if (com_buyer.Text == "")
            {

                MessageBox.Show("من فضلك أدخل اسم المشتري");

            }
            else if (dvg10.Rows.Count == 0)
            {

                MessageBox.Show("من فضلك أدخل الأصناف و الكميات");

            }
            else
            {

                for (int i = 1; i <= dvg10.Rows.Count; ++i)
                {
                    CLSezn cL = new CLSezn();
                    CLSproduct x = new CLSproduct();
                    CLSbuying b = new CLSbuying();
                    string m = dvg10.Rows[i - 1].Cells[1].Value.ToString();
                    string n = dvg10.Rows[i - 1].Cells[9].Value.ToString();
                    MessageBox.Show(m);
                    MessageBox.Show(n);
                    CLS_perchasing p = new CLS_perchasing();
                    p.load_pro_by_proname(m, n);
                    dataGridView1.DataSource = p.dt_pro_by_proname;



                    if (dataGridView1.Rows.Count < 1 && dvg10.Rows[i - 1].Cells[13].Value.ToString() == "خامات")
                    {
                        string a = "";

                        x.insert_pro(num,
                                     dvg10.Rows[i - 1].Cells[1].Value.ToString(),
                                     brr,
                                     dvg10.Rows[i - 1].Cells[13].Value.ToString(),
                                     dvg10.Rows[i - 1].Cells[5].Value.ToString(),
                                     dvg10.Rows[i - 1].Cells[8].Value.ToString(),
                                     a,
                                     Convert.ToDecimal(dvg10.Rows[i - 1].Cells[2].Value.ToString()),
                                     Convert.ToDecimal(dvg10.Rows[i - 1].Cells[3].Value.ToString()),
                                     "",
                                     dvg10.Rows[i - 1].Cells[9].Value.ToString(),

                                     dvg10.Rows[i - 1].Cells[12].Value.ToString());


                        MessageBox.Show("   تم حفظ   " + dvg10.Rows[i - 1].Cells[1].Value.ToString() + "  كصنف جديد  ");
                        ++brr;
                        ++num;

                    }
                    else if (dataGridView1.Rows.Count < 1 && dvg10.Rows[i - 1].Cells[13].Value.ToString() == "قطع غيار ")
                    {
                        string a = "";

                        x.insert_pro(num,
                                     dvg10.Rows[i - 1].Cells[1].Value.ToString(),
                                     brr,
                                     dvg10.Rows[i - 1].Cells[13].Value.ToString(),
                                     dvg10.Rows[i - 1].Cells[5].Value.ToString(),
                                     dvg10.Rows[i - 1].Cells[8].Value.ToString(),
                                     a,
                                     Convert.ToDecimal(dvg10.Rows[i - 1].Cells[2].Value.ToString()),
                                     Convert.ToDecimal(dvg10.Rows[i - 1].Cells[3].Value.ToString()),
                                     "",
                                     dvg10.Rows[i - 1].Cells[9].Value.ToString(),

                                     dvg10.Rows[i - 1].Cells[12].Value.ToString());
                        MessageBox.Show("   تم حفظ   " + dvg10.Rows[i - 1].Cells[1].Value.ToString() + "  كصنف جديد  ");
                        ++brr;
                        ++num;

                    }

                    else if (dataGridView1.Rows.Count >= 1 && dvg10.Rows[i - 1].Cells[13].Value.ToString() == "خامات")
                    {
                        MessageBox.Show("   تم حفظ  11111111111111111111كصنف جديد  " + dvg10.Rows[i - 1].Cells[1].Value.ToString());

                        decimal price1 = Convert.ToDecimal(dataGridView1.Rows[0].Cells[7].Value.ToString());
                        decimal price2 = Convert.ToDecimal(dvg10.Rows[i - 1].Cells[2].Value.ToString());

                        decimal higherPrice = Math.Max(price1, price2);


                        decimal quan1 = Convert.ToDecimal(dataGridView1.Rows[0].Cells[8].Value.ToString());
                        decimal quan2 = Convert.ToDecimal(dvg10.Rows[i - 1].Cells[3].Value.ToString());

                        decimal totalQuantity = quan1 + quan2;

                        b.update_products_from_perchasing(m, n, higherPrice, price1, totalQuantity);







                    }
                    else if (dataGridView1.Rows.Count >= 1 && dvg10.Rows[i - 1].Cells[13].Value.ToString() == "قطع غيار ")
                    {

                        MessageBox.Show("   تم حفظ   2222222222222222222222222 كصنف جديد  " + dvg10.Rows[i - 1].Cells[1].Value.ToString());
                        decimal price1 = Convert.ToDecimal(dataGridView1.Rows[0].Cells[7].Value.ToString());
                        decimal price2 = Convert.ToDecimal(dvg10.Rows[i - 1].Cells[2].Value.ToString());

                        decimal higherPrice = Math.Max(price1, price2);


                        decimal quan1 = Convert.ToDecimal(dataGridView1.Rows[0].Cells[8].Value.ToString());
                        decimal quan2 = Convert.ToDecimal(dvg10.Rows[i - 1].Cells[3].Value.ToString());

                        decimal totalQuantity = quan1 + quan2;

                        b.update_products_from_perchasing(m, n, higherPrice, price1, totalQuantity);
                    }
                    else if (dvg10.Rows[i - 1].Cells[13].Value.ToString() == "تصليحات")
                    {
                        cL.insert_eznn(Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox2.Text), dvg10.Rows[i - 1].Cells[9].Value.ToString(), "", "", "", "", "", "", dvg10.Rows[i - 1].Cells[10].Value.ToString(), dvg10.Rows[i - 1].Cells[11].Value.ToString());
                        cL.insert_ezn22(Convert.ToInt32(textBox5.Text), dvg10.Rows[i - 1].Cells[1].Value.ToString(), Convert.ToDecimal(dvg10.Rows[i - 1].Cells[3].Value.ToString()), dvg10.Rows[i - 1].Cells[5].Value.ToString(), dvg10.Rows[i - 1].Cells[13].Value.ToString(), Convert.ToDecimal(dvg10.Rows[i - 1].Cells[2].Value.ToString()), Convert.ToDecimal(dvg10.Rows[i - 1].Cells[4].Value.ToString()), dvg10.Rows[i - 1].Cells[8].Value.ToString(), "");
                        MessageBox.Show("   تم حفظ   333333333333333333333333 كصنف جديد  " + dvg10.Rows[i - 1].Cells[1].Value.ToString());
                    }
                    else if (dvg10.Rows[i - 1].Cells[13].Value.ToString() == "مصنعيات")
                    {

                        cL.insert_eznn(Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox2.Text), dvg10.Rows[i - 1].Cells[9].Value.ToString(), "", "", "", "", "", "", dvg10.Rows[i - 1].Cells[10].Value.ToString(), dvg10.Rows[i - 1].Cells[11].Value.ToString());
                        cL.insert_ezn22(Convert.ToInt32(textBox5.Text), dvg10.Rows[i - 1].Cells[1].Value.ToString(), Convert.ToDecimal(dvg10.Rows[i - 1].Cells[3].Value.ToString()), dvg10.Rows[i - 1].Cells[5].Value.ToString(), dvg10.Rows[i - 1].Cells[13].Value.ToString(), Convert.ToDecimal(dvg10.Rows[i - 1].Cells[2].Value.ToString()), Convert.ToDecimal(dvg10.Rows[i - 1].Cells[4].Value.ToString()), dvg10.Rows[i - 1].Cells[8].Value.ToString(), "");
                        MessageBox.Show("   تم حفظ   444444444444444444444444 كصنف جديد  " + dvg10.Rows[i - 1].Cells[1].Value.ToString());


                    }

                }

                try
                {

                    CLSbuying cL = new CLSbuying();
                    cL.insert_buying1(Convert.ToInt32(textBox1.Text), Convert.ToDateTime(textBox2.Text), com_buyer.Text, Convert.ToDecimal(textBox15.Text));
                    MessageBox.Show("تمت الاضافة بنجاح");
                    this.Close();


                }
                catch
                {
                    MessageBox.Show(" أدخل جميع البيانات بشكل صحيح ");
                }

            }

        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            //suggestionBox.Visible = false;
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            suggestionBox.Visible = true;
        }
    }
}
