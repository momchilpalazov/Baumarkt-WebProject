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
            this.Id = Guid.NewGuid();

            this.CartItem = new HashSet<CartItem>();

        }      



            
            [MaxLength(NameMaxLength)]
            [MinLength(NameMinLength)]
            public string? Name { get; set; }


            [MaxLength(AddressMaxLength)]
            [MinLength(AddressMinLength)]
            public string? Address { get; set; }

            [MaxLength(CityMaxLength)]
            [MinLength(CityMinLength)]
            public string? City { get; set; }

            [MaxLength(PostalCodeMaxLength)]
            [MinLength(PostalCodeMinLength)]
            public string? PostalCode { get; set; }

           
           

            public virtual ICollection<CartItem> CartItem { get; set; } = new HashSet<CartItem>();     



    }
}
