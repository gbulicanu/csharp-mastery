using System;

namespace Exercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString)) 
            {
                throw new ArgumentNullException("connectionString");
            }
            this.ConnectionString = connectionString;
        }

        public abstract void Close();
        public abstract void Open();

    }
}
