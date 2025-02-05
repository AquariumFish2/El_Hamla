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
    public partial class __examine_show : Form
    {
        public __examine_show()
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
        private void __examine_show_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Server=192.168.1.2;Initial Catalog=El_Hamla;User ID=sameh;Password=sameh"))
            {
                string query = "SELECT id_work,work_num,car_num,car_name from amr_work WHERE car_status = @carstat and examine_status=@examine_status and work_kind=@work_kind ";

                using (SqlCommand cmd_car = new SqlCommand(query, cn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd_car.Parameters.AddWithValue("carstat", "تم التسليم");
                    cmd_car.Parameters.AddWithValue("@examine_status", "لم يتم الفحص بعد");
                    cmd_car.Parameters.AddWithValue("@work_kind", "بأمر شغل");
                    SqlDataAdapter da_car = new SqlDataAdapter();
                    da_car.SelectCommand = cmd_car;

                    DataTable dt_hag_EZ = new DataTable();
                    da_car.Fill(dt_hag_EZ);

                    // Now you can work with your DataTable (dt_hag_EZ)
                    dvg10.DataSource = dt_hag_EZ;
                    dvg10.Columns[0].HeaderText = "كود أمر الشغل";
                    dvg10.Columns[1].HeaderText = "رقم أمر الشغل";
                    dvg10.Columns[2].HeaderText = "رقم السيارة";
                    dvg10.Columns[3].HeaderText = "نوع السيارة";
                    


                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvg10_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Amr_examine ex = new Amr_examine();
            ex.work_code.Text = dvg10.CurrentRow.Cells[0].Value.ToString();
            ex.ShowDialog();
            this.Close();
        }
    }
}
