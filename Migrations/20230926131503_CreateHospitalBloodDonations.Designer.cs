﻿// <auto-generated />
using System;
using BloodDonationSystem.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BloodDonationSystem.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20230926131503_CreateHospitalBloodDonations")]
    partial class CreateHospitalBloodDonations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BloodDonationSystem.Model.Donar", b =>
                {
                    b.Property<Guid>("DonarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InventoryidForBloodCollection")
                        .HasColumnType("int");

                    b.Property<string>("bloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DonarId");

                    b.HasIndex("InventoryidForBloodCollection");

                    b.ToTable("Donar");
                });

            modelBuilder.Entity("BloodDonationSystem.Model.Inventory", b =>
                {
                    b.Property<int>("idForBloodCollection")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idForBloodCollection"));

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idForBloodCollection");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("BloodDonationSystem.Model.Donar", b =>
                {
                    b.HasOne("BloodDonationSystem.Model.Inventory", null)
                        .WithMany("donarList")
                        .HasForeignKey("InventoryidForBloodCollection");
                });

            modelBuilder.Entity("BloodDonationSystem.Model.Inventory", b =>
                {
                    b.Navigation("donarList");
                });
#pragma warning restore 612, 618
        }
    }
}
