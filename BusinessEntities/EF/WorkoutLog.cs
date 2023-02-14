using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class WorkoutLog
{
    public int WorkoutLogId { get; set; }

    public int WorkoutId { get; set; }

    public DateTime WorkoutDate { get; set; }

    public string ExerciseId { get; set; } = null!;

    public int SetNumber { get; set; }

    public int RepsAchieved { get; set; }

    public decimal WeightUsed { get; set; }

    public decimal RestTaken { get; set; }

    public int? Rpe { get; set; }

    public string? Note { get; set; }

    public virtual Workouts Workout { get; set; } = null!;
}
