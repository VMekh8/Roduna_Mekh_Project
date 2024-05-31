using System;
using System.Data.SqlClient;

namespace Roduna_Mekh_Project.CostsFlow
{
    public static class CostFlow
    {
        private static DataBase db = new DataBase();
        public static SqlDataReader GetTotalIncomes()
        {
            try
            {
                db.OpenConnection();

                string query = @"";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                db.CloseConnection();
            }

        }

        public static SqlDataReader GetTotalExtendes()
        {
            try
            {
                db.OpenConnection();

                string query = @"";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
