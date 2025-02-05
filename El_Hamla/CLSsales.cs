using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Hamla
{
    class CLSsales
    {
        //********************************************************max sales id ***********************

        int mIDsales;
        public int mIDsaless()
        {
            try
            {
                CLSset.cn.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "maxId_sales";
                CLSset.cn.Open();
                mIDsales = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                mIDsales = 0;
            }
            CLSset.cn.Close();
            return mIDsales;


        }

        //*****************************************************************Load price******************************

        public DataTable dt_u_p = new DataTable();

        public void load_u_p(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "unit_select";
            cmd.Parameters.Add("@id_1", SqlDbType.Int).Value = id;

            CLSset.cn.Open();
            dt_u_p.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //*****************************************************************insert sales 111111******************************
        public void insert_sales1(int id, DateTime date, String rename, string acc_kind, string car_num, string car_name, string car_add, decimal total, String cash)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_sales_1";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@re_name", SqlDbType.VarChar, 50).Value = rename;
            cmd.Parameters.Add("@acc_kind", SqlDbType.VarChar, 50).Value = acc_kind;
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = car_num;
            cmd.Parameters.Add("@car_name", SqlDbType.VarChar, 50).Value = car_name;
            cmd.Parameters.Add("@car_address", SqlDbType.VarChar, 50).Value = car_add;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
            cmd.Parameters.Add("@cash", SqlDbType.VarChar, 50).Value = cash;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }



        //******************************************************* load sales 22222222 ******************************************


        public DataTable dt_s2 = new DataTable();

        public void load_s211(int id_123)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_sales_2";
            cmd.Parameters.Add("@id_s1", SqlDbType.Int).Value = id_123;

            CLSset.cn.Open();
            dt_s2.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //******************************************************* insert sales 22222222 ******************************************

        public void insert_sales2(int id, String proname, string unit, decimal price, decimal quantity, decimal totals2)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_sales_2";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@product_name", SqlDbType.VarChar).Value = proname;
            cmd.Parameters.Add("@unit", SqlDbType.VarChar, 50).Value = unit;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
            cmd.Parameters.Add("@quantity", SqlDbType.Decimal).Value = quantity;
            cmd.Parameters.Add("@total_s2", SqlDbType.Decimal).Value = totals2;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }

        public void delete_row_s2(string proname)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_row_s2";
            cmd.Parameters.Add("@product_name", SqlDbType.VarChar, 50).Value = proname;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }

        //----------------------------------------------------------- load s111111 ----------------------------------------------

        public DataTable dt_s1 = new DataTable();

        public void load_s1()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_sales1";


            CLSset.cn.Open();
            dt_s1.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }


        //------------------------------------------------------------search by date --------------------------------------------

        public DataTable dtseas = new DataTable();
        public void Sea_date(DateTime date1, DateTime date2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "search_in_sales";

            cmd.Parameters.Add("@d1", SqlDbType.Date).Value = date1;
            cmd.Parameters.Add("@d2", SqlDbType.Date).Value = date2;


            CLSset.cn.Open();
            dtseas.Load(cmd.ExecuteReader());
            CLSset.cn.Close();



        }

        //***************************************************************load_cars_buycarnum********************************************
        public DataTable dtloo = new DataTable();
        public void loocar(string carnum)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_cars_buycarnum";

            cmd.Parameters.Add("@carnum", SqlDbType.VarChar, 50).Value = carnum;
            CLSset.cn.Open();
            dtloo.Load(cmd.ExecuteReader());
            CLSset.cn.Close();









        }

    }


}
