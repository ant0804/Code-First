using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;
using DataAccess;

namespace Chapter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BreakAwayContext>());
            InsertDestination();
           InsertTrip();
            InsertPerson();
            UpdateTrip();
        }

        private static void InsertDestination()
        {
            Destination destination = new Destination
            {
                Name = "Bali",
                Country = "Indonesia",
                Description = "EcoTourism at its best in exquisite Bali"
            };

            using (BreakAwayContext context=new BreakAwayContext())
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }
        }

        private static void InsertTrip()
        {
            Trip trip = new Trip
            {
                CostUSD = 800,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddSeconds(10)
            };
            using (var context = new BreakAwayContext())
            {
                context.Trips.Add(trip);
                context.SaveChanges();
            }
        }

        public static void InsertPerson()
        {
            var person = new Person
            {
                FirstName = "Rowan",
                LastName = "Miller"
            };
            using (var context=new BreakAwayContext())
            {
                context.Persons.Add(person);
                context.SaveChanges();
            }
        }

        public static void UpdateTrip()
        {
            using (var context = new BreakAwayContext())
            {
                var trip = context.Trips.FirstOrDefault();
                trip.CostUSD = 750;
                context.SaveChanges();
            }
        }

        public static void UpdatePerson()
        {
            using (var context=new BreakAwayContext())
            {
                var person = context.Persons.FirstOrDefault();
                person.FirstName = "Rowena";
                context.SaveChanges();
            }
        }

    }
}
