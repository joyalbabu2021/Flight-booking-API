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
    public class booking : ControllerBase
    {
        private Ibooking bookingrepository;
        private readonly IMapper _mapper;

        public booking(Ibooking _bookingrepository, IMapper mapper)
        {
            this.bookingrepository = _bookingrepository;
            _mapper = mapper;
        }

        [HttpPost ("bookdata")]
        public IActionResult Insertbookingdata(FlightbookingDto bookingmodel)
        {
            var data = bookingrepository.Insertbookingdata(_mapper.Map<Flightbookingsmodel>(bookingmodel));
            
            return Ok(data);
        }

        [HttpGet("history")]
        public async Task<IActionResult> Getflightdetailsbyemailid(string emailid)
        {
            var data =await  bookingrepository.GetFlightdetailsbymail(emailid);
            if (data == null || data.Count==0)
                return NotFound("No record found with id: " + emailid);
            return Ok(data);
        }

        [HttpGet("FlightBookingHistory")]
        public async Task<IActionResult> GetflightBookingHistory()
        {
            var data = await bookingrepository.GetflightBookingHistory();
            if (data == null || data.Count == 0)
                return NotFound("No record found");
            return Ok(data);
        }

        [HttpGet("FlightBookingDetails/{id}")]
        public async Task<IActionResult> GetFlightBookingDetailsbyId(int id)
        {
            var data = await bookingrepository.GetFlightBookingDetailsbyId(id);
            if (data == null)
                return NotFound("No record found with id: " + id);
            return Ok(data);
        }

        //[Authorize]
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            var data = bookingrepository.cancelflightbypnr(id);
            
            return Ok(id);
        }

        [HttpPost]
        [Route("ReserveTicketForUser")]
        public IActionResult ReserveTicketForUser(FlightbookingDto flightbookingDto)
        {
            //var i = _mapper.Map<Flightbookingsmodel>(flightbookingDto);
            var data = bookingrepository.ReserveTicketForUser(flightbookingDto);
            if (data == null)
                return BadRequest("Inavlid Deatils provided ! Eg:AirlinesId value should not be other that Zero ");
            return Ok(data);
        }

        

    }
}
