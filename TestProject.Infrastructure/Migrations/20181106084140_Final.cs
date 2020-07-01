using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProject.Infrastructure.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CatalogName",
                table: "Catalog",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CatalogDescription",
                table: "Catalog",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Catalog",
                columns: new[] { "Id", "CatalogDescription", "CatalogName", "CreatedBy", "CreatedDateUtc", "IsDeleted", "LastModifiedBy", "LastModifiedDateUtc" },
                values: new object[,]
                {
                    { 300, "Winter 2018", "W2018", "Zrinko", new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), false, "Irena", new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local) },
                    { 400, "Summer 2018", "S2018", "Zrinko", new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), false, "Irena", new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BasePrice", "CreatedBy", "CreatedDateUtc", "IsDeleted", "LastModifiedBy", "LastModifiedDateUtc", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 51, 500m, "Zrinko", new DateTime(2018, 11, 6, 9, 41, 40, 416, DateTimeKind.Local), false, "Irena", new DateTime(2018, 11, 6, 9, 41, 40, 415, DateTimeKind.Local), "Running shoes", "Nike Pegasus" },
                    { 52, 400m, "Edi", new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), false, "Ozana", new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), "Sport shoes", "Nike AirMax" },
                    { 54, 1000m, "Kristijan", new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), false, "Luka", new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), "Sport watch", "Garmin Fenix 3" },
                    { 55, 1050m, "Kristijan", new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), false, "Ozren", new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), "Sport watch", "Suunto Spartann" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catalog",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Catalog",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CatalogName",
                table: "Catalog",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CatalogDescription",
                table: "Catalog",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
