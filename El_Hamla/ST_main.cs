using System.Windows.Forms;

namespace El_Hamla
{
    public partial class ST_main : Form
    {
        public ST_main()
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

        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            enter__unit frm = new enter__unit();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CLSset.cn.Close();
            ST_product frm = new ST_product();
            frm.ShowDialog();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            CLSset.cn.Close();
            ST_product frm = new ST_product();
            frm.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;

            panel10.Visible = false;




            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;




        }

        private void label2_Click(object sender, EventArgs e)
        {
            M_products_balance_report m = new M_products_balance_report();
            m.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            panel10.Visible = false;




            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            panel10.Visible = false;


            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            panel10.Visible = true;



            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;

        }

        private void main_form_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panel2.Visible = false;

            panel10.Visible = false;



            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;


        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            panel10.Visible = false;



            panel20.Visible = true;
            panel21.Visible = true;
            panel22.Visible = true;
            panel23.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;



            panel10.Visible = false;




            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            panel10.Visible = false;




            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;

            ST_ezn_show f = new ST_ezn_show();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            panel10.Visible = false;




            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            panel10.Visible = false;



            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ST_enter_type frm = new ST_enter_type();
            frm.ShowDialog();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            ST_enter_type frm = new ST_enter_type();
            frm.ShowDialog();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            enter__unit frm = new enter__unit();
            frm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ST_enter_buyAdd frm = new ST_enter_buyAdd();
            frm.ShowDialog();

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            ST_enter_buyAdd frm = new ST_enter_buyAdd();
            frm.ShowDialog();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            ST_receivers frm = new ST_receivers();
            frm.ShowDialog();

        }

        private void panel23_Click(object sender, EventArgs e)
        {
            ST_receivers frm = new ST_receivers();
            frm.ShowDialog();

        }

        private void panel24_Click(object sender, EventArgs e)
        {
            ST_tool_add frm = new ST_tool_add();
            frm.ShowDialog();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            ST_tool_add frm = new ST_tool_add();
            frm.ShowDialog();
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Click(object sender, EventArgs e)
        {
            ST_buyer frm = new ST_buyer();
            frm.ShowDialog();
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Click(object sender, EventArgs e)
        {
            ST_receivers_show frm = new ST_receivers_show();
            frm.ShowDialog();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            ST_receivers_show frm = new ST_receivers_show();
            frm.ShowDialog();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            ST_buyer frm = new ST_buyer();
            frm.ShowDialog();
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            ST_buyers_show frm = new ST_buyers_show();
            frm.ShowDialog();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            ST_buyers_show frm = new ST_buyers_show();
            frm.ShowDialog();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            ___cars f = new ___cars();
            f.ShowDialog();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            ___cars f = new ___cars();
            f.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ___cars_show frm = new ___cars_show();
            frm.ShowDialog();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            ___cars_show frm = new ___cars_show();
            frm.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ST_sales frm = new ST_sales();
            frm.ShowDialog();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            ST_sales frm = new ST_sales();
            frm.ShowDialog();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            _perchasing frm = new _perchasing();
            frm.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            _perchasing frm = new _perchasing();
            frm.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            buying_show frm = new buying_show();
            frm.ShowDialog();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            buying_show frm = new buying_show();
            frm.ShowDialog();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            ST_sales_show frm = new ST_sales_show();
            frm.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            ST_sales_show frm = new ST_sales_show();
            frm.ShowDialog();
        }

        private void main_form_MouseMove(object sender, MouseEventArgs e)
        {

            CLSset.cn.Close();
            CLSezn ezn = new CLSezn();
            ezn.load_ezn1_status2();
            dvg10.DataSource = ezn.dt_ezn_status2;
            dvg10.Columns[0].HeaderText = "رقم الأذن";
            textBox1.Text = dvg10.Rows.Count.ToString();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            M_products_balance_report m = new M_products_balance_report();
            m.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            buying_show_2 m = new buying_show_2();
            m.ShowDialog(); 
        }
    }
}
