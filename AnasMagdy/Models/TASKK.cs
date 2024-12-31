using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnasMagdy.Models
{ 
    public class TASKK
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Priorty { get; set; }
        public DateTime Deadline { get; set; }


        public int ProjectID { get; set; }

        [ForeignKey("ProjectID")]
        public Project Project { get; set; }
        public int TeamMemberID { get; set; }
        [ForeignKey("TeamMemberID")]
        public TeamMember TeamMember { get; set; }
    }
}
