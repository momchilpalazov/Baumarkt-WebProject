using BaumarktSystem.Data;
using BaumarktSystem.Common;
using BaumarktSystem.Data.Models;
using static BaumarktSystem.Common.GeneralApplicationConstants;
using BaumarktSystem.Web.Utility;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using BaumarktSystem.Web.ViewModels.ShoppingCart;
using System.Text;
using Microsoft.AspNetCore.Identity.UI.Services;

using Microsoft.EntityFrameworkCore;

namespace Baumarkt_E_commerce_Platform.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {

         

        private readonly BaumarktSystemDbContext dbContext;

        private readonly IWebHostEnvironment  webHostEnvironment;

        private readonly IEmailSender emailSender;






        [BindProperty]
        public ShoppingCartSummaryView? ShoppingCartSummaryView { get; set; }

        private readonly UserSession userSession;

        public ShoppingCartController(UserSession userSession,BaumarktSystemDbContext dbContext,IWebHostEnvironment webHostEnvironment,IEmailSender emailSender  )
        {
            
            this.userSession = userSession;
            this.dbContext = dbContext;
            this.webHostEnvironment = webHostEnvironment;
            this.emailSender = emailSender;
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
            IEnumerable<Product> productsListTemp= dbContext.Product.Where(p => productInCart.Contains(p.Id)).ToList();
            IList<Product> productsList = new List<Product>();

            foreach (var item in cartItemList)
            {

                Product product = productsListTemp.FirstOrDefault(p => p.Id == item.Id);
                product.TempQuantity = item.Quantity;
                productsList.Add(product);

            }
            

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
        public IActionResult ShoppingCartSummary( )
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
       
        [ActionName("Checkout")]

        public async Task< IActionResult> ShoppingCartSummaryPost(ShoppingCartSummaryView ShoppingCartSummaryView)
        {

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);


            var roothToTemplate = webHostEnvironment.WebRootPath + Path.DirectorySeparatorChar.ToString()
                + "templates" + Path.DirectorySeparatorChar.ToString() + "inquiry.html";


            var subject = "New Inquiry";
            string HtmlBody = "";
            using (StreamReader sr = System.IO.File.OpenText(roothToTemplate))
            {
                HtmlBody = sr.ReadToEnd();
            }

            StringBuilder productListSB = new StringBuilder();
            foreach (var item in ShoppingCartSummaryView.ProductsList)
            {
                productListSB.Append($" - Name: {item.FullName} <span style='font-size:14px;'> (ID: {item.Id})</span><br />");
            }

           

            string messageBody = $@"
            {HtmlBody}
            <p>FullName: {ShoppingCartSummaryView.ApplicationUser.FullName}</p>
            <p>Email: {ShoppingCartSummaryView.ApplicationUser.Email}</p>
            <p>PhoneNumber: {ShoppingCartSummaryView.ApplicationUser.PhoneNumber}</p>
            <hr>
            <h3>Products Interested:</h3>
            <p>{productListSB.ToString()}</p>";


            await emailSender.SendEmailAsync(EmeilSender, subject, messageBody);

            //Record User date in the database
            InquiryHedaer inquiryHedaer = new InquiryHedaer()
            {
                ApplicationUserId = Guid.Parse(claim.Value),
                FullName = ShoppingCartSummaryView.ApplicationUser.FullName,
                Email = ShoppingCartSummaryView.ApplicationUser.Email,
                PhoneNumber = ShoppingCartSummaryView.ApplicationUser.PhoneNumber,
                InquiryDate = DateTime.Now,
                
                
            };


            dbContext.InquiryHedaer.Add(inquiryHedaer);
            dbContext.SaveChanges();


           

            foreach (var item in ShoppingCartSummaryView.ProductsList)
            {
                var product = await dbContext.Product.FirstOrDefaultAsync(p => p.Id == item.Id);

                if (product != null)
                {
                    InquiryDetails inquiryDetails = new InquiryDetails()
                    {
                        InquiryHeaderId = inquiryHedaer.Id,
                        ProductId = item.Id,
                    };

                    dbContext.InquiryDetails.Add(inquiryDetails);
                }
            }

            dbContext.SaveChanges();


            
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



            TempData[GeneralApplicationConstants.SuccessMessage] = "Product removed successfully";
            return RedirectToAction("GetCartProducts");


        }


        [HttpPost]
        public IActionResult UpdateCart(List<Product> prodList)
        {

            List<CartItemIndexView> cartItemList = new List<CartItemIndexView>();

            foreach (Product prod in prodList)
            {

                cartItemList.Add(new CartItemIndexView
                {
                    Id = prod.Id,
                    Quantity = prod.TempQuantity

                }); 
            }

            userSession.Set(UserSessionConstantsKey.SessionKey, cartItemList);
            return RedirectToAction(nameof(GetCartProducts));   

        
        }
    }
}
