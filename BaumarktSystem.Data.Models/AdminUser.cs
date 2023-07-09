using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Data.Models
{
    public class AdminUser : ApplicationUser
    {

        public AdminUser()
        {
            this.Id = Guid.NewGuid();            

        }      







    }
}
