using Baumarkt_E_commerce_Platform.Data;
using BaumarktSystem.Common;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.Utility;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Baumarkt_E_commerce_Platform.Controllers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Baumarkt_E_commerce_Platform.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IShoppingCartInterface shoppingCartInterface;  

        private readonly BaumarktSystemDbContext dbContext;

        private readonly UserSession userSession;

        public ShoppingCartController(IShoppingCartInterface shoppingCartInterface,UserSession userSession,BaumarktSystemDbContext dbContext)
        {
            this.shoppingCartInterface = shoppingCartInterface;
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
