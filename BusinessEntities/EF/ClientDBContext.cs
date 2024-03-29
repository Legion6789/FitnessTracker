﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BusinessEntities;
using BusinessEntities.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BusinessEntities.EF;

public partial class ClientDBContext : IdentityDbContext<ApiUser>
{
    public ClientDBContext()
    {
    }

    public ClientDBContext(DbContextOptions<ClientDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Exercise> Exercise { get; set; }

    public virtual DbSet<ExerciseSet> ExerciseSet { get; set; }

    public virtual DbSet<SetLog> SetLog { get; set; }

    public virtual DbSet<WorkoutLog> WorkoutLog { get; set; }

    public virtual DbSet<WorkoutTemplate> WorkoutTemplate { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConnectionStringHolder.ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exercise>(entity =>
        {
            entity.Property(e => e.ExerciseId)
                .ValueGeneratedNever()
                .HasColumnName("exerciseId");
            entity.Property(e => e.ExerciseName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("exerciseName");
        });

        modelBuilder.Entity<ExerciseSet>(entity =>
        {
            entity.Property(e => e.ExerciseSetId)
                .ValueGeneratedNever()
                .HasColumnName("exerciseSetId");
            entity.Property(e => e.ExerciseId).HasColumnName("exerciseId");
            entity.Property(e => e.RestPeriod).HasColumnName("restPeriod");
            entity.Property(e => e.Sets).HasColumnName("sets");
            entity.Property(e => e.TargetReps).HasColumnName("targetReps");
            entity.Property(e => e.TargetRpe).HasColumnName("targetRPE");
            entity.Property(e => e.WorkoutId).HasColumnName("workoutId");

            entity.HasOne(d => d.Exercise).WithMany(p => p.ExerciseSet)
                .HasForeignKey(d => d.ExerciseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExerciseSet_Exercise");

            entity.HasOne(d => d.Workout).WithMany(p => p.ExerciseSet)
                .HasForeignKey(d => d.WorkoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExerciseSet_WorkoutTemplate");
        });

        modelBuilder.Entity<SetLog>(entity =>
        {
            entity.Property(e => e.SetLogId)
                .ValueGeneratedNever()
                .HasColumnName("setLogId");
            entity.Property(e => e.ExerciseId).HasColumnName("exerciseId");
            entity.Property(e => e.RepsAchieved).HasColumnName("repsAchieved");
            entity.Property(e => e.Rpe).HasColumnName("RPE");
            entity.Property(e => e.SetNumber).HasColumnName("setNumber");
            entity.Property(e => e.Weight).HasColumnName("weight");
            entity.Property(e => e.WorkoutLogId).HasColumnName("workoutLogId");

            entity.HasOne(d => d.Exercise).WithMany(p => p.SetLog)
                .HasForeignKey(d => d.ExerciseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SetLog_Exercise");

            entity.HasOne(d => d.WorkoutLog).WithMany(p => p.SetLog)
                .HasForeignKey(d => d.WorkoutLogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SetLog_WorkoutLog");
        });

        modelBuilder.Entity<WorkoutLog>(entity =>
        {
            entity.Property(e => e.WorkoutLogId)
                .ValueGeneratedNever()
                .HasColumnName("workoutLogId");
            entity.Property(e => e.WorkoutDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("workoutDate");
            entity.Property(e => e.WorkoutId).HasColumnName("workoutId");

            entity.HasOne(d => d.Workout).WithMany(p => p.WorkoutLog)
                .HasForeignKey(d => d.WorkoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkoutLog_WorkoutTemplate");
        });

        modelBuilder.Entity<WorkoutTemplate>(entity =>
        {
            entity.HasKey(e => e.WorkoutId);

            entity.Property(e => e.WorkoutId)
                .ValueGeneratedNever()
                .HasColumnName("workoutId");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.WorkoutName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("workoutName");
        });

        modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
        });

        modelBuilder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId });
        });

        modelBuilder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
