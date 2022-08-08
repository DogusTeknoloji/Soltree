using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soltree.Api.Migrations
{
    public partial class SymptomCategory_ModelId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ModelId",
                table: "SymptomCategories",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SymptomCategories_ModelId",
                table: "SymptomCategories",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_SymptomCategories_Models_ModelId",
                table: "SymptomCategories",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SymptomCategories_Models_ModelId",
                table: "SymptomCategories");

            migrationBuilder.DropIndex(
                name: "IX_SymptomCategories_ModelId",
                table: "SymptomCategories");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "SymptomCategories");
        }
    }
}
