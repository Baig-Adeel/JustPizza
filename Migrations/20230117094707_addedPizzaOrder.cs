﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JustPizza.Migrations
{
    /// <inheritdoc />
    public partial class addedPizzaOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PizzaOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PizzaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaOrders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaOrders");
        }
    }
}