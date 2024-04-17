﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SubscribersTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AdvertisingUpadtes",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DailyNewsletter",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Podcasts",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "StartupsWeekly",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WeekinReview",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvertisingUpadtes",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "DailyNewsletter",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "Podcasts",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "StartupsWeekly",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "WeekinReview",
                table: "Subscribers");
        }
    }
}
