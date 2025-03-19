﻿// <auto-generated />
using System;
using EFTEST.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFTEST.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20250319044735_somechanges")]
    partial class somechanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFTEST.Data.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CurrencyTypeid")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("NoOfPages")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyTypeid");

                    b.HasIndex("LanguageId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("EFTEST.Data.BookPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyTypeid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CurrencyTypeid");

                    b.ToTable("BookPrices");
                });

            modelBuilder.Entity("EFTEST.Data.CurrencyType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CurrencyTypes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Currency = "INR",
                            Description = "Indian Rupee"
                        },
                        new
                        {
                            id = 2,
                            Currency = "USD",
                            Description = "US Dollar"
                        },
                        new
                        {
                            id = 3,
                            Currency = "EUR",
                            Description = "Euro"
                        },
                        new
                        {
                            id = 4,
                            Currency = "GBP",
                            Description = "British Pound"
                        },
                        new
                        {
                            id = 5,
                            Currency = "JPY",
                            Description = "Japanese Yen"
                        },
                        new
                        {
                            id = 6,
                            Currency = "AUD",
                            Description = "Australian Dollar"
                        },
                        new
                        {
                            id = 7,
                            Currency = "CAD",
                            Description = "Canadian Dollar"
                        });
                });

            modelBuilder.Entity("EFTEST.Data.Language", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Description = "English Language",
                            Title = "English"
                        },
                        new
                        {
                            id = 2,
                            Description = "Spanish Language",
                            Title = "Spanish"
                        },
                        new
                        {
                            id = 3,
                            Description = "French Language",
                            Title = "French"
                        },
                        new
                        {
                            id = 4,
                            Description = "German Language",
                            Title = "German"
                        },
                        new
                        {
                            id = 5,
                            Description = "Chinese Language",
                            Title = "Chinese"
                        },
                        new
                        {
                            id = 6,
                            Description = "Japanese Language",
                            Title = "Japanese"
                        },
                        new
                        {
                            id = 7,
                            Description = "Hindi Language",
                            Title = "Hindi"
                        });
                });

            modelBuilder.Entity("EFTEST.Data.Book", b =>
                {
                    b.HasOne("EFTEST.Data.CurrencyType", null)
                        .WithMany("Books")
                        .HasForeignKey("CurrencyTypeid");

                    b.HasOne("EFTEST.Data.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("EFTEST.Data.BookPrice", b =>
                {
                    b.HasOne("EFTEST.Data.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFTEST.Data.CurrencyType", "CurrencyType")
                        .WithMany()
                        .HasForeignKey("CurrencyTypeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("CurrencyType");
                });

            modelBuilder.Entity("EFTEST.Data.CurrencyType", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EFTEST.Data.Language", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
