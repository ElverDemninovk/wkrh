namespace WinFormTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WinFormTest.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "WinFormTest.MyContext";
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            int index = baseDir.IndexOf("WinFormTest");
            string dataDir = baseDir.Substring(0, index) + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);

        }

        protected override void Seed(WinFormTest.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
