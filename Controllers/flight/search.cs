using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.Configuration;
using System.Threading.Tasks;
using Flight_booking.Interfaces;
using Flight_booking.DTO;
using Flight_booking.Models;

namespace Flight_booking.Controllers.flight
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class search : ControllerBase
    {
        private Isearch searchrepository;
        private readonly IMapper _mapper;

        public search (Isearch _searchrepository, IMapper mapper)
        {
            this.searchrepository = _searchrepository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Getflightdetailsbysearch(FlightbookingDto bookdto)
        {
            var data = searchrepository.GetFlights(_mapper.Map<Flightbookingsmodel>(bookdto));

            return Ok(data);
        }
        [HttpGet("SearchFlightTrips")]
        public IActionResult SearchFlightTrips([FromQuery]SearchFlightDTO searchFlightDTO)
        {
            var data = searchrepository.SearchFlights(searchFlightDTO,_mapper);

            if (data == null)
                return BadRequest("Inavlid Deatils provided ! ");
            // return CreatedAtAction("FlightDetails", "admin", new { flightId = addFlightDetailsDTO.FlightId }, addFlightDetailsDTO);
            return Ok(data);
        }
    }
}
