using AnasMagdy.Models;

namespace AnasMagdy.ViewModels
{
    public class EditTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }



        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Priorty { get; set; }
        public DateTime Deadline { get; set; }

        public int Project_ID {  get; set; }



        public Project Project { get; set; }
    }
}
