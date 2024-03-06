﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mvstwo.Models;

#nullable disable

namespace mvstwo.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230923194913_migrat1")]
    partial class migrat1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("mvstwo.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Currently")
                        .HasColumnType("bit");

                    b.Property<int>("questId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("questId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("mvstwo.Models.Cok", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eom1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eom2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eom3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mdk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequirementsStudentLection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequirementsStudentTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequirementsStudentTrainer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequirementsTeacherLection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequirementsTeacherTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequirementsTeacherTrainer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("teacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("teacherId");

                    b.ToTable("Coks");
                });

            modelBuilder.Entity("mvstwo.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("mvstwo.Models.Lection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextBlock")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("cokId")
                        .HasColumnType("int");

                    b.Property<int?>("trainerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("cokId");

                    b.HasIndex("trainerId");

                    b.ToTable("Lections");
                });

            modelBuilder.Entity("mvstwo.Models.Quest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("QuestText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeQuest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("testId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("testId");

                    b.ToTable("Quests");
                });

            modelBuilder.Entity("mvstwo.Models.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CokId")
                        .HasColumnType("int");

                    b.Property<int>("TimeMin")
                        .HasColumnType("int");

                    b.Property<int>("TimeSec")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("balls")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CokId");

                    b.HasIndex("UserId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("mvstwo.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("cokId")
                        .HasColumnType("int");

                    b.Property<int?>("trainerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("cokId");

                    b.HasIndex("trainerId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("mvstwo.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("cokId")
                        .HasColumnType("int");

                    b.Property<int>("page")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("cokId");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("mvstwo.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("groupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("groupId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("mvstwo.Models.keyword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("cokId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("cokId");

                    b.ToTable("Keywords");
                });

            modelBuilder.Entity("mvstwo.Models.Answer", b =>
                {
                    b.HasOne("mvstwo.Models.Quest", "quest")
                        .WithMany("answers")
                        .HasForeignKey("questId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("quest");
                });

            modelBuilder.Entity("mvstwo.Models.Cok", b =>
                {
                    b.HasOne("mvstwo.Models.User", "teacher")
                        .WithMany("cok")
                        .HasForeignKey("teacherId");

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("mvstwo.Models.Lection", b =>
                {
                    b.HasOne("mvstwo.Models.Cok", "cok")
                        .WithMany("lections")
                        .HasForeignKey("cokId");

                    b.HasOne("mvstwo.Models.Trainer", "trainer")
                        .WithMany("lection")
                        .HasForeignKey("trainerId");

                    b.Navigation("cok");

                    b.Navigation("trainer");
                });

            modelBuilder.Entity("mvstwo.Models.Quest", b =>
                {
                    b.HasOne("mvstwo.Models.Test", "test")
                        .WithMany("Questions")
                        .HasForeignKey("testId");

                    b.Navigation("test");
                });

            modelBuilder.Entity("mvstwo.Models.Result", b =>
                {
                    b.HasOne("mvstwo.Models.Cok", "Cok")
                        .WithMany()
                        .HasForeignKey("CokId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mvstwo.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cok");

                    b.Navigation("User");
                });

            modelBuilder.Entity("mvstwo.Models.Test", b =>
                {
                    b.HasOne("mvstwo.Models.Cok", "cok")
                        .WithMany("tests")
                        .HasForeignKey("cokId");

                    b.HasOne("mvstwo.Models.Trainer", "trainer")
                        .WithMany("test")
                        .HasForeignKey("trainerId");

                    b.Navigation("cok");

                    b.Navigation("trainer");
                });

            modelBuilder.Entity("mvstwo.Models.Trainer", b =>
                {
                    b.HasOne("mvstwo.Models.Cok", "cok")
                        .WithMany("trainers")
                        .HasForeignKey("cokId");

                    b.Navigation("cok");
                });

            modelBuilder.Entity("mvstwo.Models.User", b =>
                {
                    b.HasOne("mvstwo.Models.Group", "group")
                        .WithMany("Users")
                        .HasForeignKey("groupId");

                    b.Navigation("group");
                });

            modelBuilder.Entity("mvstwo.Models.keyword", b =>
                {
                    b.HasOne("mvstwo.Models.Cok", "cok")
                        .WithMany("keywords")
                        .HasForeignKey("cokId");

                    b.Navigation("cok");
                });

            modelBuilder.Entity("mvstwo.Models.Cok", b =>
                {
                    b.Navigation("keywords");

                    b.Navigation("lections");

                    b.Navigation("tests");

                    b.Navigation("trainers");
                });

            modelBuilder.Entity("mvstwo.Models.Group", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("mvstwo.Models.Quest", b =>
                {
                    b.Navigation("answers");
                });

            modelBuilder.Entity("mvstwo.Models.Test", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("mvstwo.Models.Trainer", b =>
                {
                    b.Navigation("lection");

                    b.Navigation("test");
                });

            modelBuilder.Entity("mvstwo.Models.User", b =>
                {
                    b.Navigation("cok");
                });
#pragma warning restore 612, 618
        }
    }
}