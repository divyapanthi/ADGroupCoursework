﻿// <auto-generated />
using System;
using GroupCoursework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GroupCoursework.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GroupCoursework.Models.Actor", b =>
                {
                    b.Property<int>("ActorNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorNumber"), 1L, 1);

                    b.Property<string>("ActorFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActorSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorNumber");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("GroupCoursework.Models.CastMember", b =>
                {
                    b.Property<int>("CastMemberNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CastMemberNumber"), 1L, 1);

                    b.Property<int>("ActorNumber")
                        .HasColumnType("int");

                    b.Property<int>("DVDNumber")
                        .HasColumnType("int");

                    b.HasKey("CastMemberNumber");

                    b.HasIndex("ActorNumber");

                    b.HasIndex("DVDNumber");

                    b.ToTable("CastMember");
                });

            modelBuilder.Entity("GroupCoursework.Models.DVDCategory", b =>
                {
                    b.Property<int>("CategoryNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryNumber"), 1L, 1);

                    b.Property<string>("AgeRestricted")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryNumber");

                    b.ToTable("DVDCategory");
                });

            modelBuilder.Entity("GroupCoursework.Models.DVDCopy", b =>
                {
                    b.Property<int>("CopyNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CopyNumber"), 1L, 1);

                    b.Property<int>("DVDNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime2");

                    b.HasKey("CopyNumber");

                    b.HasIndex("DVDNumber");

                    b.ToTable("DVDCopy");
                });

            modelBuilder.Entity("GroupCoursework.Models.DVDTitle", b =>
                {
                    b.Property<int>("DVDNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DVDNumber"), 1L, 1);

                    b.Property<int>("CategoryNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateReleased")
                        .HasColumnType("datetime2");

                    b.Property<int>("PenaltyCharge")
                        .HasColumnType("int");

                    b.Property<int>("ProducerNumber")
                        .HasColumnType("int");

                    b.Property<int>("StandardCharge")
                        .HasColumnType("int");

                    b.Property<int>("StudioNumber")
                        .HasColumnType("int");

                    b.HasKey("DVDNumber");

                    b.HasIndex("CategoryNumber");

                    b.HasIndex("ProducerNumber");

                    b.HasIndex("StudioNumber");

                    b.ToTable("DVDTitle");
                });

            modelBuilder.Entity("GroupCoursework.Models.Loan", b =>
                {
                    b.Property<int>("LoanNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanNumber"), 1L, 1);

                    b.Property<int>("CopyNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateReturned")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoanTypeNumber")
                        .HasColumnType("int");

                    b.Property<int>("MemberNumber")
                        .HasColumnType("int");

                    b.HasKey("LoanNumber");

                    b.HasIndex("CopyNumber");

                    b.HasIndex("LoanTypeNumber");

                    b.HasIndex("MemberNumber");

                    b.ToTable("Loan");
                });

            modelBuilder.Entity("GroupCoursework.Models.LoanType", b =>
                {
                    b.Property<int>("LoanTypeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanTypeNumber"), 1L, 1);

                    b.Property<string>("LoanDuration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loan_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoanTypeNumber");

                    b.ToTable("LoanType");
                });

            modelBuilder.Entity("GroupCoursework.Models.Member", b =>
                {
                    b.Property<int>("MemberNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberNumber"), 1L, 1);

                    b.Property<string>("MemberAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MemberDOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("MemberFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MembershipCategoryNumber")
                        .HasColumnType("int");

                    b.Property<string>("MemeberLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberNumber");

                    b.HasIndex("MembershipCategoryNumber");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("GroupCoursework.Models.MembershipCategory", b =>
                {
                    b.Property<int>("MembershipCategoryNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MembershipCategoryNumber"), 1L, 1);

                    b.Property<string>("MembershipCategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MembershipCategoryTotalLoans")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MembershipCategoryNumber");

                    b.ToTable("MembershipCategory");
                });

            modelBuilder.Entity("GroupCoursework.Models.Producer", b =>
                {
                    b.Property<int>("ProducerNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProducerNumber"), 1L, 1);

                    b.Property<string>("ProducerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProducerNumber");

                    b.ToTable("Producer");
                });

            modelBuilder.Entity("GroupCoursework.Models.Studio", b =>
                {
                    b.Property<int>("StudioNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudioNumber"), 1L, 1);

                    b.Property<string>("StudioName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudioNumber");

                    b.ToTable("Studio");
                });

            modelBuilder.Entity("GroupCoursework.Models.User", b =>
                {
                    b.Property<long>("UserNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserNumber"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserNumber");

                    b.ToTable("User");
                });

            modelBuilder.Entity("GroupCoursework.Models.CastMember", b =>
                {
                    b.HasOne("GroupCoursework.Models.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroupCoursework.Models.DVDTitle", "DVDTitle")
                        .WithMany()
                        .HasForeignKey("DVDNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("DVDTitle");
                });

            modelBuilder.Entity("GroupCoursework.Models.DVDCopy", b =>
                {
                    b.HasOne("GroupCoursework.Models.DVDTitle", "DVDTitle")
                        .WithMany()
                        .HasForeignKey("DVDNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DVDTitle");
                });

            modelBuilder.Entity("GroupCoursework.Models.DVDTitle", b =>
                {
                    b.HasOne("GroupCoursework.Models.DVDCategory", "DVDCategory")
                        .WithMany()
                        .HasForeignKey("CategoryNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroupCoursework.Models.Producer", "Producer")
                        .WithMany()
                        .HasForeignKey("ProducerNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroupCoursework.Models.Studio", "Studio")
                        .WithMany()
                        .HasForeignKey("StudioNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DVDCategory");

                    b.Navigation("Producer");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("GroupCoursework.Models.Loan", b =>
                {
                    b.HasOne("GroupCoursework.Models.DVDCopy", "DVDCopy")
                        .WithMany()
                        .HasForeignKey("CopyNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroupCoursework.Models.LoanType", "LoanType")
                        .WithMany()
                        .HasForeignKey("LoanTypeNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroupCoursework.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DVDCopy");

                    b.Navigation("LoanType");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("GroupCoursework.Models.Member", b =>
                {
                    b.HasOne("GroupCoursework.Models.MembershipCategory", "MembershipCategory")
                        .WithMany()
                        .HasForeignKey("MembershipCategoryNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembershipCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
