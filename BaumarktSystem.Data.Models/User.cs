using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Data.Models
{
    public class User:IdentityUser<Guid>
    {

           
    
            public string Name { get; set; }=null!;
    
            public string? Email { get; set; }

            [NotMapped]  
            public string Address { get; set; }=null!;
            [NotMapped]
            public string City { get; set; }=null!;
            [NotMapped]
            public string PostalCode { get; set; }=null!;
            [NotMapped]
            public string? PhoneNumber { get; set; }
    
           



    }
}
