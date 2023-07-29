using BaumarktSystem.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data.Interfaces
{
    public interface IProductInterface
    {
        Task CreateProductAsync(ProductIndexViewModel product);
        Task DeleteProductByIdAsync(int id);
        Task<List<ApplicationTypeViewModel>> GetAllApplicationTypesListAsync();
        Task<List<CategoryIndexViewModel>> GetAllFilteredCategoriesAsync();
        Task<List<CategoryViewModel>> GetAllCategoriesListAsync();
       
        Task <IEnumerable <ProductIndexViewModel>> GetAllProductsAsync();
      
        Task <ProductIndexViewModel> GetProductByIdAsync(int id);
        Task<List<ProductIndexViewModel>> GetFilteredProductsAsync(int categoryId);
        Task  EditProductAsync(ProductIndexViewModel model);
    }
}
