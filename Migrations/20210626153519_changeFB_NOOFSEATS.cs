using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_booking.Migrations
{
    public partial class changeFB_NOOFSEATS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "numberofseats", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 26, 21, 5, 19, 90, DateTimeKind.Local).AddTicks(5422), 2, new DateTime(2021, 7, 1, 21, 5, 19, 89, DateTimeKind.Local).AddTicks(2638), new DateTime(2021, 7, 3, 21, 5, 19, 90, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 26, 21, 5, 19, 90, DateTimeKind.Local).AddTicks(6108), new DateTime(2021, 7, 1, 21, 5, 19, 90, DateTimeKind.Local).AddTicks(6100), new DateTime(2021, 7, 3, 21, 5, 19, 90, DateTimeKind.Local).AddTicks(6104) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "numberofseats", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 26, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(300), 3, new DateTime(2021, 7, 1, 20, 39, 45, 245, DateTimeKind.Local).AddTicks(7685), new DateTime(2021, 7, 3, 20, 39, 45, 246, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 26, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(1001), new DateTime(2021, 7, 1, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(993), new DateTime(2021, 7, 3, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(997) });
        }
    }
}
