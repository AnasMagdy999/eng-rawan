using System.ComponentModel.DataAnnotations;

namespace AnasMagdy.Models
{
    public class TeamMember
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }


        public ICollection<TASKK> Tasks { get; set; }

    }
}
