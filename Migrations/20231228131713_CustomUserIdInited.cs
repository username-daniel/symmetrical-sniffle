using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocGems.Migrations
{
    /// <inheritdoc />
    public partial class CustomUserIdInited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "UserDocuments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "deprecated",
                table: "UserDocuments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated",
                table: "UserDocuments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "UserDocuments");

            migrationBuilder.DropColumn(
                name: "deprecated",
                table: "UserDocuments");

            migrationBuilder.DropColumn(
                name: "updated",
                table: "UserDocuments");
        }
    }
}
