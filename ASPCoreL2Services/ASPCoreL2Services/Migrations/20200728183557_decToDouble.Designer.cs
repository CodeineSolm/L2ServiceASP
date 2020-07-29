﻿// <auto-generated />
using System;
using ASPCoreL2Services.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPCoreL2Services.Migrations
{
    [DbContext(typeof(L2Context))]
    [Migration("20200728183557_decToDouble")]
    partial class decToDouble
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPCoreL2Services.Domain.Entities.EntityBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaDiscription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaKeywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Subpreview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DBEntityBase");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2020, 7, 28, 18, 35, 57, 706, DateTimeKind.Utc).AddTicks(4199),
                            Description = "Buy adena instantly, we have unlimited amount of gold.",
                            Preview = "images/adena.jpg",
                            Price = 6.0,
                            Subpreview = "images/equip1.jpg, images/equip2.jpg, images/equip3.jpg",
                            Subtitle = "Equip your character fast to compete",
                            Title = "Adena"
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(2020, 7, 28, 18, 35, 57, 706, DateTimeKind.Utc).AddTicks(4556),
                            Description = "Fastest exp u ever seen.",
                            Preview = "images/exp.jpg",
                            Price = 6.0,
                            Subpreview = "images/endgame1.jpg, images/endgame2.jpg, images/endgame3.jpg",
                            Subtitle = "You need high level for endgame.",
                            Title = "Experience"
                        },
                        new
                        {
                            Id = 3,
                            DateAdded = new DateTime(2020, 7, 28, 18, 35, 57, 706, DateTimeKind.Utc).AddTicks(4569),
                            Description = "40k, 80k, 100k mobs is boring.",
                            Preview = "images/quests.jpg",
                            Price = 6.0,
                            Subpreview = "images/quest1.jpg, images/quest2.jpg, images/quest3.jpg",
                            Subtitle = "If u dont have time to do quests",
                            Title = "Quests"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}