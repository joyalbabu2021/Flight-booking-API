using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_booking.Migrations
{
    public partial class addnewUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 24, 21, 56, 51, 972, DateTimeKind.Local).AddTicks(1306), new DateTime(2021, 6, 29, 21, 56, 51, 970, DateTimeKind.Local).AddTicks(7115), new DateTime(2021, 7, 1, 21, 56, 51, 971, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.InsertData(
                table: "usermodel",
                columns: new[] { "UserID", "Password", "Role", "UserEmail", "Username" },
                values: new object[] { 2, "Ind@3333", "user", "Surya.Teja2@gmail.com", "Surya Teja2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "usermodel",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 24, 21, 53, 50, 960, DateTimeKind.Local).AddTicks(4339), new DateTime(2021, 6, 29, 21, 53, 50, 958, DateTimeKind.Local).AddTicks(8747), new DateTime(2021, 7, 1, 21, 53, 50, 959, DateTimeKind.Local).AddTicks(7201) });
        }
    }
}
