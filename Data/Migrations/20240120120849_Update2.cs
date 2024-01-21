using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2c5444e7-ea8a-42dc-ae1a-58ba1177d002", "2c5444e7-ea8a-42dc-ae1a-58ba1177d002", "user", "USER" },
                    { "8985d129-7a7a-4a43-bd27-eff8e64dce9c", "8985d129-7a7a-4a43-bd27-eff8e64dce9c", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "70514929-1fbb-4ac0-a659-a465154336c0", 0, "acd25da7-116b-4a0b-963c-5cfd0daa58ad", "root@wsei.edu.pl", true, false, null, "ROOT@WSEI.EDU.PL", "ROOT", "AQAAAAEAACcQAAAAEOOpLfsJcSIoE6VSGpAP8CYuTlDzJubC/QXbNfRoLf4AFbL/rrjW6JmygNr8hgHYOg==", null, false, "9a966a97-3a48-47b4-9b6e-3294f481344a", false, "root" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8985d129-7a7a-4a43-bd27-eff8e64dce9c", "70514929-1fbb-4ac0-a659-a465154336c0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5444e7-ea8a-42dc-ae1a-58ba1177d002");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8985d129-7a7a-4a43-bd27-eff8e64dce9c", "70514929-1fbb-4ac0-a659-a465154336c0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8985d129-7a7a-4a43-bd27-eff8e64dce9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70514929-1fbb-4ac0-a659-a465154336c0");

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
    }
}
