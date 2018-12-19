using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace DataAccess
{
    public class BreakAwayContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Destination>().ToTable("Destination");
            //modelBuilder.Entity<Destination>().Property(obj => obj.Name).IsRequired();
            //modelBuilder.Entity<Destination>().Property(obj => obj.Photo).HasColumnType("varbinary");
            //modelBuilder.Entity<Destination>().Property(obj => obj.Photo).HasMaxLength(Int32.MaxValue);

        }

        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Lodging> Lodgings { get; set; }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<Person> Persons { get; set; }
    }
}
