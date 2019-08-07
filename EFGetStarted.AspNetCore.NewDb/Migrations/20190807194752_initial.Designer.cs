﻿// <auto-generated />
using System;
using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFGetStarted.AspNetCore.NewDb.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20190807194752_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("EFGetStarted.AspNetCore.NewDb.Models.Blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EFGetStarted.AspNetCore.NewDb.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BlogID");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("BlogID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EFGetStarted.AspNetCore.NewDb.Models.Post", b =>
                {
                    b.HasOne("EFGetStarted.AspNetCore.NewDb.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogID");
                });
#pragma warning restore 612, 618
        }
    }
}
