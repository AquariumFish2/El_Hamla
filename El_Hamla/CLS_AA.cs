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
    class CLS_AA
    {

        //********************************************الشيكاااااااااااااااااااااااااااااااااااااات********************************************
        //---------------------------------------------------------------------------------------------------
       
        //********************************************************max check id ***********************


        int mIDcheck;
        public int maxIDcheck()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "max_check_id";
                CLSset.cn.Open();
                mIDcheck = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mIDcheck = 0;
            }
            CLSset.cn.Close();
            return mIDcheck;


        }
        //******************************************** load data ***************************************************

        public DataTable dtcheck = new DataTable();
        public void loadcheck()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_check_id";

            CLSset.cn.Open();
            dtcheck.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** load data by id ***************************************************

        public DataTable dtcheckid = new DataTable();
        public void loadcheckid(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_check_by_id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            CLSset.cn.Open();
            dtcheckid.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** load data by name ***************************************************

        public DataTable dtcheckname  = new DataTable();
        public void loadcheckname(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_check_by_id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            CLSset.cn.Open();
            dtcheckid.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** insert data ***************************************************

        public void insert_check(int id, string num,DateTime date, decimal bala,decimal per,decimal net ,string addressr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_check";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@check_num", SqlDbType.VarChar, 50).Value = num;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@check_bala", SqlDbType.Decimal).Value =bala;
            cmd.Parameters.Add("@per", SqlDbType.Decimal).Value = per;
            cmd.Parameters.Add("@net", SqlDbType.Decimal).Value = net;
            cmd.Parameters.Add("@add", SqlDbType.VarChar, 50).Value = addressr;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }
       
        //******************************************** delete data ***************************************************

        public void delete_check(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_row_check";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }
        //********************************************الحسابات********************************************
        //---------------------------------------------------------------------------------------------------

        //********************************************************max check id ***********************


        int mIDaccc;
        public int maxIDaccc()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "maxId_mo_acc";
                CLSset.cn.Open();
                mIDaccc = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mIDaccc = 0;
            }
            CLSset.cn.Close();
            return mIDaccc;


        }
        //******************************************** load data ***************************************************

        public DataTable dtaccc = new DataTable();
        public void loadacc()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_mo_id";

            CLSset.cn.Open();
            dtaccc.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** load net blance from table cheak ***************************************************

        public DataTable netblance = new DataTable();
        public void loadnetbalane(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Load_Net_Balance";
            cmd.Parameters.Add("@RowID", SqlDbType.Int, 50).Value = id;
            
            CLSset.cn.Open();
            netblance.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** load all blance from table cheak ***************************************************

        public DataTable allbalance = new DataTable();
        public decimal loadallbalance()
        {
            decimal total = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Get_Sum_Check_balance";
            CLSset.cn.Open();
            allbalance.Load(cmd.ExecuteReader());
            total = Convert.ToDecimal(cmd.ExecuteScalar());
            CLSset.cn.Close();
            return total;
        }
        //******************************************** load data by name ***************************************************

        public DataTable dtacccn = new DataTable();
        public void loadaccn(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "load_AA_by_name";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
            CLSset.cn.Open();
            dtacccn.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //********************************************load net balance total***************************************************

        public DataTable allNetBalance = new DataTable();
        public decimal loadAllNetBalance(string name)
        {
            decimal total = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Get_Net_Check_balance";
            CLSset.cn.Open();
            dtacccn.Load(cmd.ExecuteReader());
            total = Convert.ToDecimal(cmd.ExecuteScalar());
            CLSset.cn.Close();
            return total;

        }
        //******************************************** update check balance ***************************************************

        public DataTable dtaccb = new DataTable();
        public void updateaccb(decimal balance,int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_sal_acc";
            cmd.Parameters.Add("@balance", SqlDbType.Decimal).Value = balance;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            CLSset.cn.Open();
            dtacccn.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }

        //******************************************** update MO balance ***************************************************

        public DataTable dtmob = new DataTable();
        public void updatemob(decimal balance,int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_mo_acc";
            cmd.Parameters.Add("@balance", SqlDbType.Decimal).Value = balance;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            CLSset.cn.Open();
            dtmob.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** insert data ***************************************************


        public void insert_MO_table(int id, string mo_name, string acc_type, decimal balance)
        {
            // إنشاء كائن SqlCommand
            SqlCommand cmd = new SqlCommand();

            // تعيين الاتصال لقاعدة البيانات
            cmd.Connection = CLSset.cn;

            // تحديد نوع الأمر كإجراء مخزن
            cmd.CommandType = CommandType.StoredProcedure;

            // تعيين اسم الإجراء المخزن
            cmd.CommandText = "AddTo_MO_table";

            // إضافة المعلمات إلى الإجراء المخزن
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@mo_name", SqlDbType.VarChar, 50).Value = mo_name;
            cmd.Parameters.Add("@acc_type", SqlDbType.VarChar, 50).Value = acc_type;
            cmd.Parameters.Add("@balance", SqlDbType.Decimal).Value = balance;

            // فتح الاتصال بقاعدة البيانات
            CLSset.cn.Open();

            // تنفيذ الإجراء المخزن
            cmd.ExecuteNonQuery();

            // إغلاق الاتصال بقاعدة البيانات
            CLSset.cn.Close();
        }


        //******************************************** delete data ***************************************************

        public void delete_MO_table(int id)
        {
            // إنشاء كائن SqlCommand
            SqlCommand cmd = new SqlCommand();

            // تعيين الاتصال بقاعدة البيانات
            cmd.Connection = CLSset.cn;

            // تعيين استعلام الحذف
            cmd.CommandText = "DELETE FROM _MO_table WHERE id_mo = @id";

            // إضافة المعلمة id إلى الاستعلام
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            // فتح الاتصال بقاعدة البيانات
            CLSset.cn.Open();

            // تنفيذ استعلام الحذف
            cmd.ExecuteNonQuery();

            // إغلاق الاتصال بقاعدة البيانات
            CLSset.cn.Close();
        }

        //*************************************************TRANSACTION***********************************


        public void insert_AA_trans(int id_trans, DateTime trans_date, string sender_kind, string sender_name, string re_kind, string re_name, decimal amount, string details)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;  // افترض أن CLSset.cn هي اتصال SQL
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertTransaction";  // اسم الإجراء المخزن
            cmd.Parameters.Add("@id_trans", SqlDbType.Int).Value = id_trans;
            cmd.Parameters.Add("@trans_date", SqlDbType.Date).Value = trans_date;
            cmd.Parameters.Add("@sender_kind", SqlDbType.NVarChar, 50).Value = sender_kind;
            cmd.Parameters.Add("@sender_name", SqlDbType.NVarChar, 50).Value = sender_name;
            cmd.Parameters.Add("@re_kind", SqlDbType.NVarChar, 50).Value = re_kind;
            cmd.Parameters.Add("@re_name", SqlDbType.NVarChar, 50).Value = re_name;
            cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
            cmd.Parameters.Add("@details", SqlDbType.NVarChar).Value = details;

            CLSset.cn.Open();  // فتح الاتصال بقاعدة البيانات
            cmd.ExecuteNonQuery();  // تنفيذ الإجراء المخزن
            CLSset.cn.Close();  // إغلاق الاتصال بقاعدة البيانات
        }
        //********************************************************max mIDTRANS id ***********************


        int mIDTRANS;
        public int maxIDTRANS()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "max_id_trans";
                CLSset.cn.Open();
                mIDTRANS = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mIDTRANS = 0;
            }
            CLSset.cn.Close();
            return mIDTRANS;


        }
        //******************************************** load data ***************************************************

        public DataTable dtTRANS = new DataTable();
        public void loadtrans()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LOAD_trans";
            CLSset.cn.Close();
            CLSset.cn.Open();
            dtTRANS.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************** delete data ***************************************************

        public void delete_AA_trans(int id_trans)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;  // افترض أن CLSset.cn هي اتصال SQL
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_AA_trans";  // اسم الإجراء المخزن لحذف البيانات
            cmd.Parameters.Add("@id_trans", SqlDbType.Int).Value = id_trans;

            CLSset.cn.Open();  // فتح الاتصال بقاعدة البيانات
            cmd.ExecuteNonQuery();  // تنفيذ الإجراء المخزن لحذف السجل
            CLSset.cn.Close();  // إغلاق الاتصال بقاعدة البيانات
        }

    }
}
