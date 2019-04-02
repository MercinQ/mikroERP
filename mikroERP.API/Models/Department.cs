using System.Collections.Generic;

namespace mikroERP.API.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string NameOfDepartment { get; set; }
        public Location Location { get; set; }
        public int? LocationId { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}