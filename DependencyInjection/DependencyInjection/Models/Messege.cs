using System.ComponentModel.DataAnnotations;

namespace DependencyInjection.Models
{
    public class Messege
    {
        public int Id { get; set; }
        [Display(Name = "Sender Name")]
        [Required(ErrorMessage = "Sender name is required.")]
        public string SenderName { get; set; }
        [Required(ErrorMessage = "Content is required.")]
        public string Content { get; set; }
    }
}
