using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroserviceRabbitMQ.DAL.Migrations.TransferDb
{
    public partial class transferlogv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "TransferLogs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "TransferLogs");
        }
    }
}
