using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace El_Hamla
{
    class CLSproduct
    {

        //******************************************** load data ***************************************************

        public DataTable dtproducts = new DataTable();
        public void loadproducts()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loadproducts";
           
            CLSset.cn.Open();
            dtproducts.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //******************************************* Max barcode****************************************************

        decimal mbarcode;
        public decimal maxbarcode()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "maxbarcode";
                CLSset.cn.Open();
                mbarcode = Convert.ToDecimal(cmd.ExecuteScalar());
                
            }
            catch
            {

                mbarcode = 10000000000;
            }
            CLSset.cn.Close();
            return mbarcode;


        }

        //******************************************* Max Id****************************************************

        int mID;
        public int maxID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "maxidproduct";
                CLSset.cn.Open();
                mID = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mID = 0;
            }
            CLSset.cn.Close();
            return mID;


        }

        //********************************************************insert data************************************************

        public void insert_pro(int id,string name,decimal barcode,string Type ,string unit ,string address ,string model,decimal price,decimal balance, string kkin, string numm,string hag)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertproducts";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@pro_name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("@barcode", SqlDbType.Decimal).Value = barcode;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = Type;
            cmd.Parameters.Add("@unit", SqlDbType.VarChar, 50).Value = unit;
            cmd.Parameters.Add("@adress", SqlDbType.VarChar, 50).Value = address;
            cmd.Parameters.Add("@model", SqlDbType.VarChar, 50).Value = model;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
            cmd.Parameters.Add("@balance", SqlDbType.Decimal).Value = balance;
            cmd.Parameters.Add("@carkind", SqlDbType.VarChar, 50).Value = kkin;
            cmd.Parameters.Add("@carnum", SqlDbType.VarChar, 50).Value = numm;
            cmd.Parameters.Add("@hagez", SqlDbType.VarChar, 50).Value = hag;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }
        //********************************************************** insert type ********************************************************
        public void insert_type(int id_type, string type_name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_type";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_type;
            cmd.Parameters.Add("@type_name", SqlDbType.VarChar, 50).Value = type_name;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }
        //******************************************************** insert unit **********************************************************
        public void insert_unit(int id_unit, string unit_name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_unit";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_unit;
            cmd.Parameters.Add("@unit_name", SqlDbType.VarChar, 50).Value = unit_name;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }

        //******************************************************* insert address **********************************************************

        public void insert_buyaddress(int id_add, string add_name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_buyAddress";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_add;
            cmd.Parameters.Add("@address_name", SqlDbType.VarChar, 50).Value = add_name;
            CLSset.cn.Open();
            cmd.ExecuteNonQuery();
            CLSset.cn.Close();

        }
        //********************************************************max buy add id ***********************

        int mIDadd;
        public int mIDaddaa()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "max_buyAddress";
                CLSset.cn.Open();
                mIDadd = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mIDadd = 0;
            }
            CLSset.cn.Close();
            return mIDadd;


        }
        //********************************************************max type id ***********************

        int mIDtype;
        public int mIDtypee()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "max_type";
                CLSset.cn.Open();
                mIDtype = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mIDtype = 0;
            }
            CLSset.cn.Close();
            return mIDtype;


        }

        //********************************************************max unit id ***********************

        int mIDunit;
        public int mIDunitt()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "max_unit";
                CLSset.cn.Open();
                mIDunit = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mIDunit = 0;
            }
            CLSset.cn.Close();
            return mIDunit;


        }
        public DataTable dt_pro_text = new DataTable();
        public void sea_pro_by_text(string text)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pro_search_in_ezn";
            cmd.Parameters.Add("@text", SqlDbType.VarChar,50).Value = text;

            CLSset.cn.Open();
            dt_pro_text.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        //************************************************************************************************
        public DataTable dt_pro_fillter = new DataTable();

        public void sea_pro_fillter(string proname, string add, string hag, string type, string balanceText, string op)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "FilterProducts";

            // Set parameters and handle NULL values
            cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 50).Value = string.IsNullOrEmpty(proname) ? (object)DBNull.Value : proname;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 50).Value = string.IsNullOrEmpty(add) ? (object)DBNull.Value : add;
            cmd.Parameters.Add("@HagesState", SqlDbType.NVarChar, 50).Value = string.IsNullOrEmpty(hag) ? (object)DBNull.Value : hag;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = string.IsNullOrEmpty(type) ? (object)DBNull.Value : type;

            // Handle balance value and operator
            if (string.IsNullOrEmpty(balanceText))
            {
                cmd.Parameters.Add("@BalanceValue", SqlDbType.Decimal).Value = DBNull.Value;
            }
            else
            {
                decimal balanceValue;
                if (decimal.TryParse(balanceText, out balanceValue))
                {
                    cmd.Parameters.Add("@BalanceValue", SqlDbType.Decimal).Value = balanceValue;
                }
                else
                {
                    // Handle invalid decimal input
                    MessageBox.Show("Please enter a valid decimal value for the balance.");
                    return;
                }
            }

            cmd.Parameters.Add("@BalanceOperator", SqlDbType.NVarChar, 2).Value = string.IsNullOrEmpty(op) ? "=" : op;

            try
            {
                CLSset.cn.Open();
                dt_pro_fillter.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                // Handle any errors here
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                CLSset.cn.Close();
            }
        }


    }
}
