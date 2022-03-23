using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUpGenius.Migrations
{
    public partial class tryagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    TimeSlotID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TourTime = table.Column<string>(nullable: true),
                    Taken = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.TimeSlotID);
                });

            migrationBuilder.CreateTable(
                name: "FormResponses",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeSlotID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormResponses", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_FormResponses_TimeSlots_TimeSlotID",
                        column: x => x.TimeSlotID,
                        principalTable: "TimeSlots",
                        principalColumn: "TimeSlotID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FormResponses_TimeSlotID",
                table: "FormResponses",
                column: "TimeSlotID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormResponses");

            migrationBuilder.DropTable(
                name: "TimeSlots");
        }
    }
}
