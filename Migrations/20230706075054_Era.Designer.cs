﻿// <auto-generated />
using DinoWebAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DinoWebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230706075054_Era")]
    partial class Era
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("DinoWebAPI.Dinosaur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Diet")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Era")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Dinosaurs");
                });
#pragma warning restore 612, 618
        }
    }
}
