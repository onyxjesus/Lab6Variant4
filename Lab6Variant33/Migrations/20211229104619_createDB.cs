using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab6Variant4.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Call_Centers",
                columns: table => new
                {
                    call_Center_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    call_Center_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    call_Center_Other_Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Call_Centers", x => x.call_Center_ID);
                });

            migrationBuilder.CreateTable(
                name: "Common_Problems",
                columns: table => new
                {
                    problem_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    problem_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    other_Problem_Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Common_Problems", x => x.problem_ID);
                });

            migrationBuilder.CreateTable(
                name: "Common_Solutions",
                columns: table => new
                {
                    solution_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    solution_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    other_Solution_Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Common_Solutions", x => x.solution_ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_Address_line_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer_Address_line_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer_Address_line_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    town_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer_Other_Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer_ID);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Call_Outcomes",
                columns: table => new
                {
                    call_Outcome_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    call_Outcome_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    other_Call_Outcome_Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Call_Outcomes", x => x.call_Outcome_Code);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Call_Status_Codes",
                columns: table => new
                {
                    call_Status_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    call_Status_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    call_Status_Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Call_Status_Codes", x => x.call_Status_Code);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    staff_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other_Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.staff_ID);
                });

            migrationBuilder.CreateTable(
                name: "Solutions_for_Common_Problems",
                columns: table => new
                {
                    problem_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    solution_ID = table.Column<int>(type: "int", nullable: false),
                    common_Problemsproblem_ID = table.Column<int>(type: "int", nullable: true),
                    common_Solutionssolution_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solutions_for_Common_Problems", x => x.problem_ID);
                    table.ForeignKey(
                        name: "FK_Solutions_for_Common_Problems_Common_Problems_common_Problemsproblem_ID",
                        column: x => x.common_Problemsproblem_ID,
                        principalTable: "Common_Problems",
                        principalColumn: "problem_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Solutions_for_Common_Problems_Common_Solutions_common_Solutionssolution_ID",
                        column: x => x.common_Solutionssolution_ID,
                        principalTable: "Common_Solutions",
                        principalColumn: "solution_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    contract_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_ID = table.Column<int>(type: "int", nullable: false),
                    contract_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    contract_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    other_Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerscustomer_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.contract_ID);
                    table.ForeignKey(
                        name: "FK_Contracts_Customers_customerscustomer_ID",
                        column: x => x.customerscustomer_ID,
                        principalTable: "Customers",
                        principalColumn: "customer_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Calls",
                columns: table => new
                {
                    call_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_ID = table.Column<int>(type: "int", nullable: false),
                    call_Center_id = table.Column<int>(type: "int", nullable: false),
                    call_Outcome_Code = table.Column<int>(type: "int", nullable: false),
                    call_Status_Code = table.Column<int>(type: "int", nullable: false),
                    recommended_Solution_ID = table.Column<int>(type: "int", nullable: false),
                    staff_ID = table.Column<int>(type: "int", nullable: false),
                    call_Date_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    call_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tailored_Solution_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    call_Other_Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    common_Solutionssolution_ID = table.Column<int>(type: "int", nullable: true),
                    staff_ID1 = table.Column<int>(type: "int", nullable: true),
                    ref_Call_Status_Codescall_Status_Code = table.Column<int>(type: "int", nullable: true),
                    ref_Call_Outcomescall_Outcome_Code = table.Column<int>(type: "int", nullable: true),
                    call_Centerscall_Center_ID = table.Column<int>(type: "int", nullable: true),
                    customerscustomer_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Calls", x => x.call_ID);
                    table.ForeignKey(
                        name: "FK_Customer_Calls_Call_Centers_call_Centerscall_Center_ID",
                        column: x => x.call_Centerscall_Center_ID,
                        principalTable: "Call_Centers",
                        principalColumn: "call_Center_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Calls_Common_Solutions_common_Solutionssolution_ID",
                        column: x => x.common_Solutionssolution_ID,
                        principalTable: "Common_Solutions",
                        principalColumn: "solution_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Calls_Customers_customerscustomer_ID",
                        column: x => x.customerscustomer_ID,
                        principalTable: "Customers",
                        principalColumn: "customer_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Calls_Ref_Call_Outcomes_ref_Call_Outcomescall_Outcome_Code",
                        column: x => x.ref_Call_Outcomescall_Outcome_Code,
                        principalTable: "Ref_Call_Outcomes",
                        principalColumn: "call_Outcome_Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Calls_Ref_Call_Status_Codes_ref_Call_Status_Codescall_Status_Code",
                        column: x => x.ref_Call_Status_Codescall_Status_Code,
                        principalTable: "Ref_Call_Status_Codes",
                        principalColumn: "call_Status_Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Calls_Staff_staff_ID1",
                        column: x => x.staff_ID1,
                        principalTable: "Staff",
                        principalColumn: "staff_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_customerscustomer_ID",
                table: "Contracts",
                column: "customerscustomer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Calls_call_Centerscall_Center_ID",
                table: "Customer_Calls",
                column: "call_Centerscall_Center_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Calls_common_Solutionssolution_ID",
                table: "Customer_Calls",
                column: "common_Solutionssolution_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Calls_customerscustomer_ID",
                table: "Customer_Calls",
                column: "customerscustomer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Calls_ref_Call_Outcomescall_Outcome_Code",
                table: "Customer_Calls",
                column: "ref_Call_Outcomescall_Outcome_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Calls_ref_Call_Status_Codescall_Status_Code",
                table: "Customer_Calls",
                column: "ref_Call_Status_Codescall_Status_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Calls_staff_ID1",
                table: "Customer_Calls",
                column: "staff_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_for_Common_Problems_common_Problemsproblem_ID",
                table: "Solutions_for_Common_Problems",
                column: "common_Problemsproblem_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_for_Common_Problems_common_Solutionssolution_ID",
                table: "Solutions_for_Common_Problems",
                column: "common_Solutionssolution_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Customer_Calls");

            migrationBuilder.DropTable(
                name: "Solutions_for_Common_Problems");

            migrationBuilder.DropTable(
                name: "Call_Centers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Ref_Call_Outcomes");

            migrationBuilder.DropTable(
                name: "Ref_Call_Status_Codes");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Common_Problems");

            migrationBuilder.DropTable(
                name: "Common_Solutions");
        }
    }
}
