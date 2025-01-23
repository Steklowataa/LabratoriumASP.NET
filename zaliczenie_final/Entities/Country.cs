using System;
using System.Collections.Generic;

namespace zaliczenie_final.Entities;

public partial class Country
{
    public int Id { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<University> Universities { get; set; } = new List<University>();
}
