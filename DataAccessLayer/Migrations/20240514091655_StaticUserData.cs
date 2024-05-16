using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class StaticUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Type" },
                values: new object[,]
                {
                    { new Guid("7a628ec2-502f-4ae0-84f2-01e0e7e8bf0d"), "monica@gmail.com", "Monica", "monica123", "organizer" },
                    { new Guid("82e24d8e-0e34-4953-b32f-fb2ac76f92ff"), "popeye@gmail.com", "Nico", "samp", "user" },
                    { new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"), "darius@gmail.com", "Darius", "darius", "admin" },
                    { new Guid("c7f9b7b3-956c-4a07-8a7c-45645eb5f2cc"), "marius@gmail.com", "Marius", "marius", "user" },
                    { new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"), "maxifny@gmail.com", "Edi", "geometryfear", "organizer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a628ec2-502f-4ae0-84f2-01e0e7e8bf0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82e24d8e-0e34-4953-b32f-fb2ac76f92ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7f9b7b3-956c-4a07-8a7c-45645eb5f2cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"));
        }
    }
}
