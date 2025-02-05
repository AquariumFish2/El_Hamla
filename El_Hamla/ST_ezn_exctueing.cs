using DevExpress.XtraRichEdit.Import.Doc;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    public partial class ST_ezn_exctueing : Form
    {
        public ST_ezn_exctueing()
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

        private void ezn_accepting_Load(object sender, EventArgs e)
        {



            //********************************************** receivers combo *************************************************
            CLSset.cn.Close();
            SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh");
            SqlCommand cmd_r = new SqlCommand("Select id_re,re_name from receiver_table", cn);
            SqlDataAdapter da_re = new SqlDataAdapter();
            da_re.SelectCommand = cmd_r;
            DataTable dt_re = new DataTable();
            da_re.Fill(dt_re);
            DataRow dr_re = dt_re.NewRow();
            dr_re[1] = "";
            dt_re.Rows.InsertAt(dr_re, 0);

            comboBox10.DataSource = dt_re;
            comboBox10.DisplayMember = "re_name";
            comboBox10.ValueMember = "id_re";
            comboBox10.SelectedIndex = 0;
            //*****************************************************************************************************************


            CLSezn pro = new CLSezn();
            pro.load_ezn_by_id(Convert.ToInt32(text_in_ezn.Text));
            dataGridView2.DataSource = pro.dtezn_id;
            textBox1.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView2.Rows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView2.Rows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView2.Rows[0].Cells[6].Value.ToString();
            textBox7.Text = dataGridView2.Rows[0].Cells[7].Value.ToString();
            textBox8.Text = dataGridView2.Rows[0].Cells[8].Value.ToString();
            textBox11.Text = dataGridView2.Rows[0].Cells[9].Value.ToString();
            textBox12.Text = dataGridView2.Rows[0].Cells[10].Value.ToString();

            pro.load_ezn2_by_id(Convert.ToInt32(text_in_ezn.Text));
            dvg10.DataSource = pro.dtezn2_id;
            dvg10.Columns[0].HeaderText = "أسم الصنف";
            dvg10.Columns[1].HeaderText = "الكمية";
            dvg10.Columns[2].Visible = false;
            decimal sum = 0;
            for (int i = 0; i < dvg10.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dvg10.Rows[i].Cells[1].Value);
            }
            textBox9.Text = sum.ToString();
            textBox10.Text = dvg10.Rows.Count.ToString();


        }



        private void button3_Click(object sender, EventArgs e)
        {
            comboBox10.Text = "";
            textBox7.Text = "تعذر الصرف";
            CLSezn cL = new CLSezn();
            cL.update_status2(Convert.ToInt32(text_in_ezn.Text), textBox7.Text, comboBox10.Text);
            MessageBox.Show("تعذر الصرف");
            ST_ezn_show f = new ST_ezn_show();
            f.ShowDialog();
            this.Close();

        }



        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLS_perchasing p = new CLS_perchasing();
            CLSezn cl = new CLSezn();
            if (comboBox10.Text == "")
            {
                MessageBox.Show("أدخل أسم المستلم ");

            }
            else
            {
                for (int i = 1; i <= dvg10.Rows.Count; ++i)
                {
                   
                    p.load_pro_by_proname2(dvg10.Rows[i - 1].Cells[2].Value.ToString());
                    dataGridView1.DataSource = p.dt_pro_by_proname2;

                    decimal c = 0;
                    c = Convert.ToDecimal(dataGridView1.Rows[i - 1].Cells[8].Value.ToString()) - Convert.ToDecimal(dvg10.Rows[i - 1].Cells[1].Value.ToString());
                   

                    cl.update_products_from_eznn_newww(dvg10.Rows[i - 1].Cells[2].Value.ToString(), c);
                    if (textBox2.Text != dataGridView1.Rows[i - 1].Cells[10].Value.ToString() && dataGridView1.Rows[i - 1].Cells[10].Value.ToString() != "")
                    {
                        int m = cl.mIDhagez()+1;
                        MessageBox.Show(m.ToString());
                        cl.insert_hagez(m, Convert.ToDateTime(textBox1.Text), dataGridView1.Rows[i - 1].Cells[10].Value.ToString(), textBox2.Text, dataGridView1.Rows[i - 1].Cells[1].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[i - 1].Cells[8].Value.ToString()));
                        MessageBox.Show("Done");

                    }

                }

                textBox7.Text = "تم الصرف";
                CLSezn cL = new CLSezn();
                cL.update_status2(Convert.ToInt32(text_in_ezn.Text), textBox7.Text, comboBox10.Text);
                MessageBox.Show("تم الصرف");
                ST_ezn_show f = new ST_ezn_show();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
