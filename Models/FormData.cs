using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithValidation.Models
{
    public class FormData
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Language { get; set; }
        public string Comment { get; set; }
    }
}