using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Hamla
{
    class CLScars
    {
        //******************************************** load data ***************************************************

        public DataTable dtcar = new DataTable();
        public void loadcars()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_cars";

            CLSset.cn.Open();
            dtcar.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** insert data ***************************************************

        public void insert_cars(int idc, string numc, string namec, string addc, DateTime enter, string status)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_cars";
            cmd.Parameters.Add("@id_car", SqlDbType.Int).Value = idc;
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = numc;
            cmd.Parameters.Add("@car_name", SqlDbType.VarChar, 50).Value = namec;
            cmd.Parameters.Add("@car_add", SqlDbType.VarChar, 50).Value = addc;
            cmd.Parameters.Add("@enter", SqlDbType.Date).Value = enter;
            
            cmd.Parameters.Add("@status", SqlDbType.VarChar, 50).Value = status;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();
          
        }
        //********************************************************max car id ***********************

        int mIDcar;
        public int mIDcarr()
        {
            try
            {
                CLSset.cn.Close ();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "max_id_cars";
                CLSset.cn.Open();
                mIDcar = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mIDcar = 0;
            }
            CLSset.cn.Close();
            return mIDcar;


        }

    }
}
