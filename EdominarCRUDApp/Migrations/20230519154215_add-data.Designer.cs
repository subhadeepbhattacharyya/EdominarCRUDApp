﻿// <auto-generated />
using EdominarCRUDApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EdominarCRUDApp.Migrations
{
    [DbContext(typeof(EdominerCRUD))]
    [Migration("20230519154215_add-data")]
    partial class adddata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EdominarCRUDApp.Models.db.Hobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hobbys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Football"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movie Binge"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Reading"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Music"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Photography"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Cooking"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Painting"
                        });
                });

            modelBuilder.Entity("EdominarCRUDApp.Models.db.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Andhra Pradesh"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Arunachal Pradesh"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Assam"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bihar"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Chhattisgarh"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Goa"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Gujarat"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Haryana"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Himachal Pradesh"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Jammu and Kashmir"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Jharkhand"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Karnataka"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Kerala"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Madhya Pradesh"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Maharashtra"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Manipur"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Meghalaya"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Mizoram"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Nagaland"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Odisha"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Punjab"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Rajasthan"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Sikkim"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Tamil Nadu"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Telangana"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Tripura"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Uttarakhand"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Uttar Pradesh"
                        },
                        new
                        {
                            Id = 29,
                            Name = "West Bengal"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Andaman and Nicobar Islands"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Chandigarh"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Dadra and Nagar Haveli"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Daman and Diu"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Delhi"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Lakshadweep"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Puducherry"
                        });
                });

            modelBuilder.Entity("EdominarCRUDApp.Models.db.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("HobbyId")
                        .HasColumnType("int");

                    b.Property<int>("Mobile")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HobbyId");

                    b.HasIndex("StateId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EdominarCRUDApp.Models.db.User", b =>
                {
                    b.HasOne("EdominarCRUDApp.Models.db.Hobby", "Hobby")
                        .WithMany()
                        .HasForeignKey("HobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EdominarCRUDApp.Models.db.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hobby");

                    b.Navigation("State");
                });
#pragma warning restore 612, 618
        }
    }
}
