using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class WorkoutLog
{
    public Guid WorkoutLogId { get; set; }

    public Guid WorkoutId { get; set; }

    public DateTime WorkoutDate { get; set; }

    public virtual ICollection<SetLog> SetLog { get; } = new List<SetLog>();

    public virtual WorkoutTemplate Workout { get; set; }
}
