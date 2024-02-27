using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApotheekApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class clientEmployeeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Employee_FirstName", "Employee_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3", 0, "44a5c3a8-5074-4a54-bcc4-efee036d3a26", "Employee", null, false, "Name", "Lastname", false, null, null, null, null, null, false, "4e12595f-fc93-4ddf-a8e3-51f1bea5abf8", false, null },
                    { "4", 0, "c4e718e4-4f09-4843-9ca8-959c18bd0804", "Employee", null, false, "Name", "Lastname", false, null, null, null, null, null, false, "52e6bd17-dc66-4593-8069-f1d5ac296fbe", false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ed3704e-1eab-453e-b865-fadc4d8cc23b", "88b87949-a2b5-43bb-8386-f16701396ddc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "970fdde6-2a90-471e-b5b6-2453f5934384", "39628689-e329-4eb4-b570-52ea33b5dff5" });
        }
    }
}
