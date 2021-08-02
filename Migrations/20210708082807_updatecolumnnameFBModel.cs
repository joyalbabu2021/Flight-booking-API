using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_booking.Migrations
{
    public partial class updatecolumnnameFBModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pnrnumber",
                table: "bookmodel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "FlightTrips",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "AvailableDate", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2021, 7, 8, 13, 58, 6, 805, DateTimeKind.Local).AddTicks(3909), new DateTime(2021, 7, 8, 15, 58, 6, 805, DateTimeKind.Local).AddTicks(5072), new DateTime(2021, 7, 8, 13, 58, 6, 805, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "Pnrnumber", "bookeddate", "onwarddate", "returndate" },
                values: new object[] { "123456", new DateTime(2021, 7, 8, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(172), new DateTime(2021, 7, 13, 13, 58, 6, 787, DateTimeKind.Local).AddTicks(8539), new DateTime(2021, 7, 15, 13, 58, 6, 789, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "Pnrnumber", "bookeddate", "onwarddate", "returndate" },
                values: new object[] { "789012", new DateTime(2021, 7, 8, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(1189), new DateTime(2021, 7, 13, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(1172), new DateTime(2021, 7, 15, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(1179) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Pnrnumber",
                table: "bookmodel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "Pnrnumber", "bookeddate", "onwarddate", "returndate" },
                values: new object[] { 123456, new DateTime(2021, 7, 2, 23, 0, 26, 344, DateTimeKind.Local).AddTicks(1861), new DateTime(2021, 7, 7, 23, 0, 26, 341, DateTimeKind.Local).AddTicks(8730), new DateTime(2021, 7, 9, 23, 0, 26, 343, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "Pnrnumber", "bookeddate", "onwarddate", "returndate" },
                values: new object[] { 789012, new DateTime(2021, 7, 2, 23, 0, 26, 344, DateTimeKind.Local).AddTicks(3443), new DateTime(2021, 7, 7, 23, 0, 26, 344, DateTimeKind.Local).AddTicks(3417), new DateTime(2021, 7, 9, 23, 0, 26, 344, DateTimeKind.Local).AddTicks(3432) });
        }
    }
}
