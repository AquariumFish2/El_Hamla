using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Hamla
{
    class CLSwork
    {
        //********************************************************max sales id ***********************

        int mIDwork;
        public int mIDworkk()
        {
            try
            {
                CLSset.cn.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "max_amr_work";
                CLSset.cn.Open();
                mIDwork = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                mIDwork = 0;
            }
            CLSset.cn.Close();
            return mIDwork;


        }
        //*****************************************************************insert amr_work******************************
        public void insert_amr_work(int id,  string C_num, string C_num2, string car_name, string car_shape, string car_model,string car_add,DateTime Car_date, string W_kind,string W_num, DateTime W_date,string EZN_NUM,decimal Price, decimal Price2,string User_name,DateTime data_intry,string YEAR,string carstatus,string work_kkk,string ex )
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_amr_work";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = C_num;
            cmd.Parameters.Add("@car_num2", SqlDbType.VarChar, 50).Value = C_num2;
            cmd.Parameters.Add("@car_name", SqlDbType.VarChar, 50).Value = car_name;
            cmd.Parameters.Add("@car_shape", SqlDbType.VarChar, 50).Value = car_shape;
            cmd.Parameters.Add("@car_model", SqlDbType.VarChar, 50).Value = car_model;
            cmd.Parameters.Add("@car_address", SqlDbType.VarChar, 50).Value = car_add;
            cmd.Parameters.Add("@car_date", SqlDbType.Date).Value = Car_date;
            cmd.Parameters.Add("@work_kind", SqlDbType.VarChar, 50).Value = W_kind;
            cmd.Parameters.Add("@work_num", SqlDbType.VarChar, 50).Value = W_num;
            cmd.Parameters.Add("@work_date", SqlDbType.Date).Value =W_date;
            cmd.Parameters.Add("@ezn_num", SqlDbType.VarChar, 50).Value = EZN_NUM;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value =Price;
            cmd.Parameters.Add("@price2", SqlDbType.Decimal).Value = Price2;
            cmd.Parameters.Add("@user_name", SqlDbType.VarChar, 50).Value = User_name;
            cmd.Parameters.Add("@data_intry", SqlDbType.Date).Value = data_intry;
            cmd.Parameters.Add("@year", SqlDbType.VarChar, 50).Value = YEAR;
            cmd.Parameters.Add("@car_status", SqlDbType.VarChar, 50).Value = carstatus;
            cmd.Parameters.Add("@work_kkk", SqlDbType.VarChar, 50).Value = work_kkk;
            cmd.Parameters.Add("@ex_stat", SqlDbType.VarChar, 50).Value = ex;



            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }
        //******************************************** load new cars in FX data ***************************************************

        public DataTable dtcar_new = new DataTable();
        public void loadcars_new()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_new_cars";

            CLSset.cn.Open();
            dtcar_new.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** Search new cars in FX data ***************************************************

        public void Search_cars_new(string text)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "search_cars";
            cmd.Parameters.Add("@text", SqlDbType.VarChar, 50).Value = text;
            CLSset.cn.Open();
            dtcar_new.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //******************************************** Search new cars in FX data ***************************************************

        public DataTable dtcar_ezn = new DataTable();
        public void loadcars_ezn(string carnum)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_cars_ezn";
            cmd.Parameters.Add("@carnum", SqlDbType.VarChar, 50).Value = carnum;

            CLSset.cn.Open();
            dtcar_ezn.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //********************************************load amr work 222222 by id *******************************************************
        public DataTable dtamr2_id = new DataTable();

        public void load_amr2_by_id(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_amr_2";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            CLSset.cn.Open();
            dtamr2_id.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //********************************************load amr work kind by *******************************************************
        public DataTable work_kind2 = new DataTable();

        public void load_work_kind_from_amr( string work_kind)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_work_kind_from_amr";
            cmd.Parameters.Add("@w_kind", SqlDbType.Int).Value = work_kind;

            CLSset.cn.Open();
            work_kind2.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** insert amr work 222222  ***************************************************

        public void insert_amr22(int id, String proname, decimal quan)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_amr_work_pro";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@product_name", SqlDbType.VarChar, 50).Value = proname;

            cmd.Parameters.Add("@quantity", SqlDbType.Decimal).Value = quan;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();



        }
        //******************************************* delete worh_pro 22222222222 **************************************
        public void delete_row_amr2(string proname)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_row_amr2";
            cmd.Parameters.Add("@product_name", SqlDbType.VarChar, 50).Value = proname;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }




        //********************************************load amr work 11111111111 *******************************************************
        public DataTable dtamr1= new DataTable();

        public void load_amr1()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_amr_work11";
        

            CLSset.cn.Open();
            dtamr1.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //********************************************update  amr work تسليم سيارة  *******************************************************
       

        public void update_car_status(string carnum, DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_car_status_date22";
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = carnum;
            cmd.Parameters.Add("@date22", SqlDbType.Date).Value =date;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }
        //********************************************load amr work 222222 id by car_num and work_num   *******************************************************

        public DataTable dtamr2_bring_id = new DataTable();

        public void load_amr2_bring_id(string carnum,string worknum)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_id_work";
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = carnum;
            cmd.Parameters.Add("@work_num", SqlDbType.VarChar, 50).Value = worknum;

            CLSset.cn.Open();
            dtamr2_bring_id.Load(cmd.ExecuteReader());
            CLSset.cn.Close();



        }

        //******************************************** Searching in amr main by add ***************************************************

        public DataTable dtamr_s_add = new DataTable();
        public void sea_amr_add(string tx)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "amr_search_car_add";
            cmd.Parameters.Add("@text", SqlDbType.VarChar, 50).Value = tx;

            CLSset.cn.Open();
            dtamr_s_add.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //******************************************** Searching in amr main by shape ***************************************************

        public DataTable dtamr_s_shape = new DataTable();
        public void sea_amr_shape(string tx)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "amr_search_car_shape";
            cmd.Parameters.Add("@text", SqlDbType.VarChar, 50).Value = tx;

            CLSset.cn.Open();
            dtamr_s_shape.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** Searching in amr main by status ***************************************************

        public DataTable dtamr_s_status = new DataTable();
        public void sea_amr_status(string tx)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "amr_search_car_status";
            cmd.Parameters.Add("@text", SqlDbType.VarChar, 50).Value = tx;

            CLSset.cn.Open();
            dtamr_s_status.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** Searching in amr main by wdate ***************************************************

        public DataTable dtamr_s_wdate = new DataTable();
        public void sea_amr_wdate(DateTime d1,DateTime d2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "amr_search_work_date";
            cmd.Parameters.Add("@d1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@d2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dtamr_s_wdate.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** Searching in amr main by kind ***************************************************

        public DataTable dtamr_s_kind = new DataTable();
        public void sea_amr_kind(string tx)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "amr_search_work_kind";
            cmd.Parameters.Add("@text", SqlDbType.VarChar, 50).Value = tx;

            CLSset.cn.Open();
            dtamr_s_kind.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** Searching in amr main by work num ***************************************************

        public DataTable dtamr_s_num = new DataTable();
        public void sea_amr_num(string tx)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "amr_search_work_num";
            cmd.Parameters.Add("@text", SqlDbType.VarChar, 50).Value = tx;

            CLSset.cn.Open();
            dtamr_s_num.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** Searching in amr main by car num ***************************************************

        public DataTable dtamr_s_carnum = new DataTable();
        public void sea_amr_carnum(string tx)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "amr_search_car_num";
            cmd.Parameters.Add("@text", SqlDbType.VarChar, 50).Value = tx;

            CLSset.cn.Open();
            dtamr_s_carnum.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** Searching in amr main by car num ***************************************************

        public DataTable dtamr_w_id = new DataTable();
        public void load_amr_by_id(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_amr_work1_by_id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            CLSset.cn.Open();
            dtamr_w_id.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //*****************************************************************update amr_work******************************
        public void update_amr_work(int id, string C_num, string C_num2, string car_name, string car_shape, string car_model, string car_add, DateTime Car_date, string W_kind, string W_num, DateTime W_date, string EZN_NUM, decimal Price, decimal Price2, string User_name, DateTime data_intry, string YEAR, string carstatus,DateTime Car_date2, string work_kkk)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_amr_work";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = C_num;
            cmd.Parameters.Add("@car_num2", SqlDbType.VarChar, 50).Value = C_num2;
            cmd.Parameters.Add("@car_name", SqlDbType.VarChar, 50).Value = car_name;
            cmd.Parameters.Add("@car_shape", SqlDbType.VarChar, 50).Value = car_shape;
            cmd.Parameters.Add("@car_model", SqlDbType.VarChar, 50).Value = car_model;
            cmd.Parameters.Add("@car_address", SqlDbType.VarChar, 50).Value = car_add;
            cmd.Parameters.Add("@car_date", SqlDbType.Date).Value = Car_date;
            cmd.Parameters.Add("@work_kind", SqlDbType.VarChar, 50).Value = W_kind;
            cmd.Parameters.Add("@work_num", SqlDbType.VarChar, 50).Value = W_num;
            cmd.Parameters.Add("@work_date", SqlDbType.Date).Value = W_date;
            cmd.Parameters.Add("@ezn_num", SqlDbType.VarChar, 50).Value = EZN_NUM;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = Price;
            cmd.Parameters.Add("@price2", SqlDbType.Decimal).Value = Price2;
            cmd.Parameters.Add("@user_name", SqlDbType.VarChar, 50).Value = User_name;
            cmd.Parameters.Add("@data_intry", SqlDbType.Date).Value = data_intry;
            cmd.Parameters.Add("@year", SqlDbType.VarChar, 50).Value = YEAR;
            cmd.Parameters.Add("@car_status", SqlDbType.VarChar, 50).Value = carstatus;
            cmd.Parameters.Add("@car_date2", SqlDbType.Date).Value = Car_date2;
            cmd.Parameters.Add("@work_kkk", SqlDbType.VarChar, 50).Value = work_kkk;



            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }
        public void delete_row_amr(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_row_amr";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }
        //********************************************insert نوع الإصلاح  *******************************************************


        public void insert_car_fix_kind(int id,string carfix,string quan)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_car_fix_kind";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
          
            cmd.Parameters.Add("@car_fix_kind", SqlDbType.VarChar, 50).Value = carfix;
            cmd.Parameters.Add("@quantity", SqlDbType.VarChar, 50).Value = quan;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }
        //***************************************************************************************************
        public DataTable dtcar_fix_kind_id = new DataTable();

        public void load_car_fix_kind_id(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_car_fix_kind";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            CLSset.cn.Open();
            dtcar_fix_kind_id.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //****************************************************************************************************
        public void delete_row_car_fix_kind(string car_fix_kind)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_row_car_fix_kind";
            cmd.Parameters.Add("@car_fix_kind", SqlDbType.VarChar, 50).Value = car_fix_kind;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }
        //*****************************************************************************************************

        public DataTable dt_amr_stat = new DataTable();
        public void load_amr_stat()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetCarStatusSummary";

            CLSset.cn.Open();
            dt_amr_stat.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //*****************************************************************************************************
        public void update_examine_status(int id, DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_examine";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@date22", SqlDbType.Date).Value = date;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }




    }
}
