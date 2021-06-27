using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Interfaces;
namespace Flight_booking.Controllers.flight
{
    [Route("api/[controller]")]
    [ApiController]
    public class ticket : ControllerBase
    {
        private Iticket ticketrepository;

        public ticket(Iticket _ticketrepository)
        {
            this.ticketrepository = _ticketrepository;
        }
       
        
        [HttpGet]
        
        public IActionResult Get(int id)
        {
            var data = ticketrepository.GetFlightdetailsbypnr(id);
            if (data == null)
                return NotFound("No record found with id: " + id);
            return Ok(data);
        }

    }
}
