using System.Data.Common;
using MySql.Data.MySqlClient;

namespace YkAbp.EntityFrameworkCore
{
    public class DatabaseCheckHelper
    {
        public static bool Exist(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                //connectionString is null for unit tests
                return true;
            }

            using (DbConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    return false;
                }

                return true;
            }
        }
    }
}