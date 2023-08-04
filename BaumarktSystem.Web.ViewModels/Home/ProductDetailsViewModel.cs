using BaumarktSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaumarktSystem.Web.ViewModels.Home
{
    public class ProductDetailsViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; }= null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }= null!;

        public string ShortProductDescription { get; set; }=null!;

        public string Description { get; set; } = null!;

        public int CategoryId { get; set; }

        public int ApplicationTypeId { get; set; }

        public bool IsInCart { get; set; }=false;

        public Category Category { get; set; } = new Category();

        public ApplicationType ApplicationType { get; set; } = new ApplicationType();



    }
}
