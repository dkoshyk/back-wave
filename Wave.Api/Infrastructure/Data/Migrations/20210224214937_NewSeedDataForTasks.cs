using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wave.Api.Infrastructure.Data.Migrations
{
    public partial class NewSeedDataForTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2021, 2, 24, 23, 49, 36, 994, DateTimeKind.Local).AddTicks(5160), new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ClosedOn", "CreatedOn", "DeadlineOn", "Description", "OwnerId", "Priority", "Status", "Title", "Type", "UpdatedOn" },
                values: new object[] { 2, null, new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2740), null, null, 1, 0, "new", "Go to shop", "task", new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ClosedOn", "CreatedOn", "DeadlineOn", "Description", "OwnerId", "Priority", "Status", "Title", "Type", "UpdatedOn" },
                values: new object[] { 3, null, new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2757), null, null, 1, 0, "new", "Go to home", "task", new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ClosedOn", "CreatedOn", "DeadlineOn", "Description", "OwnerId", "Priority", "Status", "Title", "Type", "UpdatedOn" },
                values: new object[] { 4, null, new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2761), null, null, 1, 0, "new", "Go to school", "task", new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ClosedOn", "CreatedOn", "DeadlineOn", "Description", "OwnerId", "Priority", "Status", "Title", "Type", "UpdatedOn" },
                values: new object[] { 5, null, new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2767), null, null, 1, 0, "new", "Go to kindergarten", "task", new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ClosedOn", "CreatedOn", "DeadlineOn", "Description", "OwnerId", "Priority", "Status", "Title", "Type", "UpdatedOn" },
                values: new object[] { 6, null, new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2776), null, null, 1, 0, "new", "Go to office", "task", new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ClosedOn", "CreatedOn", "DeadlineOn", "Description", "OwnerId", "Priority", "Status", "Title", "Type", "UpdatedOn" },
                values: new object[] { 7, null, new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2781), null, null, 1, 0, "new", "Go to bed", "task", new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ClosedOn", "CreatedOn", "DeadlineOn", "Description", "OwnerId", "Priority", "Status", "Title", "Type", "UpdatedOn" },
                values: new object[] { 8, null, new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2788), null, null, 1, 0, "new", "Go to the cinema", "task", new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ClosedOn", "CreatedOn", "DeadlineOn", "Description", "OwnerId", "Priority", "Status", "Title", "Type", "UpdatedOn" },
                values: new object[] { 9, null, new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2792), null, null, 1, 0, "new", "Go to meeting", "task", new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ClosedOn", "CreatedOn", "DeadlineOn", "Description", "OwnerId", "Priority", "Status", "Title", "Type", "UpdatedOn" },
                values: new object[] { 10, null, new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2798), null, null, 1, 0, "new", "Go to prison", "task", new DateTime(2021, 2, 24, 23, 49, 36, 997, DateTimeKind.Local).AddTicks(2800) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2021, 2, 21, 23, 23, 58, 358, DateTimeKind.Local).AddTicks(5776), new DateTime(2021, 2, 21, 23, 23, 58, 366, DateTimeKind.Local).AddTicks(6372) });
        }
    }
}
