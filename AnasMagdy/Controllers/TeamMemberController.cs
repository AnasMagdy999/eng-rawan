using AnasMagdy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnasMagdy.Controllers
{
    public class TeamMemberController : Controller
    {

        private readonly AppDbContext _Context;

        public TeamMemberController(AppDbContext context)
        {
            _Context = context;
        }
        public async Task<IActionResult> TeamMemberDetails(int id)
        {
            var ss = await _Context.teamMembers.Include(x => x.Tasks).ThenInclude(x => x.Project).FirstOrDefaultAsync(x => x.Id == id);
            return View(ss);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var ss = await _Context.teamMembers.FindAsync(id);
            return View(ss);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(TeamMember pro, int id)
        {
            var p2 = await _Context.teamMembers.FindAsync(id);

            p2.Name = pro.Name;
            p2.Email = pro.Email;
            p2.Role = pro.Role;


            _Context.teamMembers.Update(p2);
            await _Context.SaveChangesAsync();
            return RedirectToAction("Index", "TeamMemberDetails");
        }




        public async Task<IActionResult> Deletee(int id)
        {
            var s = await _Context.teamMembers.FirstOrDefaultAsync(x => x.Id == id);
            return View(s);

        }


        [HttpPost]
        public async Task<IActionResult> Deletee(TeamMember pro)
        {
            _Context.teamMembers.Remove(pro);
            await _Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
