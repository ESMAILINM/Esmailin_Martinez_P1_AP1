﻿// <auto-generated />
using System;
using Esmailin_Martinez_P1_AP1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Esmailin_Martinez_P1_AP1.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Esmailin_Martinez_P1_AP1.Models.Aportes", b =>
                {
                    b.Property<int>("AporteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AporteId"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("Monto")
                        .HasColumnType("float");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Persona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AporteId");

                    b.ToTable("Aportes");
                });
#pragma warning restore 612, 618
        }
    }
}
