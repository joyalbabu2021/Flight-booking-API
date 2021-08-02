using System;
using AutoMapper;
using Flight_booking.DTO;
using Flight_booking.Models;

namespace Flight_booking.Util
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<FlightTripSchedule, AvailableFlightTripsDTO>();
            CreateMap<FlightbookingDto, Flightbookingsmodel>();
                //.ForMember(x=>x.passengerdetails,opt=>opt.Ignore());
            CreateMap<passengerdetailsDTO, passengerdetails>();
            //CreateMap<Flightbookingsmodel, FlightbookingDto>().ForMember(x=>x.TripId,options=>options.Ignore())
            //    .ForMember(x=>x.passengersCount,opt=>opt.Ignore())
            //    .ForMember(x=>x.passengerdetails,opt=>opt.Ignore())
            //    .ForSourceMember(x=>x.FlightBookingId,opt=>opt.DoNotValidate());
            //CreateMap<passengerdetails, passengerdetailsDTO>();
        }
    }
}
