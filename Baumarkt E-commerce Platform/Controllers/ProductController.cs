using BaumarktSystem.Common;

using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.Utility;
using BaumarktSystem.Web.ViewModels.Home;
using static BaumarktSystem.Common.GeneralApplicationConstants;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace Baumarkt_E_commerce_Platform.Controllers
{
    [Authorize(Roles = roleAdmin)]
    public class ProductController : Controller
    {


        private readonly IProductInterface productInterface;

        private readonly IWebHostEnvironment hostingEnvironment;        

        private readonly UserSession userSession;


        private  bool IsInCart = false;





        public ProductController(IProductInterface productInterface, IWebHostEnvironment hostingEnvironment,  UserSession userSession)
        {
            this.productInterface = productInterface;
            this.hostingEnvironment = hostingEnvironment;
           
            this.userSession = userSession;
            
        }

        [HttpGet]
        public async Task<IActionResult> AllProducts()
        {

            var products = await this.productInterface.GetAllProductsAsync();

            return this.View(products);



        }

        [HttpGet]

        public async Task<IActionResult> Create()
        {
            var model = new ProductIndexViewModel
            {
                Categories = await this.productInterface.GetAllCategoriesListAsync(),
                ApplicationTypes = await this.productInterface.GetAllApplicationTypesListAsync()
            };

            return this.View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Create(ProductIndexViewModel model,IFormFile image  )
        {
            if (this.ModelState.IsValid)
            {

                TempData[GeneralApplicationConstants.ErrorMessage] = "Product Not Created Successfully";
                return this.View(model);

            }
            model.Categories = await this.productInterface.GetAllCategoriesListAsync();
            model.ApplicationTypes = await this.productInterface.GetAllApplicationTypesListAsync();
            model.ImageUrl = await this.SaveImageAsync(image);
            await this.productInterface.CreateProductAsync(model);
            TempData[GeneralApplicationConstants.SuccessMessage] = "Product Created Successfully";
            return this.RedirectToAction("AllProducts");        


        }

        [HttpGet]
        public async Task<IActionResult> EditProduct(int id)
        {
            var product = await this.productInterface.GetProductByIdAsync(id);

            if (product == null)
            {
                return this.NotFound();
            }

            
            return this.View(product);
        }


        [HttpPost]

        public async Task<IActionResult> EditProduct(ProductIndexViewModel model, IFormFile image)
        {
            if (this.ModelState.IsValid)
            {

                TempData[GeneralApplicationConstants.ErrorMessage] = "Product Not Edited Successfully"; 
                return this.View(model);

            }

            model.Categories = await this.productInterface.GetAllCategoriesListAsync();
            model.ApplicationTypes = await this.productInterface.GetAllApplicationTypesListAsync();
            model.ImageUrl = await this.SaveImageAsync(image);
            await this.productInterface.EditProductAsync(model);
            TempData[GeneralApplicationConstants.SuccessMessage] = "Product Edited Successfully";

            return this.RedirectToAction("AllProducts");
        }


        [HttpGet]

        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await this.productInterface.GetProductByIdAsync(id);

            if (product == null)
            {
                return this.NotFound();
            }

            return this.View(product);
        }

        [HttpPost]

        public async  Task<IActionResult> DeleteProducts(int id)
        {

            await this.productInterface.DeleteProductByIdAsync(id);
            TempData[GeneralApplicationConstants.SuccessMessage] = "Product Deleted Successfully";
            return this.RedirectToAction("AllProducts");
            
        }



        [HttpGet]
        [AllowAnonymous]
        [Authorize(Roles = roleCustomer)]
        public async Task<IActionResult> Details(int id)
        {


            List<CartItemIndexView> cartItemList = new List<CartItemIndexView>();

            if (userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey) != null
                && userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).Count() > 0) 
            {
                cartItemList = userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).ToList();

            }


            var product = await productInterface.GetProductDetailsByIdAsync(id);


            if (product == null)
            {
                return this.NotFound();
            }


            if (cartItemList.Count() > 0)
            {
                foreach (var item in cartItemList)
                {
                    if (item.Id == id)
                    {
                        product.IsInCart = true;
                    }
                }
            }



            return this.View(product);
        }




        [HttpPost,ActionName("AddTocart")]
        [AllowAnonymous]
        [Authorize(Roles = roleCustomer)]
        public async Task<IActionResult> DetailsPost(int Id,ProductDetailsViewModel productDetails)
        {

            if (Id == 0)
            {
                TempData[GeneralApplicationConstants.ErrorMessage] = "Product Not Added To Cart Successfully";
                return this.NotFound();
            }

            List<CartItemIndexView> cartItemList=new List<CartItemIndexView>();

            if (userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey) != null 
                && userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).Count()>0  )
            {
                cartItemList = userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).ToList();


            }

            cartItemList.Add(new CartItemIndexView { Id = Id,Quantity=productDetails.Product.TempQuantity});
            userSession.Set<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey, cartItemList);
            TempData[GeneralApplicationConstants.SuccessMessage] = "Product Added To Cart Successfully";
            return RedirectToAction("Index", "Home");




        }


        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int Id)
        {

            if (Id == 0)
            {
                TempData[GeneralApplicationConstants.ErrorMessage] = "Product Not Removed From Cart Successfully";
                return this.NotFound();
            }




            List<CartItemIndexView> cartItemList = new List<CartItemIndexView>();

            if (userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey) != null
                && userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).Count() > 0)
            {
                cartItemList = userSession.Get<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey).ToList();

            }


            var removeItem= cartItemList.SingleOrDefault(x => x.Id == Id);

            if (removeItem != null)
            {
                cartItemList.Remove(removeItem);
            }
           
            userSession.Set<IEnumerable<CartItemIndexView>>(UserSessionConstantsKey.SessionKey, cartItemList);
            TempData[GeneralApplicationConstants.SuccessMessage] = "Product Removed From Cart Successfully";
            return RedirectToAction("Index", "Home");

        }







        //Image Upload Method
        private Task<string> SaveImageAsync(IFormFile image)
        {
            string uploadsFolder = Path.Combine(this.hostingEnvironment.WebRootPath, "images");

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            if (image != null&& image.Length>0)
            {

                try
                {
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        image.CopyTo(fileStream);
                    }

                    return Task.FromResult(uniqueFileName);
                }
                catch (Exception)
                {

                    throw;
                }

               
            }

            return Task.FromResult(string.Empty);

           
        }


       


    }


    
}
