using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class Exercises
{
    public string ExerciseId { get; set; } = null!;

    public string ExerciseName { get; set; } = null!;

    public virtual ICollection<ExerciseMuscleMapping> ExerciseMuscleMapping { get; } = new List<ExerciseMuscleMapping>();

    public virtual ICollection<WorkoutExerciseMapping> WorkoutExerciseMapping { get; } = new List<WorkoutExerciseMapping>();
}
