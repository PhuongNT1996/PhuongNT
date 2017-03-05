using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEntity.DataProvider;
using System.Data;
using Model.Models;
using System.Data.SqlClient;
using Encryption;

namespace Model.DAL
{
   public class AccountDAL
    {
        public User_Account checkLogin(string email, string password)
        {
            string sql = "SELECT * FROM User_Account WHERE Email= N'"
                + email + "'";
            try
            {
                SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
                if (reader.Read())
                {
                    User_Account user = new User_Account
                    {
                        Email = reader.GetString(0),
                        Password = reader.GetString(1),
                        Full_Name = reader.GetString(2),
                        Birthday = reader.GetDateTime(3),
                        Gender = reader.GetString(4),
                        Address = reader.GetString(5),
                        Cancel_Amount = reader.GetInt32(6),
                        created_Date = reader.GetDateTime(7)
                    };
                    EncryptionSHA sha = new EncryptionSHA();
                    bool result = sha.doesPasswordMatch(password, user.Password);
                    return result ? user : null;
                }

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public User_Account getUser(string email)
        {
            string sql = "SELECT * FROM User_Account WHERE Email= N'"
               + email + "'";
            try
            {
                SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
                if (reader.Read())
                {
                    User_Account user = new User_Account
                    {
                        Email = reader.GetString(0),
                        Password = reader.GetString(1),
                        Full_Name = reader.GetString(2),
                        Birthday = reader.GetDateTime(3),
                        Gender = reader.GetString(4),
                        Address = reader.GetString(5),
                        Cancel_Amount = reader.GetInt32(6),
                        created_Date = reader.GetDateTime(7)
                    };
                    return user;
                }                    
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }


        public bool checkExist(string email)
        {

            string sql = "SELECT * FROM User_Account WHERE Email= N'" + email + "'";
            try
            {
                SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
                if (reader.Read())
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }

        public void registerAccount(string email, string password, string fullName, DateTime birthday, string gender, string address, DateTime today)
        {
            int number = 0;
            string sql = "INSERT User_Account VALUES (@Email, @Password, @Full_Name, @Birthday, @Gender, @Address, @Cancel_Amount, @created_Date)";
            SqlParameter emailParam = new SqlParameter("@Email", email);

            EncryptionSHA sha = new EncryptionSHA();
            string hashPassword = sha.getHashedPassword(password);
            SqlParameter passwordParam = new SqlParameter("@Password", hashPassword);
            SqlParameter fullNameParam = new SqlParameter("@Full_Name", fullName);
            SqlParameter birthdayParam = new SqlParameter("@Birthday", birthday);
            SqlParameter genderParam = new SqlParameter("@Gender", gender);
            SqlParameter addressParam = new SqlParameter("@Address", address);
            SqlParameter cancelParam = new SqlParameter("@Cancel_Amount", number);
            SqlParameter todayParam = new SqlParameter("@created_Date", today);
            try
            {
                bool result = DataProvider.ExecuteNonQuery(sql, CommandType.Text, emailParam, passwordParam, fullNameParam, birthdayParam, genderParam, addressParam,cancelParam, todayParam);              
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void updateAccount(string email,string fullname, DateTime birthday, string gender, string address)
        {
            string sql = "UPDATE User_Account SET Full_Name = @Full_Name, Birthday = @Birthday, Gender = @Gender, Address = @Address WHERE Email = @Email";
            SqlParameter emailParam = new SqlParameter("@Email", email);
            SqlParameter fullNameParam = new SqlParameter("@Full_Name", fullname);
            SqlParameter birthdayParam = new SqlParameter("@Birthday", birthday);
            SqlParameter genderParam = new SqlParameter("@Gender", gender);
            SqlParameter addressParam = new SqlParameter("@Address", address);
            try
            {
                bool result = DataProvider.ExecuteNonQuery(sql, CommandType.Text, fullNameParam, birthdayParam, genderParam, addressParam, emailParam);
              
            } catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
