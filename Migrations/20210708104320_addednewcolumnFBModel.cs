using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_booking.Migrations
{
    public partial class addednewcolumnFBModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReturnTripId",
                table: "bookmodel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TripId",
                table: "bookmodel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FlightTrips",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "AvailableDate", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2021, 7, 8, 16, 13, 20, 282, DateTimeKind.Local).AddTicks(428), new DateTime(2021, 7, 8, 18, 13, 20, 282, DateTimeKind.Local).AddTicks(1245), new DateTime(2021, 7, 8, 16, 13, 20, 282, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 7, 8, 16, 13, 20, 270, DateTimeKind.Local).AddTicks(6993), new DateTime(2021, 7, 13, 16, 13, 20, 269, DateTimeKind.Local).AddTicks(2494), new DateTime(2021, 7, 15, 16, 13, 20, 270, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 7, 8, 16, 13, 20, 270, DateTimeKind.Local).AddTicks(7846), new DateTime(2021, 7, 13, 16, 13, 20, 270, DateTimeKind.Local).AddTicks(7837), new DateTime(2021, 7, 15, 16, 13, 20, 270, DateTimeKind.Local).AddTicks(7842) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnTripId",
                table: "bookmodel");

            migrationBuilder.DropColumn(
                name: "TripId",
                table: "bookmodel");

            migrationBuilder.UpdateData(
                table: "FlightTrips",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "AvailableDate", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2021, 7, 8, 15, 31, 40, 446, DateTimeKind.Local).AddTicks(4475), new DateTime(2021, 7, 8, 17, 31, 40, 446, DateTimeKind.Local).AddTicks(5330), new DateTime(2021, 7, 8, 15, 31, 40, 446, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 7, 8, 15, 31, 40, 434, DateTimeKind.Local).AddTicks(3854), new DateTime(2021, 7, 13, 15, 31, 40, 433, DateTimeKind.Local).AddTicks(932), new DateTime(2021, 7, 15, 15, 31, 40, 433, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 7, 8, 15, 31, 40, 434, DateTimeKind.Local).AddTicks(4588), new DateTime(2021, 7, 13, 15, 31, 40, 434, DateTimeKind.Local).AddTicks(4575), new DateTime(2021, 7, 15, 15, 31, 40, 434, DateTimeKind.Local).AddTicks(4581) });
        }
    }
}
