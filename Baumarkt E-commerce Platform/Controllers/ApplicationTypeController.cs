using BaumarktSystem.Services.Data.Interaces;
using Microsoft.AspNetCore.Mvc;

namespace Baumarkt_E_commerce_Platform.Controllers
{
    public class ApplicationTypeController : Controller
    {

        private readonly IApplicationTypeInterface applicationTypeInterface;    

        public ApplicationTypeController(IApplicationTypeInterface applicationTypeInterface)
        {
            this.applicationTypeInterface = applicationTypeInterface;
        }       



        public async Task<IActionResult> AllApplicationType()
        {

            var applicationTypes = await this.applicationTypeInterface.GetAllApplicationTypesAsync();

            return this.View(applicationTypes);

            
        }
    }
}
