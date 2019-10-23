﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using openswaggerNswag.Models;

namespace openswaggerNswag.Migrations
{
    [DbContext(typeof(todocontextContext))]
    [Migration("20191011105747_Rating")]
    partial class Rating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("openswaggerNswag.Models.Todoitems", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20)");

                    b.Property<short>("IsComplete")
                        .HasColumnType("bit(1)");

                    b.Property<string>("Name")
                        .IsUnicode(false);

                    b.Property<string>("Rating");

                    b.HasKey("Id");

                    b.ToTable("todoitems","todocontext");
                });
#pragma warning restore 612, 618
        }
    }
}
