using System;

namespace Extensibility
{
    public class DbMigrator
    {
        public void Migrate() 
        {
            Console.WriteLine("Migration started at {0}", DateTime.Now);

            // Details of migrating the database

            Console.WriteLine("Migration finished at {0}", DateTime.Now);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
