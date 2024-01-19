using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62adf12b-1216-4ed4-a3e5-fe0cc720546a", "ed4cf424-9255-4fe3-9891-7d577f0a3cf7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62adf12b-1216-4ed4-a3e5-fe0cc720546a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4cf424-9255-4fe3-9891-7d577f0a3cf7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69ce2310-275f-4f9d-a533-5eca71884baa", "69ce2310-275f-4f9d-a533-5eca71884baa", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5ba5e692-bedd-4a8b-a43a-0ebd820945ae", 0, "7a7aaf02-7d5a-4703-b8f8-952d315ffe45", "test@wsei.edu.pl", true, false, null, "TEST@WSEI.EDU.PL", "TEST", "AQAAAAEAACcQAAAAEPHhHS1/FDiYjkcMdo/1SI4znQWoSOBEtVns4V6Y7Mmdhm2/IonBx+OfGtgA8SFMCw==", null, false, "335327c4-2751-4b4e-b4a9-85b38669d946", false, "test" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 1,
                column: "Producer",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 2,
                column: "Producer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 3,
                column: "Producer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 4,
                column: "Producer",
                value: 1);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "69ce2310-275f-4f9d-a533-5eca71884baa", "5ba5e692-bedd-4a8b-a43a-0ebd820945ae" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69ce2310-275f-4f9d-a533-5eca71884baa", "5ba5e692-bedd-4a8b-a43a-0ebd820945ae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69ce2310-275f-4f9d-a533-5eca71884baa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ba5e692-bedd-4a8b-a43a-0ebd820945ae");

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

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 4,
                column: "Producer",
                value: 2);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "62adf12b-1216-4ed4-a3e5-fe0cc720546a", "ed4cf424-9255-4fe3-9891-7d577f0a3cf7" });
        }
    }
}
