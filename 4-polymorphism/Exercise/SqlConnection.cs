using System;

namespace Exercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing the SQL connection.");
        }

        public override void Open()
        {
            Console.WriteLine("Opening the SQL connection.");
        }
    }
}
