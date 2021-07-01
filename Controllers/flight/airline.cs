using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Interfaces;

using Flight_booking.DTO;
using Flight_booking.Models;

namespace Flight_booking.Controllers.flight
{
    [Route("api/[controller]")]
    [ApiController]
    public class airline : ControllerBase
    {
        private Iairline airlinerepository;
        private readonly IMapper _mapper;

        public airline(Iairline _airlinerepository, IMapper mapper)
        {
            this.airlinerepository = _airlinerepository;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Insertflightdata(Airlinedto airline)
        {
            var data = airlinerepository.Insertflightdata(_mapper.Map<Airlinesmodel>(airline));

            return Ok(data);
        }
        [HttpGet]
        public IActionResult GetAirlinesflighnumber(Airlinedto airline)
        {
            var data = airlinerepository.GetAirlinesbyflighnumber(_mapper.Map<Airlinesmodel>(airline));
           
            if (data == null)
                return NotFound("No record found with id: " + airline.flightnumber);
            return Ok(data);
        }

        [HttpPost("InsertAirlines")]
        public IActionResult InsertAirline(AirlineMasterModel airlineMaster)
        {
            var data = airlinerepository.InsertAirline(airlineMaster);

            if (data == null)
                return BadRequest("Inavlid Deatils provided ! Eg:AirlinesId value should not be other that Zero ");
            return CreatedAtAction("GetAirlineDetailsById",new { id= airlineMaster.AirlinesId },airlineMaster);
        }
        [HttpGet("GetAirlineDetailsById")]
        public IActionResult GetAirlineDetailsById(int id)
        {
            var data = airlinerepository.GetAirlinesDetails(id);

            if (data == null)
                return NotFound("No record found with id: " + id);
            return Ok(data);
        }

        [HttpPost("AddFlightDetails")]
        public IActionResult AddFlightDetails(AddFlightDetailsDTO addFlightDetailsDTO)
        {
            var data = airlinerepository.AddFlightDetails(addFlightDetailsDTO);

            if (data == null)
                return BadRequest("Inavlid Deatils provided ! Eg:FlightId value should not be other that Zero ");
            // return CreatedAtAction("FlightDetails", "admin", new { flightId = addFlightDetailsDTO.FlightId }, addFlightDetailsDTO);
            return Ok(data);
        }
        [HttpPost("AddTripSchedule")]
        public IActionResult AddTripSchedule(AddTripScheduleDTO addTripScheduleDTO)
        {
            var data = airlinerepository.AddTripSchedule(addTripScheduleDTO);

            if (data == null)
                return BadRequest("Inavlid Deatils provided ! ");
            // return CreatedAtAction("FlightDetails", "admin", new { flightId = addFlightDetailsDTO.FlightId }, addFlightDetailsDTO);
            return Ok(data);
        }
    }
}
