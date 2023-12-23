﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using teploob.Data;

#nullable disable

namespace teploob.Migrations
{
    [DbContext(typeof(MyApplicationContex))]
    [Migration("20231222215650_TableUsers")]
    partial class TableUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("teploob.Data.InputData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AV")
                        .HasColumnType("REAL");

                    b.Property<double>("Cgaza")
                        .HasColumnType("REAL");

                    b.Property<double>("Dapparata")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("DateAdd")
                        .HasColumnType("TEXT");

                    b.Property<double>("Gmaterial")
                        .HasColumnType("REAL");

                    b.Property<double>("H")
                        .HasColumnType("REAL");

                    b.Property<double>("Rashod")
                        .HasColumnType("REAL");

                    b.Property<double>("Tgaza")
                        .HasColumnType("REAL");

                    b.Property<double>("Tmaterial")
                        .HasColumnType("REAL");

                    b.Property<double>("Vgaza")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("InputDatas");
                });

            modelBuilder.Entity("teploob.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
