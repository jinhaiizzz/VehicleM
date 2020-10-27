using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicle.Data.Migrations
{
    public partial class initDb5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleModels_Model_ID",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleModels",
                table: "VehicleModels");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "VehicleModels");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "VehicleModels",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleModels",
                table: "VehicleModels",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleModels_Model_ID",
                table: "Vehicle",
                column: "Model_ID",
                principalTable: "VehicleModels",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleModels_Model_ID",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleModels",
                table: "VehicleModels");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "VehicleModels");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "VehicleModels",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleModels",
                table: "VehicleModels",
                column: "MyProperty");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleModels_Model_ID",
                table: "Vehicle",
                column: "Model_ID",
                principalTable: "VehicleModels",
                principalColumn: "MyProperty",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
