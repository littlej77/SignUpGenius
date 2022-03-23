using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUpGenius.Migrations
{
    public partial class another : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TourTime",
                table: "TimeSlots",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 1, false, "8AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 2, false, "9AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 3, false, "10AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 4, false, "11AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 5, false, "12PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 6, false, "1PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 7, false, "2PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 8, false, "4PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 9, false, "5PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 10, false, "6PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 11, false, "7PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "Taken", "TourTime" },
                values: new object[] { 12, false, "8PM" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "TourId", "Email", "GroupName", "GroupSize", "Phone", "TimeSlotID" },
                values: new object[] { 1, "kyliefromm@gmail.com", "Kylie", 5, "801-555-5555", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormResponses",
                keyColumn: "TourId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "TimeSlotID",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TourTime",
                table: "TimeSlots",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
