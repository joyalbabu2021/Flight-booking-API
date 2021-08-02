using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_booking.Migrations
{
    public partial class updatecolumnanePassModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pnrnumber",
                table: "PassengerDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "FlightTrips",
                keyColumn: "TripId",
                keyValue: 2,
                columns: new[] { "AvailableDate", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2021, 7, 8, 15, 31, 40, 446, DateTimeKind.Local).AddTicks(4475), new DateTime(2021, 7, 8, 17, 31, 40, 446, DateTimeKind.Local).AddTicks(5330), new DateTime(2021, 7, 8, 15, 31, 40, 446, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Pnrnumber",
                value: "12345");

            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Pnrnumber",
                value: "12345");

            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "Pnrnumber",
                value: "789012");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Pnrnumber",
                table: "PassengerDetails",
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
                values: new object[] { new DateTime(2021, 7, 8, 13, 58, 6, 805, DateTimeKind.Local).AddTicks(3909), new DateTime(2021, 7, 8, 15, 58, 6, 805, DateTimeKind.Local).AddTicks(5072), new DateTime(2021, 7, 8, 13, 58, 6, 805, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Pnrnumber",
                value: 12345);

            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Pnrnumber",
                value: 12345);

            migrationBuilder.UpdateData(
                table: "PassengerDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "Pnrnumber",
                value: 789012);

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 7, 8, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(172), new DateTime(2021, 7, 13, 13, 58, 6, 787, DateTimeKind.Local).AddTicks(8539), new DateTime(2021, 7, 15, 13, 58, 6, 789, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 7, 8, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(1189), new DateTime(2021, 7, 13, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(1172), new DateTime(2021, 7, 15, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(1179) });
        }
    }
}
