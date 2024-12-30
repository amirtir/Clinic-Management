using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dashbord.Migrations
{
    /// <inheritdoc />
    public partial class Changemodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clinics",
                newName: "ClinicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClinicId",
                table: "Clinics",
                newName: "Id");
        }
    }
}
