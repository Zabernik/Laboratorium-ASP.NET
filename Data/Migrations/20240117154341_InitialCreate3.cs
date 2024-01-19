using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f1d2c4f-8485-4fb2-8600-b42d86f5850d", "ea53e1ac-126b-46d9-a1e2-4fb1c813eb84" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f1d2c4f-8485-4fb2-8600-b42d86f5850d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea53e1ac-126b-46d9-a1e2-4fb1c813eb84");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3004529-cf42-4180-970e-1d9c4ba5f541", "a3004529-cf42-4180-970e-1d9c4ba5f541", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c113b6f8-99c1-40d7-84bd-3dfe8d778304", 0, "0938bd56-9129-4ec8-a0b5-da13bafb61c9", "test@wsei.edu.pl", true, false, null, "TEST@WSEI.EDU.PL", "TEST", "AQAAAAEAACcQAAAAEJLdUXjdwTBWHqW4le4wWZHE3EQc+Ghe+J6jUMpLxtc59T5sK+zTem0TK+aAYxHiMw==", null, false, "a067575e-25ff-49d3-865b-590e41775f9b", false, "test" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "product_id", "DateOfProduction", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ot chlebek", "Chleb", 5m });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a3004529-cf42-4180-970e-1d9c4ba5f541", "c113b6f8-99c1-40d7-84bd-3dfe8d778304" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3004529-cf42-4180-970e-1d9c4ba5f541", "c113b6f8-99c1-40d7-84bd-3dfe8d778304" });

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3004529-cf42-4180-970e-1d9c4ba5f541");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c113b6f8-99c1-40d7-84bd-3dfe8d778304");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f1d2c4f-8485-4fb2-8600-b42d86f5850d", "4f1d2c4f-8485-4fb2-8600-b42d86f5850d", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ea53e1ac-126b-46d9-a1e2-4fb1c813eb84", 0, "1a16ffc8-4121-4bc4-98c4-8533ae0ecb78", "test@wsei.edu.pl", true, false, null, "TEST@WSEI.EDU.PL", "TEST", "AQAAAAEAACcQAAAAEHZgu59KnMVQBGznedeh9t1FZsqqb3ajrFrCa8S2W9OSJiCrz9RscmUlxcVYEeMQcQ==", null, false, "9f0dfc0c-9306-4ffa-80ab-0fbc50bf6904", false, "test" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4f1d2c4f-8485-4fb2-8600-b42d86f5850d", "ea53e1ac-126b-46d9-a1e2-4fb1c813eb84" });
        }
    }
}
