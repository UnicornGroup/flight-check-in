﻿// <auto-generated />
using System;
using Britannica.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Britannica.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14");

            modelBuilder.Entity("Britannica.Domain.Entities.AircraftEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ushort>("BaggagesLimit")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int>("FlightRef")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("WeightLimit")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FlightRef")
                        .IsUnique();

                    b.ToTable("Aircrafts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaggagesLimit = (ushort)100,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            FlightRef = 1,
                            WeightLimit = 1000m
                        },
                        new
                        {
                            Id = 2,
                            BaggagesLimit = (ushort)10,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            FlightRef = 2,
                            WeightLimit = 100m
                        });
                });

            modelBuilder.Entity("Britannica.Domain.Entities.BaggageEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int>("FlightId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<int>("PassengerId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FlightId", "PassengerId");

                    b.ToTable("BaggageEntity");
                });

            modelBuilder.Entity("Britannica.Domain.Entities.FlightEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Depart")
                        .HasColumnType("TEXT");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<DateTime>("Return")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            Depart = new DateTime(2021, 8, 22, 22, 0, 0, 0, DateTimeKind.Utc),
                            Destination = "DC",
                            Origin = "TLV",
                            Return = new DateTime(2021, 9, 11, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            Depart = new DateTime(2021, 8, 23, 9, 0, 0, 0, DateTimeKind.Utc),
                            Destination = "TLV",
                            Origin = "NY",
                            Return = new DateTime(2021, 9, 17, 22, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("Britannica.Domain.Entities.PassengerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirtName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Passengers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            FirtName = "Avi",
                            LastName = "Nessimian"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            FirtName = "Adam",
                            LastName = "Nahlaui"
                        });
                });

            modelBuilder.Entity("Britannica.Domain.Entities.PassengerFlightEntity", b =>
                {
                    b.Property<int>("FlightId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PassengerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeatId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FlightId", "PassengerId");

                    b.HasIndex("PassengerId");

                    b.ToTable("PassengerFlights");
                });

            modelBuilder.Entity("Britannica.Domain.Entities.SeatEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AircraftRef")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FlightId")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Row")
                        .HasColumnType("TEXT");

                    b.Property<int>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AircraftRef = 1,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            Number = (ushort)1,
                            Row = "A",
                            RowVersion = 1
                        },
                        new
                        {
                            Id = 2,
                            AircraftRef = 1,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            Number = (ushort)2,
                            Row = "A",
                            RowVersion = 1
                        },
                        new
                        {
                            Id = 3,
                            AircraftRef = 1,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            Number = (ushort)1,
                            Row = "B",
                            RowVersion = 1
                        },
                        new
                        {
                            Id = 4,
                            AircraftRef = 1,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            Number = (ushort)2,
                            Row = "B",
                            RowVersion = 1
                        },
                        new
                        {
                            Id = 5,
                            AircraftRef = 2,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            Number = (ushort)1,
                            Row = "A",
                            RowVersion = 1
                        },
                        new
                        {
                            Id = 6,
                            AircraftRef = 2,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            Number = (ushort)2,
                            Row = "A",
                            RowVersion = 1
                        },
                        new
                        {
                            Id = 7,
                            AircraftRef = 2,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            Number = (ushort)1,
                            Row = "B",
                            RowVersion = 1
                        },
                        new
                        {
                            Id = 8,
                            AircraftRef = 2,
                            Created = new DateTime(2021, 8, 21, 20, 41, 0, 0, DateTimeKind.Utc),
                            Number = (ushort)2,
                            Row = "B",
                            RowVersion = 1
                        });
                });

            modelBuilder.Entity("Britannica.Domain.Entities.AircraftEntity", b =>
                {
                    b.HasOne("Britannica.Domain.Entities.FlightEntity", "Flight")
                        .WithOne("Aircraft")
                        .HasForeignKey("Britannica.Domain.Entities.AircraftEntity", "FlightRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Britannica.Domain.Entities.BaggageEntity", b =>
                {
                    b.HasOne("Britannica.Domain.Entities.PassengerFlightEntity", "PassengerFlight")
                        .WithMany("Baggages")
                        .HasForeignKey("FlightId", "PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Britannica.Domain.Entities.PassengerFlightEntity", b =>
                {
                    b.HasOne("Britannica.Domain.Entities.FlightEntity", "Flight")
                        .WithMany("PassengerFlights")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Britannica.Domain.Entities.PassengerEntity", "Passenger")
                        .WithMany("PassengerFlights")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Britannica.Domain.Entities.SeatEntity", b =>
                {
                    b.HasOne("Britannica.Domain.Entities.AircraftEntity", "Flight")
                        .WithMany("Seats")
                        .HasForeignKey("FlightId");
                });
#pragma warning restore 612, 618
        }
    }
}
