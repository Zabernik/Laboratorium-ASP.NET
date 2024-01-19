using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "48c5fc26-0e59-4c2f-ac76-f4c16579396d", "0d9096b2-0756-487d-b70f-f5ad5a0f7d23" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48c5fc26-0e59-4c2f-ac76-f4c16579396d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d9096b2-0756-487d-b70f-f5ad5a0f7d23");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "809b2ce6-fada-4544-8faf-a59e54910fbc", "809b2ce6-fada-4544-8faf-a59e54910fbc", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "defc1d8a-246e-4458-86c4-493e36687b65", 0, "8643f382-acbe-4aa3-9301-5327fa097e82", "test@wsei.edu.pl", true, false, null, "TEST@WSEI.EDU.PL", "TEST", "AQAAAAEAACcQAAAAEEADalD+cRbTHAQ1pyeaeYI/nLCnV7sS7BeQdRVXKemQC53ziKnBVxQziuEUiDKeAg==", null, false, "920e92ab-fd38-47c8-a279-e97f07299433", false, "test" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 1,
                column: "DateOfProduction",
                value: new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 3,
                columns: new[] { "DateOfProduction", "Price" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4m });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "809b2ce6-fada-4544-8faf-a59e54910fbc", "defc1d8a-246e-4458-86c4-493e36687b65" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "809b2ce6-fada-4544-8faf-a59e54910fbc", "defc1d8a-246e-4458-86c4-493e36687b65" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "809b2ce6-fada-4544-8faf-a59e54910fbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defc1d8a-246e-4458-86c4-493e36687b65");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48c5fc26-0e59-4c2f-ac76-f4c16579396d", "48c5fc26-0e59-4c2f-ac76-f4c16579396d", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0d9096b2-0756-487d-b70f-f5ad5a0f7d23", 0, "db3b877a-b926-482e-8f8e-e2748271f6b9", "test@wsei.edu.pl", true, false, null, "TEST@WSEI.EDU.PL", "TEST", "AQAAAAEAACcQAAAAEIwS3kwFeir98BqFd0NjvKKUZ7nUuW42xXrFFTYvq4O9BsvKu1/sSKF5ZlUp+aIRcQ==", null, false, "f8ba57fc-1e24-4fdd-900b-0b49abed61cd", false, "test" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 1,
                column: "DateOfProduction",
                value: new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 3,
                columns: new[] { "DateOfProduction", "Price" },
                values: new object[] { new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5m });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "48c5fc26-0e59-4c2f-ac76-f4c16579396d", "0d9096b2-0756-487d-b70f-f5ad5a0f7d23" });
        }
    }
}
