﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkplaceSystem.Data;

#nullable disable

namespace WorkplaceSystem.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20240426180150_ClientModelFix")]
    partial class ClientModelFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WorkplaceSystem.Models.ClientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WorkplaceSystem.Models.UseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateUse")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EndUse")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartUse")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("TotalUse")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Uses");
                });

            modelBuilder.Entity("WorkplaceSystem.Models.UseModel", b =>
                {
                    b.HasOne("WorkplaceSystem.Models.ClientModel", "Client")
                        .WithMany("ClientUses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("WorkplaceSystem.Models.ClientModel", b =>
                {
                    b.Navigation("ClientUses");
                });
#pragma warning restore 612, 618
        }
    }
}
