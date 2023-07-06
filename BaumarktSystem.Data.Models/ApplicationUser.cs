using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaumarktSystem.Common.EntityValidationConstanst.ApplicationUser;

namespace BaumarktSystem.Data.Models
{
    //this is custum user class work with default ASP.NET Core Identity
    public class ApplicationUser:IdentityUser<Guid>
    {

        public ApplicationUser()
        {            

            this.CartItem = new HashSet<CartItem>();

        }      



            [Required]
            [MaxLength(NameMaxLength)]
            [MinLength(NameMinLength)]
            public string Name { get; set; }=null!;


            [MaxLength(AddressMaxLength)]
            [MinLength(AddressMinLength)]
            public string Address { get; set; }=null!;

            [MaxLength(CityMaxLength)]
            [MinLength(CityMinLength)]
            public string City { get; set; }=null!;

            [MaxLength(PostalCodeMaxLength)]
            [MinLength(PostalCodeMinLength)]
            public string PostalCode { get; set; }=null!;

            [Required(ErrorMessage = "The Role field is required.")]
            [MaxLength(RoleMaxLength)]
            [MinLength(RoleMinLength)]
            public string Role { get; set; } = null!;            

            public virtual ICollection<CartItem> CartItem { get; set; } = new HashSet<CartItem>();     



    }
}
