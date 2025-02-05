using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Telegram.Bot.Types;
using DevExpress.Utils.About;
using FastReport.Data;
using static DevExpress.RichEdit.Core.Accessibility.TextModel;

namespace El_Hamla
{
    class CLSezn
    {

        //***************************************************************** load ezn 11111 ******************************************

        public DataTable dt_ezn = new DataTable();
        public void load_ezn1(DateTime d1, DateTime d2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_ezn_1";
            cmd.Parameters.Add("@d1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@d2", SqlDbType.Date).Value = d2;
            CLSset.cn.Open();
            dt_ezn.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //***************************************************************** load ezn 11111 by id *****************************************

        public DataTable dtezn_id = new DataTable();

        public void load_ezn_by_id(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_ezn_1_by_id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            CLSset.cn.Open();
            dtezn_id.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //***************************************************************** load ezn 22222 by id *****************************************

        public DataTable dtezn2_id = new DataTable();

        public void load_ezn2_by_id(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_ezn_2";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            CLSset.cn.Open();
            dtezn2_id.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //***************************************************************** accepting *****************************************
        public void update_status1(int id, string status)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_status1_in_ezn";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@status", SqlDbType.VarChar,50).Value = status;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }
        //***************************************************************** excuting *****************************************
        public void update_status2(int id, string status,string rename)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_status2_in_ezn";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@status", SqlDbType.VarChar, 50).Value = status;
            cmd.Parameters.Add("@rename", SqlDbType.VarChar, 50).Value = rename;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }
        //***************************************************************** load ezn 11111 status ******************************************

        public DataTable dt_ezn_status = new DataTable();
        public void load_ezn1_status()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_ezn_1_status";

            CLSset.cn.Open();
            dt_ezn_status.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //***************************************************************** load ezn 11111 status2 ******************************************

        public DataTable dt_ezn_status2 = new DataTable();
        public void load_ezn1_status2()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_ezn_1_status2";
            
            CLSset.cn.Open();
            dt_ezn_status2.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //***************************************************************** load ezn 11111 status22 ******************************************

        public DataTable dt_ezn_status22 = new DataTable();
        public void load_ezn1_status22()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_ezn_1_status22";

            CLSset.cn.Open();
            dt_ezn_status22.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //***************************************************************** MAX ******************************************





        int mIDezn1;
        public int mIDeznn()
        {
            try
            {
                CLSset.cn.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ezn_max_id";
                CLSset.cn.Open();
                mIDezn1 = Convert.ToInt32(cmd.ExecuteScalar());
                CLSset.cn.Close();
            }
            catch
            {
                mIDezn1 = 0;
            }
            CLSset.cn.Close();
            return mIDezn1;

        }
        //***************************************************************load_cars_buycarnum********************************************
        public DataTable dtlooo = new DataTable();
        public void loocar(string carnum)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_cars_buycarnum";

            cmd.Parameters.Add("@carnum", SqlDbType.VarChar, 50).Value = carnum;
            CLSset.cn.Open();
            dtlooo.Load(cmd.ExecuteReader());
            CLSset.cn.Close();









        }
        //*****************************************************************insert ezn ******************************
        public void insert_eznn(int id, DateTime date, string car_num, string car_name, string car_add, string reman, string user_n, string stat1, string stat2,string wk,string wn )
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_ezn";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = car_num;
            cmd.Parameters.Add("@car_name", SqlDbType.VarChar, 50).Value = car_name;
            cmd.Parameters.Add("@car_address", SqlDbType.VarChar, 50).Value = car_add;
            cmd.Parameters.Add("@re_man", SqlDbType.VarChar, 50).Value = reman;
            cmd.Parameters.Add("@user_name", SqlDbType.VarChar, 50).Value = user_n;
            cmd.Parameters.Add("@ezn_status", SqlDbType.VarChar, 50).Value = stat1;
            cmd.Parameters.Add("@ezn_status2", SqlDbType.VarChar, 50).Value = stat2;
            cmd.Parameters.Add("@work_kind", SqlDbType.VarChar, 50).Value = wk;
            cmd.Parameters.Add("@work_num", SqlDbType.VarChar, 50).Value = wn;

            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }

        //******************************************************* insert ezn  22222222 ******************************************

        public void insert_ezn22(int id, string proname, decimal quan, string u, string ty, decimal p, decimal t,string pro_add, string pro_id)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_ezn_2";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@product_name", SqlDbType.VarChar, 50).Value = proname;
            cmd.Parameters.Add("@quantity", SqlDbType.Decimal).Value = quan;
            cmd.Parameters.Add("@unit", SqlDbType.VarChar, 50).Value = u;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = ty;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = p;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = t;
            cmd.Parameters.Add("@pro_add", SqlDbType.VarChar, 50).Value = pro_add;
            cmd.Parameters.Add("@product_id", SqlDbType.VarChar, 50).Value = pro_id;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();
         
 
        }
        //******************************************* delete **************************************
        public void delete_row_ezn2(string proname)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_row_ezn2";
            cmd.Parameters.Add("@product_name", SqlDbType.VarChar, 50).Value = proname;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }
        //***************************************************************** load ezn 11111 in store  ******************************************

        public DataTable dt_load_ezn_1_in_store = new DataTable();
        public void load_ezn_1_in_store()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_ezn_1_in_store";
         
            CLSset.cn.Open();
            dt_load_ezn_1_in_store.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //*****************************************************************Load pro table by name******************************

        public DataTable dt_u_p_by_name = new DataTable();

        public void load_u_p_by_name(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loadproducts_by_name_only";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;

            CLSset.cn.Open();
            dt_u_p_by_name.Load(cmd.ExecuteReader());
            CLSset.cn.Close();




        }

        //--------------------------------------------------------------
        public DataTable dt_u_p_by_name22 = new DataTable();

        public void load_u_p_by_name22(string name, decimal q)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loadproducts_by_name_only22";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("@product_bala", SqlDbType.Decimal).Value = q;
            CLSset.cn.Open();
            dt_u_p_by_name22.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //             update products from ezn excuting
        //***************************************************************************
        public void update_products_from_eznn(string name, string carnum, decimal q)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_pro_in_ezn_excuting";

            cmd.Parameters.Add("@product_name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = carnum;

            cmd.Parameters.Add("@product_bala", SqlDbType.Decimal).Value = q;



            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();


        }
        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //             update products from ezn excuting NEWWWWWWWWWWWWWWW
        //***************************************************************************
        public void update_products_from_eznn_newww(string id,  decimal q)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_pro_in_ezn_excuting_new";
            cmd.Parameters.Add("@pro_id", SqlDbType.VarChar, 50).Value = id;
            cmd.Parameters.Add("@product_bala", SqlDbType.Decimal).Value = q;



            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();


        }

        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //           insert hagez history
        //***************************************************************************
        public void insert_hagez(int id, DateTime date, string car1, string car2, string pro, decimal q)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_hagez";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@car1", SqlDbType.VarChar, 50).Value = car1;
            cmd.Parameters.Add("@car2", SqlDbType.VarChar, 50).Value = car2;
            cmd.Parameters.Add("@pro", SqlDbType.VarChar, 50).Value = pro;
            cmd.Parameters.Add("@quan", SqlDbType.Decimal).Value = q;



            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();
        }
        //***************************************************max id hagez******************************
        int mIDhag;
        public int mIDhagez()
        {
            try
            {
                CLSset.cn.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "max_id_hagez";
                CLSset.cn.Open();
                mIDhag = Convert.ToInt32(cmd.ExecuteScalar());
                CLSset.cn.Close();
            }
            catch
            {
                mIDhag = 0;
            }
            CLSset.cn.Close();
            return mIDhag;

        }

        




    }
}
