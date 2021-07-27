using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("7e01a9b1-a4b9-4461-80ed-aac6e865a387"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("58a5dafc-b468-4aae-b74a-28b2b257d84f"), null, "Avatar.jpg", "Ahmed Nafady", ".Net Core Developer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("58a5dafc-b468-4aae-b74a-28b2b257d84f"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("7e01a9b1-a4b9-4461-80ed-aac6e865a387"), null, "Avatar.jpg", "Ahmed Nafady", ".Net Core Developer" });
        }
    }
}
