using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class ExerciseMuscleMapping
{
    public int ExerciseMuscleMappingId { get; set; }

    public string ExerciseId { get; set; } = null!;

    public string MuscleId { get; set; } = null!;

    public virtual Exercises Exercise { get; set; } = null!;

    public virtual Muscles Muscle { get; set; } = null!;
}
