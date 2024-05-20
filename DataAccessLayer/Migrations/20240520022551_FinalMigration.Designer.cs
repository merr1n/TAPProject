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
    [Migration("20240520022551_FinalMigration")]
    partial class FinalMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccessLayer.Models.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrganizerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganizerId");

                    b.HasIndex(new[] { "TypeId" }, "IX_Events_TypeId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b2f6eaa1-4c39-411a-8579-d237d33c35e3"),
                            Date = new DateTime(2024, 6, 15, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            Description = "Concert Ian, Azteca, Rava, si multi altii!",
                            Location = "Tiki-Club",
                            OrganizerId = new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"),
                            Price = 60.00m,
                            Status = "Available",
                            Title = "Concert Ian&Azteca",
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("7b676b19-fdb8-4d76-95a5-d8df5efc2c4e"),
                            Date = new DateTime(2024, 9, 23, 19, 45, 0, 0, DateTimeKind.Unspecified),
                            Description = "Spectacol folcloric 'Trandafir de la Moldova'!",
                            Location = "Husi",
                            OrganizerId = new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"),
                            Price = 0.00m,
                            Status = "Available",
                            Title = "Spectacol Trandafir de la Moldova!",
                            TypeId = 2
                        },
                        new
                        {
                            Id = new Guid("f5a4f779-55f1-47bc-8b95-9ae2b1b69e6a"),
                            Date = new DateTime(2024, 11, 5, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Veniti ca sa va simtiti bine!",
                            Location = "OneCaffe",
                            OrganizerId = new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"),
                            Price = 30.00m,
                            Status = "Closed",
                            Title = "Micutzu - Stand up Comedy Show",
                            TypeId = 3
                        },
                        new
                        {
                            Id = new Guid("6dfeef92-d8cf-4e4e-85d6-67fc74e6eb92"),
                            Date = new DateTime(2024, 2, 28, 16, 15, 0, 0, DateTimeKind.Unspecified),
                            Description = "Come listen to what Selaru has to say",
                            Location = "Switzerland",
                            OrganizerId = new Guid("7a628ec2-502f-4ae0-84f2-01e0e7e8bf0d"),
                            Price = 500.00m,
                            Status = "Sold-out",
                            Title = "NATO Congress Speech",
                            TypeId = 4
                        },
                        new
                        {
                            Id = new Guid("5eab5c23-2198-4f79-8120-3ad2348f2ed7"),
                            Date = new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Come have some fun and become healthier while trying to win a prize!",
                            Location = "Stefan cel Mare street",
                            OrganizerId = new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"),
                            Price = 0.00m,
                            Status = "Available",
                            Title = "Marathon (Special Event)",
                            TypeId = 5
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.EventType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EventTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Concert"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Spectacol Dans"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Stand-up Comedy"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Speech"
                        },
                        new
                        {
                            Id = 5,
                            Type = "Other (Please Specify in the Event's title)"
                        });
                });

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

            modelBuilder.Entity("DataAccessLayer.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
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

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"),
                            Email = "darius@gmail.com",
                            Name = "Darius",
                            Password = "darius",
                            TypeId = 3
                        },
                        new
                        {
                            Id = new Guid("7a628ec2-502f-4ae0-84f2-01e0e7e8bf0d"),
                            Email = "monica@gmail.com",
                            Name = "Monica",
                            Password = "monica123",
                            TypeId = 2
                        },
                        new
                        {
                            Id = new Guid("c7f9b7b3-956c-4a07-8a7c-45645eb5f2cc"),
                            Email = "marius@gmail.com",
                            Name = "Marius",
                            Password = "marius",
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"),
                            Email = "maxifny@gmail.com",
                            Name = "Edi",
                            Password = "geometryfear",
                            TypeId = 2
                        },
                        new
                        {
                            Id = new Guid("82e24d8e-0e34-4953-b32f-fb2ac76f92ff"),
                            Email = "popeye@gmail.com",
                            Name = "Nico",
                            Password = "samp",
                            TypeId = 1
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "user"
                        },
                        new
                        {
                            Id = 2,
                            Type = "organizer"
                        },
                        new
                        {
                            Id = 3,
                            Type = "admin"
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Event", b =>
                {
                    b.HasOne("DataAccessLayer.Models.User", "Organizer")
                        .WithMany("Events")
                        .HasForeignKey("OrganizerId")
                        .IsRequired()
                        .HasConstraintName("FK_Events_Users");

                    b.HasOne("DataAccessLayer.Models.EventType", "Type")
                        .WithMany("Events")
                        .HasForeignKey("TypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Events_EventTypes");

                    b.Navigation("Organizer");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Ticket", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("EventId")
                        .IsRequired()
                        .HasConstraintName("FK_Tickets_Events");

                    b.HasOne("DataAccessLayer.Models.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Tickets_Users");

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccessLayer.Models.User", b =>
                {
                    b.HasOne("DataAccessLayer.Models.UserType", "Type")
                        .WithMany("Users")
                        .HasForeignKey("TypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Users_UserTypes");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Event", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("DataAccessLayer.Models.EventType", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("DataAccessLayer.Models.User", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("DataAccessLayer.Models.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
