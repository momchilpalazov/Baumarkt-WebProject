
using System.ComponentModel.DataAnnotations;
using static BaumarktSystem.Common.ViewModelValidationConstants.Category;

namespace BaumarktSystem.Web.ViewModels.Home
{
    public class CategoryIndexViewModel
    {

        public int Id { get; set; }



        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }=null!;

        [Required]
        [Display(Name = "Show Order")]
        [Range(1, int.MaxValue, ErrorMessage = "Order for category must be greater than 0")]
        public int ShowOrder { get; set; }


        [Required]
        public string Creator { get; set; } = null!; 

        [Required]
        public DateTime CreatedOn { get; set; }


    }
}
