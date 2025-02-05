using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Hamla
{
    class CLSezn_report
    {

        //********************************************رقم السيارة********************************************
        //---------------------------------------------------------------------------------------------------
        //***************************************************************************************************

        public DataTable dt_ezn_re_car = new DataTable();
        public void load_ezn_re_car(string car, DateTime d1, DateTime d2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_cars_sea";
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = car;
            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_ezn_re_car.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //**********************************************************
        public DataTable dt_ezn_re_car2 = new DataTable();
        public void load_ezn_re_car2(string car, DateTime d1, DateTime d2, string t, string m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_cars_sea2";
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = car;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = t;
            cmd.Parameters.Add("@mo", SqlDbType.VarChar, 50).Value = m;
            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_ezn_re_car2.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //**********************************************************
        public DataTable dt_ezn_re_car3 = new DataTable();
        public void load_ezn_re_car3(string car, DateTime d1, DateTime d2, string t)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_cars_sea3";
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = car;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = t;

            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_ezn_re_car3.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //**********************************************************
        public DataTable dt_ezn_re_car4 = new DataTable();

        public void load_ezn_re_car4(string car, DateTime d1, DateTime d2, string m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_cars_sea4";
            cmd.Parameters.Add("@car_num", SqlDbType.VarChar, 50).Value = car;
            cmd.Parameters.Add("@mo", SqlDbType.VarChar, 50).Value = m;

            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_ezn_re_car4.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //***************************************************************************************************
        //-----------------------------------أمر الشغل ------------------------------------------------------
        //***************************************************************************************************
        public DataTable dt_ezn_re_amr = new DataTable();
        public void load_ezn_re_amr(string amr, DateTime d1, DateTime d2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_amr_sea";
            cmd.Parameters.Add("@work_num", SqlDbType.VarChar, 50).Value = amr;
            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_ezn_re_amr.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //***************************************************************************************************
        public DataTable dt_ezn_re_amr2 = new DataTable();
        public void load_ezn_re_amr2(string amr, DateTime d1, DateTime d2, string t, string m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_amr_sea2";
            cmd.Parameters.Add("@work_num", SqlDbType.VarChar, 50).Value = amr;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = t;
            cmd.Parameters.Add("@mo", SqlDbType.VarChar, 50).Value = m;
            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_ezn_re_amr2.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //***************************************************************************************************
        public DataTable dt_ezn_re_amr3 = new DataTable();
        public void load_ezn_re_amr3(string car, DateTime d1, DateTime d2, string t)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_amr_sea3";
            cmd.Parameters.Add("@work_num", SqlDbType.VarChar, 50).Value = car;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = t;

            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_ezn_re_amr3.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //***************************************************************************************************
        public DataTable dt_ezn_re_amr4 = new DataTable();

        public void load_ezn_re_amr4(string car, DateTime d1, DateTime d2, string m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_amr_sea4";
            cmd.Parameters.Add("@work_num", SqlDbType.VarChar, 50).Value = car;
            cmd.Parameters.Add("@mo", SqlDbType.VarChar, 50).Value = m;

            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_ezn_re_amr4.Load(cmd.ExecuteReader());
            CLSset.cn.Close();



        }
        //***************************************************************************************************
        //-----------------------------------جهة المركبة ----------------------------------------------------------
        //***************************************************************************************************

        public DataTable dt_ezn_re_add = new DataTable();
        public void load_ezn_re_add(string amr, DateTime d1, DateTime d2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_add_sea";
            cmd.Parameters.Add("@car_add", SqlDbType.VarChar, 50).Value = amr;
            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_ezn_re_add.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //****************************************************************************************************
        public DataTable dt_ezn_re_add2 = new DataTable();
        public void load_ezn_re_add2(string amr, DateTime d1, DateTime d2, string t, string m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_add_sea2";
            cmd.Parameters.Add("@car_add", SqlDbType.VarChar, 50).Value = amr;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = t;
            cmd.Parameters.Add("@mo", SqlDbType.VarChar, 50).Value = m;
            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_ezn_re_add2.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }


        //*******************************************************************************************************
      
        public DataTable dt_ezn_re_add3 = new DataTable();
        public void load_ezn_re_add3(string car, DateTime d1, DateTime d2, string t)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_add_sea3";
            cmd.Parameters.Add("@car_add", SqlDbType.VarChar, 50).Value = car;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = t;

            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_ezn_re_add3.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }




        //*******************************************************************************************************
        public DataTable dt_ezn_re_add4 = new DataTable();
        public void load_ezn_re_add4(string car, DateTime d1, DateTime d2, string m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ezn_report_add_sea4";
            cmd.Parameters.Add("@car_add", SqlDbType.VarChar, 50).Value = car;
            cmd.Parameters.Add("@mo", SqlDbType.VarChar, 50).Value = m;

            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;
            CLSset.cn.Open();
            dt_ezn_re_add4.Load(cmd.ExecuteReader());
            CLSset.cn.Close();



        }
        //*******************************************************************************************************
        public DataTable dt_magg_re_add = new DataTable();
        public void load_magg_re_add(string amr, DateTime d1, DateTime d2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "maghood_sea";
            cmd.Parameters.Add("@car_add", SqlDbType.VarChar, 50).Value = amr;
            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_magg_re_add.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //*******************************************************************************************************

        public DataTable dt_magg2_re_add = new DataTable();
        public void load_magg2_re_add(string amr, DateTime d1, DateTime d2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "magg22";
            cmd.Parameters.Add("@car_add", SqlDbType.VarChar, 50).Value = amr;
            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = d2;

            CLSset.cn.Open();
            dt_magg2_re_add.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //***********************************************************************************************************

        //*******************************************************تقرير الصرف *******************************


        public DataTable FilterEznData(DateTime? startDate, DateTime? endDate, string carNum, string workNum, string type, string proAdd,string car_add)
        {
            // إنشاء DataTable لتخزين النتائج
            DataTable dtEznData = new DataTable();

            // إنشاء اتصال وتنفيذ الإجراء المخزن
            using (SqlCommand cmd = new SqlCommand("FilterEznData", CLSset.cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // تمرير المعاملات مع التحقق من القيم الفارغة
                cmd.Parameters.Add("@startDate", SqlDbType.DateTime).Value = (object)startDate ?? DBNull.Value;
                cmd.Parameters.Add("@endDate", SqlDbType.DateTime).Value = (object)endDate ?? DBNull.Value;
                cmd.Parameters.Add("@carNum", SqlDbType.NVarChar, 50).Value = string.IsNullOrWhiteSpace(carNum) ? DBNull.Value : carNum.Trim();
                cmd.Parameters.Add("@workNum", SqlDbType.NVarChar, 50).Value = string.IsNullOrWhiteSpace(workNum) ? DBNull.Value : workNum.Trim();
                cmd.Parameters.Add("@type", SqlDbType.NVarChar, 50).Value = string.IsNullOrWhiteSpace(type) ? DBNull.Value : type.Trim();
                cmd.Parameters.Add("@proAdd", SqlDbType.NVarChar, 100).Value = string.IsNullOrWhiteSpace(proAdd) ? DBNull.Value : proAdd.Trim();
                cmd.Parameters.Add("@car_add", SqlDbType.NVarChar, 100).Value = string.IsNullOrWhiteSpace(car_add) ? DBNull.Value : car_add.Trim();
                // فتح الاتصال وتنفيذ الإجراء المخزن، وتعبئة DataTable بالنتائج
                CLSset.cn.Open();
                dtEznData.Load(cmd.ExecuteReader());
                CLSset.cn.Close();
            }

            return dtEznData;
        }
        public DataTable FilterEznData222( string carNum, string workNum, string type, string proAdd, string car_add)
        {
            // إنشاء DataTable لتخزين النتائج
            DataTable dtEznData = new DataTable();

            // إنشاء اتصال وتنفيذ الإجراء المخزن
            using (SqlCommand cmd = new SqlCommand("FilterEznData22222", CLSset.cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // تمرير المعاملات مع التحقق من القيم الفارغة
               
                cmd.Parameters.Add("@carNum", SqlDbType.NVarChar, 50).Value = string.IsNullOrWhiteSpace(carNum) ? DBNull.Value : carNum.Trim();
                cmd.Parameters.Add("@workNum", SqlDbType.NVarChar, 50).Value = string.IsNullOrWhiteSpace(workNum) ? DBNull.Value : workNum.Trim();
                cmd.Parameters.Add("@type", SqlDbType.NVarChar, 50).Value = string.IsNullOrWhiteSpace(type) ? DBNull.Value : type.Trim();
                cmd.Parameters.Add("@proAdd", SqlDbType.NVarChar, 100).Value = string.IsNullOrWhiteSpace(proAdd) ? DBNull.Value : proAdd.Trim();
                cmd.Parameters.Add("@car_add", SqlDbType.NVarChar, 100).Value = string.IsNullOrWhiteSpace(car_add) ? DBNull.Value : car_add.Trim();
                // فتح الاتصال وتنفيذ الإجراء المخزن، وتعبئة DataTable بالنتائج
                CLSset.cn.Open();
                dtEznData.Load(cmd.ExecuteReader());
                CLSset.cn.Close();
            }

            return dtEznData;
        }

    }
}
