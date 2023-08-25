using BaumarktSystem.Common;
using BaumarktSystem.Services.Data.Interaces;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BaumarktSystem.Common.GeneralApplicationConstants;
namespace Baumarkt_E_commerce_Platform.Controllers
{
    [Authorize(Roles = roleAdmin)]
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
                TempData[GeneralApplicationConstants.ErrorMessage] = "Application Type Not Created Successfully";                
                return this.View(applicationType);
            }

            await this.applicationTypeInterface.CreateApplicationTypeAsync(applicationType);
            TempData[GeneralApplicationConstants.SuccessMessage] = "Application Type Created Successfully";


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
                TempData[GeneralApplicationConstants.ErrorMessage] = "Application Type Not Edited Successfully";
                return this.View(applicationType);
            }

            await this.applicationTypeInterface.EditApplicationTypePostAsync(applicationType);
            TempData[GeneralApplicationConstants.SuccessMessage] = "Application Type Edited Successfully";

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
            

            await this.applicationTypeInterface.DeleteApplicationTypeAsync(applicationType);
            TempData[GeneralApplicationConstants.SuccessMessage] = "Application Type Deleted Successfully";

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
