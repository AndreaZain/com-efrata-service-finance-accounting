﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Efrata.Service.Finance.Accounting.Lib.Migrations
{
    public partial class AddProductInCreditorAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Products",
                table: "CreditorAccounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Products",
                table: "CreditorAccounts");
        }
    }
}
