using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProject.Infrastructure.Migrations
{
    public partial class BaseEntity : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CatalogItems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "CatalogItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CatalogItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "CatalogItems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDateUtc",
                table: "CatalogItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                    { 333, "Winter 2018", "W2018", "Zrinko", new DateTime(2020, 6, 7, 19, 43, 43, 709, DateTimeKind.Local), false, "Irena", new DateTime(2020, 6, 7, 19, 43, 43, 709, DateTimeKind.Local) },
                    { 444, "Summer 2018", "S2018", "Zrinko", new DateTime(2020, 6, 7, 19, 43, 43, 709, DateTimeKind.Local), false, "Irena", new DateTime(2020, 6, 7, 19, 43, 43, 709, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BasePrice", "CreatedBy", "CreatedDateUtc", "IsDeleted", "LastModifiedBy", "LastModifiedDateUtc", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 510, 500m, "Zrinko", new DateTime(2020, 6, 7, 19, 43, 43, 707, DateTimeKind.Local), false, "Irena", new DateTime(2020, 6, 7, 19, 43, 43, 706, DateTimeKind.Local), "Running shoes", "Nike Pegasus" },
                    { 520, 400m, "Edi", new DateTime(2020, 6, 7, 19, 43, 43, 709, DateTimeKind.Local), false, "Ozana", new DateTime(2020, 6, 7, 19, 43, 43, 709, DateTimeKind.Local), "Sport shoes", "Nike AirMax" },
                    { 540, 1000m, "Kristijan", new DateTime(2020, 6, 7, 19, 43, 43, 709, DateTimeKind.Local), false, "Luka", new DateTime(2020, 6, 7, 19, 43, 43, 709, DateTimeKind.Local), "Sport watch", "Garmin Fenix 3" },
                    { 550, 1050m, "Kristijan", new DateTime(2020, 6, 7, 19, 43, 43, 709, DateTimeKind.Local), false, "Ozren", new DateTime(2020, 6, 7, 19, 43, 43, 709, DateTimeKind.Local), "Sport watch", "Suunto Spartann" }
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

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "CreatedDateUtc",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "LastModifiedDateUtc",
                table: "CatalogItems");

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
