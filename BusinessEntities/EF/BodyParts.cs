using System;
using System.Collections.Generic;

namespace BusinessEntities.EF;

public partial class BodyParts
{
    public string BodyPartId { get; set; } = null!;

    public string BodyPartName { get; set; } = null!;

    public virtual ICollection<Muscles> Muscles { get; } = new List<Muscles>();
}
