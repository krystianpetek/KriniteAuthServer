﻿// <auto-generated />
using System;
using KriniteAuthServer.ResourceDataAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KriniteAuthServer.ResourceDataAPI.Migrations
{
    [DbContext(typeof(ComplaintDbContext))]
    [Migration("20230112202553_initialMigrate")]
    partial class initialMigrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KriniteAuthServer.ResourceDataAPI.Models.ApplicantModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicantModel");
                });

            modelBuilder.Entity("KriniteAuthServer.ResourceDataAPI.Models.ComplaintModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<int?>("State")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("KriniteAuthServer.ResourceDataAPI.Models.ComplaintModel", b =>
                {
                    b.HasOne("KriniteAuthServer.ResourceDataAPI.Models.ApplicantModel", "Applicant")
                        .WithMany()
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Applicant");
                });
#pragma warning restore 612, 618
        }
    }
}
