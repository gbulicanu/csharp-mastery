using System;

namespace Exercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing oracle connection.");
        }

        public override void Open()
        {
            Console.WriteLine("Opening oracle connection.");
        }
    }
}
