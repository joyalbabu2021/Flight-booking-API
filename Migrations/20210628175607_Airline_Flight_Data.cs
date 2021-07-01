using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_booking.Migrations
{
    public partial class Airline_Flight_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    AirlinesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirlineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.AirlinesId);
                });

            migrationBuilder.CreateTable(
                name: "FlightTrips",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    FromPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeatsAvailable = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightTrips", x => x.TripId);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlinesId = table.Column<int>(type: "int", nullable: false),
                    InstrumentUsed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowsCount = table.Column<int>(type: "int", nullable: false),
                    BusinessClassSeatsCount = table.Column<int>(type: "int", nullable: false),
                    NonBusinessClassSeatsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_Flights_Airlines_AirlinesId",
                        column: x => x.AirlinesId,
                        principalTable: "Airlines",
                        principalColumn: "AirlinesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "AirlinesId", "AirlineLogo", "AirlineName", "Blocked" },
                values: new object[,]
                {
                    { 1, "AirIndia.jpg", "Air India", false },
                    { 2, "SpiceJet.jpg", "SpiceJet", false },
                    { 3, "IndiGo.jpg", "IndiGo", false }
                });

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

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "AirlinesId", "BusinessClassSeatsCount", "FlightNumber", "InstrumentUsed", "NonBusinessClassSeatsCount", "RowsCount" },
                values: new object[] { 1, 1, 20, "AI300", "A320Neo", 80, 50 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "AirlinesId", "BusinessClassSeatsCount", "FlightNumber", "InstrumentUsed", "NonBusinessClassSeatsCount", "RowsCount" },
                values: new object[] { 2, 1, 20, "AI301", "A320", 80, 50 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "AirlinesId", "BusinessClassSeatsCount", "FlightNumber", "InstrumentUsed", "NonBusinessClassSeatsCount", "RowsCount" },
                values: new object[] { 3, 2, 30, "SP100", "A320", 90, 60 });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AirlinesId",
                table: "Flights",
                column: "AirlinesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "FlightTrips");

            migrationBuilder.DropTable(
                name: "Airlines");

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 1,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 27, 17, 26, 47, 550, DateTimeKind.Local).AddTicks(1999), new DateTime(2021, 7, 2, 17, 26, 47, 548, DateTimeKind.Local).AddTicks(7560), new DateTime(2021, 7, 4, 17, 26, 47, 549, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "bookmodel",
                keyColumn: "FlightBookingId",
                keyValue: 2,
                columns: new[] { "bookeddate", "onwarddate", "returndate" },
                values: new object[] { new DateTime(2021, 6, 27, 17, 26, 47, 550, DateTimeKind.Local).AddTicks(2999), new DateTime(2021, 7, 2, 17, 26, 47, 550, DateTimeKind.Local).AddTicks(2986), new DateTime(2021, 7, 4, 17, 26, 47, 550, DateTimeKind.Local).AddTicks(2994) });
        }
    }
}
