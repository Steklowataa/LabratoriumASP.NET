    using System;
    using System.Collections.Generic;

    namespace zaliczenie_final.Entities;

    public partial class UniversityRankingYear
    {
        public int? UniversityId { get; set; }

        public int? RankingCriteriaId { get; set; }

        public int? Year { get; set; }

        public int? Score { get; set; }

        public virtual RankingCriterion? RankingCriteria { get; set; }

        public virtual University? University { get; set; }
    }
