using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Interfaces;
using Flight_booking.Models;
using Flight_booking.Context;
using static Flight_booking.commonenum;
using Microsoft.EntityFrameworkCore;

namespace Flight_booking.Repositories
{
    public class booking : Ibooking
    {
        private FDbcontext context;

        public booking(FDbcontext _context)
        {
            this.context = _context;
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
            var bookcancel = context.bookmodel.Where(w => w.Pnrnumber == pnr).FirstOrDefault();
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
    }
}
