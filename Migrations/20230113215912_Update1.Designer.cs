﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_master.Data;

#nullable disable

namespace Proiectmaster.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20230113215912_Update1")]
    partial class Update1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proiect_master.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("Proiect_master.Models.Instrument", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Instrument", (string)null);
                });

            modelBuilder.Entity("Proiect_master.Models.ManufacturedInstruments", b =>
                {
                    b.Property<int>("InstrumentID")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturersID")
                        .HasColumnType("int");

                    b.HasKey("InstrumentID", "ManufacturersID");

                    b.HasIndex("ManufacturersID");

                    b.ToTable("ManufacturedIntruments", (string)null);
                });

            modelBuilder.Entity("Proiect_master.Models.Manufacturers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("ManufacturersName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Manufacturers", (string)null);
                });

            modelBuilder.Entity("Proiect_master.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("InstrumentID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("InstrumentID");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("Proiect_master.Models.ManufacturedInstruments", b =>
                {
                    b.HasOne("Proiect_master.Models.Instrument", "Instrument")
                        .WithMany("ManufacturedInstruments")
                        .HasForeignKey("InstrumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect_master.Models.Manufacturers", "Manufacturers")
                        .WithMany("ManufacturedInstruments")
                        .HasForeignKey("ManufacturersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instrument");

                    b.Navigation("Manufacturers");
                });

            modelBuilder.Entity("Proiect_master.Models.Order", b =>
                {
                    b.HasOne("Proiect_master.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect_master.Models.Instrument", "Instrument")
                        .WithMany("Orders")
                        .HasForeignKey("InstrumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Instrument");
                });

            modelBuilder.Entity("Proiect_master.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Proiect_master.Models.Instrument", b =>
                {
                    b.Navigation("ManufacturedInstruments");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Proiect_master.Models.Manufacturers", b =>
                {
                    b.Navigation("ManufacturedInstruments");
                });
#pragma warning restore 612, 618
        }
    }
}
