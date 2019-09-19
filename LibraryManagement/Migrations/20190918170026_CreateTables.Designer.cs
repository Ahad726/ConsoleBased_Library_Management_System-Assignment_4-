﻿// <auto-generated />
using System;
using LibraryManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryManagement.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20190918170026_CreateTables")]
    partial class CreateTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryManagement.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Barcode");

                    b.Property<int>("CopyCount");

                    b.Property<string>("Edition");

                    b.Property<string>("Title");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryManagement.BookIssue", b =>
                {
                    b.Property<int>("SerialNo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookBarcode");

                    b.Property<DateTime>("BookIssueDate");

                    b.Property<int>("StudentId");

                    b.HasKey("SerialNo");

                    b.ToTable("IssuedBookDetails");
                });

            modelBuilder.Entity("LibraryManagement.CheckFine", b =>
                {
                    b.Property<int>("SerialNo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookIssueDate");

                    b.Property<int>("BookKeepingDays");

                    b.Property<DateTime>("BookReturnDate");

                    b.Property<int>("FineAmount");

                    b.Property<int>("StudentId");

                    b.HasKey("SerialNo");

                    b.ToTable("CheckFines");
                });

            modelBuilder.Entity("LibraryManagement.ReceiveFine", b =>
                {
                    b.Property<int>("SerialNo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReceivedAmount");

                    b.Property<int>("StudentId");

                    b.HasKey("SerialNo");

                    b.ToTable("ReceiveFines");
                });

            modelBuilder.Entity("LibraryManagement.ReturnBook", b =>
                {
                    b.Property<int>("SerialNo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookBarcode");

                    b.Property<DateTime>("BookReturnDate");

                    b.Property<int>("StudentId");

                    b.HasKey("SerialNo");

                    b.ToTable("ReturnBookDetails");
                });

            modelBuilder.Entity("LibraryManagement.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}