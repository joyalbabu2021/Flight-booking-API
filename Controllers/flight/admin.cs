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
    public class admin : ControllerBase
    {
        private Iadmin adminRepository;
        private readonly IMapper _mapper;
        public admin(Iadmin _adminRepository, IMapper mapper)
        {
            this.adminRepository = _adminRepository;
        }

        [HttpGet("user/{userid}")]
        public IActionResult GetUserDetails(int userid)
        {

           var data= adminRepository.GetUserDetails(userid);
            if (data == null )
                return NotFound("No record found with id: " + userid);
            return Ok(data);
        }
        [HttpGet("userDetails/{userEmail}")]
        public IActionResult GetUserDetails(string userEmail)
        {

            var data = adminRepository.GetUserDetails(userEmail);
            if (data == null)
                return NotFound("No record found with id: " + userEmail);
            return Ok(data);
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var data =await adminRepository.GetUsers();
            if (data == null)
                return NotFound("No record found ");
            return Ok(data);
        }

        [HttpGet("Flights")]
        public async Task<IActionResult> GetFlightsList()
        {
            var data = await adminRepository.GetFlightsList();
            if (data == null)
                return NotFound("No record found ");
            return Ok(data);
        }
        [HttpGet("FlightDetails/{flightId}")]
        public  IActionResult GetFlightDetailsByID(int flightId)
        {
            var data = adminRepository.GetFlightDetailsById(flightId);
            if (data == null)
                return NotFound("No record found ");
            return Ok(data);
        }
    }
}
