using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApotheekApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class medicineMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "596fb5f5-9189-42ee-a4e9-f89c6ca42916", "1a7e61e9-1ece-4418-864a-eda13f38a052" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dfeb3e0c-05c2-4ade-8fb3-0922021665e1", "75f4ed0e-967c-4a1e-8148-65c54c345a46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "97fe3233-7341-4c9c-bc27-d57d0460044c", "f9259ca6-847a-4500-818f-5f205c402f61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59d18ff8-b60b-43f3-a45a-1b5ebe84b66e", "21875922-5b68-489c-8d4c-3978554cc7df" });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "ClientId", "Description", "Manual", "Name", "Stock", "Type", "Warnings" },
                values: new object[,]
                {
                    { 1, "1", "Description", "Manual", "Name", 5, "Type", null },
                    { 2, "2", "Description", "Manual", "Name", 12, "Type", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62b13146-0fe1-46f8-9d17-58e9f0e16653", "fea60775-31f8-4878-b6b5-02ad36d6cdef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef9ba6eb-f803-425d-b823-02f75a1b2e87", "e719487c-00d5-46c7-b881-1b10049f1da7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f831d0c-20f8-4722-872c-8fb2f3d53d4c", "aa3d418f-afce-4ca2-90bf-220186d1460b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6810dd16-45d0-471a-9dfc-333a890afdcd", "6040417c-5e47-4eed-b7f5-4c9926ad5b10" });
        }
    }
}
