﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Efrata.Service.Finance.Accounting.Lib.Migrations
{
    public partial class AddTransactionNominalDailyBankTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TransactionNominal",
                table: "DailyBankTransactions",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionNominal",
                table: "DailyBankTransactions");
        }
    }
}
