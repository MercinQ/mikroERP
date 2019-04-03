using System;

namespace mikroERP.API.Dtos
{
    public class EmployeeForTableDto
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
        public string NameOfDepartment { get; set; }
        public int RoomNr { get; set; }
        public int FloorNr { get; set; }
        public string NameOfTransport { get; set; }
  
    }
}