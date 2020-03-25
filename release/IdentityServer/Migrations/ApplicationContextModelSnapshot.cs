﻿// <auto-generated />
using System;
using IdentityServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IdentityServer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer.Models.Pais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Habitantes")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Pais");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dc91db59-bef1-41bc-961d-0f561995c905"),
                            Habitantes = 46000000,
                            Nombre = "España"
                        },
                        new
                        {
                            Id = new Guid("c16c0e21-6a3c-46bd-a178-d401e3e13547"),
                            Habitantes = 83000000,
                            Nombre = "Alemania"
                        },
                        new
                        {
                            Id = new Guid("7c94004c-9e70-49fc-980f-fc1306e783d1"),
                            Habitantes = 65000000,
                            Nombre = "Francia"
                        },
                        new
                        {
                            Id = new Guid("d3bf5522-1820-4b68-bc46-b1c8d6f0a890"),
                            Habitantes = 61000000,
                            Nombre = "Italia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
