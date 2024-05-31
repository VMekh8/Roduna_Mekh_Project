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
                        SendIncomesToDb(reader);
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
                        SendExtendesToDb(reader);
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

        private static void SendIncomesToDb(in SqlDataReader reader)
        {
            try
            {
                db.OpenConnection();

                string query = @"";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue();
                    cmd.Parameters.AddWithValue();
                    cmd.Parameters.AddWithValue();
                    cmd.Parameters.AddWithValue();

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private static void SendExtendesToDb(in SqlDataReader reader)
        {
            try
            {
                db.OpenConnection();

                string query = @"";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue();
                    cmd.Parameters.AddWithValue();
                    cmd.Parameters.AddWithValue();
                    cmd.Parameters.AddWithValue();

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
