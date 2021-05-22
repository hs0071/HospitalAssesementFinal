﻿// <auto-generated />
using HospitalAssesementFinal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalAssesementFinal.Migrations
{
    [DbContext(typeof(HospitalAssesementFinalContext))]
    [Migration("20210522070543_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalAssesementFinal.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Doctor_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("HospitalAssesementFinal.Models.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hospital_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hospital");
                });

            modelBuilder.Entity("HospitalAssesementFinal.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("Patient_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorID");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("HospitalAssesementFinal.Models.Patient", b =>
                {
                    b.HasOne("HospitalAssesementFinal.Models.Doctor", "Doctor_ID")
                        .WithMany()
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
