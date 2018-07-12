using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;


namespace Share
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<DAL.Models.Crew, CrewDTO>();
            CreateMap<CrewDTO, DAL.Models.Crew>();

            CreateMap<DAL.Models.Departure, DepartureDTO>();
            CreateMap<DepartureDTO, DAL.Models.Departure>();

            CreateMap<DAL.Models.Flight, FlightDTO>();
            CreateMap<FlightDTO, DAL.Models.Flight>();

            CreateMap<DAL.Models.Flightattendant, FlightattendantDTO>();
            CreateMap<FlightattendantDTO, DAL.Models.Flightattendant>();

            CreateMap<DAL.Models.Pilot, PilotDTO>();
            CreateMap<PilotDTO, DAL.Models.Pilot>();

            CreateMap<DAL.Models.Plane, PlaneDTO>();
            CreateMap<PlaneDTO, DAL.Models.Plane>();

            CreateMap<DAL.Models.PlaneType, PlaneTypeDTO>();
            CreateMap<PlaneTypeDTO, DAL.Models.PlaneType>();

            CreateMap<DAL.Models.Ticket, TicketDTO>();
            CreateMap<TicketDTO, DAL.Models.Ticket>();
        }
    }
}
