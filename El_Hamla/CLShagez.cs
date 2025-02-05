using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Hamla
{
    class CLShagez
    {


        public DataTable dt_load_cars_pro = new DataTable();
        public void load_cars_pro_re(string car)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sea_car_report";
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = car;
       

            CLSset.cn.Open();
            dt_load_cars_pro.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //***********************************************************************************

        public DataTable dt_hagg_pro = new DataTable();
        public void load_hag_pro( DateTime d1, DateTime d2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sea_hagez_report";
           
            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_hagg_pro.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }



    }
}
