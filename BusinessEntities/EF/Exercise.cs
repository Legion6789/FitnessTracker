using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class Exercise
{
    public Guid ExerciseId { get; set; }

    public string ExerciseName { get; set; }

    public virtual ICollection<ExerciseSet> ExerciseSet { get; } = new List<ExerciseSet>();

    public virtual ICollection<SetLog> SetLog { get; } = new List<SetLog>();
}
