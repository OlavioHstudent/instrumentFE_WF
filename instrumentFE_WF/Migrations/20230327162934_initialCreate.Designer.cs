﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using instrumentFE_WF;

#nullable disable

namespace instrumentFE_WF.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230327162934_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("instrumentFE_WF.Instrument", b =>
                {
                    b.Property<string>("instrumentName")
                        .HasColumnType("TEXT");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("lrv")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("measureType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("options")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("registerDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("serialNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("signalType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("urv")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("instrumentName");

                    b.ToTable("instruments");
                });
#pragma warning restore 612, 618
        }
    }
}