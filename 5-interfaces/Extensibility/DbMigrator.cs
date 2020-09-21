using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger logger;


        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }
        
        public void Migrate() 
        {
            this.logger.LogInfo("Migration started at " + DateTime.Now);

            // Details of migrating the database

            this.logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}
