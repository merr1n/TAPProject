using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class EventsAndEventTypesAdditionPlusData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    OrganizerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Concert" },
                    { 2, "Spectacol Dans" },
                    { 3, "Stand-up Comedy" },
                    { 4, "Speech" },
                    { 5, "Other (Please Specify in the Event's title)" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "Location", "OrganizerId", "Price", "Status", "Title", "TypeId" },
                values: new object[,]
                {
                    { new Guid("5eab5c23-2198-4f79-8120-3ad2348f2ed7"), new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Come have some fun and become healthier while trying to win a prize!", "Stefan cel Mare street", new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"), 0.00m, "Available", "Marathon (Special Event)", 5 },
                    { new Guid("6dfeef92-d8cf-4e4e-85d6-67fc74e6eb92"), new DateTime(2024, 2, 28, 16, 15, 0, 0, DateTimeKind.Unspecified), "Come listen to what Selaru has to say", "Switzerland", new Guid("7a628ec2-502f-4ae0-84f2-01e0e7e8bf0d"), 500.00m, "Sold-out", "NATO Congress Speech", 4 },
                    { new Guid("7b676b19-fdb8-4d76-95a5-d8df5efc2c4e"), new DateTime(2024, 9, 23, 19, 45, 0, 0, DateTimeKind.Unspecified), "Spectacol folcloric 'Trandafir de la Moldova'!", "Husi", new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"), 0.00m, "Available", "Spectacol Trandafir de la Moldova!", 2 },
                    { new Guid("b2f6eaa1-4c39-411a-8579-d237d33c35e3"), new DateTime(2024, 6, 15, 14, 30, 0, 0, DateTimeKind.Unspecified), "Concert Ian, Azteca, Rava, si multi altii!", "Tiki-Club", new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"), 60.00m, "Available", "Concert Ian&Azteca", 1 },
                    { new Guid("f5a4f779-55f1-47bc-8b95-9ae2b1b69e6a"), new DateTime(2024, 11, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), "Veniti ca sa va simtiti bine!", "OneCaffe", new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"), 30.00m, "Closed", "Micutzu - Stand up Comedy Show", 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a628ec2-502f-4ae0-84f2-01e0e7e8bf0d"),
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82e24d8e-0e34-4953-b32f-fb2ac76f92ff"),
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"),
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7f9b7b3-956c-4a07-8a7c-45645eb5f2cc"),
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"),
                column: "TypeId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a628ec2-502f-4ae0-84f2-01e0e7e8bf0d"),
                column: "Type",
                value: "organizer");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82e24d8e-0e34-4953-b32f-fb2ac76f92ff"),
                column: "Type",
                value: "user");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"),
                column: "Type",
                value: "admin");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7f9b7b3-956c-4a07-8a7c-45645eb5f2cc"),
                column: "Type",
                value: "user");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"),
                column: "Type",
                value: "organizer");
        }
    }
}
