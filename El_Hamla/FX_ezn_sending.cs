using DevExpress.CodeParser;
using FastReport.DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class FX_ezn_sending : Form
    {
        DataTable dt_pro_EZ;
        DataTable dt_car_EZ;
        public FX_ezn_sending()
        {
            InitializeComponent();
            CLSezn cL = new CLSezn();
            int ID = cL.mIDeznn() + 1;
            textBox2.Text = ID.ToString();
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




        private void button4_Click(object sender, EventArgs e)
        {
            CLSset.cn.Close();

            bool foundValidData = false; // متغير لتتبع ما إذا تم العثور على بيانات صالحة

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                // تحقق إذا كانت قيمة العمود 11 تحتوي على بيانات (غير null أو فارغة)
                if (dataGridView1.Rows[i].Cells[11].Value != null && !string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[10].Value.ToString()))
                {
                    // تحقق مما إذا كانت بيانات textBox3 تحتوي على رقم صحيح
                    decimal parsedValue;
                    bool isNumeric = decimal.TryParse(textBox3.Text, out parsedValue);

                    if (!isNumeric || parsedValue <= 0)
                    {
                        // عرض رسالة تحذير إذا كانت البيانات غير صحيحة
                        MessageBox.Show("أدخل البيانات كاملة وبشكل صحيح (يجب أن يحتوي المبلغ على رقم صحيح).");
                        return; // إيقاف العملية وعدم فتح الفورم
                    }
                    else
                    {
                        // فتح الفورم ezn_mahgoz إذا كانت البيانات صحيحة
                        ezn_mahgoz ez = new ezn_mahgoz();
                        ez.textBox15.Text = textBox15.Text;
                        ez.textBox2.Text = textBox2.Text;
                        ez.ShowDialog();
                        foundValidData = true; // تم العثور على بيانات صالحة
                        break; // إيقاف الحلقة إذا تم العثور على بيانات صالحة
                    }
                }
            }

            // إذا لم يتم العثور على بيانات صالحة في جميع الصفوف، قم بتنفيذ العملية الافتراضية
            if (!foundValidData)
            {
                try
                {
                    CLSset.cn.Close();
                    CLSezn cL = new CLSezn();

                    decimal parsedValue;
                    bool isNumeric = decimal.TryParse(textBox3.Text, out parsedValue);

                    if (!isNumeric || parsedValue <= 0)
                    {
                        MessageBox.Show("أدخل البيانات كاملة وبشكل صحيح (يجب أن يحتوي المبلغ على رقم صحيح).");
                        return; // إيقاف العملية إذا كانت البيانات غير صحيحة
                    }

                    decimal tot = 0;
                    tot = Convert.ToDecimal(dataGridView1.Rows[0].Cells[7].Value.ToString()) * Convert.ToDecimal(textBox3.Text);

                    // إضافة بيانات الصنف
                    cL.insert_ezn22(Convert.ToInt32(textBox2.Text), textBox15.Text, Convert.ToDecimal(textBox3.Text), dataGridView1.Rows[0].Cells[4].Value.ToString(), dataGridView1.Rows[0].Cells[3].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[0].Cells[7].Value.ToString()), tot, dataGridView1.Rows[0].Cells[5].Value.ToString(), dataGridView1.Rows[0].Cells[0].Value.ToString());

                    // تحميل البيانات وفقاً للمعرف
                    cL.load_ezn2_by_id(Convert.ToInt32(textBox2.Text));
                    dvg10.DataSource = cL.dtezn2_id;

                    // تخصيص أسماء الأعمدة
                    dvg10.Columns[0].HeaderText = "أسم الصنف";
                    dvg10.Columns[1].HeaderText = "الكمية";
                    dvg10.Columns[2].Visible = false;

                    // إخفاء رؤوس الأعمدة
                    dvg10.ColumnHeadersVisible = false;
                    dvg10.RowHeadersVisible = false;

                    // حساب مجموع الكمية
                    decimal sum = 0;
                    for (int j = 0; j < dvg10.Rows.Count; ++j)
                    {
                        sum += Convert.ToDecimal(dvg10.Rows[j].Cells[1].Value);
                    }
                    textBox9.Text = sum.ToString();
                }
                catch
                {
                    MessageBox.Show("أدخل البيانات  كاملة");
                }

                // إعادة ضبط الحقول بعد الحفظ
                textBox3.Text = "";
                textBox15.Text = "";
                textBox15.Focus();
                textBox10.Text = dvg10.Rows.Count.ToString();
            }
        }


        private void ezn_insert_Load(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            textBox6.Text = "يوزر";
            textBox7.Text = "قيد الإنتظار";
            textBox8.Text = "لم يتم الصرف بعد";
            textBox10.Text = dvg10.Rows.Count.ToString();


            //********************************************** cars TEXTBOX *************************************************

            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_car = new SqlCommand("Select distinct car_num from amr_work where car_status='لم يتم التسليم بعد' ", cn);
            SqlDataAdapter da_car = new SqlDataAdapter();
            da_car.SelectCommand = cmd_car;
            dt_car_EZ = new DataTable();
            da_car.Fill(dt_car_EZ);


            //********************************************** pro TEXTBOX *************************************************


            SqlCommand cmd_pro = new SqlCommand("Select distinct product_name from product_table", cn);
            SqlDataAdapter da_pro = new SqlDataAdapter();
            da_pro.SelectCommand = cmd_pro;
            dt_pro_EZ = new DataTable();
            da_pro.Fill(dt_pro_EZ);
            //***********************************************************************************************************



            CLSset.cn.Close();


            CLSezn cL = new CLSezn();


            CLSset.cn.Close();
            cL.load_ezn2_by_id(Convert.ToInt32(textBox2.Text));
            dvg10.DataSource = cL.dtezn2_id;

            dvg10.Columns[0].HeaderText = "أسم الصنف";
            dvg10.Columns[1].HeaderText = "الكمية";

            dvg10.ColumnHeadersVisible = false;
            dvg10.RowHeadersVisible = false;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {

                MessageBox.Show("من فضلك أختر بلوكامين الصيانة");

            }
            else if (dvg10.Rows.Count == 0)
            {

                MessageBox.Show("من فضلك أدخل الأصناف و الكميات");

            }
            else
            {
                try
                {

                    CLSezn cL = new CLSezn();
                    cL.insert_eznn(Convert.ToInt32(textBox2.Text), Convert.ToDateTime(textBox12.Text), textBox13.Text, textBox4.Text, textBox5.Text, comboBox1.Text, textBox6.Text, textBox7.Text, textBox8.Text, comboBox3.Text, comboBox2.Text);
                    MessageBox.Show("تم الإرسال بنجاح");
                    this.Close();


                }
                catch
                {
                    MessageBox.Show(" أدخل جميع البيانات بشكل صحيح ");
                }

            }

        }





        private void button6_Click(object sender, EventArgs e)
        {
            CLSezn cl = new CLSezn();
            try
            {
                string proo = dvg10.CurrentRow.Cells[0].Value.ToString();
                cl.delete_row_ezn2(proo);
                cl.load_ezn2_by_id(Convert.ToInt32(textBox2.Text));
                dvg10.DataSource = cl.dtezn2_id;

                dvg10.Columns[0].HeaderText = "أسم الصنف";
                dvg10.Columns[1].HeaderText = "الوحدة";

                dvg10.ColumnHeadersVisible = false;
                dvg10.RowHeadersVisible = false;


            }
            catch
            {
                MessageBox.Show("لا يوجد أصناف لحذفها ");

            }
            textBox3.Text = "";
            textBox3.Focus();
            textBox10.Text = dvg10.Rows.Count.ToString();
        }





        private void FX_ezn_sending_MouseMove(object sender, MouseEventArgs e)
        {
            textBox12.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            CLSset.cn.Close();
            CLSezn cL = new CLSezn();
            cL.load_ezn2_by_id(Convert.ToInt32(textBox2.Text));
            dvg10.DataSource = cL.dtezn2_id;

            dvg10.Columns[0].HeaderText = "أسم الصنف";
            dvg10.Columns[1].HeaderText = "الكمية";
            dvg10.Columns[2].Visible = false;

            dvg10.ColumnHeadersVisible = false;
            dvg10.RowHeadersVisible = false;
            decimal sum = 0;
            for (int j = 0; j < dvg10.Rows.Count; ++j)
            {
                sum += Convert.ToDecimal(dvg10.Rows[j].Cells[1].Value);
            }
            textBox9.Text = sum.ToString();
            textBox10.Text = dvg10.Rows.Count.ToString();


        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox15.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Filter DataTable based on search text using Contains to match anywhere in the string
                var filteredRows = dt_pro_EZ.AsEnumerable()
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
            CLSezn s = new CLSezn();
            s.load_u_p_by_name(textBox15.Text);
            dataGridView1.DataSource = s.dt_u_p_by_name;
            decimal quan = 0;
            for (int i = 1; i <= dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.RowCount > i)
                {
                    quan += Convert.ToDecimal(dataGridView1.Rows[i - 1].Cells[8].Value.ToString());


                }

            }

            textBox1.Text = quan.ToString();









        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && suggestionBox.Items.Count > 0)
            {
                suggestionBox.Focus();
                suggestionBox.SelectedIndex = 0;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && suggestionBox.Visible && suggestionBox.Focused)
            {
                CLS_perchasing p = new CLS_perchasing();
                p.load_pro_by_proname(textBox15.Text, textBox13.Text);
                dataGridView1.DataSource = p.dt_pro_by_proname;
                try
                {
                    if (dataGridView1.Rows.Count > 0)
                    {

                        textBox3.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();




                    }


                }
                catch
                {



                }




                textBox15.Text = suggestionBox.SelectedItem.ToString();
                suggestionBox.Visible = false;
                return true;

            }
            if (keyData == Keys.Enter && suggestionBox2.Visible && suggestionBox2.Focused)
            {
                textBox13.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
                return true;
            }



            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void suggestionBox_Click(object sender, EventArgs e)
        {
            if (suggestionBox.SelectedItem != null)
            {
                textBox15.Text = suggestionBox.SelectedItem.ToString();
                suggestionBox.Visible = false;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            string searchText = textBox13.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Filter DataTable based on search text using Contains to match anywhere in the string
                var filteredRows = dt_car_EZ.AsEnumerable()
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


            try
            {
                CLSwork u_p = new CLSwork();
                u_p.loadcars_ezn(textBox13.Text);
                dvg_car.DataSource = u_p.dtcar_ezn;

                comboBox2.DataSource = u_p.dtcar_ezn;
                comboBox2.DisplayMember = "work_num";
                comboBox2.SelectedIndex = 0;
                comboBox3.DataSource = u_p.dtcar_ezn;
                comboBox3.DisplayMember = "work_kind";
                comboBox3.SelectedIndex = 0;
                textBox4.Text = dvg_car.Rows[0].Cells[0].Value.ToString();
                textBox5.Text = dvg_car.Rows[0].Cells[1].Value.ToString();



                if (dvg_car.Rows.Count > 2)
                {
                    comboBox3.Enabled = true;
                    comboBox2.Enabled = true;

                }
                else
                {
                    comboBox3.Enabled = false;
                    comboBox2.Enabled = false;
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
                textBox13.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
            }
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && suggestionBox2.Items.Count > 0)
            {
                suggestionBox2.Focus();
                suggestionBox2.SelectedIndex = 0;
            }
        }

        private void FX_ezn_sending_Enter(object sender, EventArgs e)
        {
            
        }
    }






}
