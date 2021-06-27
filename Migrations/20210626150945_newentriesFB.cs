using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_booking.Migrations
{
    public partial class newentriesFB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PassengerDetails",
                columns: new[] { "Id", "Age", "Gender", "Name", "Pnrnumber", "Usermail", "flightbookingid", "mealpreference", "selectedseatnumber" },
                values: new object[] { 2, 25, "M", "Teja", 12345, "Surya.Teja3@gmail.com", 1, "mealpref", "A2" });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 26, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(300), new DateTime(2021, 7, 1, 20, 39, 45, 245, DateTimeKind.Local).AddTicks(7685), new DateTime(2021, 7, 3, 20, 39, 45, 246, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.InsertData(
                table: "bookmodel",
                columns: new[] { "FlightBookingId", "Airlinelogo", "Airlinename", "Amount", "Discountcode", "Fromplace", "Mealtype", "Pnrnumber", "ReturnAirlinelogo", "ReturnAirlinename", "ReturnAmount", "ReturnMealtype", "Selectedseatonward", "Selectedseatreturn", "Toplace", "Totalamount", "Triptype", "UserEmail", "Userid", "Username", "bookeddate", "numberofseats", "onwarddate", "returndate", "status" },
                values: new object[] { 2, "", "SpiceJet", 2504m, "DC100", "Hyderabad", "SampleMeal", 789012, "ssss", "Indigo", 2504m, "SampleMeal", "B1", "B2", "Delhi", 5008m, "TwoWayTrip", "Surya.Teja2@gmail.com", "2", "Surya2", new DateTime(2021, 6, 26, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(1001), 1, new DateTime(2021, 7, 1, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(993), new DateTime(2021, 7, 3, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(997), 1 });

            migrationBuilder.InsertData(
                table: "PassengerDetails",
                columns: new[] { "Id", "Age", "Gender", "Name", "Pnrnumber", "Usermail", "flightbookingid", "mealpreference", "selectedseatnumber" },
                values: new object[] { 3, 25, "M", "Surya2", 789012, "Surya.Teja2@gmail.com", 2, "mealpref", "B1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 24, 21, 56, 51, 972, DateTimeKind.Local).AddTicks(1306), new DateTime(2021, 6, 29, 21, 56, 51, 970, DateTimeKind.Local).AddTicks(7115), new DateTime(2021, 7, 1, 21, 56, 51, 971, DateTimeKind.Local).AddTicks(5626) });
        }
    }
}
