﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Efrata.Service.Finance.Accounting.Lib.Migrations
{
    public partial class UpdateVBRealization4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DifferenceReqReal",
                table: "RealizationVbs",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DifferenceReqReal",
                table: "RealizationVbs");
        }
    }
}
