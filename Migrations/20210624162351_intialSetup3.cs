using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_booking.Migrations
{
    public partial class intialSetup3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "airlinemodel",
                columns: table => new
                {
                    Airlinename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Airlinelogo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avilabledate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Triptype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Contactnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contactname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flightnumber = table.Column<int>(type: "int", nullable: false),
                    instrumentused = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bookmodel",
                columns: table => new
                {
                    FlightBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Userid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Triptype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discountcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Selectedseatonward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Selectedseatreturn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    onwarddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    returndate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Airlinename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Airlinelogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnAirlinename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnAirlinelogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Totalamount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    Fromplace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Toplace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mealtype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnMealtype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pnrnumber = table.Column<int>(type: "int", nullable: false),
                    bookeddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numberofseats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookmodel", x => x.FlightBookingId);
                });

            migrationBuilder.CreateTable(
                name: "usermodel",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usermodel", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "PassengerDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usermail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pnrnumber = table.Column<int>(type: "int", nullable: false),
                    mealpreference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    selectedseatnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flightbookingid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassengerDetails_bookmodel_flightbookingid",
                        column: x => x.flightbookingid,
                        principalTable: "bookmodel",
                        principalColumn: "FlightBookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "bookmodel",
                columns: new[] { "FlightBookingId", "Airlinelogo", "Airlinename", "Amount", "Discountcode", "Fromplace", "Mealtype", "Pnrnumber", "ReturnAirlinelogo", "ReturnAirlinename", "ReturnAmount", "ReturnMealtype", "Selectedseatonward", "Selectedseatreturn", "Toplace", "Totalamount", "Triptype", "UserEmail", "Userid", "Username", "bookeddate", "numberofseats", "onwarddate", "returndate", "status" },
                values: new object[] { 1, "", "SpiceJet", 2504m, "DC100", "Hyderabad", "SampleMeal", 123456, "ssss", "SpiceJet", 2504m, "SampleMeal", "A1", "A2", "Bangalore", 5008m, "sampelTriptype", "Surya.Teja@gmail.com", "1", "Surya", new DateTime(2021, 6, 24, 21, 53, 50, 960, DateTimeKind.Local).AddTicks(4339), 3, new DateTime(2021, 6, 29, 21, 53, 50, 958, DateTimeKind.Local).AddTicks(8747), new DateTime(2021, 7, 1, 21, 53, 50, 959, DateTimeKind.Local).AddTicks(7201), 1 });

            migrationBuilder.InsertData(
                table: "usermodel",
                columns: new[] { "UserID", "Password", "Role", "UserEmail", "Username" },
                values: new object[] { 1, "Ind@3333", "user", "Surya.Teja@gmail.com", "Surya Teja" });

            migrationBuilder.InsertData(
                table: "PassengerDetails",
                columns: new[] { "Id", "Age", "Gender", "Name", "Pnrnumber", "Usermail", "flightbookingid", "mealpreference", "selectedseatnumber" },
                values: new object[] { 1, 25, "M", "Surya", 12345, "Surya.Teja@gmail.com", 1, "mealpref", "A1" });

            migrationBuilder.CreateIndex(
                name: "IX_PassengerDetails_flightbookingid",
                table: "PassengerDetails",
                column: "flightbookingid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "airlinemodel");

            migrationBuilder.DropTable(
                name: "PassengerDetails");

            migrationBuilder.DropTable(
                name: "usermodel");

            migrationBuilder.DropTable(
                name: "bookmodel");
        }
    }
}
