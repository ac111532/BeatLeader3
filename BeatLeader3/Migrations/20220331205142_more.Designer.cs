﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeatLeader3.Migrations
{
    [DbContext(typeof(BeatLeader3ContextDb))]
    [Migration("20220331205142_more")]
    partial class more
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeatLeader3.Models.Beatmap", b =>
                {
                    b.Property<int>("BeatmapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bombs")
                        .HasColumnType("int");

                    b.Property<int>("MapPlays")
                        .HasColumnType("int");

                    b.Property<int>("Notes")
                        .HasColumnType("int");

                    b.Property<int>("Slash")
                        .HasColumnType("int");

                    b.Property<int>("SongID")
                        .HasColumnType("int");

                    b.Property<int>("Walls")
                        .HasColumnType("int");

                    b.HasKey("BeatmapID");

                    b.HasIndex("SongID")
                        .IsUnique();

                    b.ToTable("Beatmap");
                });

            modelBuilder.Entity("BeatLeader3.Models.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountAge")
                        .HasColumnType("int");

                    b.Property<int>("LevelsBeaten")
                        .HasColumnType("int");

                    b.Property<int>("Modcount")
                        .HasColumnType("int");

                    b.Property<string>("PlayerHMD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerPlatform")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerID");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("BeatLeader3.Models.Score", b =>
                {
                    b.Property<int>("ScoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BeatmapID1")
                        .HasColumnType("int");

                    b.Property<bool>("FullCombo")
                        .HasColumnType("bit");

                    b.Property<int>("Multiplier")
                        .HasColumnType("int");

                    b.Property<decimal>("Percentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<string>("Rank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.HasKey("ScoreID");

                    b.HasIndex("BeatmapID1");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("BeatLeader3.Models.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("SongBPM")
                        .HasColumnType("int");

                    b.Property<int>("SongLength")
                        .HasColumnType("int");

                    b.Property<string>("SongName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongID");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("BeatLeader3.Models.Beatmap", b =>
                {
                    b.HasOne("BeatLeader3.Models.Song", "song")
                        .WithOne("Beatmap")
                        .HasForeignKey("BeatLeader3.Models.Beatmap", "SongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("song");
                });

            modelBuilder.Entity("BeatLeader3.Models.Score", b =>
                {
                    b.HasOne("BeatLeader3.Models.Beatmap", "BeatmapID")
                        .WithMany()
                        .HasForeignKey("BeatmapID1");

                    b.Navigation("BeatmapID");
                });

            modelBuilder.Entity("BeatLeader3.Models.Song", b =>
                {
                    b.Navigation("Beatmap");
                });
#pragma warning restore 612, 618
        }
    }
}
