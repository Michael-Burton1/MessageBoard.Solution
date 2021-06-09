using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Category = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Booze = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Subject = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Text = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Author = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Booze", "Category", "Date", "Name" },
                values: new object[,]
                {
                    { 1, true, "Birthday", new DateTime(2021, 6, 9, 10, 30, 0, 0, DateTimeKind.Utc), "My son's 7th bday" },
                    { 2, false, "Ted Talk", new DateTime(2021, 6, 9, 10, 30, 0, 0, DateTimeKind.Utc), "Mushrooms?" },
                    { 3, true, "Concert", new DateTime(2021, 6, 9, 10, 30, 0, 0, DateTimeKind.Utc), "The Grateful Dead" },
                    { 4, true, "Concert", new DateTime(2021, 6, 9, 10, 30, 0, 0, DateTimeKind.Utc), "Generationals" },
                    { 5, true, "A saucey puppet show", new DateTime(2021, 6, 9, 10, 30, 0, 0, DateTimeKind.Utc), "Where's your hand?" },
                    { 6, false, "Book signing", new DateTime(2021, 6, 9, 10, 30, 0, 0, DateTimeKind.Utc), "David Sedaris: Me Talk Pretty One Day" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Author", "Date", "Subject", "Text" },
                values: new object[,]
                {
                    { 1, "Towelly", new DateTime(2021, 6, 9, 10, 30, 0, 0, DateTimeKind.Utc), "Beach safety", "Don't forget to bring a towel" },
                    { 2, "StrongBad", new DateTime(2021, 6, 9, 10, 30, 0, 0, DateTimeKind.Utc), "Shut up", "Shut it up, you" },
                    { 3, "Woolly Mammoth", new DateTime(2021, 6, 9, 10, 30, 0, 0, DateTimeKind.Utc), "Mammoth shaming", "It's not a coat!" },
                    { 4, "Sea Cow", new DateTime(2021, 6, 9, 10, 30, 0, 0, DateTimeKind.Utc), "Manitee shaming", "I'm a manitee, I have a layer of blubber to keep me warm." },
                    { 5, "StrongBad", new DateTime(2021, 6, 9, 10, 30, 0, 0, DateTimeKind.Utc), "Christmas carol remix", "Oh Holy Crap!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
