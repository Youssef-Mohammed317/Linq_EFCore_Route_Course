using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations.Context03Migrations
{
    /// <inheritdoc />
    public partial class InitMusician : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Musician_Id = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Albums_Musicians_Musician_Id",
                        column: x => x.Musician_Id,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Musican_Instruments",
                columns: table => new
                {
                    MusicianId = table.Column<int>(type: "int", nullable: false),
                    Instrument_Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musican_Instruments", x => new { x.MusicianId, x.Instrument_Name });
                    table.ForeignKey(
                        name: "FK_Musican_Instruments_Instruments_Instrument_Name",
                        column: x => x.Instrument_Name,
                        principalTable: "Instruments",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Musican_Instruments_Musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Author_Id = table.Column<int>(type: "int", nullable: false),
                    Album_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Title);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_Album_Id",
                        column: x => x.Album_Id,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Songs_Authors_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Song_Musicans",
                columns: table => new
                {
                    Song_Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MusicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_Musicans", x => new { x.Song_Title, x.MusicianId });
                    table.ForeignKey(
                        name: "FK_Song_Musicans_Musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Song_Musicans_Songs_Song_Title",
                        column: x => x.Song_Title,
                        principalTable: "Songs",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_Musician_Id",
                table: "Albums",
                column: "Musician_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Musican_Instruments_Instrument_Name",
                table: "Musican_Instruments",
                column: "Instrument_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Musicans_MusicianId",
                table: "Song_Musicans",
                column: "MusicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_Album_Id",
                table: "Songs",
                column: "Album_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_Author_Id",
                table: "Songs",
                column: "Author_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musican_Instruments");

            migrationBuilder.DropTable(
                name: "Song_Musicans");

            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Musicians");
        }
    }
}
