using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormTest.Models;

namespace WinFormTest
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContextDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyContext,
                WinFormTest.Migrations.Configuration>("MyContextDB"));
        }

        public virtual DbSet<Users> Users { get; set; }

    }

}
