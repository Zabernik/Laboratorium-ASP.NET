using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc8c740e-e080-444e-99d8-992fcd2f9836");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57cba5ad-43fc-4f5e-8612-4915016afe0b", "2aeca659-31b7-446e-9add-863d9dfc39c0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57cba5ad-43fc-4f5e-8612-4915016afe0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aeca659-31b7-446e-9add-863d9dfc39c0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17b5c83b-c8fd-4b20-aff9-3ec68e12785f", "17b5c83b-c8fd-4b20-aff9-3ec68e12785f", "user", "USER" },
                    { "52205307-a0ab-4a33-909d-febafca8accb", "52205307-a0ab-4a33-909d-febafca8accb", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d78b66ac-1458-492d-80ff-e54f475fc3d7", 0, "87a99063-d61e-45b4-a194-23e7c9b506c0", "test@wsei.edu.pl", true, false, null, "TEST@WSEI.EDU.PL", "TEST", "AQAAAAEAACcQAAAAENeaBazHcxNSGnB/KymhlDQtAsyjNUActcCylGaUkAHZQK1ORUrtaQ7CMLeFs1L4+w==", null, false, "aa4855be-65a9-4138-b539-2f4e86cdd6e0", false, "test" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "52205307-a0ab-4a33-909d-febafca8accb", "d78b66ac-1458-492d-80ff-e54f475fc3d7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17b5c83b-c8fd-4b20-aff9-3ec68e12785f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "52205307-a0ab-4a33-909d-febafca8accb", "d78b66ac-1458-492d-80ff-e54f475fc3d7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52205307-a0ab-4a33-909d-febafca8accb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d78b66ac-1458-492d-80ff-e54f475fc3d7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57cba5ad-43fc-4f5e-8612-4915016afe0b", "57cba5ad-43fc-4f5e-8612-4915016afe0b", "admin", "ADMIN" },
                    { "dc8c740e-e080-444e-99d8-992fcd2f9836", "e41a84fc-a856-4192-a6ec-b02f5a05e004", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2aeca659-31b7-446e-9add-863d9dfc39c0", 0, "a2e49c7d-cada-41ab-b0fe-e9a8a8256487", "test@wsei.edu.pl", true, false, null, "TEST@WSEI.EDU.PL", "TEST", "AQAAAAEAACcQAAAAEFcJTzce5m+shub8T5OgP5/3cKT6LXQkBYMqBaUiTnmd4++4KUBhV4D+JmEIk81RsA==", null, false, "4a56b650-098b-4d38-9ee3-4fd4a65b23a3", false, "test" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "57cba5ad-43fc-4f5e-8612-4915016afe0b", "2aeca659-31b7-446e-9add-863d9dfc39c0" });
        }
    }
}
