using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class Muscles
{
    public string MuscleId { get; set; } = null!;

    public string MuscleName { get; set; } = null!;

    public string BodyPartId { get; set; } = null!;

    public virtual BodyParts BodyPart { get; set; } = null!;

    public virtual ICollection<ExerciseMuscleMapping> ExerciseMuscleMapping { get; } = new List<ExerciseMuscleMapping>();
}
