using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a074e746-062c-44e7-8e9a-1e03e0e23719", "1e86f0fa-86d9-4d5f-b687-ae85a5ea3e55" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a074e746-062c-44e7-8e9a-1e03e0e23719");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e86f0fa-86d9-4d5f-b687-ae85a5ea3e55");

            migrationBuilder.RenameColumn(
                name: "DateOdProduction",
                table: "products",
                newName: "DateOfProduction");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "DateOfProduction",
                table: "products",
                newName: "DateOdProduction");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a074e746-062c-44e7-8e9a-1e03e0e23719", "a074e746-062c-44e7-8e9a-1e03e0e23719", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1e86f0fa-86d9-4d5f-b687-ae85a5ea3e55", 0, "68780d15-22e3-4b63-8df1-08869baaa5e2", "test@wsei.edu.pl", true, false, null, "TEST@WSEI.EDU.PL", "TEST", "AQAAAAEAACcQAAAAEAZQlmwgrdo5dayJKqE9vdHgWcDzxhTh3ILKmFOEI0zl4lHsVnoqMsWdDv2etJMlTw==", null, false, "92541ecb-ada7-4841-b7d7-63c433362ae0", false, "test" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a074e746-062c-44e7-8e9a-1e03e0e23719", "1e86f0fa-86d9-4d5f-b687-ae85a5ea3e55" });
        }
    }
}
