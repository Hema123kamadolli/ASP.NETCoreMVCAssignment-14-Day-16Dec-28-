﻿// <auto-generated />
using System;
using Assignment_14.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment_14.Migrations
{
    [DbContext(typeof(CMSDbContext))]
    partial class CMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Assignment_14.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseCategory")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CourseCategory" }, "UQ__Category__672ECC6D3439B2A2")
                        .IsUnique();

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("Assignment_14.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryName")
                        .HasColumnType("int");

                    b.Property<double?>("Fee")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CategoryName");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("Assignment_14.Models.Course", b =>
                {
                    b.HasOne("Assignment_14.Models.Category", "CategoryNameNavigation")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryName")
                        .HasConstraintName("FK__Course__Category__3A81B327");

                    b.Navigation("CategoryNameNavigation");
                });

            modelBuilder.Entity("Assignment_14.Models.Category", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
