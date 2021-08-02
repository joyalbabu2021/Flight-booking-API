using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Interfaces;
using Flight_booking.Models;
using Flight_booking.Context;
using static Flight_booking.commonenum;
using Microsoft.EntityFrameworkCore;
using Flight_booking.DTO;
using AutoMapper;

namespace Flight_booking.Repositories
{
    public class booking : Ibooking
    {
        private FDbcontext context;
        private readonly IMapper _mapper;

        public booking(FDbcontext _context,IMapper mapper)
        {
            this.context = _context;
            this._mapper = mapper;
        }
        public async Task<Tuple<bool, string>> Insertbookingdata(Flightbookingsmodel fltmodel)
        {
            var message = "inserted successfully";
            Flightbookingsmodel bookmodel = new Flightbookingsmodel();
            var pnrnumber = Convert.ToInt32(DateTime.Now);
            if (fltmodel != null)
            {
                //bookmodel.Username = fltmodel.Username;
                //bookmodel.UserEmail = fltmodel.UserEmail;
                //bookmodel.Userid = fltmodel.Userid;
                //bookmodel.Triptype = fltmodel.Triptype;
                //bookmodel.Discountcode = fltmodel.Discountcode;
                //bookmodel.Totalamount = fltmodel.Totalamount;
                //bookmodel.Amount = fltmodel.Amount;
                //bookmodel.ReturnAmount = fltmodel.ReturnAmount;
                //bookmodel.Airlinename = fltmodel.Airlinename;
                //bookmodel.Airlinelogo = fltmodel.Airlinelogo;
                //bookmodel.ReturnAirlinename = fltmodel.ReturnAirlinename;
                //bookmodel.ReturnAirlinelogo = fltmodel.ReturnAirlinelogo;
                //bookmodel.Fromplace = fltmodel.Fromplace;
                //bookmodel.Toplace = fltmodel.Toplace;
                //bookmodel.onwarddate = fltmodel.onwarddate;
                //bookmodel.returndate = fltmodel.returndate;
                //bookmodel.Mealtype = fltmodel.Mealtype;
                //bookmodel.ReturnMealtype = fltmodel.ReturnMealtype;
                //bookmodel.Selectedseatonward = fltmodel.Selectedseatonward;
                //bookmodel.Selectedseatreturn = fltmodel.Selectedseatreturn;
                //bookmodel.Pnrnumber = pnrnumber;
                // bookmodel.bookeddate = DateTime.Now;
                //bookmodel.numberofseats = fltmodel.numberofseats;
                // bookmodel.status = (int)journeystatus.booked;
                //bookmodel.Pnrnumber = pnrnumber;
                //foreach (var item in fltmodel.passengerdetails)
                //{
                //    passengerdetails passdetails = new passengerdetails();
                //    passdetails.Name = passdetails.Name;
                //    passdetails.Age = passdetails.Age;
                //    passdetails.Gender = passdetails.Gender;
                //    passdetails.mealpreference = passdetails.mealpreference;
                //    passdetails.selectedseatnumber = passdetails.selectedseatnumber;
                //    passdetails.Pnrnumber = pnrnumber;
                //    bookmodel.passengerdetails.Add(passdetails);
                //}
                context.bookmodel.Add(bookmodel);
                context.SaveChanges();
            }
            return Tuple.Create(true, message);
        }
        

        public async Task<List<Flightbookingsmodel>> GetFlightdetailsbymail(string Emailid)
        {
            List<Flightbookingsmodel> bookmodel = new List<Flightbookingsmodel>();
            bookmodel = context.bookmodel.Include(b=>b.passengerdetails).Where(w => w.UserEmail == Emailid).ToList();

            return bookmodel;
        }
        public async Task<Tuple<bool, string>> cancelflightbypnr(int pnr)
        {
            var message = "Cancelld successfully";
            var bookcancel = context.bookmodel.Where(w => w.Pnrnumber == pnr.ToString()).FirstOrDefault();
            if (bookcancel != null)
            {
                var presntdate = DateTime.Now;
            TimeSpan ts = bookcancel.bookeddate - presntdate;
            if(ts.TotalHours>=24)
            {
                
                    bookcancel.status = (int)journeystatus.cancelled;
                    return Tuple.Create(true, message);

                }
                
            }
            else
            {
                return Tuple.Create(false, "Canellation not allowed");
            }

            return Tuple.Create(false, "Canellation not allowed");

        }

        public async Task<Flightbookingsmodel> GetFlightBookingDetailsbyId(int flightBookingId)
        {
            Flightbookingsmodel bookmodel = new Flightbookingsmodel();
            bookmodel = context.bookmodel.Include(b => b.passengerdetails).Where(w => w.FlightBookingId==flightBookingId).FirstOrDefault();
            return bookmodel;
        }

        public async Task<List<Flightbookingsmodel>> GetflightBookingHistory()
        {
            List<Flightbookingsmodel> bookmodel = new List<Flightbookingsmodel>();
            bookmodel = context.bookmodel.Include(b => b.passengerdetails).ToList();

            return bookmodel;
        }

        public Tuple<bool, string> ReserveTicketForUser(FlightbookingDto flightbookingDto)
        {
            if (flightbookingDto != null)
            {
                try
                {
                    //deduct seat count from Trip
                    var TripData = context.FlightTrips.Include(f=>f.Flight).SingleOrDefault(x => x.TripId == flightbookingDto.TripId);
                    TripData.SeatsAvailable = TripData.SeatsAvailable - flightbookingDto.passengersCount;
                    if(flightbookingDto.Triptype!="oneway" && context.FlightTrips.Any(x=>x.TripId==flightbookingDto.ReturnTripId))
                    {
                        var returnTripData = context.FlightTrips.Include(f => f.Flight).SingleOrDefault(x => x.TripId == flightbookingDto.ReturnTripId);
                        returnTripData.SeatsAvailable = returnTripData.SeatsAvailable - flightbookingDto.passengersCount;
                    }
                    var fbm = _mapper.Map<Flightbookingsmodel>(flightbookingDto);
                    fbm.bookeddate = DateTime.Now;
                    fbm.numberofseats = flightbookingDto.passengersCount;
                    context.bookmodel.Add(fbm);
                    context.SaveChanges();
                    var bookid = fbm.FlightBookingId;
                    var bookedTicket = context.bookmodel.SingleOrDefault(x => x.FlightBookingId == bookid);
                   string PNRNumber= bookedTicket.Airlinename.Substring(0, 3).ToUpper() + bookedTicket.Fromplace.Substring(0, 3).ToUpper() + TripData.Flight.FlightNumber + bookid;
                    bookedTicket.Pnrnumber = PNRNumber;
                   bookedTicket.passengerdetails.ToList().ForEach(x => x.Pnrnumber = PNRNumber);
                    context.SaveChanges();
                    string message = $"Ticket Booked sucessfully .PNR Number is: {bookedTicket.Pnrnumber} ..Booking Id/TransactionId : {bookid}  ";
                    return Tuple.Create(true, message);
                }
                catch(Exception ex)
                {
                    // if exception occurs revoke seat count..
                    var TripData = context.FlightTrips.SingleOrDefault(x => x.TripId == flightbookingDto.TripId);
                    TripData.SeatsAvailable = TripData.SeatsAvailable + flightbookingDto.passengersCount;
                    if (flightbookingDto.Triptype != "oneway" && context.FlightTrips.Any(x => x.TripId == flightbookingDto.ReturnTripId))
                    {
                        var returnTripData = context.FlightTrips.Include(f => f.Flight).SingleOrDefault(x => x.TripId == flightbookingDto.ReturnTripId);
                        returnTripData.SeatsAvailable = returnTripData.SeatsAvailable - flightbookingDto.passengersCount;
                    }
                    string message = $"Error While  Booking Flight Ticket ";
                    return Tuple.Create(true, message);
                }
            }
            else
            {
                string message = $"Flight Booking Details can't be Null";
                return Tuple.Create(true, message);
            }
        }
    }
}
