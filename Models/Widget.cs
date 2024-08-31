using System.ComponentModel.DataAnnotations;

namespace CustomBlazorInputs.Models
{
    public class Widget
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Option { get; set; }
        [Required]
        public DateTime? CreatedAt { get; set; }
    }
}
