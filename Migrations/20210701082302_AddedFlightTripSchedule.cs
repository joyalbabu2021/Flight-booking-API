using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_booking.Migrations
{
    public partial class AddedFlightTripSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FlightTrips",
                columns: new[] { "TripId", "AvailableDate", "EndDateTime", "FlightId", "FromPlace", "SeatsAvailable", "StartDateTime", "ToPlace" },
                values: new object[] { 2, new DateTime(2021, 7, 1, 13, 53, 2, 298, DateTimeKind.Local).AddTicks(5341), new DateTime(2021, 7, 1, 15, 53, 2, 298, DateTimeKind.Local).AddTicks(6160), 2, "Tirupathi", 100, new DateTime(2021, 7, 1, 13, 53, 2, 298, DateTimeKind.Local).AddTicks(5768), "Hyderabad" });

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

            migrationBuilder.CreateIndex(
                name: "IX_FlightTrips_FlightId",
                table: "FlightTrips",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightTrips_Flights_FlightId",
                table: "FlightTrips",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightTrips_Flights_FlightId",
                table: "FlightTrips");

            migrationBuilder.DropIndex(
                name: "IX_FlightTrips_FlightId",
                table: "FlightTrips");

            migrationBuilder.DeleteData(
                table: "FlightTrips",
                keyColumn: "TripId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 28, 23, 26, 7, 295, DateTimeKind.Local).AddTicks(8142), new DateTime(2021, 7, 3, 23, 26, 7, 294, DateTimeKind.Local).AddTicks(5521), new DateTime(2021, 7, 5, 23, 26, 7, 295, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 28, 23, 26, 7, 295, DateTimeKind.Local).AddTicks(8841), new DateTime(2021, 7, 3, 23, 26, 7, 295, DateTimeKind.Local).AddTicks(8832), new DateTime(2021, 7, 5, 23, 26, 7, 295, DateTimeKind.Local).AddTicks(8837) });
        }
    }
}
