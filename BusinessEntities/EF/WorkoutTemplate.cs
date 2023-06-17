using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class WorkoutTemplate
{
    public Guid WorkoutId { get; set; }

    public string WorkoutName { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<ExerciseSet> ExerciseSet { get; } = new List<ExerciseSet>();

    public virtual ICollection<WorkoutLog> WorkoutLog { get; } = new List<WorkoutLog>();
}
