using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soltree.Api.Migrations
{
    public partial class Solution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SymptomId",
                table: "Solutions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_SymptomId",
                table: "Solutions",
                column: "SymptomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Solutions_Symptoms_SymptomId",
                table: "Solutions",
                column: "SymptomId",
                principalTable: "Symptoms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solutions_Symptoms_SymptomId",
                table: "Solutions");

            migrationBuilder.DropIndex(
                name: "IX_Solutions_SymptomId",
                table: "Solutions");

            migrationBuilder.DropColumn(
                name: "SymptomId",
                table: "Solutions");
        }
    }
}
