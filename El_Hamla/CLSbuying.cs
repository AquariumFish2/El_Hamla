using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace El_Hamla
{
    class CLSbuying
    {
        //*******************************************************load buying 11111111 by id ******************************************

        public DataTable dtb111 = new DataTable();

        public void load_b111(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "buying1_by_id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            CLSset.cn.Open();
            dtb111.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }



        //*******************************************************load buying 11111111 ******************************************


        public DataTable dtb1 = new DataTable();
        public void loadb1()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_buying";

            CLSset.cn.Open();
            dtb1.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }


        //********************************************************max buying id ***********************

        int mIDbuying;
        public int mIDbuyingg()
        {
            try
            {
                CLSset.cn.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "maxId_buying";
                CLSset.cn.Open();
                mIDbuying = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                mIDbuying = 0;
            }
            CLSset.cn.Close();
            return mIDbuying;


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
        //*****************************************************************Load price 22222222 ******************************

        public DataTable dt_u_p2 = new DataTable();

        public void load_u_p2(string p_name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "unit_select_d_buying";
            cmd.Parameters.Add("@proname", SqlDbType.VarChar, 50).Value = p_name;

            CLSset.cn.Open();
            dt_u_p2.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //*****************************************************************insert buying 111111******************************
        public void insert_buying1(int id, DateTime date, String buyname, decimal total)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_buying_1";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@buyer_name", SqlDbType.VarChar, 50).Value = buyname;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;

            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }



        //******************************************************* load buying 22222222 ******************************************


        public DataTable dt_b2 = new DataTable();

        public void load_b211(int id_123)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_buying_2";
            cmd.Parameters.Add("@id_buying", SqlDbType.Int).Value = id_123;

            CLSset.cn.Open();
            dt_b2.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }



        //******************************************************* insert buying 22222222 ******************************************

        public void insert_buying2(int id, string proname, string pro_type, string unit, decimal price, decimal quantity, decimal totalb2, DateTime date, string perchasing_add, string mo, string carnum, string workkind, string worknum, string hagez,string user_name )
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_buying_2";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@product_name", SqlDbType.VarChar).Value = proname;
            cmd.Parameters.Add("@pro_type", SqlDbType.VarChar).Value = pro_type;
            cmd.Parameters.Add("@unit", SqlDbType.VarChar, 50).Value = unit;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
            cmd.Parameters.Add("@quantity", SqlDbType.Decimal).Value = quantity;
            cmd.Parameters.Add("@total_b2", SqlDbType.Decimal).Value = totalb2;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@perchasing_add", SqlDbType.VarChar, 50).Value = perchasing_add;
            cmd.Parameters.Add("@mo_name", SqlDbType.VarChar, 50).Value = mo;
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = carnum;
            cmd.Parameters.Add("@work_kind", SqlDbType.VarChar, 50).Value = workkind;
            cmd.Parameters.Add("@work_num", SqlDbType.VarChar, 50).Value = worknum;
            cmd.Parameters.Add("@hagez_type", SqlDbType.VarChar, 50).Value = hagez;
            cmd.Parameters.Add("@user_name", SqlDbType.VarChar, 50).Value = user_name;



            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }

        //******************************************************* load acc by name  ******************************************

        public DataTable dtacc = new DataTable();
        public void loadacc()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_acc";

            CLSset.cn.Open();
            dtacc.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************************* delete buying 22222222 ******************************************
        public void delete_row_b2(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_row_b2";
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }
        //******************************************************* تحديث قيمة الأصناف ******************************************
        public void update_pro(int id, decimal pronewbala)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_pro";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@product_bala", SqlDbType.Decimal).Value = pronewbala;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }
        //******************************************************* تحديث قيمة رأس الفاتورة ******************************************
        public void update_buying(int id, DateTime date, string buyer, decimal total)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_buying11";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = buyer;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;

            CLSset.cn.Open();
            cmd.ExecuteReader();
            CLSset.cn.Close();
        }
        //******************************************************* البحث بالتاريخ ******************************************
        public DataTable dtsea = new DataTable();
        public void Sea_date(DateTime date1, DateTime date2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "search_in_buying";

            cmd.Parameters.Add("@d1", SqlDbType.Date).Value = date1;
            cmd.Parameters.Add("@d2", SqlDbType.Date).Value = date2;


            CLSset.cn.Open();
            dtsea.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************************* والأسم البحث بالتاريخ ******************************************
        public DataTable dtsea2 = new DataTable();
        public void Sea_date2(string b_name, DateTime date1, DateTime date2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "search_in_buying2";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = b_name;
            cmd.Parameters.Add("@d1", SqlDbType.Date).Value = date1;
            cmd.Parameters.Add("@d2", SqlDbType.Date).Value = date2;

            CLSset.cn.Open();
            dtsea2.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //             insert or update products from perchasing
        //***************************************************************************
        public void insert_proor_
            (int id, string name, decimal barcode, string Type, string unit, string address, string model, decimal price, decimal balance, string kkin, string numm, DateTime da, string peradd)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_perchasing_pro_table";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@product_name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("@barcode", SqlDbType.Decimal).Value = barcode;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = Type;
            cmd.Parameters.Add("@unit", SqlDbType.VarChar, 50).Value = unit;
            cmd.Parameters.Add("@adress", SqlDbType.VarChar, 50).Value = address;
            cmd.Parameters.Add("@model", SqlDbType.VarChar, 50).Value = model;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
            cmd.Parameters.Add("@product_bala", SqlDbType.Decimal).Value = balance;
            cmd.Parameters.Add("@carkind", SqlDbType.VarChar, 50).Value = kkin;
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = numm;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = da;
            cmd.Parameters.Add("@perchasing_add", SqlDbType.VarChar, 50).Value = peradd;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();




        }


        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //             update products from perchasing
        //***************************************************************************
        public void update_products_from_perchasing(string name, string carnum, decimal p1, decimal p2, decimal q)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_pro_in_perchasing";
        
            cmd.Parameters.Add("@product_name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = carnum;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = p1;
            cmd.Parameters.Add("@price2", SqlDbType.Decimal).Value = p2;
            cmd.Parameters.Add("@product_bala", SqlDbType.Decimal).Value = q;
           
            
            
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();




        }



    }


}
