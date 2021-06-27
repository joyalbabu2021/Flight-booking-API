using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_booking.Migrations
{
    public partial class changeFlightBookingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Usermail" },
                values: new object[] { "Jack", "Jack.Reacher@gmail.com" });

            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Usermail" },
                values: new object[] { "J Reacher", "Jack.Reacher2@gmail.com" });

            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Usermail" },
                values: new object[] { "J Reacher3", "Jack.Reacher3@gmail.com" });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "UserEmail", "Username", "bookeddate", "onwarddate", "returndate" },
                values: new object[] { "Jack.Reacher@gmail.com", "Jack", new DateTime(2021, 6, 27, 17, 26, 47, 550, DateTimeKind.Local).AddTicks(1999), new DateTime(2021, 7, 2, 17, 26, 47, 548, DateTimeKind.Local).AddTicks(7560), new DateTime(2021, 7, 4, 17, 26, 47, 549, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "UserEmail", "Username", "bookeddate", "onwarddate", "returndate" },
                values: new object[] { "Jack.Reacher2@gmail.com", "Jack2", new DateTime(2021, 6, 27, 17, 26, 47, 550, DateTimeKind.Local).AddTicks(2999), new DateTime(2021, 7, 2, 17, 26, 47, 550, DateTimeKind.Local).AddTicks(2986), new DateTime(2021, 7, 4, 17, 26, 47, 550, DateTimeKind.Local).AddTicks(2994) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Usermail" },
                values: new object[] { "Surya", "Surya.Teja@gmail.com" });

            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Usermail" },
                values: new object[] { "Teja", "Surya.Teja3@gmail.com" });

            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Usermail" },
                values: new object[] { "Surya2", "Surya.Teja2@gmail.com" });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "UserEmail", "Username", "bookeddate", "onwarddate", "returndate" },
                values: new object[] { "Surya.Teja@gmail.com", "Surya", new DateTime(2021, 6, 26, 21, 5, 19, 90, DateTimeKind.Local).AddTicks(5422), new DateTime(2021, 7, 1, 21, 5, 19, 89, DateTimeKind.Local).AddTicks(2638), new DateTime(2021, 7, 3, 21, 5, 19, 90, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "UserEmail", "Username", "bookeddate", "onwarddate", "returndate" },
                values: new object[] { "Surya.Teja2@gmail.com", "Surya2", new DateTime(2021, 6, 26, 21, 5, 19, 90, DateTimeKind.Local).AddTicks(6108), new DateTime(2021, 7, 1, 21, 5, 19, 90, DateTimeKind.Local).AddTicks(6100), new DateTime(2021, 7, 3, 21, 5, 19, 90, DateTimeKind.Local).AddTicks(6104) });
        }
    }
}
