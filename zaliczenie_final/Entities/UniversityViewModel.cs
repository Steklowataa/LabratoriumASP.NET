namespace zaliczenie_final.Entities;

public class UniversityViewModel
{
        public University University { get; set; }
        public List<UniversityRankingYear> UniversityRankingYears { get; set; }
        public int TotalRankings { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        
        public List<string> SystemName { get; set; }
}