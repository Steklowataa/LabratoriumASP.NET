using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace zaliczenie_final.Entities;

public class AddRankingModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Please select a university.")]
    public int UniversityId { get; set; }
    [Required(ErrorMessage = "Year must be greater than 2016")]
    public int Year { get; set; }
    [Required(ErrorMessage = "Please select a ranking criteria.")]
    public int RankingCriteriaId { get; set; }
    public int Score { get; set; }
    public List<SelectListItem> Universities { get; set; }
    public List<SelectListItem> RankingCriterion { get; set; }

}