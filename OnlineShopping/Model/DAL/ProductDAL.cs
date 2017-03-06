using System.Data;
using DemoEntity.DataProvider;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model.DAL
{
    public class ProductDAL
    {
        public List<Product> getTopNewProduct()
        {
            //Get top 4 products order by Added_Date descending

            List<Product> products = new List<Product>();
            String sql = " SELECT TOP 4 *"
                + " FROM Product"
                + " ORDER BY Created_Date DESC";
            try
            {
                SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Product_ID = reader.GetInt32(0),
                        Catalogue_ID = reader.GetInt32(1),
                        Is_Sale = reader.GetBoolean(2),
                        Product_Name = reader.GetString(3),
                        Price = reader.GetFloat(4),
                        Level_Trending = reader.GetInt32(5),
                        Description = reader.GetString(6),
                        Products_Available = reader.GetInt32(7),
                        Total_Sold = reader.GetInt32(8),
                        Created_Date = reader.GetDateTime(9),
                        Created_Username = reader.GetString(10),
                        Guarantee_Description = reader.GetString(11),
                        Title_Image = reader.GetString(12),
                        Tax_Percent = reader.GetFloat(13),
                        Manufacturer = reader.GetString(14),
                    };

                    products.Add(product);
                }
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }
        public List<Product> getAllNewProduct()
        {
            //GET top 50 new product in 1 month

            List<Product> products = new List<Product>();
            String sql = " SELECT TOP 50 *"
                + " FROM Product"
                + " WHERE Created_Date < DATEADD(month, -1, GETDATE())"
                + " ORDER BY Created_Date DESC";
            try
            {
                SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Product_ID = reader.GetInt32(0),
                        Catalogue_ID = reader.GetInt32(1),
                        Is_Sale = reader.GetBoolean(2),
                        Product_Name = reader.GetString(3),
                        Price = reader.GetFloat(4),
                        Level_Trending = reader.GetInt32(5),
                        Description = reader.GetString(6),
                        Products_Available = reader.GetInt32(7),
                        Total_Sold = reader.GetInt32(8),
                        Created_Date = reader.GetDateTime(9),
                        Created_Username = reader.GetString(10),
                        Guarantee_Description = reader.GetString(11),
                        Title_Image = reader.GetString(12),
                        Tax_Percent = reader.GetFloat(13),
                        Manufacturer = reader.GetString(14),
                    };

                    products.Add(product);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public List<Product> getTopTrending()
        {
            //Get top 4 products order by Level_Trending descending

            List<Product> products = new List<Product>();
            String sql = " SELECT TOP 4 *"
                + " FROM Product"
                + " ORDER BY Level_Trending DESC";
            try
            {
                SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Product_ID = reader.GetInt32(0),
                        Catalogue_ID = reader.GetInt32(1),
                        Is_Sale = reader.GetBoolean(2),
                        Product_Name = reader.GetString(3),
                        Price = reader.GetFloat(4),
                        Level_Trending = reader.GetInt32(5),
                        Description = reader.GetString(6),
                        Products_Available = reader.GetInt32(7),
                        Total_Sold = reader.GetInt32(8),
                        Created_Date = reader.GetDateTime(9),
                        Created_Username = reader.GetString(10),
                        Guarantee_Description = reader.GetString(11),
                        Title_Image = reader.GetString(12),
                        Tax_Percent = reader.GetFloat(13),
                        Manufacturer = reader.GetString(14),
                    };

                    products.Add(product);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public List<Product> getAllTrending()
        {
            //Get top 50 products order by Level_Trending descending AND Level_Trending BETWEEN 1 and 5

            List<Product> products = new List<Product>();
            String sql = " SELECT TOP 50 *"
                + " FROM Product"
                + " WHERE Level_Trending BETWEEN 1 AND 5"
                + " ORDER BY Level_Trending DESC";
            try
            {
                SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Product_ID = reader.GetInt32(0),
                        Catalogue_ID = reader.GetInt32(1),
                        Is_Sale = reader.GetBoolean(2),
                        Product_Name = reader.GetString(3),
                        Price = reader.GetFloat(4),
                        Level_Trending = reader.GetInt32(5),
                        Description = reader.GetString(6),
                        Products_Available = reader.GetInt32(7),
                        Total_Sold = reader.GetInt32(8),
                        Created_Date = reader.GetDateTime(9),
                        Created_Username = reader.GetString(10),
                        Guarantee_Description = reader.GetString(11),
                        Title_Image = reader.GetString(12),
                        Tax_Percent = reader.GetFloat(13),
                        Manufacturer = reader.GetString(14),
                    };

                    products.Add(product);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }
        public List<Product> getTopBestSeller()
        {
            //Get top 4 products order by Total_Sold descending

            List<Product> products = new List<Product>();
            String sql = " SELECT TOP 4 *"
                + " FROM Product"
                + " ORDER BY Total_Sold DESC";
            try
            {
                SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Product_ID = reader.GetInt32(0),
                        Catalogue_ID = reader.GetInt32(1),
                        Is_Sale = reader.GetBoolean(2),
                        Product_Name = reader.GetString(3),
                        Price = reader.GetFloat(4),
                        Level_Trending = reader.GetInt32(5),
                        Description = reader.GetString(6),
                        Products_Available = reader.GetInt32(7),
                        Total_Sold = reader.GetInt32(8),
                        Created_Date = reader.GetDateTime(9),
                        Created_Username = reader.GetString(10),
                        Guarantee_Description = reader.GetString(11),
                        Title_Image = reader.GetString(12),
                        Tax_Percent = reader.GetFloat(13),
                        Manufacturer = reader.GetString(14),
                    };

                    products.Add(product);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public List<Product> getAllBestSeller()
        {
            //Get top 50 products order by Total_Sold descending

            List<Product> products = new List<Product>();
            String sql = " SELECT TOP 50 *"
                + " FROM Product"
                + " ORDER BY Total_Sold DESC";
            try
            {
                SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Product_ID = reader.GetInt32(0),
                        Catalogue_ID = reader.GetInt32(1),
                        Is_Sale = reader.GetBoolean(2),
                        Product_Name = reader.GetString(3),
                        Price = reader.GetFloat(4),
                        Level_Trending = reader.GetInt32(5),
                        Description = reader.GetString(6),
                        Products_Available = reader.GetInt32(7),
                        Total_Sold = reader.GetInt32(8),
                        Created_Date = reader.GetDateTime(9),
                        Created_Username = reader.GetString(10),
                        Guarantee_Description = reader.GetString(11),
                        Title_Image = reader.GetString(12),
                        Tax_Percent = reader.GetFloat(13),
                        Manufacturer = reader.GetString(14),
                    };

                    products.Add(product);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public Product getProductById(int id)
        {
            Product result = null;
            string sql = " SELECT *"
                + " FROM Product"
                + " WHERE Product_ID = " + id;
            try
            {
                SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
                if (reader.Read())
                {
                    result = new Product
                    {
                        Product_ID = reader.GetInt32(0),
                        Catalogue_ID = reader.GetInt32(1),
                        Is_Sale = reader.GetBoolean(2),
                        Product_Name = reader.GetString(3),
                        Price = reader.GetFloat(4),
                        Level_Trending = reader.GetInt32(5),
                        Description = reader.GetString(6),
                        Products_Available = reader.GetInt32(7),
                        Total_Sold = reader.GetInt32(8),
                        Created_Date = reader.GetDateTime(9),
                        Created_Username = reader.GetString(10),
                        Guarantee_Description = reader.GetString(11),
                        Title_Image = reader.GetString(12),
                        Tax_Percent = reader.GetFloat(13),
                        Manufacturer = reader.GetString(14),
                    };
                    return result;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
