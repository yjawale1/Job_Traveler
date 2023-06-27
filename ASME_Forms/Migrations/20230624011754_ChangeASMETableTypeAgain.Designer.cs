﻿// <auto-generated />
using ASME_Forms.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASME_Forms.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230624011754_ChangeASMETableTypeAgain")]
    partial class ChangeASMETableTypeAgain
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASME_Forms.Models.ASME_CBI", b =>
                {
                    b.Property<int>("JOB_TRAVELER_NUMBER")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JOB_TRAVELER_NUMBER"));

                    b.Property<string>("BASIC_TANK_NUMBER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPTION")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DWG_NUMBER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HX_NUMBER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MVP_NUMBER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NATL_BD_NUMBER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PART_NUMBER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JOB_TRAVELER_NUMBER");

                    b.ToTable("ASME_CBI");
                });
#pragma warning restore 612, 618
        }
    }
}
