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
        Task <IEnumerable<ProductIndexViewModel>>  CreateProductAsync(ProductIndexViewModel product);
        Task<List<ApplicationTypeViewModel>> GetAllApplicationTypesListAsync();
        Task<List<CategoryViewModel>> GetAllCategoriesListAsync();
        Task <IEnumerable <ProductIndexViewModel>> GetAllProductsAsync();
        Task GetCategoriesAndApplicationTypeListAsync();
    }
}
