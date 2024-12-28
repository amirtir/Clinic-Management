using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dashbord.Migrations
{
    /// <inheritdoc />
    public partial class NewChangesForUpgrading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clinicTable_DoctorTable_doctorId",
                table: "clinicTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorTable",
                table: "DoctorTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clinicTable",
                table: "clinicTable");

            migrationBuilder.DropColumn(
                name: "fName",
                table: "DoctorTable");

            migrationBuilder.RenameTable(
                name: "DoctorTable",
                newName: "Doctors");

            migrationBuilder.RenameTable(
                name: "clinicTable",
                newName: "Clinics");

            migrationBuilder.RenameColumn(
                name: "mName",
                table: "Doctors",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "lName",
                table: "Doctors",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_clinicTable_doctorId",
                table: "Clinics",
                newName: "IX_Clinics_doctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "doctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clinics",
                table: "Clinics",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clinics_Doctors_doctorId",
                table: "Clinics",
                column: "doctorId",
                principalTable: "Doctors",
                principalColumn: "doctorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clinics_Doctors_doctorId",
                table: "Clinics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clinics",
                table: "Clinics");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "DoctorTable");

            migrationBuilder.RenameTable(
                name: "Clinics",
                newName: "clinicTable");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "DoctorTable",
                newName: "mName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "DoctorTable",
                newName: "lName");

            migrationBuilder.RenameIndex(
                name: "IX_Clinics_doctorId",
                table: "clinicTable",
                newName: "IX_clinicTable_doctorId");

            migrationBuilder.AddColumn<string>(
                name: "fName",
                table: "DoctorTable",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorTable",
                table: "DoctorTable",
                column: "doctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clinicTable",
                table: "clinicTable",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clinicTable_DoctorTable_doctorId",
                table: "clinicTable",
                column: "doctorId",
                principalTable: "DoctorTable",
                principalColumn: "doctorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
