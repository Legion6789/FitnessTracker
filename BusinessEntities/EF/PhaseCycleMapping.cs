using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class PhaseCycleMapping
{
    public int PhaseCycleMappingId { get; set; }

    public int PhaseId { get; set; }

    public int CycleId { get; set; }

    public int Ordinal { get; set; }

    public virtual Cycles Cycle { get; set; } = null!;

    public virtual Phases Phase { get; set; } = null!;
}
