﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Efrata.Service.Finance.Accounting.Lib.Migrations
{
    public partial class AddBalanceInCOA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "ChartsOfAccounts",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "ChartsOfAccounts");
        }
    }
}
