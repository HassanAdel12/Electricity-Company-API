using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricityCompany.EF.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Ignoreds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Ignoreds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Headers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Headers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Details",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Details",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Ignoreds_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Ignoreds",
                column: "Cutting_Down_A_Incident_ID",
                unique: true,
                filter: "[Cutting_Down_A_Incident_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Ignoreds_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Ignoreds",
                column: "Cutting_Down_B_Incident_ID",
                unique: true,
                filter: "[Cutting_Down_B_Incident_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Headers_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Headers",
                column: "Cutting_Down_A_Incident_ID",
                unique: true,
                filter: "[Cutting_Down_A_Incident_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Headers_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Headers",
                column: "Cutting_Down_B_Incident_ID",
                unique: true,
                filter: "[Cutting_Down_B_Incident_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Details_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Details",
                column: "Cutting_Down_A_Incident_ID",
                unique: true,
                filter: "[Cutting_Down_A_Incident_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Details_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Details",
                column: "Cutting_Down_B_Incident_ID",
                unique: true,
                filter: "[Cutting_Down_B_Incident_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Details_Cutting_Down_As_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Details",
                column: "Cutting_Down_A_Incident_ID",
                principalTable: "Cutting_Down_As",
                principalColumn: "Cutting_Down_A_Incident_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Details_Cutting_Down_Bs_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Details",
                column: "Cutting_Down_B_Incident_ID",
                principalTable: "Cutting_Down_Bs",
                principalColumn: "Cutting_Down_B_Incident_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Headers_Cutting_Down_As_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Headers",
                column: "Cutting_Down_A_Incident_ID",
                principalTable: "Cutting_Down_As",
                principalColumn: "Cutting_Down_A_Incident_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Headers_Cutting_Down_Bs_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Headers",
                column: "Cutting_Down_B_Incident_ID",
                principalTable: "Cutting_Down_Bs",
                principalColumn: "Cutting_Down_B_Incident_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Ignoreds_Cutting_Down_As_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Ignoreds",
                column: "Cutting_Down_A_Incident_ID",
                principalTable: "Cutting_Down_As",
                principalColumn: "Cutting_Down_A_Incident_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Ignoreds_Cutting_Down_Bs_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Ignoreds",
                column: "Cutting_Down_B_Incident_ID",
                principalTable: "Cutting_Down_Bs",
                principalColumn: "Cutting_Down_B_Incident_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Details_Cutting_Down_As_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Details_Cutting_Down_Bs_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Headers_Cutting_Down_As_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Headers");

            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Headers_Cutting_Down_Bs_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Headers");

            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Ignoreds_Cutting_Down_As_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Ignoreds");

            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Ignoreds_Cutting_Down_Bs_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Ignoreds");

            migrationBuilder.DropIndex(
                name: "IX_Cutting_Down_Ignoreds_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Ignoreds");

            migrationBuilder.DropIndex(
                name: "IX_Cutting_Down_Ignoreds_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Ignoreds");

            migrationBuilder.DropIndex(
                name: "IX_Cutting_Down_Headers_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Headers");

            migrationBuilder.DropIndex(
                name: "IX_Cutting_Down_Headers_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Headers");

            migrationBuilder.DropIndex(
                name: "IX_Cutting_Down_Details_Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Details");

            migrationBuilder.DropIndex(
                name: "IX_Cutting_Down_Details_Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Details");

            migrationBuilder.DropColumn(
                name: "Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Ignoreds");

            migrationBuilder.DropColumn(
                name: "Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Ignoreds");

            migrationBuilder.DropColumn(
                name: "Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Headers");

            migrationBuilder.DropColumn(
                name: "Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Headers");

            migrationBuilder.DropColumn(
                name: "Cutting_Down_A_Incident_ID",
                table: "Cutting_Down_Details");

            migrationBuilder.DropColumn(
                name: "Cutting_Down_B_Incident_ID",
                table: "Cutting_Down_Details");
        }
    }
}
