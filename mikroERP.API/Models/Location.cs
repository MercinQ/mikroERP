using System.Collections.Generic;

namespace mikroERP.API.Models
{
    public class Location
    {
        public int Id { get; set; }
        public int RoomNr { get; set; }
        public int FloorNr { get; set; }
        public ICollection<Department> Department { get; set; }
    }
}