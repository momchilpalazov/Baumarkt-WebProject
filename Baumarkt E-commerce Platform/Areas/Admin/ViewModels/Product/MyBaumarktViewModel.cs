using BaumarktSystem.Web.ViewModels.Home;

namespace BaumarktSystem.Areas.Admin.ViewModels.Baumarkt
{
    public class MyBaumarktViewModel
    {

        public IEnumerable<ProductIndexViewModel> FilteredProducts { get; set; } = null!;

        public IEnumerable<ProductIndexViewModel> CreateProduct { get; set; } = null!;

        public IEnumerable<CategoryViewModel> ListCategories { get; set; } = null!;

        public IEnumerable<ApplicationTypeViewModel> ListApplicationTypes { get; set; } = null!;

        public IEnumerable<ProductIndexViewModel> ListProducts { get; set; } = null!;



        public IEnumerable<ProductIndexViewModel> EditProduct { get; set; } = null!;

        public IEnumerable<ProductIndexViewModel> DeleteProduct { get; set; } = null!;

        public IEnumerable<ProductDetailsViewModel> DetailsProduct { get; set; } = null!;

        public IEnumerable<ProductIndexViewModel> AllProducts { get; set; } = null!;




    }
}
