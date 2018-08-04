using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidation.Models
{
    public class FormData
    {
        [Required(ErrorMessage = "Name Field Required")]
        [MinLength(2)]
        [MaxLength(15)]
        [Display(Name = "Your Name:")]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string Language { get; set; }
        
        [MinLength(8)]
        [MaxLength(30)]
        public string Comment { get; set; }
    }
}