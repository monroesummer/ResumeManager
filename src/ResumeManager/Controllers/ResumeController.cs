using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResumeManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ResumeManager.Controllers
{
    public class ResumeController : Controller
    {
        ResumeContext db;
        public ResumeController(ResumeContext context)
        {
            db = context;
        }

        // GET: /<controller>/
        public IActionResult Send()
        {
            SelectList company = new SelectList(db.Companies, "Id", "CompanyName");
            ViewBag.Company = company;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Send(Competitor competitor)
        {

            db.Competitors.Add(competitor);
            await db.SaveChangesAsync();
            return Redirect("~/Home/Index");
        }
    }
}
