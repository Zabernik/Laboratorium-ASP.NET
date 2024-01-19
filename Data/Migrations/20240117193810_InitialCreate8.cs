using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Producer",
                table: "products",
                newName: "Category");

            migrationBuilder.AddColumn<int>(
                name: "ProducerId",
                table: "products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProducerName",
                table: "products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ProducerEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Regon = table.Column<string>(type: "TEXT", nullable: false),
                    NIP = table.Column<string>(type: "TEXT", nullable: false),
                    ProducerCategory = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducerEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c47092c1-6239-4ae5-a731-ae08b5291dd8", "c47092c1-6239-4ae5-a731-ae08b5291dd8", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7e477ebc-b6ca-4991-956d-fbee593283f1", 0, "2d4b4376-136d-422c-8061-86bc7619c3b9", "test@wsei.edu.pl", true, false, null, "TEST@WSEI.EDU.PL", "TEST", "AQAAAAEAACcQAAAAENt8XplVIovOfEZJjpQQREmguOx2G+ffvJdSncyAPcIyV4Te8TRlkwk9PVmwDDAUrA==", null, false, "4b9166cf-0a07-47bc-af30-393ee087b822", false, "test" });

            migrationBuilder.InsertData(
                table: "ProducerEntity",
                columns: new[] { "Id", "NIP", "Name", "ProducerCategory", "Regon" },
                values: new object[,]
                {
                    { 1, "5260210530", "PepsiCo", "Food", "012610700" },
                    { 2, "7962468402", "BAT", "Cigarettes", "140471142" },
                    { 3, "5270203968", "Nestle", "Food", "010006420" },
                    { 4, "5213390341", "Unilever", "Chemistry", "140566233" }
                });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 1,
                columns: new[] { "ProducerId", "ProducerName" },
                values: new object[] { null, "Nestle" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 2,
                columns: new[] { "DateOfProduction", "Description", "Name", "ProducerId", "ProducerName" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Płyn do płukania prania", "Cocolino", null, "Unilever" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 3,
                columns: new[] { "Category", "ProducerId", "ProducerName" },
                values: new object[] { 1, null, "PepsiCo" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 4,
                columns: new[] { "ProducerId", "ProducerName" },
                values: new object[] { null, "PepsiCo" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c47092c1-6239-4ae5-a731-ae08b5291dd8", "7e477ebc-b6ca-4991-956d-fbee593283f1" });

            migrationBuilder.CreateIndex(
                name: "IX_products_ProducerId",
                table: "products",
                column: "ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_ProducerEntity_ProducerId",
                table: "products",
                column: "ProducerId",
                principalTable: "ProducerEntity",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_ProducerEntity_ProducerId",
                table: "products");

            migrationBuilder.DropTable(
                name: "ProducerEntity");

            migrationBuilder.DropIndex(
                name: "IX_products_ProducerId",
                table: "products");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c47092c1-6239-4ae5-a731-ae08b5291dd8", "7e477ebc-b6ca-4991-956d-fbee593283f1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c47092c1-6239-4ae5-a731-ae08b5291dd8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e477ebc-b6ca-4991-956d-fbee593283f1");

            migrationBuilder.DropColumn(
                name: "ProducerId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ProducerName",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "products",
                newName: "Producer");

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
                keyValue: 2,
                columns: new[] { "DateOfProduction", "Description", "Name" },
                values: new object[] { new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Napój gazowany", "Cola" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 3,
                column: "Producer",
                value: 2);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "69ce2310-275f-4f9d-a533-5eca71884baa", "5ba5e692-bedd-4a8b-a43a-0ebd820945ae" });
        }
    }
}
