﻿// <auto-generated />
using Hospital_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hospital_MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220217112100_addingDoctorsTable")]
    partial class addingDoctorsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Hospital_MVC.Models.ApplicantsTable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<int>("SSN")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ApplicantsTables");
                });

            modelBuilder.Entity("Hospital_MVC.Models.DoctorsTable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<int>("SSN")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("DoctorsTable");
                });
#pragma warning restore 612, 618
        }
    }
}