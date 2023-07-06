using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

       



            [Required]
            public string Name { get; set; }=null!;             

             
            public string Address { get; set; }=null!;
            
            public string City { get; set; }=null!;
            
            public string PostalCode { get; set; }=null!;

            public virtual ICollection<CartItem> CartItem { get; set; } = new HashSet<CartItem>();







    }
}
