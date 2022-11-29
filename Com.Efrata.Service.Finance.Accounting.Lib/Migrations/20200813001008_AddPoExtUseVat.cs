﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Efrata.Service.Finance.Accounting.Lib.Migrations
{
    public partial class AddPoExtUseVat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "POExtUseVat",
                table: "VbRequestsDetails",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "POExtUseVat",
                table: "VbRequestsDetails");
        }
    }
}
