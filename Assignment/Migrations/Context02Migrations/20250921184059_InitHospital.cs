using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations.Context02Migrations
{
    /// <inheritdoc />
    public partial class InitHospital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consultants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "DrugBrands",
                columns: table => new
                {
                    DrugCode = table.Column<int>(type: "int", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugBrands", x => new { x.DrugCode, x.BrandName });
                    table.ForeignKey(
                        name: "FK_DrugBrands_Drugs_DrugCode",
                        column: x => x.DrugCode,
                        principalTable: "Drugs",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    NurseNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ward_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.NurseNumber);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    Ward_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ward_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nurse_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.Ward_Id);
                    table.ForeignKey(
                        name: "FK_Wards_Nurses_Nurse_Number",
                        column: x => x.Nurse_Number,
                        principalTable: "Nurses",
                        principalColumn: "NurseNumber",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Consultant_Id = table.Column<int>(type: "int", nullable: false),
                    Ward_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Consultants_Consultant_Id",
                        column: x => x.Consultant_Id,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Patients_Wards_Ward_Id",
                        column: x => x.Ward_Id,
                        principalTable: "Wards",
                        principalColumn: "Ward_Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Patient_Consultant_Examines",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false),
                    Consultant_Id = table.Column<int>(type: "int", nullable: false),
                    Examine_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Consultant_Examines", x => new { x.Patient_Id, x.Consultant_Id, x.Examine_Date });
                    table.ForeignKey(
                        name: "FK_Patient_Consultant_Examines_Consultants_Consultant_Id",
                        column: x => x.Consultant_Id,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Patient_Consultant_Examines_Patients_Patient_Id",
                        column: x => x.Patient_Id,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Patient_Nurse_Drugs",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    NurseNumber = table.Column<int>(type: "int", nullable: false),
                    DrugCode = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Nurse_Drugs", x => new { x.PatientId, x.NurseNumber, x.DrugCode, x.Date, x.Time });
                    table.ForeignKey(
                        name: "FK_Patient_Nurse_Drugs_Drugs_DrugCode",
                        column: x => x.DrugCode,
                        principalTable: "Drugs",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Patient_Nurse_Drugs_Nurses_NurseNumber",
                        column: x => x.NurseNumber,
                        principalTable: "Nurses",
                        principalColumn: "NurseNumber",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Patient_Nurse_Drugs_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_Ward_Id",
                table: "Nurses",
                column: "Ward_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Consultant_Examines_Consultant_Id",
                table: "Patient_Consultant_Examines",
                column: "Consultant_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Nurse_Drugs_DrugCode",
                table: "Patient_Nurse_Drugs",
                column: "DrugCode");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Nurse_Drugs_NurseNumber",
                table: "Patient_Nurse_Drugs",
                column: "NurseNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Consultant_Id",
                table: "Patients",
                column: "Consultant_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Ward_Id",
                table: "Patients",
                column: "Ward_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_Nurse_Number",
                table: "Wards",
                column: "Nurse_Number");

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_Wards_Ward_Id",
                table: "Nurses",
                column: "Ward_Id",
                principalTable: "Wards",
                principalColumn: "Ward_Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_Wards_Ward_Id",
                table: "Nurses");

            migrationBuilder.DropTable(
                name: "DrugBrands");

            migrationBuilder.DropTable(
                name: "Patient_Consultant_Examines");

            migrationBuilder.DropTable(
                name: "Patient_Nurse_Drugs");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Consultants");

            migrationBuilder.DropTable(
                name: "Wards");

            migrationBuilder.DropTable(
                name: "Nurses");
        }
    }
}
