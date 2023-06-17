using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class ExerciseSet
{
    public Guid ExerciseSetId { get; set; }

    public Guid WorkoutId { get; set; }

    public Guid ExerciseId { get; set; }

    public int Sets { get; set; }

    public int TargetReps { get; set; }

    public int? TargetRpe { get; set; }

    public int? RestPeriod { get; set; }

    public virtual Exercise Exercise { get; set; }

    public virtual WorkoutTemplate Workout { get; set; }
}
