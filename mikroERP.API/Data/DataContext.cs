using System;
using Microsoft.EntityFrameworkCore;
using mikroERP.API.Models;

namespace mikroERP.API.Data
{
    public class DataContext : DbContext
    {
      public DataContext(DbContextOptions<DataContext> options) : base(options){ }
      public DbSet<Employee> Employees {get; set;}
      public DbSet<Department> Departments { get; set; }
      public DbSet<Location> Locations { get; set; }
      public DbSet<Transport> Transports { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Department>().HasData( //write seed here
             new Department { Id = 1, NameOfDepartment = "Management", LocationId = 1 },
             new Department { Id = 2, NameOfDepartment = "Logistics Department", LocationId = 2 },
             new Department { Id = 3, NameOfDepartment = "Administration Department", LocationId = 6 },
             new Department { Id = 4, NameOfDepartment = "Marketing Department", LocationId = 7 }
            );

            builder.Entity<Employee>().HasData(
             new Employee { Id = 1, FirstName = "Adam", LastName = "Kowalski", Sex = "M", Email = "adam.kowalski@xx.pl", Wages = 5000, DayOfEmployment = new DateTime(2017, 4, 23), Phone = 123456789, DateOfBirth = new DateTime(1994, 11, 1), DepartmentId = 2 , TransportId = 1 },
             new Employee { Id = 2, FirstName = "Ewa", LastName = "Lampa", Sex = "F", Email = "ewa.lampa@xx.pl", Wages = 3000, DayOfEmployment = new DateTime(2007, 6, 13), Phone = 123789456, DateOfBirth = new DateTime(1974, 5, 12), DepartmentId = 3, TransportId = 6 },
             new Employee { Id = 3, FirstName = "Kacper", LastName = "Stół", Sex = "M", Email = "kacper.stol@xx.pl", Wages = 5000, DayOfEmployment = new DateTime(2011, 11, 1), Phone = 345126789, DateOfBirth = new DateTime(1987, 3, 12), DepartmentId = 4, TransportId = 4 },
             new Employee { Id = 4, FirstName = "Joanna", LastName = "Poduszka", Sex = "F", Email = "joanna.poduszka@xx.pl", Wages = 4000, DayOfEmployment = new DateTime(2014, 8, 30), Phone = 123678945, DateOfBirth = new DateTime(1995, 6, 4), DepartmentId = 4, TransportId = 5 },
             new Employee { Id = 5, FirstName = "Wojtek", LastName = "Grzyb", Sex = "M", Email = "wojtek.grzyb@xx.pl", Wages = 3500, DayOfEmployment = new DateTime(2015, 9, 24), Phone = 127893456, DateOfBirth = new DateTime(1997, 4, 26), DepartmentId = 2, TransportId = 5 },
             new Employee { Id = 6, FirstName = "Wiktor", LastName = "Kalafior", Sex = "M", Email = "wiktor.kalafior@xx.pl", Wages = 7500, DayOfEmployment = new DateTime(2010, 1, 11), Phone = 678912345, DateOfBirth = new DateTime(1993, 2, 15), DepartmentId = 1, TransportId = 3 },
             new Employee { Id = 7, FirstName = "Maciej", LastName = "Cerata", Sex = "M", Email = "maciej.cerata@xx.pl", Wages = 6000, DayOfEmployment = new DateTime(2012, 5, 3), Phone = 123945678, DateOfBirth = new DateTime(1986, 7, 9), DepartmentId = 4, TransportId = 2 },
             new Employee { Id = 8, FirstName = "Marcin", LastName = "Brokuł", Sex = "M", Email = "marcin.brokul@xx.pl", Wages = 5000, DayOfEmployment = new DateTime(2018, 4, 11), Phone = 456123789, DateOfBirth = new DateTime(1997, 9, 23), DepartmentId = 2, TransportId = 6 },
             new Employee { Id = 9, FirstName = "Martyna", LastName = "Pudełko", Sex = "F", Email = "martyna.pudelko@xx.pl", Wages = 5500, DayOfEmployment = new DateTime(2019, 1, 23), Phone = 567891234, DateOfBirth = new DateTime(1990, 1, 1), DepartmentId = 4, TransportId = 1 },
             new Employee { Id = 10, FirstName = "Agata", LastName = "Kot", Sex = "F", Email = "agata.kot@xx.pl", Wages = 3300, DayOfEmployment = new DateTime(2015, 12, 24), Phone = 156723489, DateOfBirth = new DateTime(1989, 6, 16), DepartmentId = 3, TransportId = 1 },
             new Employee { Id = 11, FirstName = "Karolina", LastName = "Butelka", Sex = "F", Email = "karolina.butelka@xx.pl", Wages = 5300, DayOfEmployment = new DateTime(2010, 4, 25), Phone = 234516789, DateOfBirth = new DateTime(1989, 6, 17), DepartmentId = 4, TransportId = 1 },
             new Employee { Id = 12, FirstName = "Natalia", LastName = "Liść", Sex = "F", Email = "natalia.lisc@xx.pl", Wages = 5400, DayOfEmployment = new DateTime(2009, 7, 23), Phone = 123784569, DateOfBirth = new DateTime(1976, 2, 16), DepartmentId = 2, TransportId = 1 },
             new Employee { Id = 13, FirstName = "Wioletta", LastName = "Popiół", Sex = "F", Email = "wioletta.popiol@xx.pl", Wages = 4400, DayOfEmployment = new DateTime(2018, 11, 18), Phone = 456781239, DateOfBirth = new DateTime(1970, 1, 11), DepartmentId = 3, TransportId = 1 },
             new Employee { Id = 14, FirstName = "Janusz", LastName = "Smith", Sex = "M", Email = "janusz.smith@xx.pl", Wages = 4100, DayOfEmployment = new DateTime(2018, 7, 17), Phone = 123458967, DateOfBirth = new DateTime(1984, 7, 12), DepartmentId = 4, TransportId = 1 },
             new Employee { Id = 15, FirstName = "Paweł", LastName = "McRee", Sex = "M", Email = "pawel.mcree@xx.pl", Wages = 7400, DayOfEmployment = new DateTime(2019, 2, 14), Phone = 678123459, DateOfBirth = new DateTime(1982, 9, 1), DepartmentId = 2, TransportId = 4 },
             new Employee { Id = 16, FirstName = "Jonnathan", LastName = "Joestar", Sex = "M", Email = "jonnathan.joestar@xx.pl", Wages = 10000, DayOfEmployment = new DateTime(2007, 1, 11), Phone = 456789123, DateOfBirth = new DateTime(1968, 4, 4), DepartmentId = 1, TransportId = 1 },
             new Employee { Id = 17, FirstName = "Soap", LastName = "Price", Sex = "M", Email = "soap.price@xx.pl", Wages = 8000, DayOfEmployment = new DateTime(2013, 7, 15), Phone = 127345689, DateOfBirth = new DateTime(1970, 2, 25), DepartmentId = 1, TransportId = 1 },
             new Employee { Id = 18, FirstName = "Anna", LastName = "Migawka", Sex = "F", Email = "anna.migawka@xx.pl", Wages = 2700, DayOfEmployment = new DateTime(2017, 6, 16), Phone = 456123789, DateOfBirth = new DateTime(1984, 11, 11), DepartmentId = 2, TransportId = 3 },
             new Employee { Id = 19, FirstName = "Klaudia", LastName = "Pass", Sex = "F", Email = "klaudia.pass@xx.pl", Wages = 3400, DayOfEmployment = new DateTime(2014, 7, 28), Phone = 126789345, DateOfBirth = new DateTime(1988, 12, 21), DepartmentId = 2, TransportId = 2 },
             new Employee { Id = 20, FirstName = "Krzysztof", LastName = "Mastuczak", Sex = "M", Email = "krzysztof.krzysztof@xx.pl", Wages = 5800, DayOfEmployment = new DateTime(2015, 2, 10), Phone = 234516789, DateOfBirth = new DateTime(1988, 11, 11), DepartmentId = 3, TransportId = 1 }

            );

            builder.Entity<Location>().HasData(
              new Location { Id = 1, RoomNr = 101, FloorNr = 1 },
              new Location { Id = 2, RoomNr = 102, FloorNr = 1 },
              new Location { Id = 3, RoomNr = 103, FloorNr = 1 },
              new Location { Id = 4, RoomNr = 104, FloorNr = 1 },
              new Location { Id = 5, RoomNr = 105, FloorNr = 1 },
              new Location { Id = 6, RoomNr = 201, FloorNr = 2 },
              new Location { Id = 7, RoomNr = 202, FloorNr = 2 },
              new Location { Id = 8, RoomNr = 203, FloorNr = 2 },
              new Location { Id = 9, RoomNr = 204, FloorNr = 2 },
              new Location { Id = 10, RoomNr = 205, FloorNr = 2 }
            );

            builder.Entity<Transport>().HasData(
              new Transport { Id = 1, NameOfTransport = "Car" },
              new Transport { Id = 2, NameOfTransport = "Walk" },
              new Transport { Id = 3, NameOfTransport = "Bike" },
              new Transport { Id = 4, NameOfTransport = "Public Transport" },
              new Transport { Id = 5, NameOfTransport = "Train" },
              new Transport { Id = 6, NameOfTransport = "Other" }
            );
    }   }
}
