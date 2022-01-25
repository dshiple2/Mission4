﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4Jan24.Models;

namespace Mission4Jan24.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4Jan24.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            Category = "Family",
                            Director = "Hilton",
                            Edited = false,
                            Rating = "R",
                            Title = "Surfs Up",
                            Year = 2005
                        },
                        new
                        {
                            ApplicationId = 2,
                            Category = "Family",
                            Director = "Washington",
                            Edited = false,
                            Rating = "G",
                            Title = "Megamind",
                            Year = 2006
                        },
                        new
                        {
                            ApplicationId = 3,
                            Category = "Family",
                            Director = "Nieldman",
                            Edited = false,
                            Rating = "PG",
                            Title = "Shrek",
                            Year = 2002
                        });
                });
#pragma warning restore 612, 618
        }
    }
}