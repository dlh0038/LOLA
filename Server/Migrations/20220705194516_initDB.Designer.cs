﻿// <auto-generated />
using LOLA.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LOLA.Server.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20220705194516_initDB")]
    partial class initDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("LOLA.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Restaurant")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Order", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
