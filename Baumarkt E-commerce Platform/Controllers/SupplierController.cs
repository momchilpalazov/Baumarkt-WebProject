using BaumarktSystem.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BaumarktSystem.Web.Infrastructure.Extensions;
using BaumarktSystem.Web.ViewModels.Home;

namespace Baumarkt_E_commerce_Platform.Controllers
{

    [Authorize]
    public class SupplierController : Controller
    {

        private readonly ISupplierInterface dealerInterface;

        public SupplierController(ISupplierInterface dealerInterface)
        {
            this.dealerInterface = dealerInterface;
        }


        [HttpGet]
        public async Task<IActionResult> Supplier()
        {


            //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var userId = this.User.GetId();

            var isSupplier = await this.dealerInterface.BeASupplierAsync(Guid.Parse(userId));

            if (isSupplier)
            {
                return View("DealerError", "There was an error processing your request as a dealer.");

            }

            return this.View();



        }


        [HttpPost]
        public async Task<IActionResult> CreateSupplier(SupplierIndexViewModel supplier)
        {
            if (!ModelState.IsValid)
            {
                return this.View(supplier);
            }

            var existDealer = await this.dealerInterface.ExistSupplierByPhoneNumber(supplier.PhoneNumber);

            if (existDealer)
            {
                this.ModelState.AddModelError(nameof(supplier.PhoneNumber), "This phone number is already exist");
                //return this.View(supplier);
            }

            //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var userId = this.User.GetId();

            var isDealer = await this.dealerInterface.BeASupplierAsync(Guid.Parse(userId));

            if (isDealer)
            {
                return this.BadRequest();
            }


            try
            {
                var newSupplier = this.dealerInterface.CreateSupplier(Guid.Parse(userId), supplier);

                if (newSupplier == null)

                {

                    this.ModelState.AddModelError(string.Empty, "Something went wrong");


                }
               
            }
            catch (Exception)
            {

                throw;
                return this.RedirectToAction("Index", "Home");
            }


            return this.RedirectToAction("Index", "Home");
        }

           
        
    }
}
