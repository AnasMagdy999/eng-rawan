using AnasMagdy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnasMagdy.Controllers
{
    public class ProjectController : Controller
    {
        private readonly AppDbContext _Context;

        public ProjectController(AppDbContext context)
        {
            _Context = context;
        }

        public async Task<IActionResult> Index()
        {
            var s = await _Context.Projects.ToListAsync();
            return View(s);
        }


        public async Task<IActionResult> Create()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Create(Project pro)
        {
            if(pro == null)
            {
                return NotFound();
            }

            await _Context.Projects.AddAsync(pro);
            await _Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }




        public async Task<IActionResult> Edit(int id)
        {
            var ss = await _Context.Projects.FindAsync(id);
            return View(ss);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(Project pro , int id)
        {
           var p2 = await _Context.Projects.FindAsync(id);

            p2.Name = pro.Name;
            p2.Description = pro.Description;
            p2.StartDate = pro.StartDate;
            p2.EndDate = pro.EndDate;


            _Context.Projects.Update(p2);
            await _Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }



        public async Task<IActionResult> Details(int id)
        {
            var s = await _Context.Projects.Include(x => x.Tasks).ThenInclude(x => x.TeamMember).FirstOrDefaultAsync(x => x.Id == id);
            return View(s);
        }


   

        public async Task<IActionResult> Delete(int id)
        {
            var s = await _Context.Projects.FindAsync(id);
            return View(s);
                
        }


        [HttpPost , ActionName("Delete")]
        public async Task<IActionResult> DeleteCon(Project pro)
        {
            _Context.Projects.Remove(pro);
            await _Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


      
    }
}
