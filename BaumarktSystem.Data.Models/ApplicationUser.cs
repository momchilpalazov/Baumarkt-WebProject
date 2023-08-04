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

            this.Products = new HashSet<Product>();

        }





        [MaxLength(NameMaxLength)]
        [MinLength(NameMinLength)]
        public string? FullName { get; set; } 


       

           
           

            public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        
    }
}
