using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class BasicFormModel
    {
        [Required]
        [StringLength(15,ErrorMessage ="Shorten this")]
        public string jobTitle { get; set; }
        [Required]
        public string jobDescription { get; set; }
        [Required]
        public DateTime dateOfPosting { get; set; }
        [Required]
        public bool currentlyEmploed { get; set; }
        [Required]
        [Range(typeof(decimal),"1","200")]
        public decimal yearOfExperience { get; set; }
        [Required]
        public string levelOfExperience { get; set; }
    }
}
