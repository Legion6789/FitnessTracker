using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class Cycles
{
    public int CycleId { get; set; }

    public string CycleName { get; set; } = null!;

    public virtual ICollection<CycleWorkoutMapping> CycleWorkoutMapping { get; } = new List<CycleWorkoutMapping>();

    public virtual ICollection<PhaseCycleMapping> PhaseCycleMapping { get; } = new List<PhaseCycleMapping>();
}
