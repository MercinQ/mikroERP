using System;

namespace mikroERP.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public double Wages { get; set; }  
        public DateTime DayOfEmployment { get; set; }
        public int Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
        public int? TransportId { get; set; }
        public Transport Transport { get; set; }
    }
}