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
    public partial class AA_transaction : Form
    {
        public AA_transaction()
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

        private void AA_transaction_Load(object sender, EventArgs e)
        {
            panel7.Visible = false;
            // الاتصال بقاعدة البيانات
            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");

            // الاستعلام عن أنواع الحسابات من جدول _MO_table
            SqlCommand cmd_u = new SqlCommand(@"Select distinct acc_type from _MO_table", cn);
            SqlDataAdapter da_unit = new SqlDataAdapter();
            da_unit.SelectCommand = cmd_u;
            DataTable dt_unit = new DataTable();
            da_unit.Fill(dt_unit);
            DataRow dr_unit = dt_unit.NewRow();
            dr_unit[0] = "شيك";
            dt_unit.Rows.InsertAt(dr_unit, 0);

            SqlCommand cmd_m = new SqlCommand(@"Select distinct acc_type from _MO_table", cn);
            SqlDataAdapter da_m = new SqlDataAdapter();
            da_m.SelectCommand = cmd_m;
            DataTable dt_m = new DataTable();
            da_m.Fill(dt_m);



            comboBox5.DataSource = dt_unit;
            comboBox5.DisplayMember = "acc_type";
            comboBox5.ValueMember = "acc_type";
            comboBox5.Text = "";
            comboBox3.DataSource = dt_m;
            comboBox3.DisplayMember = "acc_type";
            comboBox3.ValueMember = "acc_type";
            comboBox3.Text = "";
            CLS_AA cLS_AA = new CLS_AA();
            cLS_AA.loadtrans();
            dvg10.DataSource = cLS_AA.dtTRANS;
            int ID = cLS_AA.maxIDTRANS() + 1;
            textBox1.Text = ID.ToString();
            panel7.Visible = false;

        }

        private void UpdateComboBox2Options(string selectedValue)
        {
            comboBox1.Items.Clear();

            // إذا كانت القيمة المختارة هي "اختيار مخصص"
            if (selectedValue == "شيك")
            {
                // استعلام جديد يعتمد على جدول مختلف
                string query = @"Select  AA_check_id from _AA_check_table";

                using (SqlConnection connection = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh"))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // إضافة النتائج إلى ComboBox1
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["AA_check_id"].ToString());
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            else
            {
                // تنفيذ الاستعلام الأصلي بناءً على القيمة المختارة من قاعدة البيانات
                string query = @"SELECT DISTINCT mo_name FROM _MO_table WHERE acc_type = @SelectedValue";

                using (SqlConnection connection = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedValue", selectedValue);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // إضافة كل نتيجة من الاستعلام إلى ComboBox1
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["mo_name"].ToString());
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void UpdateComboBox22ptions(string selectedValue)
        {
            comboBox2.Items.Clear();

            // إذا كانت القيمة المختارة هي "اختيار مخصص"
            if (selectedValue == "شيك")
            {
                // استعلام جديد يعتمد على جدول مختلف
                string query = @"Select  AA_check_id from _AA_check_table";

                using (SqlConnection connection = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh"))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // إضافة النتائج إلى ComboBox1
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader["AA_check_id"].ToString());
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else if (selectedValue == "شيك")
            {
                // استعلام جديد يعتمد على جدول مختلف
                string query = @"Select  AA_check_id from _AA_check_table";

                using (SqlConnection connection = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh"))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // إضافة النتائج إلى ComboBox1
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader["AA_check_id"].ToString());
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            else
            {
                // تنفيذ الاستعلام الأصلي بناءً على القيمة المختارة من قاعدة البيانات
                string query = @"SELECT DISTINCT mo_name FROM _MO_table WHERE acc_type = @SelectedValue";

                using (SqlConnection connection = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedValue", selectedValue);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // إضافة كل نتيجة من الاستعلام إلى ComboBox1
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader["mo_name"].ToString());
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedValue != null)
            {
                // جلب القيمة المختارة من ComboBox5
                string selectedValue = comboBox5.SelectedValue.ToString();

                // تحديث الخيارات في ComboBox1 بناءً على القيمة المختارة
                UpdateComboBox2Options(selectedValue);
            }
            if (comboBox5.Text == "شيك")
            {
                panel7.Visible = true;

            }
            else
            {
                panel7.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "خزينة مشروع")
            {
                CLS_AA_pro nn = new CLS_AA_pro();
                nn.loadProjects_name(comboBox2.Text);
                dataGridView4.DataSource = nn.dtProject_name;
                nn.loadProjects2_name(comboBox1.Text);
                dataGridView5.DataSource = nn.dtProject2_name;
                CLS_AA m = new CLS_AA();
                m.loadaccn(comboBox2.Text);
                dataGridView3.DataSource = m.dtacccn;
                textBox9.Text = dataGridView3.Rows[0].Cells[3].Value.ToString();

            }
            else
            {
                CLS_AA m = new CLS_AA();
                m.loadaccn(comboBox2.Text);
                dataGridView3.DataSource = m.dtacccn;
                textBox9.Text = dataGridView3.Rows[0].Cells[3].Value.ToString();
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue != null)
            {
                // جلب القيمة المختارة من ComboBox5
                string selectedValue = comboBox3.SelectedValue.ToString();

                // تحديث الخيارات في ComboBox1 بناءً على القيمة المختارة
                UpdateComboBox22ptions(selectedValue);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal m = 0;
            decimal n = 0;
            decimal x = 0;
            decimal y = 0;
            decimal z = 0;

            CLS_AA cL = new CLS_AA();
            CLS_AA_pro nn = new CLS_AA_pro();

            try
            {



                cL.insert_AA_trans(Convert.ToInt32(textBox1.Text), Convert.ToDateTime(dateTimePicker1.Text), comboBox5.Text, comboBox1.Text, comboBox3.Text, comboBox2.Text, Convert.ToDecimal(textBox5.Text), textBox8.Text);
                if (comboBox5.Text == "شيك")
                {
                    m = Convert.ToDecimal(dataGridView1.Rows[0].Cells[5].Value.ToString()) - Convert.ToDecimal(textBox5.Text);
                    n = Convert.ToDecimal(textBox5.Text) + Convert.ToDecimal(dataGridView3.Rows[0].Cells[3].Value.ToString());
                    cL.updateaccb(m, Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString()));
                    cL.updatemob(n, Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value.ToString()));

                }

                else if (comboBox3.Text == "خزينة مشروع")
                {

                    x = Convert.ToDecimal(dataGridView2.Rows[0].Cells[3].Value.ToString()) - Convert.ToDecimal(textBox5.Text);

                    n = Convert.ToDecimal(textBox5.Text) + Convert.ToDecimal(dataGridView3.Rows[0].Cells[3].Value.ToString());

                    y = Convert.ToDecimal(textBox5.Text) + Convert.ToDecimal(dataGridView4.Rows[0].Cells[5].Value.ToString());

                    z = Convert.ToDecimal(dataGridView5.Rows[0].Cells[3].Value.ToString()) + Convert.ToDecimal(textBox5.Text);


                    cL.updatemob(x, Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value.ToString()));

                    cL.updatemob(n, Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value.ToString()));

                    nn.updateProject2(comboBox1.Text, z);

                    nn.updateProject_income(Convert.ToInt32(dataGridView4.Rows[0].Cells[0].Value.ToString()), y);
                }
                else
                {

                    x = Convert.ToDecimal(dataGridView2.Rows[0].Cells[3].Value.ToString()) - Convert.ToDecimal(textBox5.Text);
                    n = Convert.ToDecimal(textBox5.Text) + Convert.ToDecimal(dataGridView3.Rows[0].Cells[3].Value.ToString());

                    cL.updatemob(x, Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value.ToString()));
                    cL.updatemob(n, Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value.ToString()));
                }

            }
            catch
            {
                MessageBox.Show("أدخل القيم بشكل صحيح");
            }

            cL.loadtrans();
            dvg10.DataSource = cL.dtTRANS;
            textBox5.Text = "";
            textBox8.Text = "";
            comboBox5.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";
            comboBox2.Text = "";
            int ID = cL.maxIDTRANS() + 1;
            textBox1.Text = ID.ToString();

            cL.loadnetbalane(38);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLS_AA cL = new CLS_AA();
            CLS_AA_pro nn = new CLS_AA_pro();
            try
            {
                if (MessageBox.Show("هل أنت متأكد من حذف هذه العملية؟", "حذف عملية تحويل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    decimal m = 0;
                    decimal n = 0;
                    decimal x = 0;
                    decimal y = 0;
                    decimal z = 0;

                    if (dvg10.CurrentRow.Cells[2].Value.ToString() == "شيك")
                    {

                        cL.loadcheckid(Convert.ToInt32(dvg10.CurrentRow.Cells[3].Value.ToString()));
                        dataGridView1.DataSource = cL.dtcheckid;

                        cL.loadaccn(dvg10.CurrentRow.Cells[5].Value.ToString());
                        dataGridView3.DataSource = cL.dtacccn;

                        m = Convert.ToDecimal(dataGridView1.Rows[0].Cells[5].Value.ToString()) + Convert.ToDecimal(dvg10.CurrentRow.Cells[6].Value.ToString());
                        n = Convert.ToDecimal(dataGridView3.Rows[0].Cells[3].Value.ToString()) - Convert.ToDecimal(dvg10.CurrentRow.Cells[6].Value.ToString());
                        cL.updateaccb(m, Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString()));
                        cL.updatemob(n, Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value.ToString()));

                    }
                    else if (dvg10.CurrentRow.Cells[4].Value.ToString() == "خزينة مشروع")
                    {

                        cL.loadaccn(dvg10.CurrentRow.Cells[3].Value.ToString());
                        dataGridView2.DataSource = cL.dtacccn;

                        cL.loadaccn(dvg10.CurrentRow.Cells[5].Value.ToString());
                        dataGridView3.DataSource = cL.dtacccn;
                        nn.loadProjects_name(dvg10.CurrentRow.Cells[5].Value.ToString());
                        dataGridView4.DataSource = nn.dtProject_name;
                        nn.loadProjects2_name(dvg10.CurrentRow.Cells[3].Value.ToString());
                        dataGridView5.DataSource = nn.dtProject2_name;



                        x = Convert.ToDecimal(dataGridView2.Rows[0].Cells[3].Value.ToString()) + Convert.ToDecimal(dvg10.CurrentRow.Cells[6].Value.ToString());
                        n = Convert.ToDecimal(dataGridView3.Rows[1].Cells[3].Value.ToString()) - Convert.ToDecimal(dvg10.CurrentRow.Cells[6].Value.ToString());
                        y = Convert.ToDecimal(dataGridView4.Rows[0].Cells[5].Value.ToString()) - Convert.ToDecimal(dvg10.CurrentRow.Cells[6].Value.ToString());
                        cL.updatemob(x, Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value.ToString()));
                        cL.updatemob(n, Convert.ToInt32(dataGridView3.Rows[1].Cells[0].Value.ToString()));

                        z = Convert.ToDecimal(dataGridView5.Rows[0].Cells[2].Value.ToString()) - Convert.ToDecimal(dvg10.CurrentRow.Cells[6].Value.ToString());


                        nn.updateProject2(dvg10.CurrentRow.Cells[3].Value.ToString(), z);
                        nn.updateProject_income(Convert.ToInt32(dataGridView4.Rows[0].Cells[0].Value.ToString()), y);
                    }

                    else
                    {
                        cL.loadaccn(dvg10.CurrentRow.Cells[3].Value.ToString());
                        dataGridView2.DataSource = cL.dtacccn;

                        cL.loadaccn(dvg10.CurrentRow.Cells[5].Value.ToString());
                        dataGridView3.DataSource = cL.dtacccn;

                        x = Convert.ToDecimal(dataGridView2.Rows[0].Cells[3].Value.ToString()) + Convert.ToDecimal(dvg10.CurrentRow.Cells[6].Value.ToString());
                        n = Convert.ToDecimal(dataGridView3.Rows[1].Cells[3].Value.ToString()) - Convert.ToDecimal(dvg10.CurrentRow.Cells[6].Value.ToString());

                        cL.updatemob(x, Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value.ToString()));
                        cL.updatemob(n, Convert.ToInt32(dataGridView3.Rows[1].Cells[0].Value.ToString()));
                    }
                    cL.delete_AA_trans(Convert.ToInt32(dvg10.CurrentRow.Cells[0].Value.ToString()));

                    cL.loadtrans();
                    dvg10.DataSource = cL.dtTRANS;

                }
            }
            catch
            {
                MessageBox.Show("لا يوجد شيكات لحذفها ");

            }
            textBox5.Text = "";
            textBox8.Text = "";
            comboBox5.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";
            comboBox2.Text = "";
            int ID = cL.maxIDTRANS() + 1;
            textBox1.Text = ID.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLS_AA m = new CLS_AA();
            if (comboBox5.Text == "شيك")
            {

                m.loadcheckid(Convert.ToInt32(comboBox1.Text));
                dataGridView1.DataSource = m.dtcheckid;
                textBox2.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();

            }

            else
            {
                m.loadaccn(comboBox1.Text);
                dataGridView2.DataSource = m.dtacccn;
                textBox7.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();


            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CLS_AA m = new CLS_AA();
            if (textBox5.Text == "")
            {
                textBox4.Text = textBox2.Text;

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
