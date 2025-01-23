using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using zaliczenie_final.Context;
using zaliczenie_final.Entities;

namespace zaliczenie_final.Controllers
{
    public class UniversityController : Controller
    {
        private readonly MyDbContext _context;

        public UniversityController(MyDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Details(int id, int pageNumber = 1)
        {
            var university = _context.Universities
                .Include(u => u.Country)
                .FirstOrDefault(u => u.Id == id);

            if (university == null)
            {
                return NotFound();
            }

            int rankingsPerPage = 10;
            var totalRankings = _context.UniversityRankingYears
                .Where(ur => ur.UniversityId == id)
                .Count();
            int totalPages = (int)Math.Ceiling(totalRankings / (double)rankingsPerPage);

            var rankings = _context.UniversityRankingYears
                .Where(ur => ur.UniversityId == id)
                .Include(ur => ur.RankingCriteria)
                .OrderBy(ur => ur.Year)
                .Skip((pageNumber - 1) * rankingsPerPage) 
                .Take(rankingsPerPage)
                .ToList();
            
            var viewModel = new UniversityViewModel
            {
                University = university,
                UniversityRankingYears = rankings,
                TotalRankings = totalRankings, 
                CurrentPage = pageNumber, 
                TotalPages = totalPages 
            };

            return View(viewModel);
        }

        // GET: University/Create
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Id");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CountryId,UniversityName")] University university)
        {
            if (ModelState.IsValid)
            {
                _context.Add(university);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Id", university.CountryId);
            return View(university);
        }

        // GET: University/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var university = await _context.Universities.FindAsync(id);
            if (university == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "CountryName", university.CountryId);
            return View(university);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CountryId,UniversityName")] University university)
        {
            if (id != university.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(university);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityExists(university.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "CountryName", university.CountryId);
            return View(university);
        }

        // GET: University/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var university = await _context.Universities
                .Include(u => u.Country)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (university == null)
            {
                return NotFound();
            }

            return View(university);
        }

        // POST: University/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var university = await _context.Universities.FindAsync(id);
            if (university != null)
            {
                _context.Universities.Remove(university);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            var universityData = _context.UniversityRankingYears
                .Include(ury => ury.University) 
                .ThenInclude(u => u.Country)
                .Include(ury => ury.RankingCriteria) 
                .ThenInclude(rc => rc.RankingSystem)
                .Select(ury => new UniversityDisplayModel
                {
                    Id = ury.University.Id,
                    UniversityName = ury.University.UniversityName,
                    CountryName = ury.University.Country.CountryName,
                    SystemName = ury.RankingCriteria.RankingSystem.SystemName
                })
                .Distinct()
                .ToList();
            var paginatedData = universityData
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            var viewModel = new UniversityPaginationViewModel
            {
                Items = paginatedData,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = universityData.Count
            };

            return View(viewModel);
        }

        //Wyswietlanie rankingow
        public IActionResult AlphabeticalRankings(int pageNumber = 1, int pageSize = 13)
        {
            var rankings = _context.UniversityRankingYears
                .Include(ur => ur.University)
                .Include(ur => ur.RankingCriteria) 
                .OrderBy(ur => ur.University.UniversityName)
                .ToList();
            var paginatedRankings = rankings
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = pageNumber;
            ViewBag.TotalPages = (int)Math.Ceiling(rankings.Count / (double)pageSize);

            return View(paginatedRankings);
        }
        
        //Add Ranking
        [HttpGet]
        public IActionResult AddRanking()
        {
            var model = new AddRankingModel
            {
                Universities = _context.Universities
                    .Select(u => new SelectListItem { Value = u.Id.ToString(), Text = u.UniversityName })
                    .ToList(),

                RankingCriterion = _context.RankingCriteria
                    .Select(rc => new SelectListItem { Value = rc.Id.ToString(), Text = rc.CriteriaName })
                    .ToList()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRanking(AddRankingModel model)
        {
            if (ModelState.IsValid)
            {
                var ranking = new UniversityRankingYear
                {
                    UniversityId = model.UniversityId,
                    Year = model.Year,
                    RankingCriteriaId = model.RankingCriteriaId,
                    Score = model.Score
                };

                _context.UniversityRankingYears.Add(ranking);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            
            model.Universities = _context.Universities
                .Select(u => new SelectListItem { Value = u.Id.ToString(), Text = u.UniversityName })
                .ToList();
            model.RankingCriterion = _context.RankingCriteria
                .Select(rc => new SelectListItem { Value = rc.Id.ToString(), Text = rc.CriteriaName })
                .ToList();

            return View(model);
        }
        
        private bool UniversityExists(int id)
        {
            return _context.Universities.Any(e => e.Id == id);
        }
    }
}
