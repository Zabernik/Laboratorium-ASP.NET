using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "6a6c0990-f368-45ce-8c38-7735e4c8ae0c", "6a6c0990-f368-45ce-8c38-7735e4c8ae0c", "admin", "ADMIN" },
                    { "a5042bb7-5f6e-4412-8aeb-aeb3f9795b27", "a5042bb7-5f6e-4412-8aeb-aeb3f9795b27", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "41b665a3-1ad4-4bcc-8c2a-b0ba3c79591e", 0, "30513c7e-4d48-4a2f-89c8-afe4a4592a99", "root@wsei.edu.pl", true, false, null, "ROOT@WSEI.EDU.PL", "ROOT", "AQAAAAEAACcQAAAAECcMt8B4qpkYezDKd6pN5bBC95gnNmP8DEZiWfjgIN+nM/bE02vkO45E+oY66GuJdQ==", null, false, "f2a62b08-8a5d-4e44-87d7-4546ba43da33", false, "root" },
                    { "5c798f09-2db6-4578-844a-dd587eb25e96", 0, "b7a5f876-321d-497e-81be-bd236345e28f", "user@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "USER", "AQAAAAEAACcQAAAAEBWuifHMDu9OLhx4kj5rjGl4emsyOaMPbg+/i9JqkFPv6/nFOF5LN+Ot3y5KtQojFQ==", null, false, "5a866a4c-b154-4756-9c25-43038512b912", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6a6c0990-f368-45ce-8c38-7735e4c8ae0c", "41b665a3-1ad4-4bcc-8c2a-b0ba3c79591e" },
                    { "a5042bb7-5f6e-4412-8aeb-aeb3f9795b27", "5c798f09-2db6-4578-844a-dd587eb25e96" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6a6c0990-f368-45ce-8c38-7735e4c8ae0c", "41b665a3-1ad4-4bcc-8c2a-b0ba3c79591e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5042bb7-5f6e-4412-8aeb-aeb3f9795b27", "5c798f09-2db6-4578-844a-dd587eb25e96" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a6c0990-f368-45ce-8c38-7735e4c8ae0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5042bb7-5f6e-4412-8aeb-aeb3f9795b27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41b665a3-1ad4-4bcc-8c2a-b0ba3c79591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c798f09-2db6-4578-844a-dd587eb25e96");

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
    }
}
