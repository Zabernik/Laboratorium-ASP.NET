using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Producer",
                table: "products",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62adf12b-1216-4ed4-a3e5-fe0cc720546a", "62adf12b-1216-4ed4-a3e5-fe0cc720546a", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ed4cf424-9255-4fe3-9891-7d577f0a3cf7", 0, "53ed7468-39cc-4fd8-8fa2-b36e223622c6", "test@wsei.edu.pl", true, false, null, "TEST@WSEI.EDU.PL", "TEST", "AQAAAAEAACcQAAAAEHxQ6sCe0KqwZQXFinsp8j5uFg8QlJMW1U2mSkKqKYl/0MqvBaxNfW8JchSryNikfQ==", null, false, "150f6de4-598a-41d7-9662-d32d8cd28af7", false, "test" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 1,
                column: "Producer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 2,
                column: "Producer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 3,
                column: "Producer",
                value: 3);

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "product_id", "DateOfProduction", "Description", "Name", "Price", "Producer" },
                values: new object[] { 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Napój gazowany", "Sprite", 6m, 2 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "62adf12b-1216-4ed4-a3e5-fe0cc720546a", "ed4cf424-9255-4fe3-9891-7d577f0a3cf7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62adf12b-1216-4ed4-a3e5-fe0cc720546a", "ed4cf424-9255-4fe3-9891-7d577f0a3cf7" });

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62adf12b-1216-4ed4-a3e5-fe0cc720546a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4cf424-9255-4fe3-9891-7d577f0a3cf7");

            migrationBuilder.AlterColumn<string>(
                name: "Producer",
                table: "products",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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
                column: "Producer",
                value: "Nestle");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 2,
                column: "Producer",
                value: "Cocacola");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 3,
                column: "Producer",
                value: "PepsiCo");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "809b2ce6-fada-4544-8faf-a59e54910fbc", "defc1d8a-246e-4458-86c4-493e36687b65" });
        }
    }
}
