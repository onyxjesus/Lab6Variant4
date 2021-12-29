﻿// <auto-generated />
using System;
using Lab6Variant4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab6Variant4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211229104619_createDB")]
    partial class createDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab6Variant4.Models.Call_Centers", b =>
                {
                    b.Property<int>("call_Center_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("call_Center_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("call_Center_Other_Details")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("call_Center_ID");

                    b.ToTable("Call_Centers");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Common_Problems", b =>
                {
                    b.Property<int>("problem_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("other_Problem_Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("problem_Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("problem_ID");

                    b.ToTable("Common_Problems");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Common_Solutions", b =>
                {
                    b.Property<int>("solution_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("other_Solution_Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("solution_Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("solution_ID");

                    b.ToTable("Common_Solutions");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Contracts", b =>
                {
                    b.Property<int>("contract_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("contract_End_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("contract_Start_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("customer_ID")
                        .HasColumnType("int");

                    b.Property<int?>("customerscustomer_ID")
                        .HasColumnType("int");

                    b.Property<string>("other_Details")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contract_ID");

                    b.HasIndex("customerscustomer_ID");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Customer_Calls", b =>
                {
                    b.Property<int>("call_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("call_Center_id")
                        .HasColumnType("int");

                    b.Property<int?>("call_Centerscall_Center_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("call_Date_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("call_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("call_Other_Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("call_Outcome_Code")
                        .HasColumnType("int");

                    b.Property<int>("call_Status_Code")
                        .HasColumnType("int");

                    b.Property<int?>("common_Solutionssolution_ID")
                        .HasColumnType("int");

                    b.Property<int>("customer_ID")
                        .HasColumnType("int");

                    b.Property<int?>("customerscustomer_ID")
                        .HasColumnType("int");

                    b.Property<int>("recommended_Solution_ID")
                        .HasColumnType("int");

                    b.Property<int?>("ref_Call_Outcomescall_Outcome_Code")
                        .HasColumnType("int");

                    b.Property<int?>("ref_Call_Status_Codescall_Status_Code")
                        .HasColumnType("int");

                    b.Property<int>("staff_ID")
                        .HasColumnType("int");

                    b.Property<int?>("staff_ID1")
                        .HasColumnType("int");

                    b.Property<string>("tailored_Solution_Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("call_ID");

                    b.HasIndex("call_Centerscall_Center_ID");

                    b.HasIndex("common_Solutionssolution_ID");

                    b.HasIndex("customerscustomer_ID");

                    b.HasIndex("ref_Call_Outcomescall_Outcome_Code");

                    b.HasIndex("ref_Call_Status_Codescall_Status_Code");

                    b.HasIndex("staff_ID1");

                    b.ToTable("Customer_Calls");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Customers", b =>
                {
                    b.Property<int>("customer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("customer_Address_line_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_Address_line_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_Address_line_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_Other_Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("town_city")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customer_ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Ref_Call_Outcomes", b =>
                {
                    b.Property<int>("call_Outcome_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("call_Outcome_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("other_Call_Outcome_Details")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("call_Outcome_Code");

                    b.ToTable("Ref_Call_Outcomes");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Ref_Call_Status_Codes", b =>
                {
                    b.Property<int>("call_Status_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("call_Status_Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("call_Status_Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("call_Status_Code");

                    b.ToTable("Ref_Call_Status_Codes");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Solutions_for_Common_Problems", b =>
                {
                    b.Property<int>("problem_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("common_Problemsproblem_ID")
                        .HasColumnType("int");

                    b.Property<int?>("common_Solutionssolution_ID")
                        .HasColumnType("int");

                    b.Property<int>("solution_ID")
                        .HasColumnType("int");

                    b.HasKey("problem_ID");

                    b.HasIndex("common_Problemsproblem_ID");

                    b.HasIndex("common_Solutionssolution_ID");

                    b.ToTable("Solutions_for_Common_Problems");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Staff", b =>
                {
                    b.Property<int>("staff_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Other_Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("staff_ID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Contracts", b =>
                {
                    b.HasOne("Lab6Variant4.Models.Customers", "customers")
                        .WithMany("contracts")
                        .HasForeignKey("customerscustomer_ID");

                    b.Navigation("customers");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Customer_Calls", b =>
                {
                    b.HasOne("Lab6Variant4.Models.Call_Centers", "call_Centers")
                        .WithMany("customer_Calls")
                        .HasForeignKey("call_Centerscall_Center_ID");

                    b.HasOne("Lab6Variant4.Models.Common_Solutions", "common_Solutions")
                        .WithMany("customer_Calls")
                        .HasForeignKey("common_Solutionssolution_ID");

                    b.HasOne("Lab6Variant4.Models.Customers", "customers")
                        .WithMany("customer_Calls")
                        .HasForeignKey("customerscustomer_ID");

                    b.HasOne("Lab6Variant4.Models.Ref_Call_Outcomes", "ref_Call_Outcomes")
                        .WithMany("customer_Calls")
                        .HasForeignKey("ref_Call_Outcomescall_Outcome_Code");

                    b.HasOne("Lab6Variant4.Models.Ref_Call_Status_Codes", "ref_Call_Status_Codes")
                        .WithMany("customer_Calls")
                        .HasForeignKey("ref_Call_Status_Codescall_Status_Code");

                    b.HasOne("Lab6Variant4.Models.Staff", "staff")
                        .WithMany("customer_Calls")
                        .HasForeignKey("staff_ID1");

                    b.Navigation("call_Centers");

                    b.Navigation("common_Solutions");

                    b.Navigation("customers");

                    b.Navigation("ref_Call_Outcomes");

                    b.Navigation("ref_Call_Status_Codes");

                    b.Navigation("staff");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Solutions_for_Common_Problems", b =>
                {
                    b.HasOne("Lab6Variant4.Models.Common_Problems", "common_Problems")
                        .WithMany("solutions_For_Common_Problems")
                        .HasForeignKey("common_Problemsproblem_ID");

                    b.HasOne("Lab6Variant4.Models.Common_Solutions", "common_Solutions")
                        .WithMany("solutions_For_Common_Problems")
                        .HasForeignKey("common_Solutionssolution_ID");

                    b.Navigation("common_Problems");

                    b.Navigation("common_Solutions");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Call_Centers", b =>
                {
                    b.Navigation("customer_Calls");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Common_Problems", b =>
                {
                    b.Navigation("solutions_For_Common_Problems");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Common_Solutions", b =>
                {
                    b.Navigation("customer_Calls");

                    b.Navigation("solutions_For_Common_Problems");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Customers", b =>
                {
                    b.Navigation("contracts");

                    b.Navigation("customer_Calls");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Ref_Call_Outcomes", b =>
                {
                    b.Navigation("customer_Calls");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Ref_Call_Status_Codes", b =>
                {
                    b.Navigation("customer_Calls");
                });

            modelBuilder.Entity("Lab6Variant4.Models.Staff", b =>
                {
                    b.Navigation("customer_Calls");
                });
#pragma warning restore 612, 618
        }
    }
}
