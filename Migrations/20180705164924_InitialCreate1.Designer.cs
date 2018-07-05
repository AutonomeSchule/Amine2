﻿// <auto-generated />
using AMINEV02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AmineV02.Migrations
{
    [DbContext(typeof(AMINEV02Context))]
    [Migration("20180705164924_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("AMINEV02.Models.Gaeste", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Ankunft");

                    b.Property<string>("Email");

                    b.Property<string>("Genre")
                        .IsRequired();

                    b.Property<string>("Nachname");

                    b.Property<string>("Name");

                    b.Property<decimal>("Phonenumber");

                    b.Property<decimal>("Price");

                    b.Property<string>("Wunsch")
                        .IsRequired();

                    b.Property<bool>("vegan");

                    b.HasKey("ID");

                    b.ToTable("Gaeste");
                });
#pragma warning restore 612, 618
        }
    }
}
