using System;

namespace Composition
{
    /*
        is a kind of relationship b/w to class that allow one to contain the other

        HAS_A relationship

        like car has a engine

        benfits: code -reuse , flexibility , help to biult loosly coupled class
    */
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigration = new DbMigrator(new Logger());
            dbMigration.Migrate();

            var installer = new Installer(new Logger());
            installer.Install();

        }
    }
}
