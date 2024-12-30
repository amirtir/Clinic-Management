using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dashbord.Migrations
{
    /// <inheritdoc />
    public partial class Changemodels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clinics_Doctors_doctorId",
                table: "Clinics");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Doctors",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "idNumber",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "doctorId",
                table: "Clinics",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Clinics_Doctors_doctorId",
                table: "Clinics",
                column: "doctorId",
                principalTable: "Doctors",
                principalColumn: "doctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clinics_Doctors_doctorId",
                table: "Clinics");

            migrationBuilder.AlterColumn<decimal>(
                name: "phone",
                table: "Doctors",
                type: "decimal(18,2)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<decimal>(
                name: "idNumber",
                table: "Doctors",
                type: "decimal(18,2)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "doctorId",
                table: "Clinics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clinics_Doctors_doctorId",
                table: "Clinics",
                column: "doctorId",
                principalTable: "Doctors",
                principalColumn: "doctorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
