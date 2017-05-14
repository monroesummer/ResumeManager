using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResumeManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace ResumeManager.Controllers
{
    public class CompanyController : Controller
    {
        ResumeContext db;
        public CompanyController(ResumeContext context)
        {
            db = context;
        }

        [Authorize]
        public async Task<IActionResult> Companies()
        {

            IQueryable<Company> companies = db.Companies;
            return View(await companies.AsNoTracking().ToListAsync());

        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(Company company)
        {

            db.Companies.Add(company);
            await db.SaveChangesAsync();
            return RedirectToAction("Companies");
        }
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {

            if (id != null)
            {
                Company company = await db.Companies.FirstOrDefaultAsync(p => p.Id == id);
                if (company != null)
                    return View(company);
            }
            return NotFound();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(Company company)
        {
            db.Companies.Update(company);
            await db.SaveChangesAsync();
            return RedirectToAction("Companies");
        }

        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Company company = await db.Companies.FirstOrDefaultAsync(p => p.Id == id);
                if (company != null)
                    return View(company);
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
                Company company = await db.Companies.FirstOrDefaultAsync(p => p.Id == id);
                if (company != null)
                    return View(company);
            }
            return NotFound();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Company company = await db.Companies.FirstOrDefaultAsync(p => p.Id == id);
                if (company != null)
                {
                    db.Companies.Remove(company);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Companies");
                }
            }
            return NotFound();
        }
    }
}
