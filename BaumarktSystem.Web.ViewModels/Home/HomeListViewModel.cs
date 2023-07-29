using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Web.ViewModels.Home
{
    public class HomeListViewModel
    {

        public IEnumerable<ProductIndexViewModel> Products { get; set; }=new List<ProductIndexViewModel>();

       
        public IEnumerable<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();

    

        public IEnumerable<ApplicationTypeViewModel> ApplicationTypes { get; set; } = new List<ApplicationTypeViewModel>();




    }
}
