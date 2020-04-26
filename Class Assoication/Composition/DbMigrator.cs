namespace Composition
{
    class DbMigrator
    {
        private readonly Logger _logger;

        // to create a relationship b/w logger class it neet to be pass in the constructor of the class and create the a priavte filed to inital it 
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("data migrate from DB migrator");
        }
    }
}
