﻿// <auto-generated />
using System;
using CorrectionPetiteAnnonce.Tools;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CorrectionPetiteAnnonce.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("CorrectionPetiteAnnonce.Models.Annonce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Titre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Annonces");
                });

            modelBuilder.Entity("CorrectionPetiteAnnonce.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AnnonceId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AnnonceId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("CorrectionPetiteAnnonce.Models.Image", b =>
                {
                    b.HasOne("CorrectionPetiteAnnonce.Models.Annonce", null)
                        .WithMany("Images")
                        .HasForeignKey("AnnonceId");
                });

            modelBuilder.Entity("CorrectionPetiteAnnonce.Models.Annonce", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}