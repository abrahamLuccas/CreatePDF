using System.ComponentModel.DataAnnotations;

namespace CreatePDF.Models
{
    public class Supplier
    {
        public Guid Id { get; set; }
        
        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        
        [Required]
        public string TradeName { get; set; }


        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
