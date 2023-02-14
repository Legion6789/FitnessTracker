using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessEntities.EF;

public partial class ClientDBContext : DbContext
{
    public ClientDBContext()
    {
    }

    public ClientDBContext(DbContextOptions<ClientDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BodyParts> BodyParts { get; set; }

    public virtual DbSet<CycleWorkoutMapping> CycleWorkoutMapping { get; set; }

    public virtual DbSet<Cycles> Cycles { get; set; }

    public virtual DbSet<ExerciseMuscleMapping> ExerciseMuscleMapping { get; set; }

    public virtual DbSet<Exercises> Exercises { get; set; }

    public virtual DbSet<Muscles> Muscles { get; set; }

    public virtual DbSet<PhaseCycleMapping> PhaseCycleMapping { get; set; }

    public virtual DbSet<Phases> Phases { get; set; }

    public virtual DbSet<WorkoutExerciseMapping> WorkoutExerciseMapping { get; set; }

    public virtual DbSet<WorkoutLog> WorkoutLog { get; set; }

    public virtual DbSet<Workouts> Workouts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DevServer;initial catalog=FitnessTracker;user id=sa;password=pass@word1;MultipleActiveResultSets=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BodyParts>(entity =>
        {
            entity.HasKey(e => e.BodyPartId);

            entity.Property(e => e.BodyPartId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BodyPartName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CycleWorkoutMapping>(entity =>
        {
            entity.HasOne(d => d.Cycle).WithMany(p => p.CycleWorkoutMapping)
                .HasForeignKey(d => d.CycleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleWorkoutMapping_Cycles");

            entity.HasOne(d => d.Workout).WithMany(p => p.CycleWorkoutMapping)
                .HasForeignKey(d => d.WorkoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CycleWorkoutMapping_Workouts");
        });

        modelBuilder.Entity<Cycles>(entity =>
        {
            entity.HasKey(e => e.CycleId);

            entity.Property(e => e.CycleName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ExerciseMuscleMapping>(entity =>
        {
            entity.Property(e => e.ExerciseId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.MuscleId)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.Exercise).WithMany(p => p.ExerciseMuscleMapping)
                .HasForeignKey(d => d.ExerciseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExerciseMuscleMapping_Exercises");

            entity.HasOne(d => d.Muscle).WithMany(p => p.ExerciseMuscleMapping)
                .HasForeignKey(d => d.MuscleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExerciseMuscleMapping_Muscles");
        });

        modelBuilder.Entity<Exercises>(entity =>
        {
            entity.HasKey(e => e.ExerciseId);

            entity.Property(e => e.ExerciseId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ExerciseName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Muscles>(entity =>
        {
            entity.HasKey(e => e.MuscleId);

            entity.Property(e => e.MuscleId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BodyPartId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MuscleName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.BodyPart).WithMany(p => p.Muscles)
                .HasForeignKey(d => d.BodyPartId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Muscles_BodyParts");
        });

        modelBuilder.Entity<PhaseCycleMapping>(entity =>
        {
            entity.HasOne(d => d.Cycle).WithMany(p => p.PhaseCycleMapping)
                .HasForeignKey(d => d.CycleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhaseCycleMapping_Cycles");

            entity.HasOne(d => d.Phase).WithMany(p => p.PhaseCycleMapping)
                .HasForeignKey(d => d.PhaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhaseCycleMapping_Phases");
        });

        modelBuilder.Entity<Phases>(entity =>
        {
            entity.HasKey(e => e.PhaseId);

            entity.Property(e => e.PhaseName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WorkoutExerciseMapping>(entity =>
        {
            entity.Property(e => e.ExerciseId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.RestPeriod).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.TargetRpe).HasColumnName("TargetRPE");

            entity.HasOne(d => d.Exercise).WithMany(p => p.WorkoutExerciseMapping)
                .HasForeignKey(d => d.ExerciseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkoutExerciseMapping_Exercises");

            entity.HasOne(d => d.Workout).WithMany(p => p.WorkoutExerciseMapping)
                .HasForeignKey(d => d.WorkoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkoutExerciseMapping_Workouts");
        });

        modelBuilder.Entity<WorkoutLog>(entity =>
        {
            entity.Property(e => e.ExerciseId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RestTaken).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.Rpe).HasColumnName("RPE");
            entity.Property(e => e.WeightUsed).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.WorkoutDate).HasColumnType("smalldatetime");

            entity.HasOne(d => d.Workout).WithMany(p => p.WorkoutLog)
                .HasForeignKey(d => d.WorkoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkoutLog_Workouts");
        });

        modelBuilder.Entity<Workouts>(entity =>
        {
            entity.HasKey(e => e.WorkoutId);

            entity.Property(e => e.WorkoutName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
