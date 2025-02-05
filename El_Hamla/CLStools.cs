using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Hamla
{
    class CLStools
    {
        //******************************************************** max buyer id ***********************

        int mIDtool;
        public int mIDtoool()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "max_id_tool";
                CLSset.cn.Open();
                mIDtool = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mIDtool = 0;
            }
            CLSset.cn.Close();
            return mIDtool;


        }
        //******************************************************** lood tools ***********************

        public DataTable dttool = new DataTable();
        public void load_tool()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_tool";

            CLSset.cn.Open();
            dttool.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }


    }
}
