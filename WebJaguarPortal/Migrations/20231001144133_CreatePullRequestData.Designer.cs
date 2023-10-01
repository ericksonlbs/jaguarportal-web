﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebJaguarPortal.Infrastructure;

#nullable disable

namespace WebJaguarPortal.Migrations
{
    [DbContext(typeof(JaguarDbContext))]
    [Migration("20231001144133_CreatePullRequestData")]
    partial class CreatePullRequestData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebJaguarPortal.Models.ClassAnalysis", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AnalysisId")
                        .HasColumnType("bigint");

                    b.Property<long?>("FileAnalyzeId")
                        .HasColumnType("bigint");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AnalysisId");

                    b.HasIndex("FileAnalyzeId");

                    b.ToTable("ClassAnalyzes");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.ControlFlowAnalysis", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("EndAnalysis")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MessageError")
                        .HasColumnType("text");

                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PullRequestBase")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PullRequestBranch")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PullRequestNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Repository")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartAnalysis")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("TestsFail")
                        .HasColumnType("integer");

                    b.Property<int>("TestsPass")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ControlFlowAnalyzes");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.FileAnalysis", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FileAnalyzes");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.LineAnalysis", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Cef")
                        .HasColumnType("integer");

                    b.Property<int>("Cep")
                        .HasColumnType("integer");

                    b.Property<long>("ClassAnalysisId")
                        .HasColumnType("bigint");

                    b.Property<int>("Cnf")
                        .HasColumnType("integer");

                    b.Property<int>("Cnp")
                        .HasColumnType("integer");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberLine")
                        .HasColumnType("integer");

                    b.Property<double>("SuspiciousValue")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("ClassAnalysisId");

                    b.ToTable("LineAnalyzes");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.RenewPassword", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RenewPasswords");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EntropyLevelPassword")
                        .HasColumnType("integer");

                    b.Property<string>("JWTSigningKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SmtpAddress")
                        .HasColumnType("text");

                    b.Property<string>("SmtpFrom")
                        .HasColumnType("text");

                    b.Property<string>("SmtpPassword")
                        .HasColumnType("text");

                    b.Property<int?>("SmtpPort")
                        .HasColumnType("integer");

                    b.Property<bool>("SmtpUseSSL")
                        .HasColumnType("boolean");

                    b.Property<string>("SmtpUsername")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ClientSecret")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("RolesId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RolesId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.UserPermissions", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Delete")
                        .HasColumnType("boolean");

                    b.Property<bool>("Detail")
                        .HasColumnType("boolean");

                    b.Property<bool>("Edit")
                        .HasColumnType("boolean");

                    b.Property<bool>("List")
                        .HasColumnType("boolean");

                    b.Property<bool>("New")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.UserRoles", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("AnalyzesPermissionId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<long?>("ProjectsPermissionId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UsersPermissionId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AnalyzesPermissionId");

                    b.HasIndex("ProjectsPermissionId");

                    b.HasIndex("UsersPermissionId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.ClassAnalysis", b =>
                {
                    b.HasOne("WebJaguarPortal.Models.ControlFlowAnalysis", "Analyze")
                        .WithMany("Classes")
                        .HasForeignKey("AnalysisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebJaguarPortal.Models.FileAnalysis", "Code")
                        .WithMany()
                        .HasForeignKey("FileAnalyzeId");

                    b.Navigation("Analyze");

                    b.Navigation("Code");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.ControlFlowAnalysis", b =>
                {
                    b.HasOne("WebJaguarPortal.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.LineAnalysis", b =>
                {
                    b.HasOne("WebJaguarPortal.Models.ClassAnalysis", "Class")
                        .WithMany("Lines")
                        .HasForeignKey("ClassAnalysisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.User", b =>
                {
                    b.HasOne("WebJaguarPortal.Models.UserRoles", "Roles")
                        .WithMany()
                        .HasForeignKey("RolesId");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.UserRoles", b =>
                {
                    b.HasOne("WebJaguarPortal.Models.UserPermissions", "AnalyzesPermission")
                        .WithMany()
                        .HasForeignKey("AnalyzesPermissionId");

                    b.HasOne("WebJaguarPortal.Models.UserPermissions", "ProjectsPermission")
                        .WithMany()
                        .HasForeignKey("ProjectsPermissionId");

                    b.HasOne("WebJaguarPortal.Models.UserPermissions", "UsersPermission")
                        .WithMany()
                        .HasForeignKey("UsersPermissionId");

                    b.Navigation("AnalyzesPermission");

                    b.Navigation("ProjectsPermission");

                    b.Navigation("UsersPermission");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.ClassAnalysis", b =>
                {
                    b.Navigation("Lines");
                });

            modelBuilder.Entity("WebJaguarPortal.Models.ControlFlowAnalysis", b =>
                {
                    b.Navigation("Classes");
                });
#pragma warning restore 612, 618
        }
    }
}
