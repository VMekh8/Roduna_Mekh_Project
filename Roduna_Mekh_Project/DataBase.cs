using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Roduna_Mekh_Project
{
    class DataBase
    {
        SqlConnection connection = new SqlConnection("Data Source=5.58.28.5,1433; Database=Roduna_MekhFG; Persist Security Info=false; User ID='st'; Password='111'; MultipleActiveResultSets=True; Trusted_Connection=False;");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
        }

        
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
