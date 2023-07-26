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


        //public string? Category { get; set; }

        //public string ApplicationType { get; set; } = null!;

        //public List<CategoryIndexViewModel> Category { get; set; } = new List<CategoryIndexViewModel>();

        //public List<ApplicationTypeIndexViewModel> ApplicationType { get; set; } = new List<ApplicationTypeIndexViewModel>();

        public CategoryIndexViewModel Category { get; set; } = new CategoryIndexViewModel();

        public ApplicationTypeIndexViewModel ApplicationType { get; set; } = new ApplicationTypeIndexViewModel();






    }
}
