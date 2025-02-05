using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Hamla
{
   class CLS_AA_pro
    {

        public DataTable dtProject2_name = new DataTable();

        //******************************************** load data ***************************************************
        public void loadProjects2_name(string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_GetAllProjects2_name"; // استدعاء الإجراء المخزن لتحميل البيانات
                cmd.Parameters.Add("@name", SqlDbType.VarChar,50).Value = name;
                CLSset.cn.Open();
                dtProject2_name.Load(cmd.ExecuteReader());
                CLSset.cn.Close();
            }
        }
        public DataTable dtProject2 = new DataTable();

        //******************************************** load data ***************************************************
        public void loadProjects2(int id)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_GetAllProjects2"; // استدعاء الإجراء المخزن لتحميل البيانات
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                CLSset.cn.Open();
                dtProject2.Load(cmd.ExecuteReader());
                CLSset.cn.Close();
            }
        }
        public DataTable dtProjectid1 = new DataTable();

        //******************************************** load data ***************************************************
        public void loadProjectsid1(int id)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_GetAllProjectsby_id"; // استدعاء الإجراء المخزن لتحميل البيانات
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                CLSset.cn.Open();
                dtProjectid1.Load(cmd.ExecuteReader());
                CLSset.cn.Close();
            }
        }
        public DataTable dtProject_name = new DataTable();

        //******************************************** load data ***************************************************
        public void loadProjects_name(string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_GetAllProjectsby_name"; // استدعاء الإجراء المخزن لتحميل البيانات
                cmd.Parameters.Add("@name", SqlDbType.VarChar,255).Value = name;
                CLSset.cn.Open();
                dtProject_name.Load(cmd.ExecuteReader());
                CLSset.cn.Close();
            }
        }
        //******************************************** insert data ***************************************************
        public void insertProject2(int id, string name, string type, decimal bala, decimal mo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_InsertProject2"; // استدعاء الإجراء المخزن للإدخال

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = name;
                cmd.Parameters.Add("@type", SqlDbType.NVarChar, 50).Value = type;
                cmd.Parameters.Add("@bala", SqlDbType.Decimal).Value = bala;
                cmd.Parameters.Add("@moqa", SqlDbType.Decimal).Value = mo;

                CLSset.cn.Open();
                cmd.ExecuteNonQuery();
                CLSset.cn.Close();
            }
        }

        //******************************************** update data ***************************************************
        public void updateProject2( string name, decimal bala)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_UpdateProject2"; // استدعاء الإجراء المخزن للتحديث

               
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = name;
              
                cmd.Parameters.Add("@bala", SqlDbType.Decimal).Value = bala;

                CLSset.cn.Open();
                cmd.ExecuteNonQuery();
                CLSset.cn.Close();
            }
        }

        //******************************************** delete data ***************************************************
        public void deleteProject2(string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_DeleteProject2"; // استدعاء الإجراء المخزن للحذف

                cmd.Parameters.Add("@name", SqlDbType.VarChar,100).Value = name;

                CLSset.cn.Open();
                cmd.ExecuteNonQuery();
                CLSset.cn.Close();
            }
        }
        public DataTable dtProject = new DataTable();

        //******************************************** load data ***************************************************
        public void loadProjects()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_GetAllProjects"; // استدعاء الإجراء المخزن لتحميل البيانات من AA_Projects

                CLSset.cn.Open();
                dtProject.Load(cmd.ExecuteReader());
                CLSset.cn.Close();
            }
        }

        //******************************************** insert data ***************************************************
        public void insertProject(int projectId, string projectName, decimal totalCost, decimal totalProfit, decimal totalTot, decimal total_income)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_InsertProject"; // استدعاء الإجراء المخزن للإدخال في AA_Projects

                cmd.Parameters.Add("@ProjectID", SqlDbType.Int).Value = projectId;
                cmd.Parameters.Add("@ProjectName", SqlDbType.NVarChar, 100).Value = projectName;
                cmd.Parameters.Add("@TotalCost", SqlDbType.Decimal).Value = totalCost;
                cmd.Parameters.Add("@TotalProfit", SqlDbType.Decimal).Value = totalProfit;
                cmd.Parameters.Add("@totaltot", SqlDbType.Decimal).Value = totalTot;
                cmd.Parameters.Add("@total_income", SqlDbType.Decimal).Value = total_income;

                CLSset.cn.Open();
                cmd.ExecuteNonQuery();
                CLSset.cn.Close();
            }
        }

        //******************************************** update data ***************************************************
        public void updateProject(int projectId, string projectName, decimal totalCost, decimal totalProfit, decimal totalTot, decimal totalinc)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_UpdateProject"; // استدعاء الإجراء المخزن للتحديث في AA_Projects

                cmd.Parameters.Add("@ProjectID", SqlDbType.Int).Value = projectId;
                cmd.Parameters.Add("@ProjectName", SqlDbType.NVarChar, 100).Value = projectName;
                cmd.Parameters.Add("@TotalCost", SqlDbType.Decimal).Value = totalCost;
                cmd.Parameters.Add("@TotalProfit", SqlDbType.Decimal).Value = totalProfit;
                cmd.Parameters.Add("@totaltot", SqlDbType.Decimal).Value = totalTot;
                cmd.Parameters.Add("@Total_income", SqlDbType.Decimal).Value = totalinc;

                CLSset.cn.Open();
                cmd.ExecuteNonQuery();
                CLSset.cn.Close();
            }
        }
        public void updateProject_income(int projectId,decimal totalinc)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_UpdateProject_income"; // استدعاء الإجراء المخزن للتحديث في AA_Projects

                cmd.Parameters.Add("@ProjectID", SqlDbType.Int).Value = projectId;
                
                cmd.Parameters.Add("@Total_income", SqlDbType.Decimal).Value = totalinc;

                CLSset.cn.Open();
                cmd.ExecuteNonQuery();
                CLSset.cn.Close();
            }
        }

        //******************************************** delete data ***************************************************
        public void deleteProject(int projectId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = CLSset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AA_DeleteProject"; // استدعاء الإجراء المخزن للحذف من AA_Projects

                cmd.Parameters.Add("@ProjectID", SqlDbType.Int).Value = projectId;

                CLSset.cn.Open();
                cmd.ExecuteNonQuery();
                CLSset.cn.Close();
            }
        }



    }
}
