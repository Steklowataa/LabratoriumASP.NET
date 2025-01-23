using System;
using System.Collections.Generic;

namespace zaliczenie_final.Entities;

public class UniversityPaginationViewModel
{
    // public List<University> Universities { get; set; }
    // public List<UniversityRankingYear> UniversityRankingYears { get; set; }
    // public int TotalUniversities { get; set; }
    // public int PageNumber { get; set; }
    // public int PageSize { get; set; }
    // public int TotalPages => (int)Math.Ceiling((double)TotalUniversities / PageSize);
    public List<UniversityDisplayModel> Items { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    
}