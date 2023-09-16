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
using BaumarktSystem.Services.Data.Interfaces;
using Braintree;
using Baumarkt_E_commerce_Platform.Utility.BrainTree;

namespace Baumarkt_E_commerce_Platform.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {

         

        private readonly BaumarktSystemDbContext dbContext;

        private readonly IWebHostEnvironment  webHostEnvironment;

        private readonly IEmailSender emailSender;

        private readonly IOrderHeaderInterface orderHeaderInterface;

        private readonly IOrderDetailsInterface orderDetailsInterface;

        private readonly IBrainTreeGateInterface brainTreeGateInterface;






        [BindProperty]
        public ShoppingCartSummaryView? ShoppingCartSummaryView { get; set; }

        private readonly UserSession userSession;

        public ShoppingCartController(UserSession userSession,BaumarktSystemDbContext dbContext,IWebHostEnvironment webHostEnvironment,
            IEmailSender emailSender,IOrderDetailsInterface orderDetails,IOrderHeaderInterface orderHeader,IBrainTreeGateInterface brainTreeGateInterface  )
        {
            
            this.userSession = userSession;
            this.dbContext = dbContext;
            this.webHostEnvironment = webHostEnvironment;
            this.emailSender = emailSender;
            this.orderHeaderInterface = orderHeader;
            this.orderDetailsInterface = orderDetails;
            this.brainTreeGateInterface = brainTreeGateInterface;
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
        public IActionResult GetCartProductsPost(IEnumerable<Product> prodList)
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



            return RedirectToAction(nameof(ShoppingCartSummary));


        }

        //Checkout
        [HttpGet]
        public IActionResult ShoppingCartSummary( )
        {

            ApplicationUser applicationUser;

            if (User.IsInRole(roleAdmin))
            {

                if (userSession.Get<int>(SessionInquiryId)!=0)
                {
                    InquiryHedaer inquiryHedaer = dbContext.InquiryHedaer.FirstOrDefault(p => p.Id == userSession.Get<int>(SessionInquiryId));
                    applicationUser = new ApplicationUser()
                    {
                        FullName = inquiryHedaer.FullName,
                        Email = inquiryHedaer.Email,
                        PhoneNumber = inquiryHedaer.PhoneNumber
                    };

                }
                else
                {
                    applicationUser = new ApplicationUser();
                }

                var gateway = brainTreeGateInterface.GetGateway();
                var clientToken = gateway.ClientToken.Generate();
                ViewBag.ClientToken = clientToken;
               
            }


            else
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                // var userId= User.FindFirstValue(ClaimTypes.NameIdentifier);

                applicationUser = dbContext.ApplicationUser.FirstOrDefault(p => p.Id == Guid.Parse(claim.Value));

            }           


            List<CartItem> cartItemList = new List<CartItem>();           
            
           if (userSession.Get<IEnumerable<CartItem>>(UserSessionConstantsKey.SessionKey) != null
                                   && userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).Count() > 0)
           {
                 cartItemList = userSession.Get<IEnumerable<CartItem>>(UserSessionConstantsKey.SessionKey).ToList();
           }
            
            
            

            List<int> productInCart = cartItemList.Select(p => p.Id).ToList();
            IEnumerable<Product> productsList = dbContext.Product.Where(p => productInCart.Contains(p.Id)).ToList();


            ShoppingCartSummaryView = new ShoppingCartSummaryView()
            {
                ApplicationUser = applicationUser,
                //ProductsList = productsList.ToList()
            };

            foreach (var item in cartItemList)
            {

                Product product = productsList.FirstOrDefault(p => p.Id == item.Id);
                product.TempQuantity = item.Quantity;
                ShoppingCartSummaryView.ProductsList.Add(product);
                

               
            }



            

            return View(ShoppingCartSummaryView);


        }

       


        //checkout


        [HttpPost]      
       
        public async Task< IActionResult> ShoppingCartSummaryPost(IFormCollection collection , ShoppingCartSummaryView ShoppingCartSummaryView)
        {


            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(ShoppingCartSummary));
            }


            if (User.IsInRole(roleAdmin))
            {
                //need to create order

                OrderHeader orderHeader = new OrderHeader()
                {

                    CreatedByUserId = Guid.Parse(claim.Value),
                    FinalOrderTotal = (double)ShoppingCartSummaryView.ProductsList.Sum(p => p.TempQuantity * p.Price),
                    City = ShoppingCartSummaryView.ApplicationUser.City,
                    StreetAddress = ShoppingCartSummaryView.ApplicationUser.StreetAddress,
                    State = ShoppingCartSummaryView.ApplicationUser.State,
                    PostalCode = ShoppingCartSummaryView.ApplicationUser.PostalCode,
                    FullName = ShoppingCartSummaryView.ApplicationUser.FullName,
                    Email = ShoppingCartSummaryView.ApplicationUser.Email,
                    PhoneNumber = ShoppingCartSummaryView.ApplicationUser.PhoneNumber,
                    TransactionId = Guid.NewGuid().ToString(),
                    OrderDate = DateTime.Now,
                    OrderStatus = StatusPending,

                };

                dbContext.OrderHeader.Add(orderHeader);
                dbContext.SaveChanges();


                foreach (var item in ShoppingCartSummaryView.ProductsList)
                {
                    var product = await dbContext.Product.FirstOrDefaultAsync(p => p.Id == item.Id);

                    if (product != null)
                    {
                        OrderDetails orderDetails = new OrderDetails()
                        {
                            OrderHeaderId = orderHeader.Id,
                            PricePerTempQuantity = (double)item.Price,
                            TempQuantity = item.TempQuantity,
                            ProductId = item.Id,
                        };

                        dbContext.OrderDetails.Add(orderDetails);
                    }
                }

                dbContext.SaveChanges();

                string nonceFromTheClient = collection["payment_method_nonce"];


                var request = new TransactionRequest
                {
                    Amount = Convert.ToDecimal(orderHeader.FinalOrderTotal),
                    PaymentMethodNonce = nonceFromTheClient,
                    OrderId=orderHeader.Id.ToString(),
                    Options = new TransactionOptionsRequest
                    {
                        SubmitForSettlement = true
                    }
                };

                var gateway = brainTreeGateInterface.GetGateway();
                Result<Transaction> result = gateway.Transaction.Sale(request);

                if (result.Target.ProcessorResponseText == "Approved")
                {
                    orderHeader.TransactionId = result.Target.Id;
                    orderHeader.OrderStatus = StatusApproved;
                }
                else
                {
                    orderHeader.OrderStatus = StatusCancelled;
                }

                dbContext.SaveChanges();

                return RedirectToAction(nameof(InquiryConfirm), new {id=orderHeader.Id});

            }
            else
            {
                //need to create inquiry
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
                TempData[GeneralApplicationConstants.SuccessMessage] = "Inquiry Created Successfully";
            }

            
            return RedirectToAction(nameof(InquiryConfirm));


        }

        public IActionResult InquiryConfirm(int id=0)
        {

            OrderHeader orderHeader = dbContext.OrderHeader.FirstOrDefault(p => p.Id == id);
            userSession.Clear();
            return View(orderHeader);



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


        [HttpPost]
        public IActionResult Clear()
        {

            userSession.Clear();
            return RedirectToAction("Index","Home");
        }
    }
}
