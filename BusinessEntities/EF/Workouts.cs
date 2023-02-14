using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class Workouts
{
    public int WorkoutId { get; set; }

    public string WorkoutName { get; set; } = null!;

    public virtual ICollection<CycleWorkoutMapping> CycleWorkoutMapping { get; } = new List<CycleWorkoutMapping>();

    public virtual ICollection<WorkoutExerciseMapping> WorkoutExerciseMapping { get; } = new List<WorkoutExerciseMapping>();

    public virtual ICollection<WorkoutLog> WorkoutLog { get; } = new List<WorkoutLog>();
}
