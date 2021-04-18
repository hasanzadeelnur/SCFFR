﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCYDMWebServices.Data;

namespace TCYDMWebServices.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210416224756_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TCYDMWebServices.Models.AdminTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("admintables");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("contactuss");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("genders");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.HomePage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("homepage");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.Langluage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LangluageName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("ValueKey")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("languages");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.OnlineQuery", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Info")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("IsSeen")
                        .HasColumnType("int");

                    b.Property<DateTime>("ServiceDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserId");

                    b.ToTable("onlinequeries");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.PDFClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("OnlineQueryId")
                        .HasColumnType("bigint");

                    b.Property<string>("PDFName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OnlineQueryId");

                    b.ToTable("pdfbase");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("regions");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IsLocal")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.Property<int>("NeedsAdittion")
                        .HasColumnType("int");

                    b.Property<int>("NeedsPayment")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("services");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.ServiceAddition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("InputId")
                        .HasColumnType("int");

                    b.Property<string>("PlaceHolder")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("serviceadditions");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.ServiceAdditionFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long?>("OnlineQueryId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OnlineQueryId");

                    b.ToTable("serviceadditionfile");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.ServiceAdditionNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Content")
                        .HasColumnType("int");

                    b.Property<long?>("OnlineQueryId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OnlineQueryId");

                    b.ToTable("serviceadditionnumber");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.ServiceAdditionText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long?>("OnlineQueryId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OnlineQueryId");

                    b.ToTable("serviceadditiontext");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.ServiceInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Info")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("serviceinfos");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BornYear")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<int>("IsConfirmed")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<string>("PKey")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("SexId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<string>("TCNo")
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<string>("Token")
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("RegionId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.WhatWeDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("whatwedos");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.WhoWeAre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("whoweares");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.OnlineQuery", b =>
                {
                    b.HasOne("TCYDMWebServices.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TCYDMWebServices.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TCYDMWebServices.Models.PDFClass", b =>
                {
                    b.HasOne("TCYDMWebServices.Models.OnlineQuery", "OnlineQuery")
                        .WithMany("PdfClasses")
                        .HasForeignKey("OnlineQueryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TCYDMWebServices.Models.Region", b =>
                {
                    b.HasOne("TCYDMWebServices.Models.Country", "Country")
                        .WithMany("Regions")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TCYDMWebServices.Models.ServiceAddition", b =>
                {
                    b.HasOne("TCYDMWebServices.Models.Service", "Service")
                        .WithMany("ServiceAdditions")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.ServiceAdditionFile", b =>
                {
                    b.HasOne("TCYDMWebServices.Models.OnlineQuery", "OnlineQuery")
                        .WithMany("ServiceAdditionFiles")
                        .HasForeignKey("OnlineQueryId");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.ServiceAdditionNumber", b =>
                {
                    b.HasOne("TCYDMWebServices.Models.OnlineQuery", "OnlineQuery")
                        .WithMany("ServiceAdditionNumbers")
                        .HasForeignKey("OnlineQueryId");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.ServiceAdditionText", b =>
                {
                    b.HasOne("TCYDMWebServices.Models.OnlineQuery", "OnlineQuery")
                        .WithMany("ServiceAdditionTexts")
                        .HasForeignKey("OnlineQueryId");
                });

            modelBuilder.Entity("TCYDMWebServices.Models.User", b =>
                {
                    b.HasOne("TCYDMWebServices.Models.Country", "Countries")
                        .WithMany("Users")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TCYDMWebServices.Models.Region", "Regions")
                        .WithMany("Users")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
