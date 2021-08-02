using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_booking.Migrations
{
    public partial class newcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "costPerSeat",
                table: "FlightTrips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FlightTrips",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "AvailableDate", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2021, 7, 2, 23, 0, 26, 364, DateTimeKind.Local).AddTicks(1973), new DateTime(2021, 7, 3, 1, 0, 26, 364, DateTimeKind.Local).AddTicks(3066), new DateTime(2021, 7, 2, 23, 0, 26, 364, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 7, 2, 23, 0, 26, 344, DateTimeKind.Local).AddTicks(1861), new DateTime(2021, 7, 7, 23, 0, 26, 341, DateTimeKind.Local).AddTicks(8730), new DateTime(2021, 7, 9, 23, 0, 26, 343, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 7, 2, 23, 0, 26, 344, DateTimeKind.Local).AddTicks(3443), new DateTime(2021, 7, 7, 23, 0, 26, 344, DateTimeKind.Local).AddTicks(3417), new DateTime(2021, 7, 9, 23, 0, 26, 344, DateTimeKind.Local).AddTicks(3432) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "costPerSeat",
                table: "FlightTrips");

            migrationBuilder.UpdateData(
                table: "FlightTrips",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "AvailableDate", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2021, 7, 1, 13, 53, 2, 298, DateTimeKind.Local).AddTicks(5341), new DateTime(2021, 7, 1, 15, 53, 2, 298, DateTimeKind.Local).AddTicks(6160), new DateTime(2021, 7, 1, 13, 53, 2, 298, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 7, 1, 13, 53, 2, 287, DateTimeKind.Local).AddTicks(779), new DateTime(2021, 7, 6, 13, 53, 2, 285, DateTimeKind.Local).AddTicks(9102), new DateTime(2021, 7, 8, 13, 53, 2, 286, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 7, 1, 13, 53, 2, 287, DateTimeKind.Local).AddTicks(1473), new DateTime(2021, 7, 6, 13, 53, 2, 287, DateTimeKind.Local).AddTicks(1464), new DateTime(2021, 7, 8, 13, 53, 2, 287, DateTimeKind.Local).AddTicks(1469) });
        }
    }
}
