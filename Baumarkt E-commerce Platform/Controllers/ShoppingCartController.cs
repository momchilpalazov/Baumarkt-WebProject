using BaumarktSystem.Data;
using BaumarktSystem.Common;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.Utility;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Baumarkt_E_commerce_Platform.Controllers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using BaumarktSystem.Web.ViewModels.ShoppingCart;

namespace Baumarkt_E_commerce_Platform.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {

         

        private readonly BaumarktSystemDbContext dbContext;

        [BindProperty]
        public ShoppingCartSummaryView ShoppingCartSummaryView { get; private set; }

        private readonly UserSession userSession;

        public ShoppingCartController(UserSession userSession,BaumarktSystemDbContext dbContext )
        {
            
            this.userSession = userSession;
            this.dbContext = dbContext;
        }







        [HttpGet]
        public IActionResult GetCartProducts()
        {


            List<CartItemIndexView> cartItemList = new List<CartItemIndexView>();

            if (userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey) != null
                && userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).Count() > 0)
            {
                cartItemList = userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).ToList();


            }

            List<int> productInCart= cartItemList.Select(p => p.Id).ToList(); 
            IEnumerable<Product> productsList= dbContext.Product.Where(p => productInCart.Contains(p.Id)).ToList();


            return View(productsList);



        }


        [HttpPost]
        public IActionResult GetCartProductsPost()
        {





            return RedirectToAction(nameof(ShoppingCartSummary));


        }


        [HttpGet]
        public IActionResult ShoppingCartSummary()
        {

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
           // var userId= User.FindFirstValue(ClaimTypes.NameIdentifier);

            List<CartItemIndexView> cartItemList = new List<CartItemIndexView>();

            if (claim != null) 
            {
                if (userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey) != null
                                   && userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).Count() > 0)
                {
                    cartItemList = userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).ToList();
                }
            
            
            }


            ShoppingCartSummaryView = new ShoppingCartSummaryView()
            {
                ApplicationUser = dbContext.ApplicationUser.FirstOrDefault(p => p.Id ==Guid.Parse (claim.Value)),
                ProductsList = dbContext.Product.Where(p => cartItemList.Select(p => p.Id).Contains(p.Id)).ToList()
            };


            return View(ShoppingCartSummaryView);






        }










        [HttpPost]
        public IActionResult RemoveCartProducts(int id)
        {


            List<CartItemIndexView> cartItemList = new List<CartItemIndexView>();

            if (userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey) != null
                && userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).Count() > 0)
            {
                cartItemList = userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).ToList();


            }


            cartItemList.Remove(cartItemList.FirstOrDefault(p => p.Id == id));
            userSession.Set(UserSessionConstantsKey.SessionKey, cartItemList);


           

            return RedirectToAction("GetCartProducts");



        }
    }
}
