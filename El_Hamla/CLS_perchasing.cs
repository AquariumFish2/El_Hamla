using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Hamla
{
    class CLS_perchasing
    {


        public DataTable dt_pro_by_proname = new DataTable();

        public void load_pro_by_proname(string p_name,string car_num)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loadproducts_by_name";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = p_name;
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = car_num;

            CLSset.cn.Open();
            dt_pro_by_proname.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //****************************************************************************************************

        public DataTable dt_pro_by_proname2 = new DataTable();

        public void load_pro_by_proname2(string p_name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loadproducts_by_id";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 50).Value = p_name;
 
            CLSset.cn.Open();
            dt_pro_by_proname2.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }





    }
}
