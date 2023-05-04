using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniformAccountingSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiptDate",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 4, 5, 20, 7, 508, DateTimeKind.Utc).AddTicks(8007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 23, 12, 8, 29, 632, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "IssuanceDate",
                table: "Issues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 4, 5, 20, 7, 508, DateTimeKind.Utc).AddTicks(8496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 23, 12, 8, 29, 632, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "LastName", "Patronymic", "WorkPosition" },
                values: new object[,]
                {
                    { new Guid("179287bf-dbea-4e19-ac04-410731a15674"), "Александр", "Черепанов", "Петрович", "роблоксер" },
                    { new Guid("1ee18c46-4680-430b-b2f8-573f30f1eebb"), "Вячеслав", "Горелов", "Антонович", "разработчик" },
                    { new Guid("ef4d4fb4-cf1d-4fd3-b148-f4e5455fcccf"), "Валерия", "Косынкова", "Дмитриевна", "грузчик" }
                });

            migrationBuilder.InsertData(
                table: "Uniforms",
                columns: new[] { "Id", "Name", "Price", "UniformType", "UniformTypeRefUniformType" },
                values: new object[] { new Guid("3fe835d7-bede-4312-a6a2-de17818a4a43"), "Костюм грузчика", 6000.0, 5, null });

            migrationBuilder.InsertData(
                table: "Uniforms",
                columns: new[] { "Id", "Name", "Price", "UniformTypeRefUniformType" },
                values: new object[,]
                {
                    { new Guid("578d6c97-6c40-49cc-8e0f-7f202286110a"), "Футболка роблоксера", 3250.0, null },
                    { new Guid("ea30c579-a09c-4d5a-9a0c-820c33e9801d"), "Штаны обыкновенные", 800.0, null }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "Description", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { new Guid("58be4909-b55c-42fd-a7af-8b01bdcf3a0e"), null, "refriver@mail.ru", "ИП Краснореченск", "89505602033" },
                    { new Guid("626e842b-861d-43cc-b8f6-980602708027"), "Компания много Деловые линии", "dellines@gmail.com", "Деловые линии", "89996604020" }
                });

            migrationBuilder.InsertData(
                table: "Receipts",
                columns: new[] { "Id", "Desctiption", "ReceiptDate", "VendorId" },
                values: new object[] { new Guid("46b2f407-d022-4b7a-8e65-4e1e60c8fd7d"), "Первая поставка", new DateTime(2023, 5, 4, 5, 20, 7, 509, DateTimeKind.Utc).AddTicks(484), new Guid("58be4909-b55c-42fd-a7af-8b01bdcf3a0e") });

            migrationBuilder.InsertData(
                table: "ReceiptItems",
                columns: new[] { "Id", "Amount", "ReceiptId", "UniformId" },
                values: new object[] { new Guid("a61b5e91-1ce1-4fe3-af25-df88d3b9d33b"), 5, new Guid("46b2f407-d022-4b7a-8e65-4e1e60c8fd7d"), new Guid("ea30c579-a09c-4d5a-9a0c-820c33e9801d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("179287bf-dbea-4e19-ac04-410731a15674"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1ee18c46-4680-430b-b2f8-573f30f1eebb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ef4d4fb4-cf1d-4fd3-b148-f4e5455fcccf"));

            migrationBuilder.DeleteData(
                table: "ReceiptItems",
                keyColumn: "Id",
                keyValue: new Guid("a61b5e91-1ce1-4fe3-af25-df88d3b9d33b"));

            migrationBuilder.DeleteData(
                table: "Uniforms",
                keyColumn: "Id",
                keyValue: new Guid("3fe835d7-bede-4312-a6a2-de17818a4a43"));

            migrationBuilder.DeleteData(
                table: "Uniforms",
                keyColumn: "Id",
                keyValue: new Guid("578d6c97-6c40-49cc-8e0f-7f202286110a"));

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("626e842b-861d-43cc-b8f6-980602708027"));

            migrationBuilder.DeleteData(
                table: "Receipts",
                keyColumn: "Id",
                keyValue: new Guid("46b2f407-d022-4b7a-8e65-4e1e60c8fd7d"));

            migrationBuilder.DeleteData(
                table: "Uniforms",
                keyColumn: "Id",
                keyValue: new Guid("ea30c579-a09c-4d5a-9a0c-820c33e9801d"));

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("58be4909-b55c-42fd-a7af-8b01bdcf3a0e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiptDate",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 23, 12, 8, 29, 632, DateTimeKind.Utc).AddTicks(6235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 4, 5, 20, 7, 508, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "IssuanceDate",
                table: "Issues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 23, 12, 8, 29, 632, DateTimeKind.Utc).AddTicks(6910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 4, 5, 20, 7, 508, DateTimeKind.Utc).AddTicks(8496));
        }
    }
}
