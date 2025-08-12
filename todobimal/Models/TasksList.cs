using System.ComponentModel.DataAnnotations;

namespace todobimal.Models
{
    public class TasksList
    {
        [Required]
        [Display(Name ="Task")]
        public string Task {  get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "status")]
        public string Status { get; set; }
    }
}
