using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations.Context01Migrations
{
    /// <inheritdoc />
    public partial class InitAirline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Route_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Route_Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Airline_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Airlines_Airline_Id",
                        column: x => x.Airline_Id,
                        principalTable: "Airlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hostesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Airline_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hostesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hostesses_Airlines_Airline_Id",
                        column: x => x.Airline_Id,
                        principalTable: "Airlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Airline_Id = table.Column<int>(type: "int", nullable: false),
                    Phone_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => new { x.Airline_Id, x.Phone_Number });
                    table.ForeignKey(
                        name: "FK_Phones_Airlines_Airline_Id",
                        column: x => x.Airline_Id,
                        principalTable: "Airlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pilots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Airline_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pilots_Airlines_Airline_Id",
                        column: x => x.Airline_Id,
                        principalTable: "Airlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Airline_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Airlines_Airline_Id",
                        column: x => x.Airline_Id,
                        principalTable: "Airlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Employee_Id = table.Column<int>(type: "int", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => new { x.Employee_Id, x.Qualification });
                    table.ForeignKey(
                        name: "FK_Qualifications_Employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AirCrafts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Major_Pilot_Id = table.Column<int>(type: "int", nullable: false),
                    Assistant_Pilot_Id = table.Column<int>(type: "int", nullable: false),
                    Hostess01_Id = table.Column<int>(type: "int", nullable: false),
                    Hostess02_Id = table.Column<int>(type: "int", nullable: false),
                    Airline_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirCrafts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirCrafts_Airlines_Airline_Id",
                        column: x => x.Airline_Id,
                        principalTable: "Airlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AirCrafts_Hostesses_Hostess01_Id",
                        column: x => x.Hostess01_Id,
                        principalTable: "Hostesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AirCrafts_Hostesses_Hostess02_Id",
                        column: x => x.Hostess02_Id,
                        principalTable: "Hostesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AirCrafts_Pilots_Assistant_Pilot_Id",
                        column: x => x.Assistant_Pilot_Id,
                        principalTable: "Pilots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AirCrafts_Pilots_Major_Pilot_Id",
                        column: x => x.Major_Pilot_Id,
                        principalTable: "Pilots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AirCraft_Routes",
                columns: table => new
                {
                    AirCraft_Id = table.Column<int>(type: "int", nullable: false),
                    Route_Id = table.Column<int>(type: "int", nullable: false),
                    Number_of_Passengers = table.Column<int>(type: "int", nullable: false),
                    Price_per_Passenger = table.Column<int>(type: "int", nullable: false),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirCraft_Routes", x => new { x.AirCraft_Id, x.Route_Id });
                    table.ForeignKey(
                        name: "FK_AirCraft_Routes_AirCrafts_AirCraft_Id",
                        column: x => x.AirCraft_Id,
                        principalTable: "AirCrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AirCraft_Routes_Routes_Route_Id",
                        column: x => x.Route_Id,
                        principalTable: "Routes",
                        principalColumn: "Route_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirCraft_Routes_Route_Id",
                table: "AirCraft_Routes",
                column: "Route_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AirCrafts_Airline_Id",
                table: "AirCrafts",
                column: "Airline_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AirCrafts_Assistant_Pilot_Id",
                table: "AirCrafts",
                column: "Assistant_Pilot_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AirCrafts_Hostess01_Id",
                table: "AirCrafts",
                column: "Hostess01_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AirCrafts_Hostess02_Id",
                table: "AirCrafts",
                column: "Hostess02_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AirCrafts_Major_Pilot_Id",
                table: "AirCrafts",
                column: "Major_Pilot_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Airline_Id",
                table: "Employees",
                column: "Airline_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hostesses_Airline_Id",
                table: "Hostesses",
                column: "Airline_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pilots_Airline_Id",
                table: "Pilots",
                column: "Airline_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Airline_Id",
                table: "Transactions",
                column: "Airline_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirCraft_Routes");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "AirCrafts");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Hostesses");

            migrationBuilder.DropTable(
                name: "Pilots");

            migrationBuilder.DropTable(
                name: "Airlines");
        }
    }
}
