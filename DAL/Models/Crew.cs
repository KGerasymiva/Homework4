using System.Collections.Generic;

namespace DAL.Models
{
    public class Crew : Entity
    {
        public int Pilot { get; set; }
        public IEnumerable<int> FlightAttendance { get; set; }
    }
}
