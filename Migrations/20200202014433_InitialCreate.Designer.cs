﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scouting_v2.Data;

namespace Scouting_v2.Migrations
{
    [DbContext(typeof(StatsContext))]
    [Migration("20200202014433_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Scouting_v2.Models.Stats", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AutoBalls_LVL_1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AutoBalls_LVL_2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AutoBalls_LVL_3")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Balanced")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Baseline")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Climb_HI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Climb_LO")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Climb_MI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Climbed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CompetitionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Match")
                        .HasColumnType("int");

                    b.Property<decimal>("Spinner_Colour")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Spinner_Number")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Team")
                        .HasColumnType("int");

                    b.Property<decimal>("TeleopBalls_LVL_1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TeleopBalls_LVL_2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TeleopBalls_LVL_3")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Stats");
                });
#pragma warning restore 612, 618
        }
    }
}
