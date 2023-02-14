using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class WorkoutExerciseMapping
{
    public int WorkoutExerciseMappingId { get; set; }

    public int WorkoutId { get; set; }

    public string ExerciseId { get; set; } = null!;

    public int Sets { get; set; }

    public int Reps { get; set; }

    public int? TargetRpe { get; set; }

    public decimal? RestPeriod { get; set; }

    public virtual Exercises Exercise { get; set; } = null!;

    public virtual Workouts Workout { get; set; } = null!;
}
