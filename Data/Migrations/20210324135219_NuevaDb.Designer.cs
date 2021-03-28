﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicShopMVC.Data;

namespace MusicShopMVC.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210324135219_NuevaDb")]
    partial class NuevaDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MusicShopMVC.Models.InstrumentoCuerda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadCuerdas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MarcaID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreImagen")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrientacionMano")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("InstrumentosDeCuerda");

                    b.HasDiscriminator<string>("Discriminator").HasValue("InstrumentoCuerda");
                });

            modelBuilder.Entity("MusicShopMVC.Models.InstrumentoPercusion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MarcaID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreImagen")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("InstrumentosDePercusion");

                    b.HasDiscriminator<string>("Discriminator").HasValue("InstrumentoPercusion");
                });

            modelBuilder.Entity("MusicShopMVC.Models.InstrumentoTecla", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadTeclas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MarcaID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreImagen")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("InstrumentosDeTecla");

                    b.HasDiscriminator<string>("Discriminator").HasValue("InstrumentoTecla");
                });

            modelBuilder.Entity("MusicShopMVC.Models.InstrumentoViento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MarcaID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreImagen")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("InstrumentosDeViento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("InstrumentoViento");
                });

            modelBuilder.Entity("MusicShopMVC.Models.Marca", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("MusicShopMVC.Models.Bajo", b =>
                {
                    b.HasBaseType("MusicShopMVC.Models.InstrumentoCuerda");

                    b.Property<int>("CAntidadMics")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Bajo_CAntidadMics");

                    b.Property<int>("CantidadTrastes")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Bajo_CantidadTrastes");

                    b.Property<string>("MaderaCuerpo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("Bajo_MaderaCuerpo");

                    b.Property<string>("MaderaMastil")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("Bajo_MaderaMastil");

                    b.HasDiscriminator().HasValue("Bajo");
                });

            modelBuilder.Entity("MusicShopMVC.Models.GuitarraAcustica", b =>
                {
                    b.HasBaseType("MusicShopMVC.Models.InstrumentoCuerda");

                    b.Property<int>("CantidadTrastes")
                        .HasColumnType("INTEGER")
                        .HasColumnName("GuitarraAcustica_CantidadTrastes");

                    b.Property<bool>("ElectroAcustica")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaderaCuerpo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("GuitarraAcustica_MaderaCuerpo");

                    b.HasDiscriminator().HasValue("GuitarraAcustica");
                });

            modelBuilder.Entity("MusicShopMVC.Models.GuitarraCriolla", b =>
                {
                    b.HasBaseType("MusicShopMVC.Models.InstrumentoCuerda");

                    b.Property<int>("CantidadTrastes")
                        .HasColumnType("INTEGER")
                        .HasColumnName("GuitarraCriolla_CantidadTrastes");

                    b.Property<string>("MaderaCuerpo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("GuitarraCriolla_MaderaCuerpo");

                    b.HasDiscriminator().HasValue("GuitarraCriolla");
                });

            modelBuilder.Entity("MusicShopMVC.Models.GuitarraElectrica", b =>
                {
                    b.HasBaseType("MusicShopMVC.Models.InstrumentoCuerda");

                    b.Property<int>("CAntidadMics")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadTrastes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaderaCuerpo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("MaderaMastil")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoMics")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoPuente")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("GuitarraElectrica");
                });

            modelBuilder.Entity("MusicShopMVC.Models.Violin", b =>
                {
                    b.HasBaseType("MusicShopMVC.Models.InstrumentoCuerda");

                    b.Property<string>("Digitacion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Violin");
                });

            modelBuilder.Entity("MusicShopMVC.Models.Bateria", b =>
                {
                    b.HasBaseType("MusicShopMVC.Models.InstrumentoPercusion");

                    b.Property<bool>("Banqueta")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cuerpo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Linea")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<bool>("PedalBombo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Platillos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Bateria");
                });

            modelBuilder.Entity("MusicShopMVC.Models.PianoDigital", b =>
                {
                    b.HasBaseType("MusicShopMVC.Models.InstrumentoTecla");

                    b.HasDiscriminator().HasValue("PianoDigital");
                });

            modelBuilder.Entity("MusicShopMVC.Models.Teclado", b =>
                {
                    b.HasBaseType("MusicShopMVC.Models.InstrumentoTecla");

                    b.Property<int>("CantidadRitmos")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Teclado");
                });

            modelBuilder.Entity("MusicShopMVC.Models.Flauta", b =>
                {
                    b.HasBaseType("MusicShopMVC.Models.InstrumentoViento");

                    b.Property<string>("Digitacion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Flauta");
                });

            modelBuilder.Entity("MusicShopMVC.Models.Saxofon", b =>
                {
                    b.HasBaseType("MusicShopMVC.Models.InstrumentoViento");

                    b.HasDiscriminator().HasValue("Saxofon");
                });

            modelBuilder.Entity("MusicShopMVC.Models.Trompeta", b =>
                {
                    b.HasBaseType("MusicShopMVC.Models.InstrumentoViento");

                    b.Property<string>("Afinacion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Trompeta");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicShopMVC.Models.InstrumentoCuerda", b =>
                {
                    b.HasOne("MusicShopMVC.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("MusicShopMVC.Models.InstrumentoPercusion", b =>
                {
                    b.HasOne("MusicShopMVC.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("MusicShopMVC.Models.InstrumentoTecla", b =>
                {
                    b.HasOne("MusicShopMVC.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("MusicShopMVC.Models.InstrumentoViento", b =>
                {
                    b.HasOne("MusicShopMVC.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });
#pragma warning restore 612, 618
        }
    }
}