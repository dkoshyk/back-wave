using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wave.Api.Infrastructure.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 1, null, "James", null, null, "Smith", "user2", "12345678", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 2, null, "John", null, null, "Johnson", "user3", "12345678", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 3, null, "Robert", null, null, "Williams", "user4", "12345678", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 4, null, "Michael", null, null, "Brown", "user5", "12345678", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 5, null, "William", null, null, "Jones", "user6", "12345678", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 6, null, "David", null, null, "Garcia", "user7", "12345678", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 7, null, "Richard", null, null, "Miller", "user8", "12345678", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 8, null, "Joseph", null, null, "Davis", "user9", "12345678", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 9, null, "Thomas", null, null, "Rodriguez", "user10", "12345678", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 10, null, "Charles", null, null, "Martinez", "james", "12345678", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 11, null, "Patricia", null, null, "Lopez", "user12", "12345678", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImageStored", "LastActiveOn", "LastName", "Login", "Password", "PhoneNumber" },
                values: new object[] { 12, null, "Jennifer", null, null, "Gonzales", "user13", "12345678", null });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ClosedOn", "CreatedOn", "DeadlineOn", "Description", "OwnerId", "Priority", "Status", "Title", "Type", "UpdatedOn" },
                values: new object[] { 1, null, new DateTime(2021, 2, 21, 23, 19, 41, 937, DateTimeKind.Local).AddTicks(235), null, null, 1, 0, "new", "Go to shop", "task", new DateTime(2021, 2, 21, 23, 19, 41, 943, DateTimeKind.Local).AddTicks(4089) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
