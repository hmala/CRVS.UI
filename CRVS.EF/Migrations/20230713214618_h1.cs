using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class h1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GovernorateId",
                table: "Dohs",
                newName: "GovernorateCode");

            migrationBuilder.AddColumn<int>(
                name: "GovernorateCode",
                table: "Governorates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DohCode",
                table: "Dohs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GovernorateCode",
                table: "Governorates");

            migrationBuilder.DropColumn(
                name: "DohCode",
                table: "Dohs");

            migrationBuilder.RenameColumn(
                name: "GovernorateCode",
                table: "Dohs",
                newName: "GovernorateId");
        }
    }
}
