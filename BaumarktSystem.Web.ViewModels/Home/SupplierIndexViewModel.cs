using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Web.ViewModels.Home
{
    public class SupplierIndexViewModel
    {

        public Guid Id { get; set; }


        [Required]
        [StringLength(17, MinimumLength = 15, ErrorMessage = "Phone number must be 15 digits")]
        [RegularExpression(@"^([0-9]+)$", ErrorMessage = "Please enter valid phone number")]
        [Phone]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; } = null!;



    }
}
