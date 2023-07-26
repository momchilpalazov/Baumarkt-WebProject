using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaumarktSystem.Data.Models;


namespace BaumarktSystem.Web.ViewModels.Home
{
    public class ProductIndexViewModel
    {

        public int Id { get; set; } 

        public string Name { get; set; } = null!;

        public string ShortProductDescription { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public decimal Price { get; set; }




        public CategoryIndexViewModel Category { get; set; } = new CategoryIndexViewModel();



        public ApplicationTypeIndexViewModel ApplicationType { get; set; } = new ApplicationTypeIndexViewModel();

        public int CategoryId { get; set; } // Property to store the selected category ID
        public Guid ApplicationTypeId { get; set; }


        public List<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();

        public List<ApplicationTypeViewModel> ApplicationTypes { get; set; } = new List<ApplicationTypeViewModel>();




    }
}
