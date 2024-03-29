﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Playing2.Models;

namespace Playing2.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20190809193306_authors")]
    partial class authors
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Playing2.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Playing2.Models.Blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("OwnerID");

                    b.HasKey("ID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Playing2.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorID");

                    b.Property<int>("BlogID");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<int>("PostTypeID");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("BlogID");

                    b.HasIndex("PostTypeID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Playing2.Models.PostType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("PostTypes");
                });

            modelBuilder.Entity("Playing2.Models.Blog", b =>
                {
                    b.HasOne("Playing2.Models.Author", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Playing2.Models.Post", b =>
                {
                    b.HasOne("Playing2.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Playing2.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Playing2.Models.PostType", "PostType")
                        .WithMany()
                        .HasForeignKey("PostTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
