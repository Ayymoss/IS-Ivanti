﻿// <auto-generated />
using System;
using ISIvanti.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ISIvanti.Server.Migrations
{
    [DbContext(typeof(LocalDataContext))]
    partial class LocalDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("ISIvanti.Server.Models.LocalModels.EFJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AgentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Completed")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Guid")
                        .HasColumnType("TEXT");

                    b.Property<int>("State")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StateResult")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EFJobs", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}