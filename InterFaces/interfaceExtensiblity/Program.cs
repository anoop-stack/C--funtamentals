using System;

namespace interfaceExtensiblity
{
    class Program
    {
        // in C# we cannot have multiple inheritance , but can have multiple Interface
        static void Main(string[] args)
        {
           var db_migration = new Db_Migrator(new ConsoleLogger());
           db_migration.Migrate();
        }
    }
}
