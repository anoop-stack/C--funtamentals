namespace Composition
{
    class Installer
    {
        private readonly Logger _logger;

        // to create a relationship b/w logger class it neet to be pass in the constructor of the class and create the a priavte filed to inital it 
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("data migrate from installer");
        }
    }
}
