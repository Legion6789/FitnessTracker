using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class SetLog
{
    public Guid SetLogId { get; set; }

    public Guid WorkoutLogId { get; set; }

    public Guid ExerciseId { get; set; }

    public int SetNumber { get; set; }

    public int RepsAchieved { get; set; }

    public int Weight { get; set; }

    public int? Rpe { get; set; }

    public virtual Exercise Exercise { get; set; }

    public virtual WorkoutLog WorkoutLog { get; set; }
}
