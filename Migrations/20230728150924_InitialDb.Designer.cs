﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _19_07_2023_task1.Data;

#nullable disable

namespace _19_07_2023_task1.Migrations
{
    [DbContext(typeof(TaxSubjectsDbContext))]
    [Migration("20230728150924_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaxSubjectWorker", b =>
                {
                    b.Property<Guid>("TaxSubjectsTaxSubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkersWorkerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TaxSubjectsTaxSubjectId", "WorkersWorkerId");

                    b.HasIndex("WorkersWorkerId");

                    b.ToTable("TaxSubjectWorker");
                });

            modelBuilder.Entity("_19_07_2023_task1.Data.Entities.Account", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TaxSubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AccountId");

                    b.HasIndex("TaxSubjectId");

                    b.ToTable("Accunts");
                });

            modelBuilder.Entity("_19_07_2023_task1.Data.Entities.TaxSubject", b =>
                {
                    b.Property<Guid>("TaxSubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("HasVirtualAccounts")
                        .HasColumnType("bit");

                    b.Property<string>("Krs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationDenialBasis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationDenialDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationLegalDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemovalBasis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemovalDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidenceAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestorationBasis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestorationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusVat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaxSubjectId");

                    b.ToTable("TaxSubjects");
                });

            modelBuilder.Entity("_19_07_2023_task1.Data.Entities.Worker", b =>
                {
                    b.Property<Guid>("WorkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkerRole")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkerId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("TaxSubjectWorker", b =>
                {
                    b.HasOne("_19_07_2023_task1.Data.Entities.TaxSubject", null)
                        .WithMany()
                        .HasForeignKey("TaxSubjectsTaxSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_19_07_2023_task1.Data.Entities.Worker", null)
                        .WithMany()
                        .HasForeignKey("WorkersWorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_19_07_2023_task1.Data.Entities.Account", b =>
                {
                    b.HasOne("_19_07_2023_task1.Data.Entities.TaxSubject", "TaxSubject")
                        .WithMany("Account")
                        .HasForeignKey("TaxSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaxSubject");
                });

            modelBuilder.Entity("_19_07_2023_task1.Data.Entities.TaxSubject", b =>
                {
                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}