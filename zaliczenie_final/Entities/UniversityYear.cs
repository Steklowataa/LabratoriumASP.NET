using System;
using System.Collections.Generic;

namespace zaliczenie_final.Entities;

public partial class UniversityYear
{
    public int? UniversityId { get; set; }

    public int? Year { get; set; }

    public int? NumStudents { get; set; }

    public double? StudentStaffRatio { get; set; }

    public int? PctInternationalStudents { get; set; }

    public int? PctFemaleStudents { get; set; }

    public virtual University? University { get; set; }
}
