﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Data.Migrations
{
    public partial class AddingBdayColToCus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "Customers");
        }
    }
}
