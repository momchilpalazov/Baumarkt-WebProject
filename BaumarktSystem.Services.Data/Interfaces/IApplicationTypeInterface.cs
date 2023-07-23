using BaumarktSystem.Web.ViewModels.Home;

namespace BaumarktSystem.Services.Data.Interaces
{
    public interface IApplicationTypeInterface
    {
        Task CreateApplicationTypeAsync(ApplicationTypeIndexViewModel applicationType);
        Task DeleteApplicationTypeAsync(ApplicationTypeIndexViewModel applicationType);
        Task EditApplicationTypePostAsync(ApplicationTypeIndexViewModel applicationType);
        Task<IEnumerable<ApplicationTypeIndexViewModel>> GetAllApplicationTypesAsync();
        Task<ApplicationTypeIndexViewModel?> GetApplicationTypeByIdAsync(int id);
        Task<ApplicationTypeIndexViewModel?> GetApplicationTypeDetailsByIdAsync(int id);
    }
}
