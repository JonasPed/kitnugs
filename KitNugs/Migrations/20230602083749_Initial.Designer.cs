﻿// <auto-generated />
using System;
using KitNugs.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KitNugs.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230602083749_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("KitNugs.Repository.HelloTable", b =>
                {
                    b.Property<int>("HelloTableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetime(6)");

                    b.HasKey("HelloTableId");

                    b.ToTable("HelloTable");
                });
#pragma warning restore 612, 618
        }
    }
}
