using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResumeManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ResumeManager.Controllers
{
    public class CompetitorController : Controller
    {
        ResumeContext db;
        public CompetitorController(ResumeContext context)
        {
            db = context;
        }

        [Authorize]
        public async Task<IActionResult> Competitors()
        {

            IQueryable<Competitor> competitros = db.Competitors.Include(u => u.Company);
            return View(await competitros.AsNoTracking().ToListAsync());

        }

        [Authorize]
        public IActionResult Create()
        {
            SelectList company = new SelectList(db.Companies, "Id", "CompanyName");
            ViewBag.Company = company;
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(Competitor competitor)
        {
            
            db.Competitors.Add(competitor);
            await db.SaveChangesAsync();
            return RedirectToAction("Competitors");
        }
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            SelectList company = new SelectList(db.Companies, "Id", "CompanyName");
            ViewBag.Company = company;

            if (id != null)
            {
                Competitor competitor = await db.Competitors.Include(u => u.Company).FirstOrDefaultAsync(p => p.Id == id);
                if (competitor != null)
                    return View(competitor);
            }
            return NotFound();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(Competitor competitor)
        {
            db.Competitors.Update(competitor);
            await db.SaveChangesAsync();
            return RedirectToAction("Competitors");
        }

        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Competitor competitor = await db.Competitors.Include(u => u.Company).FirstOrDefaultAsync(p => p.Id == id);
                if (competitor != null)
                    return View(competitor);
            }
            return NotFound();
        }


        [Authorize]
        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Competitor competitor = await db.Competitors.Include(u => u.Company).FirstOrDefaultAsync(p => p.Id == id);
                if (competitor != null)
                    return View(competitor);
            }
            return NotFound();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Competitor competitor = await db.Competitors.Include(u => u.Company).FirstOrDefaultAsync(p => p.Id == id);
                if (competitor != null)
                {
                    db.Competitors.Remove(competitor);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Competitors");
                }
            }
            return NotFound();
        }

    }
}
