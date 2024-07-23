using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricityCompany.EF.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFTA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Parent_Network_Element_Type_key",
                table: "Netwrok_Element_Types",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Parent_Network_Element_Key",
                table: "Network_Elements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Netwrok_Element_Types_Parent_Network_Element_Type_key",
                table: "Netwrok_Element_Types",
                column: "Parent_Network_Element_Type_key");

            migrationBuilder.CreateIndex(
                name: "IX_Network_Elements_Parent_Network_Element_Key",
                table: "Network_Elements",
                column: "Parent_Network_Element_Key");

            migrationBuilder.AddForeignKey(
                name: "FK_Network_Elements_Network_Elements_Parent_Network_Element_Key",
                table: "Network_Elements",
                column: "Parent_Network_Element_Key",
                principalTable: "Network_Elements",
                principalColumn: "Network_Element_Key");

            migrationBuilder.AddForeignKey(
                name: "FK_Netwrok_Element_Types_Netwrok_Element_Types_Parent_Network_Element_Type_key",
                table: "Netwrok_Element_Types",
                column: "Parent_Network_Element_Type_key",
                principalTable: "Netwrok_Element_Types",
                principalColumn: "Nework_Element_Type_key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Network_Elements_Network_Elements_Parent_Network_Element_Key",
                table: "Network_Elements");

            migrationBuilder.DropForeignKey(
                name: "FK_Netwrok_Element_Types_Netwrok_Element_Types_Parent_Network_Element_Type_key",
                table: "Netwrok_Element_Types");

            migrationBuilder.DropIndex(
                name: "IX_Netwrok_Element_Types_Parent_Network_Element_Type_key",
                table: "Netwrok_Element_Types");

            migrationBuilder.DropIndex(
                name: "IX_Network_Elements_Parent_Network_Element_Key",
                table: "Network_Elements");

            migrationBuilder.DropColumn(
                name: "Parent_Network_Element_Type_key",
                table: "Netwrok_Element_Types");

            migrationBuilder.DropColumn(
                name: "Parent_Network_Element_Key",
                table: "Network_Elements");
        }
    }
}
