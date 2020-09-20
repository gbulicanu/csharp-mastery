namespace Composition
{
    public class DbMigrator
    {
        private readonly Logger logger;

        public DbMigrator(Logger logger)
        {
            this.logger = logger;
        }

        public void Migrate() 
        {
            this.logger.Log("Migrating database to new version ...");
        }
    }
}
