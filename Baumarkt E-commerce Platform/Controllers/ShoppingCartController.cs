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
        public ShoppingCartSummaryView ShoppingCartSummaryView { get; set; }

        private readonly UserSession userSession;

        public ShoppingCartController(UserSession userSession,BaumarktSystemDbContext dbContext  )
        {
            
            this.userSession = userSession;
            this.dbContext = dbContext;
        }






        //Your Shoping Cart Check 
        [HttpGet]
        public IActionResult GetCartProducts()
        {


            List<CartItem> cartItemList = new List<CartItem>();

            if (userSession.Get<IEnumerable<CartItem>>(UserSessionConstantsKey.SessionKey) != null
                && userSession.Get<IEnumerable<CartItem>>(UserSessionConstantsKey.SessionKey).Count() > 0)
            {
                cartItemList = userSession.Get<IEnumerable<CartItem>>(UserSessionConstantsKey.SessionKey).ToList();


            }

            List<int> productInCart= cartItemList.Select(p => p.Id).ToList(); 
            IEnumerable<Product> productsList= dbContext.Product.Where(p => productInCart.Contains(p.Id)).ToList();


            return View(productsList);



        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult GetCartProductsPost()
        {





            return RedirectToAction(nameof(ShoppingCartSummary));


        }

        //Checkout
        [HttpGet]
        public IActionResult ShoppingCartSummary()
        {

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
           // var userId= User.FindFirstValue(ClaimTypes.NameIdentifier);

            List<CartItem> cartItemList = new List<CartItem>();

            if (claim != null) 
            {
                if (userSession.Get<IEnumerable<CartItem>>(UserSessionConstantsKey.SessionKey) != null
                                   && userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).Count() > 0)
                {
                    cartItemList = userSession.Get<IEnumerable<CartItem>>(UserSessionConstantsKey.SessionKey).ToList();
                }
            
            
            }

            List<int> productInCart = cartItemList.Select(p => p.Id).ToList();
            IEnumerable<Product> productsList = dbContext.Product.Where(p => productInCart.Contains(p.Id)).ToList();


            ShoppingCartSummaryView = new ShoppingCartSummaryView()
            {
                ApplicationUser = dbContext.ApplicationUser.FirstOrDefault(p => p.Id ==Guid.Parse (claim.Value)),
                ProductsList = productsList.ToList()
            };


            return View(ShoppingCartSummaryView);


        }


        //checkout


        [HttpPost]
       // [ActionName("ShoppingCartSummaryPost")]

        public IActionResult ShoppingCartSummaryPost(ShoppingCartSummaryView ShoppingCartSummaryView)
        {




            return RedirectToAction(nameof(InquiryConfirm));


        }

        public IActionResult InquiryConfirm()
        {

            userSession.Clear();

           return View();



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
