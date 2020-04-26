namespace interfaceExtensiblity
{
    public class Db_Migrator
    {
        private readonly ILogger _logger;

        public Db_Migrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("data was log at: " + DateTime.Now);

        }
    }
}
