using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicle.Data.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true,maxLength:150),
                    LastName = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false,defaultValue:DateTime.Now),
                    UpdatedAt = table.Column<DateTime>(nullable: false,defaultValue:DateTime.Now)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleAppraisal",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAppraisal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCondition",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Scratch = table.Column<int>(nullable: false),
                    Dent = table.Column<int>(nullable: false),
                    Mark = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCondition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleMakes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMakes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModels",
                columns: table => new
                {
                    MyProperty = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModels", x => x.MyProperty);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VIN = table.Column<string>(maxLength: 250, nullable: false),
                    Mileage = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Customer_ID = table.Column<int>(nullable: false),
                    Model_ID = table.Column<int>(nullable: false),
                    Make_ID = table.Column<int>(nullable: false),
                    Appraisal_ID = table.Column<int>(nullable: false),
                    Condition_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleAppraisal_Appraisal_ID",
                        column: x => x.Appraisal_ID,
                        principalTable: "VehicleAppraisal",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleCondition_Condition_ID",
                        column: x => x.Condition_ID,
                        principalTable: "VehicleCondition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_Customer_Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleMakes_Make_ID",
                        column: x => x.Make_ID,
                        principalTable: "VehicleMakes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleModels_Model_ID",
                        column: x => x.Model_ID,
                        principalTable: "VehicleModels",
                        principalColumn: "MyProperty",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Appraisal_ID",
                table: "Vehicle",
                column: "Appraisal_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Condition_ID",
                table: "Vehicle",
                column: "Condition_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Customer_ID",
                table: "Vehicle",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Make_ID",
                table: "Vehicle",
                column: "Make_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Model_ID",
                table: "Vehicle",
                column: "Model_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "VehicleAppraisal");

            migrationBuilder.DropTable(
                name: "VehicleCondition");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "VehicleMakes");

            migrationBuilder.DropTable(
                name: "VehicleModels");
        }
    }
}
