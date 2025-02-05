using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace El_Hamla
{
    class CLSusres
    {
        public static class CurrentUser
        {
            public static string UserName { get; set; }
        }
        public DataTable dt = new DataTable();  
        public void Log(string username, string password)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loginsp";
            cmd.Parameters.Add("@user", SqlDbType.VarChar,50).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;
            CLSset.cn.Open();
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count > 0)
            {
                CurrentUser.UserName = username;
                MessageBox.Show($"User logged in: {CurrentUser.UserName}");

                M_choose f = new M_choose();

               f.ShowDialog();

            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة");

            }
            CLSset.cn.Close();



        }

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
        public void insacc(int id,string user,string pass )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_acc";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = pass;
            CLSset.cn.Open();
            dt.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }
        int mIacc;
        public int mIDacc()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "max_id_acc";
                CLSset.cn.Open();
                mIacc = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {

                mIacc = 0;
            }
            CLSset.cn.Close();
            return mIacc;


        }
        public void deleacc(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CLSset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_row_acc";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
         
            CLSset.cn.Open();
            dt.Load(cmd.ExecuteReader());
            CLSset.cn.Close();
        }



    }



}
