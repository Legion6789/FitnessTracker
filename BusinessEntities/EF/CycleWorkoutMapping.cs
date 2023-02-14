using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class CycleWorkoutMapping
{
    public int CycleWorkoutMappingId { get; set; }

    public int CycleId { get; set; }

    public int WorkoutId { get; set; }

    public int Ordinal { get; set; }

    public virtual Cycles Cycle { get; set; } = null!;

    public virtual Workouts Workout { get; set; } = null!;
}
