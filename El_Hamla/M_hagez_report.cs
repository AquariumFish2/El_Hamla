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
    public partial class M_hagez_report : Form
    {
        DataTable dt_car_EZ_re;
        public M_hagez_report()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Filter DataTable based on search text using Contains to match anywhere in the string
                var filteredRows = dt_car_EZ_re.AsEnumerable()
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M_hagez_report_Load(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;



            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_car = new SqlCommand("Select distinct car_num from amr_work ", cn);
            SqlDataAdapter da_car = new SqlDataAdapter();
            da_car.SelectCommand = cmd_car;
            dt_car_EZ_re = new DataTable();
            da_car.Fill(dt_car_EZ_re);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && suggestionBox2.Items.Count > 0)
            {
                suggestionBox2.Focus();
                suggestionBox2.SelectedIndex = 0;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Enter && suggestionBox2.Visible && suggestionBox2.Focused)
            {
                textBox1.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
                return true;
            }



            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void suggestionBox2_Click(object sender, EventArgs e)
        {

            if (suggestionBox2.SelectedItem != null)
            {
                textBox1.Text = suggestionBox2.SelectedItem.ToString();
                suggestionBox2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true )
            {
                CLShagez cL = new CLShagez();
                cL.load_cars_pro_re(textBox1.Text);
                dataGridView1.DataSource = cL.dt_load_cars_pro;

                dataGridView1.Columns[0].HeaderText = "اسم الصنف";
                dataGridView1.Columns[1].HeaderText = "الكمية";
                dataGridView1.Columns[2].HeaderText = "الوحدة";
               
            }
            else if (checkBox1.Checked == true)
            {
                CLShagez cL = new CLShagez();
                cL.load_hag_pro(Convert.ToDateTime( dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
                dataGridView1.DataSource = cL.dt_hagg_pro;

                dataGridView1.Columns[0].HeaderText = "تاريخ الصرف";
                dataGridView1.Columns[1].HeaderText = "القطعة محجوزة لمركبة رقم";
                dataGridView1.Columns[2].HeaderText = "صرفت لمركبة رقم";
                dataGridView1.Columns[3].HeaderText = "اسم القطعة";
                dataGridView1.Columns[4].HeaderText = "الكمية";

            }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                textBox1.Enabled = true;   
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {

                checkBox2.Checked = false;
                textBox1.Enabled = false;
                dateTimePicker1.Enabled=true;
                dateTimePicker2.Enabled = true;
                textBox1.Text = "";


            }

        }
    }
}
