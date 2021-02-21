using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wave.Api.Infrastructure.Data.Migrations
{
    public partial class FixSeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2021, 2, 21, 23, 23, 58, 358, DateTimeKind.Local).AddTicks(5776), new DateTime(2021, 2, 21, 23, 23, 58, 366, DateTimeKind.Local).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Login",
                value: "user11");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2021, 2, 21, 23, 19, 41, 937, DateTimeKind.Local).AddTicks(235), new DateTime(2021, 2, 21, 23, 19, 41, 943, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Login",
                value: "james");
        }
    }
}
