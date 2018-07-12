using System;

namespace Share
{
    public class DepartureDTO
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public string DepartingTime { get; set; }
        public int Crue { get; set; }
        public int Plane { get; set; }
    }
}
