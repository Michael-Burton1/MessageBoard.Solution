using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Subject = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Text = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Author = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Author", "Subject", "Text" },
                values: new object[,]
                {
                    { 1, "Towelly", "Beach safety", "Don't forget to bring a towel" },
                    { 2, "StrongBad", "Shut up", "Shut it up, you" },
                    { 3, "Woolly Mammoth", "Mammoth shaming", "It's not a coat!" },
                    { 4, "Sea Cow", "Manitee shaming", "I'm a manitee, I have a layer of blubber to keep me warm." },
                    { 5, "StrongBad", "Christmas carol remix", "Oh Holy Crap!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
