using BaumarktSystem.Web.ViewModels.Home;

namespace BaumarktSystem.Services.Data.Interaces
{
    public interface IApplicationTypeInterface
    {
        Task<IEnumerable<ApplicationTypeIndexViewModel>> CreateApplicationTypeAsync(ApplicationTypeIndexViewModel applicationType);
        Task<IEnumerable<ApplicationTypeIndexViewModel>> GetAllApplicationTypesAsync();
    }
}
