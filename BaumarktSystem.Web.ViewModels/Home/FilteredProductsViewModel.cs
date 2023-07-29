using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Web.ViewModels.Home
{
    public class FilteredProductsViewModel
    {

        public int? CategoryId { get; set; }
        public List<ProductIndexViewModel> FilteredProducts { get; set; }=new List<ProductIndexViewModel>();
        public List<CategoryIndexViewModel> AllCategories { get; set; } = new List<CategoryIndexViewModel>();




    }
}
