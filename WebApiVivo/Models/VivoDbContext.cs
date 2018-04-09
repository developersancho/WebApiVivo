using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace WebApiVivo.Models
{
    public class VivoDbContext : DbContext
    {

        string path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;

        //public VivoDbContext():base("default")
        //{

        //}

        public VivoDbContext() : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + "Database.db"
            }.ConnectionString
        }, true)
        { }

        public DbSet<AllModel> All { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<VivoDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

        }
    }
}