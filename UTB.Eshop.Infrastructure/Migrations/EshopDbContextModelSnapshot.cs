﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UTB.Eshop.Infrastructure.Database;

#nullable disable

namespace UTB.Eshop.Infrastructure.Migrations
{
    [DbContext(typeof(EshopDbContext))]
    partial class EshopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UTB.Eshop.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("ID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Mobilní telefon - 6,1\" IPS 1792 × 828, procesor Apple A13 Bionic 6jádrový, RAM 4 GB, interní paměť 128 GB, zadní fotoaparát 12 Mpx (f/1,8) + 12 Mpx (f/2,4), přední fotoaparát 12 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, Lightning port, voděodolný dle IP68, single SIM + eSIM, neblokovaný, rychlé nabíjení 18W, bezdrátové nabíjení, baterie 3110 mAh, iOS 13",
                            Name = "iPhone 11 128GB černá",
                            Price = 14500.0
                        },
                        new
                        {
                            ID = 2,
                            Description = "Mobilní telefon - 5,9\" AMOLED 2400 × 1080, 120Hz, procesor Qualcomm Snapdragon 8+ Gen 1 8jádrový, RAM 8 GB, interní paměť 128,01 GB, zadní fotoaparát 50 Mpx (f/1,9) + 12 Mpx (f/2,2), přední fotoaparát 12 Mpx, optická a elektronická stabilizace, GPS, Glonass, NFC, LTE, 5G, Jack (3,5mm) a USB-C, čtečka otisků, voděodolný dle IP68, dual SIM, neblokovaný, rychlé nabíjení 30W, baterie 4300 mAh, Android 12",
                            Name = "Asus Zenfone 9 8GB/128GB černá",
                            Price = 17500.0
                        },
                        new
                        {
                            ID = 3,
                            Description = " Mobilní telefon - 6,1\" OLED 2532 × 1170, 120Hz, procesor Apple A15 Bionic 6jádrový, RAM 6 GB, interní paměť 128 GB, zadní fotoaparát s optickým zoomem 12 Mpx (f/1,5) + 12 Mpx (f/2,8) + 12 Mpx (f/1,8), přední fotoaparát 12 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, 5G, Lightning port, voděodolný dle IP68, single SIM + eSIM, neblokovaný, rychlé nabíjení 20W, bezdrátové nabíjení 15W, baterie 3095 mAh, iOS 15, EU distribuce",
                            Name = "iPhone 13 Pro 128GB grafitově šedá",
                            Price = 30000.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}