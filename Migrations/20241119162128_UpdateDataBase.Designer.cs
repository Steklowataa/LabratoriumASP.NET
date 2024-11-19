﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lab3.Models;

#nullable disable

namespace Lab3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241119162128_UpdateDataBase")]
    partial class UpdateDataBase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("lab3.Models.ContactEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("birth_date");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Category = 3,
                            Email = "johndoe@gmail.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "123123123"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2002, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Category = 2,
                            Email = "janedoe@gmail.com",
                            FirstName = "Jane",
                            LastName = "Doe",
                            PhoneNumber = "321231321"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
