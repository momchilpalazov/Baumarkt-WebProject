using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Web.ViewModels.Home
{
    public class ApplicationTypeIndexViewModel
    {

        public int Id { get; set; }

        [Required]         
        public string Name { get; set; }=null!;

        [Required]

        public string Creator { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }


        public List<ApplicationTypeViewModel> ApplicationTypes { get; set; }=new List<ApplicationTypeViewModel>();

    }
}
