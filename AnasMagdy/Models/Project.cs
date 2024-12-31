using System.ComponentModel.DataAnnotations;

namespace AnasMagdy.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        

        public ICollection<TASKK> Tasks { get; set; }

    }
}
