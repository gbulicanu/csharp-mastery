using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //var connection = new DbConnection();
            
            var sqlConnectionString = "server=(local)";
            var oracleConnectionString = "server=locahost";

            var sqlConnection = new SqlConnection(sqlConnectionString);
            var oracleConnection = new OracleConnection(oracleConnectionString);

            try
            {
                var badSqlConnection = new SqlConnection(null);
            }
            catch (Exception)
            {

                Console.WriteLine("SQL: Throws exception as expected for null connection strings.");
            }

            try
            {
                var badOracleConnection = new OracleConnection(null);
            }
            catch (Exception)
            {

                Console.WriteLine("Oracle: Throws exception as expected for null connection strings.");
            }

            sqlConnection.Open();
            oracleConnection.Open();

            sqlConnection.Close();
            oracleConnection.Close();

        }
    }
}
