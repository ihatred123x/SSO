using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSO.Repository.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IdentityResource",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 10, 30, 16, 28, 4, 382, DateTimeKind.Local).AddTicks(8412));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IdentityResource",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 10, 30, 16, 26, 52, 260, DateTimeKind.Local).AddTicks(5112));
        }
    }
}
