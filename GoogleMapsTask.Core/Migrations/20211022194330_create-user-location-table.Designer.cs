// <auto-generated />
using System;
using GoogleMapsTask.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoogleMapsTask.Core.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20211022194330_create-user-location-table")]
    partial class createuserlocationtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoogleMapsTask.Core.Entities.UserLocation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("latitude")
                        .HasColumnType("bigint");

                    b.Property<long>("longitude")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("UserLocation");
                });
#pragma warning restore 612, 618
        }
    }
}
