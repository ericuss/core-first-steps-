using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Informed.Core.Context.Sql.Migrations
{
    public partial class SerieEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SerieId",
                table: "Book",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_SerieId",
                table: "Book",
                column: "SerieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Serie_SerieId",
                table: "Book",
                column: "SerieId",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Serie_SerieId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Serie");

            migrationBuilder.DropIndex(
                name: "IX_Book_SerieId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "SerieId",
                table: "Book");
        }
    }
}
