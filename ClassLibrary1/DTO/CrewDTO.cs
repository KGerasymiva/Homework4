using System.Collections.Generic;

namespace Share
{
    public class CrewDTO
    {
        public int Id { get; set; }
        public int Pilot { get; set; }
        public IEnumerable<int> FlightAttendance { get; set; }
    }
}

