﻿using BTLWebNC_QLLopHocOnline.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BTLWebNC_QLLopHocOnline.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LMS_SASS.Models.ActivityModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("CourseId")
                    .HasColumnType("int");

                b.Property<DateTime>("Created")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("EndDate")
                    .HasColumnType("datetime2");

                b.Property<int>("InstanceId")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("StartDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Type")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("CourseId");

                b.ToTable("Activities");
            });

            modelBuilder.Entity("LMS_SASS.Models.AssignmentModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("PassingGrade")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.ToTable("Assignment");
            });

            modelBuilder.Entity("LMS_SASS.Models.AssignmentSubmissionsModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("AssignmentId")
                    .HasColumnType("int");

                b.Property<double?>("Grade")
                    .HasColumnType("float");

                b.Property<string>("UploadedFile")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("AssignmentId");

                b.HasIndex("UserId");

                b.ToTable("AssignmentSubmission");
            });

            modelBuilder.Entity("LMS_SASS.Models.CourseModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Code")
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnType("nvarchar(32)");

                b.Property<DateTime>("EndDate")
                    .HasColumnType("datetime2");

                b.Property<string>("InviteCode")
                    .HasMaxLength(8)
                    .HasColumnType("nvarchar(8)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnType("nvarchar(32)");

                b.Property<DateTime>("StartDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Subject")
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnType("nvarchar(32)");

                b.HasKey("Id");

                b.HasIndex("Code")
                    .IsUnique();

                b.ToTable("Courses");
            });

            modelBuilder.Entity("LMS_SASS.Models.CourseUserModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("CourseId")
                    .HasColumnType("int");

                b.Property<string>("Role")
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnType("nvarchar(8)");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("CourseId");

                b.HasIndex("UserId");

                b.ToTable("CourseUsers");
            });

            modelBuilder.Entity("LMS_SASS.Models.MeetingModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("url")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Meeting");
            });

            modelBuilder.Entity("LMS_SASS.Models.QuizAttemptDetailModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("Answered")
                    .HasColumnType("int");

                b.Property<bool>("IsCorrect")
                    .HasColumnType("bit");

                b.Property<int>("QuestionId")
                    .HasColumnType("int");

                b.Property<int>("QuizAttemptId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("QuizAttemptDetails");
            });

            modelBuilder.Entity("LMS_SASS.Models.QuizAttemptModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("Correct")
                    .HasColumnType("int");

                b.Property<int>("QuizId")
                    .HasColumnType("int");

                b.Property<double>("Result")
                    .HasColumnType("float");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.Property<int>("Wrong")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("QuizId");

                b.HasIndex("UserId");

                b.ToTable("QuizAttempts");
            });

            modelBuilder.Entity("LMS_SASS.Models.QuizModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<double>("PassingGrade")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.ToTable("Quiz");
            });

            modelBuilder.Entity("LMS_SASS.Models.QuizQuestionModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("Answer")
                    .HasColumnType("int");

                b.Property<string>("Answer1")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Answer2")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Answer3")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Answer4")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Question")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("QuizId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("QuizId");

                b.ToTable("QuizQuestions");
            });

            modelBuilder.Entity("LMS_SASS.Models.UserModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Address")
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<DateTime>("Created")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("DOB")
                    .HasColumnType("datetime2");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnType("nvarchar(32)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnType("nvarchar(32)");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("Phone")
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnType("nvarchar(14)");

                b.Property<string>("Role")
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnType("nvarchar(8)");

                b.Property<string>("Username")
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnType("nvarchar(32)");

                b.HasKey("Id");

                b.HasIndex("Username")
                    .IsUnique();

                b.ToTable("Users");
            });

            modelBuilder.Entity("LMS_SASS.Models.ActivityModel", b =>
            {
                b.HasOne("LMS_SASS.Models.CourseModel", "Course")
                    .WithMany()
                    .HasForeignKey("CourseId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Course");
            });

            modelBuilder.Entity("LMS_SASS.Models.AssignmentSubmissionsModel", b =>
            {
                b.HasOne("LMS_SASS.Models.AssignmentModel", "Assignment")
                    .WithMany()
                    .HasForeignKey("AssignmentId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("LMS_SASS.Models.UserModel", "User")
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Assignment");

                b.Navigation("User");
            });

            modelBuilder.Entity("LMS_SASS.Models.CourseUserModel", b =>
            {
                b.HasOne("LMS_SASS.Models.CourseModel", "Course")
                    .WithMany()
                    .HasForeignKey("CourseId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("LMS_SASS.Models.UserModel", "User")
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Course");

                b.Navigation("User");
            });

            modelBuilder.Entity("LMS_SASS.Models.QuizAttemptModel", b =>
            {
                b.HasOne("LMS_SASS.Models.QuizModel", "Quiz")
                    .WithMany()
                    .HasForeignKey("QuizId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("LMS_SASS.Models.UserModel", "User")
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Quiz");

                b.Navigation("User");
            });

            modelBuilder.Entity("LMS_SASS.Models.QuizQuestionModel", b =>
            {
                b.HasOne("LMS_SASS.Models.QuizModel", "Quiz")
                    .WithMany()
                    .HasForeignKey("QuizId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Quiz");
            });
#pragma warning restore 612, 618
        }
    }
}
