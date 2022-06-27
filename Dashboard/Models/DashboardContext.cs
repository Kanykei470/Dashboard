using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dashboard.Models
{
    public partial class DashboardContext : DbContext
    {
        public DashboardContext()
        {
        }

        public DashboardContext(DbContextOptions<DashboardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Direction> Directions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Milestone> Milestones { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-0NMHJ2G\\SQLEXPRESS;Database=Dashboard;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Direction>(entity =>
            {
                entity.ToTable("Direction");

                entity.Property(e => e.Completion).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Priority).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.Surname).HasMaxLength(50);
            });

            modelBuilder.Entity<Milestone>(entity =>
            {
                entity.Property(e => e.Completion).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateOfBegining).HasColumnType("date");

                entity.Property(e => e.DateOfFinish).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Priority).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.DirectionNavigation)
                    .WithMany(p => p.Milestones)
                    .HasForeignKey(d => d.Direction)
                    .HasConstraintName("FK_Milestones_Direction");

                entity.HasOne(d => d.ProjectNavigation)
                    .WithMany(p => p.Milestones)
                    .HasForeignKey(d => d.Project)
                    .HasConstraintName("FK_Milestones_Projects");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.Position1)
                    .HasMaxLength(50)
                    .HasColumnName("Position");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.Completion).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Priority).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.DirectionNavigation)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.Direction)
                    .HasConstraintName("FK_Projects_Direction");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Completion).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateOfBegining).HasColumnType("date");

                entity.Property(e => e.DateOfFinish).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Priority).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.DirectionNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.Direction)
                    .HasConstraintName("FK_Tasks_Direction");

                entity.HasOne(d => d.EmployeeNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.Employee)
                    .HasConstraintName("FK_Tasks_Employees");

                entity.HasOne(d => d.MilestoneNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.Milestone)
                    .HasConstraintName("FK_Tasks_Milestones");

                entity.HasOne(d => d.ProjectNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.Project)
                    .HasConstraintName("FK_Tasks_Projects");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
