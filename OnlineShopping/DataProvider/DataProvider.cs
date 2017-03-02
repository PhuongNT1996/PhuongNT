using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntity.DataProvider
{
    public static class DataProvider
    {

        public static string getConnectionString()
        {
            string strConnection = "server=.;database=OnlineShopping;uid=sa;pwd=123a";
            return strConnection;
        }

        //Execute Query
        public static DataSet ExecuteQueryWithDataSet(string strSQL,
            CommandType cmdType,
            params SqlParameter[] param)
        {
            SqlConnection cnn = new SqlConnection(getConnectionString());
            SqlCommand cmd = new SqlCommand(strSQL, cnn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static SqlDataReader ExecuteQueryWithDataReader(string strSQL,
            CommandType cmdType, params SqlParameter[] param)
        {
            SqlDataReader rd = null;
            SqlConnection cnn = new SqlConnection(getConnectionString());
            SqlCommand cmd = new SqlCommand(strSQL, cnn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(param);
            try
            {
                cnn.Open();
                rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
            return rd;
        }
        //ExecuteNonQuery
        public static bool ExecuteNonQuery(string strSQL,
            CommandType cmdType, params SqlParameter[] paramList)
        {
            bool result = false;
            SqlConnection cnn = new SqlConnection(getConnectionString());
            SqlCommand cmd = new SqlCommand(strSQL, cnn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(paramList);
            try
            {
                cnn.Open();
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return result;
        }
    }
}
