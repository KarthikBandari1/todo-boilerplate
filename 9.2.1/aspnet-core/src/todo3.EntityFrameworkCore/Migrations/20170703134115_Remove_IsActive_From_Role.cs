﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace todo3.Migrations
{
    public partial class Remove_IsActive_From_Role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AbpRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AbpRoles",
                nullable: false,
                defaultValue: false);
        }
    }
}