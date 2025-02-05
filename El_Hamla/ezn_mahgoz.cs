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

namespace El_Hamla
{
    public partial class ezn_mahgoz : Form
    {
        public ezn_mahgoz()
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
        private void ezn_mahgoz_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh"))
            {
                string query = "SELECT * FROM product_table WHERE product_name = @ProductName";

                using (SqlCommand cmd_car = new SqlCommand(query, cn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd_car.Parameters.AddWithValue("@ProductName", textBox15.Text);

                    SqlDataAdapter da_car = new SqlDataAdapter();
                    da_car.SelectCommand = cmd_car;

                    DataTable dt_hag_EZ = new DataTable();
                    da_car.Fill(dt_hag_EZ);

                    // Now you can work with your DataTable (dt_hag_EZ)
                    dataGridView1.DataSource = dt_hag_EZ;
                    dataGridView1.ColumnHeadersVisible = false;

                    // إخفاء جميع الأعمدة
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.Visible = false;
                    }

                    // إظهار عمودي "رقم السيارة" و "الكمية"
                    // استبدل الفهارس بأسماء الأعمدة إذا كنت تعرفها
                    dataGridView1.Columns["car_nuum"].Visible = true;
                    dataGridView1.Columns["balance"].Visible = true;  
                    dataGridView1.Columns["car_nuum"].DisplayIndex = 0; 
                    dataGridView1.Columns["balance"].DisplayIndex = 1;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                CLSset.cn.Close();
                CLSezn cL = new CLSezn();
                decimal tot = 0;
                tot = Convert.ToDecimal(dataGridView1.Rows[0].Cells[7].Value.ToString()) * Convert.ToDecimal(textBox1.Text);
                // إضافة بيانات الصنف
                cL.insert_ezn22(Convert.ToInt32(textBox2.Text), textBox15.Text, Convert.ToDecimal(textBox1.Text), dataGridView1.Rows[0].Cells[4].Value.ToString(), dataGridView1.Rows[0].Cells[3].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[0].Cells[7].Value.ToString()), tot, dataGridView1.Rows[0].Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());
                this.Close();

            }
            catch
            {
                MessageBox.Show("أدخل البيانات  كاملة");

            }

        }

        private void ezn_mahgoz_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
