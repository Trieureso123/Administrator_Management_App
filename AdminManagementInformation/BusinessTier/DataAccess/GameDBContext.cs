using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Library.DataAccess
{
    public partial class GameDBContext : DbContext
    {
        public GameDBContext()
        {
        }

        public GameDBContext(DbContextOptions<GameDBContext> options)
            : base(options)
        {
        }

        public string ConnectionString;

        public GameDBContext(string cs)
        {
            ConnectionString = cs;
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Description> Descriptions { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Question> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.IdAccount);

                entity.ToTable("Account");

                entity.Property(e => e.NameAccount)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.ToTable("Category");

                entity.Property(e => e.NameCategory)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Description>(entity =>
            {
                entity.HasKey(e => e.IdDescription);

                entity.ToTable("Description");

                entity.Property(e => e.Description1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Description");

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.IdFeedback)
                    .HasName("PK__Feedback__408FF103271A4C94");

                entity.ToTable("Feedback");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.LessonFeedback).HasMaxLength(500);

                entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.HasKey(e => e.IdLesson);

                entity.ToTable("Lesson");

                entity.Property(e => e.NameLesson)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VideoUrl)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.IdQuestion);

                entity.ToTable("Question");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Question1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Question");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
