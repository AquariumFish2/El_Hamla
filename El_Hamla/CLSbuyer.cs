using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Hamla
{
     class CLSbuyer
    {
        //******************************************** load data ***************************************************

        public DataTable dtbuyer = new DataTable();
        public void loadbuyer()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_buyer";

            CLSset.cn.Open();
            dtbuyer.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** insert data ***************************************************

        public void insert_receivers(int idb, string nameb, string jobb, string nationalb, string details)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_buyer";
            cmd.Parameters.Add("@id_b", SqlDbType.Int).Value = idb;
            cmd.Parameters.Add("@b_name", SqlDbType.VarChar, 50).Value = nameb;
            cmd.Parameters.Add("@job_b", SqlDbType.VarChar, 50).Value = jobb;
            cmd.Parameters.Add("@nation_b", SqlDbType.VarChar, 50).Value = nationalb;
            cmd.Parameters.Add("@details_b", SqlDbType.VarChar, 50).Value = details;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }
        //********************************************************max buyer id ***********************


        int mIDbuyer;
        public int mIDbuyere()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MaxIDbuyer";
                CLSset.cn.Open();
                mIDbuyer = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mIDbuyer = 0;
            }
            CLSset.cn.Close();
            return mIDbuyer;


        }
        //******************************************** insert data ***************************************************

        public void delete_buyer(int idb)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_row_buyer";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idb;
         
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }

    }
}
