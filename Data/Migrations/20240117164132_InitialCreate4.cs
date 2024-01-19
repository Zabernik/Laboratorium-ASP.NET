using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3004529-cf42-4180-970e-1d9c4ba5f541", "c113b6f8-99c1-40d7-84bd-3dfe8d778304" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3004529-cf42-4180-970e-1d9c4ba5f541");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c113b6f8-99c1-40d7-84bd-3dfe8d778304");

            migrationBuilder.AddColumn<string>(
                name: "Producer",
                table: "products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
                column: "Producer",
                value: "Nestle");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Producer" },
                values: new object[] { "Napój gazowany", "Cola", "Cocacola" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "product_id", "DateOfProduction", "Description", "Name", "Price", "Producer" },
                values: new object[] { 3, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Napój gazowany o smaku pomarańczowym", "Mirinda", 5m, "PepsiCo" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "48c5fc26-0e59-4c2f-ac76-f4c16579396d", "0d9096b2-0756-487d-b70f-f5ad5a0f7d23" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "48c5fc26-0e59-4c2f-ac76-f4c16579396d", "0d9096b2-0756-487d-b70f-f5ad5a0f7d23" });

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48c5fc26-0e59-4c2f-ac76-f4c16579396d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d9096b2-0756-487d-b70f-f5ad5a0f7d23");

            migrationBuilder.DropColumn(
                name: "Producer",
                table: "products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3004529-cf42-4180-970e-1d9c4ba5f541", "a3004529-cf42-4180-970e-1d9c4ba5f541", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c113b6f8-99c1-40d7-84bd-3dfe8d778304", 0, "0938bd56-9129-4ec8-a0b5-da13bafb61c9", "test@wsei.edu.pl", true, false, null, "TEST@WSEI.EDU.PL", "TEST", "AQAAAAEAACcQAAAAEJLdUXjdwTBWHqW4le4wWZHE3EQc+Ghe+J6jUMpLxtc59T5sK+zTem0TK+aAYxHiMw==", null, false, "a067575e-25ff-49d3-865b-590e41775f9b", false, "test" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ot chlebek", "Chleb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a3004529-cf42-4180-970e-1d9c4ba5f541", "c113b6f8-99c1-40d7-84bd-3dfe8d778304" });
        }
    }
}
