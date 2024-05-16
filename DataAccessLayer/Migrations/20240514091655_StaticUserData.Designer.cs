﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240514091655_StaticUserData")]
    partial class StaticUserData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccessLayer.Models.TestModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestModels");
                });

            modelBuilder.Entity("DataAccessLayer.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"),
                            Email = "darius@gmail.com",
                            Name = "Darius",
                            Password = "darius",
                            Type = "admin"
                        },
                        new
                        {
                            Id = new Guid("7a628ec2-502f-4ae0-84f2-01e0e7e8bf0d"),
                            Email = "monica@gmail.com",
                            Name = "Monica",
                            Password = "monica123",
                            Type = "organizer"
                        },
                        new
                        {
                            Id = new Guid("c7f9b7b3-956c-4a07-8a7c-45645eb5f2cc"),
                            Email = "marius@gmail.com",
                            Name = "Marius",
                            Password = "marius",
                            Type = "user"
                        },
                        new
                        {
                            Id = new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"),
                            Email = "maxifny@gmail.com",
                            Name = "Edi",
                            Password = "geometryfear",
                            Type = "organizer"
                        },
                        new
                        {
                            Id = new Guid("82e24d8e-0e34-4953-b32f-fb2ac76f92ff"),
                            Email = "popeye@gmail.com",
                            Name = "Nico",
                            Password = "samp",
                            Type = "user"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
