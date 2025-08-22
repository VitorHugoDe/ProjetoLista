using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListWeb.Migrations
{
    /// <inheritdoc />
    public partial class RetiradaErro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatergoriaId",
                table: "Tarefas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CatergoriaId",
                table: "Tarefas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
