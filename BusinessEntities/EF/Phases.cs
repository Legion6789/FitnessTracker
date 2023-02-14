using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class Phases
{
    public int PhaseId { get; set; }

    public string PhaseName { get; set; } = null!;

    public virtual ICollection<PhaseCycleMapping> PhaseCycleMapping { get; } = new List<PhaseCycleMapping>();
}
