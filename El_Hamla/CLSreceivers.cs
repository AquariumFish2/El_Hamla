using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Hamla
{
    class CLSreceivers
    {
        //******************************************** load data ***************************************************

        public DataTable dtreceivers = new DataTable();
        public void loadreceivers()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loadreceivers";

            CLSset.cn.Open();
            dtreceivers.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** insert data ***************************************************

        public void insert_receivers(int idr, string namer, string jobr, string national, string addressr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertreceivers";
            cmd.Parameters.Add("@id_re", SqlDbType.Int).Value = idr;
            cmd.Parameters.Add("@re_name", SqlDbType.VarChar, 50).Value = namer;
            cmd.Parameters.Add("@job", SqlDbType.VarChar, 50).Value = jobr;
            cmd.Parameters.Add("@nation", SqlDbType.VarChar, 50).Value = national;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = addressr;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }
        //********************************************************max receivers id ***********************

        int mIDrere;
        public int mIDreee()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MaxIDreceivers";
                CLSset.cn.Open();
                mIDrere = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mIDrere = 0;
            }
            CLSset.cn.Close();
            return mIDrere;


        }
        //******************************************** delete data ***************************************************

        public void delete_receivers(int idb)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_row_receivers";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idb;

            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }

    }
}
