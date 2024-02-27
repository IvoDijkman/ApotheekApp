using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApotheekApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class allergyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Allergy",
                columns: new[] { "Id", "ClientId", "Description" },
                values: new object[,]
                {
                    { 1, "1", "Description" },
                    { 2, "2", "Description" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2063aad-b5d1-484d-b4fd-719feb0ee3c4", "d76b065a-c93d-4606-ab7b-620ab22d008e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bab41e6c-5b2f-43bf-98e6-862ae0ec253b", "3c6f5ce7-fcb2-4e47-88c6-6a8c6c37e01d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15cc58d9-a47b-45fe-8b99-1cf8265583f1", "e2622719-eaa2-4e7c-a350-5f8a9a49da40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f31d2e9-c584-46f0-84fd-8bc5d085603e", "c38bcf9d-7977-4d07-a0fa-a4a0228cafae" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Allergy",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Allergy",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0087f59-ab86-4cbf-a586-6b02faecded9", "46442976-3f17-47f0-9c8d-f12707e8d1e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5cf39080-309e-4104-8e13-41752073b2df", "324e658b-fa11-4748-bc89-4c4054a1d7b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "44a5c3a8-5074-4a54-bcc4-efee036d3a26", "4e12595f-fc93-4ddf-a8e3-51f1bea5abf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4e718e4-4f09-4843-9ca8-959c18bd0804", "52e6bd17-dc66-4593-8069-f1d5ac296fbe" });
        }
    }
}
