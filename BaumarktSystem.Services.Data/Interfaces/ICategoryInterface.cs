using BaumarktSystem.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data.Interaces
{
    public interface ICategoryInterface
    {
        Task<IEnumerable<CategoryIndexViewModel>> GetAllCategoriesAsync();

        Task<IEnumerable<CategoryIndexViewModel>> CreateCategoryAsync(CategoryIndexViewModel category);

    }
}
