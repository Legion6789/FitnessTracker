using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class BodyPartMuscleMapping
{
    public int BodyPartMuscleMappingId { get; set; }

    public string BodyPartId { get; set; } = null!;

    public string MuscleId { get; set; } = null!;

    public virtual BodyParts BodyPart { get; set; } = null!;

    public virtual Muscles Muscle { get; set; } = null!;
}
