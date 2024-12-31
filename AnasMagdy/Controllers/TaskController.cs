using AnasMagdy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnasMagdy.Models
{
    public class TaskController : Controller
    {
        private readonly AppDbContext _Context;

        public TaskController(AppDbContext context)
        {
            _Context = context;
        }
        public async Task<IActionResult> Edit(int id , TASKK task)
        {
            var ss = await _Context.Tasks.FirstOrDefaultAsync(x => x.Id == id);
            ss.TeamMemberID = task.TeamMemberID;
            ss.ProjectID = task.ProjectID;
            ss.Priorty = task.Priorty;
            ss.Status = task.Status;
            ss.Title = task.Title;
            ss.Deadline = task.Deadline;

            return View(ss);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(TASKK pro, int id)
        {
            var p2 = await _Context.Tasks.FindAsync(id);

            p2.Title = pro.Title;
            p2.Status = pro.Status;
            p2.Priorty = pro.Priorty;
            p2.Description = pro.Description;
            p2.ProjectID = pro.ProjectID;
            p2.TeamMemberID = pro.TeamMemberID;
            p2.Deadline = pro.Deadline;



            _Context.Tasks.Update(p2);
            await _Context.SaveChangesAsync();
            return RedirectToAction("Index", "TeamMemberDetails");
        }

    }
}
