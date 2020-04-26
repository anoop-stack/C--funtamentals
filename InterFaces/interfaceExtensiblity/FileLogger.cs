namespace interfaceExtensiblity
{
    class FileLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }

        public void LogError(string message)
        {
            Console.WriteLine(message);
        }
    }
}
