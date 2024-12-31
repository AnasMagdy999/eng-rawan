using AnasMagdy.Models;

namespace AnasMagdy.ViewModels
{
    public class ProjectTaskVM
    {
        public int Project_ID;
        public int Task_ID;
        public int TeamMember_ID;

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }



        public string Task_Title { get; set; }
        public string Task_Ststus { get; set; }
        public DateTime Deadline { get; set; }


        public string TeamMember_Name { get; set; }




        public TeamMember TeamMember { get; set; }
        public Project Project { get; set; }
        public List<TASKK> tasksss { get; set; }

    }
}
