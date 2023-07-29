using BaumarktSystem.Services.Data.Interaces;
using BaumarktSystem.Web.ViewModels.Home;
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

        [HttpGet]
        public IActionResult CreateApplicationType()
        {
            return this.View();
        }


        [HttpPost]

        public async Task<IActionResult> CreateApplicationType(ApplicationTypeIndexViewModel applicationType)
        {
            if (this.ModelState.IsValid)
            {
                return this.View(applicationType);
            }

            await this.applicationTypeInterface.CreateApplicationTypeAsync(applicationType);

            return this.RedirectToAction("AllApplicationType");
        }


        [HttpGet]

        public async Task<IActionResult> EditApplicationType(int id)
        {
            var applicationType = await this.applicationTypeInterface.GetApplicationTypeByIdAsync(id);

            return this.View(applicationType);
        }

        [HttpPost]

        public async Task<IActionResult> EditApplicationType(ApplicationTypeIndexViewModel applicationType)
        {
            if (this.ModelState.IsValid)
            {
                return this.View(applicationType);
            }

            await this.applicationTypeInterface.EditApplicationTypePostAsync(applicationType);

            return this.RedirectToAction("AllApplicationType");
        }


        [HttpGet]

        public async Task<IActionResult> DeleteApplicationType(int id)
        {
            var applicationType = await this.applicationTypeInterface.GetApplicationTypeByIdAsync(id);

            return this.View(applicationType);
        }

        [HttpPost]

        public async Task<IActionResult> DeleteApplicationType(ApplicationTypeIndexViewModel applicationType)
        {
            if (this.ModelState.IsValid)
            {
                return this.View(applicationType);
            }

            await this.applicationTypeInterface.DeleteApplicationTypeAsync(applicationType);

            return this.RedirectToAction("AllApplicationType");
        }


        [HttpGet]

        public async Task<IActionResult> DetailsApplicationType(int id)
        {
            var applicationType = await this.applicationTypeInterface.GetApplicationTypeDetailsByIdAsync(id);

            return this.View(applicationType);
        }




    }
}
