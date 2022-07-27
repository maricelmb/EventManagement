using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class seedActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("5377de01-48ff-463f-afd0-7944b152b3c6"), "music", "London", new DateTime(2023, 1, 27, 16, 34, 11, 29, DateTimeKind.Local).AddTicks(7320), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("62368b65-8f93-475f-82ae-a7c54cf69dfd"), "drinks", "London", new DateTime(2022, 11, 27, 16, 34, 11, 29, DateTimeKind.Local).AddTicks(7305), "Activity 4 months in future", "Future Activity 4", "Yet another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("677b012f-a342-4f2c-af21-a1dc8d6635f2"), "culture", "London", new DateTime(2022, 8, 27, 16, 34, 11, 29, DateTimeKind.Local).AddTicks(7299), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("9b11a4ea-a585-4e8f-b6be-6cbb5607118e"), "culture", "Paris", new DateTime(2022, 6, 27, 16, 34, 11, 29, DateTimeKind.Local).AddTicks(7297), "Activity 1 month ago", "Past Activity 2", "Louvre" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("bd9b90c5-ad33-4663-9b5f-f28990f61a3e"), "travel", "London", new DateTime(2023, 2, 27, 16, 34, 11, 29, DateTimeKind.Local).AddTicks(7322), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("be4ab50f-cab6-4607-a206-f15e0b4626c6"), "film", "London", new DateTime(2023, 3, 27, 16, 34, 11, 29, DateTimeKind.Local).AddTicks(7324), "Activity 8 months in future", "Future Activity 8", "Cinema" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("d5c3b51d-1b2c-4f4c-9c2a-d0efa00b1c2a"), "music", "London", new DateTime(2022, 9, 27, 16, 34, 11, 29, DateTimeKind.Local).AddTicks(7301), "Activity 2 months in future", "Future Activity 2", "O2 Arena" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("e559e647-5bc8-4862-86a2-37486afc1303"), "drinks", "London", new DateTime(2022, 10, 27, 16, 34, 11, 29, DateTimeKind.Local).AddTicks(7303), "Activity 3 months in future", "Future Activity 3", "Another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("e91f1cf2-6cf6-4046-93e7-fb343f0d14ae"), "drinks", "London", new DateTime(2022, 12, 27, 16, 34, 11, 29, DateTimeKind.Local).AddTicks(7318), "Activity 5 months in future", "Future Activity 5", "Just another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("f17e3f20-c85c-4aaf-8412-89ae0069ce48"), "drinks", "London", new DateTime(2022, 5, 27, 16, 34, 11, 29, DateTimeKind.Local).AddTicks(7280), "Activity 2 months ago", "Past Activity 1", "Pub" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5377de01-48ff-463f-afd0-7944b152b3c6"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("62368b65-8f93-475f-82ae-a7c54cf69dfd"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("677b012f-a342-4f2c-af21-a1dc8d6635f2"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("9b11a4ea-a585-4e8f-b6be-6cbb5607118e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("bd9b90c5-ad33-4663-9b5f-f28990f61a3e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("be4ab50f-cab6-4607-a206-f15e0b4626c6"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("d5c3b51d-1b2c-4f4c-9c2a-d0efa00b1c2a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e559e647-5bc8-4862-86a2-37486afc1303"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e91f1cf2-6cf6-4046-93e7-fb343f0d14ae"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f17e3f20-c85c-4aaf-8412-89ae0069ce48"));
        }
    }
}
