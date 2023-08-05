using BaumarktSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Web.ViewModels.ShoppingCart
{
    public class ShoppingCartSummaryView
    {

        public ShoppingCartSummaryView()
        {
            ProductsList = new List<Product>();

            ApplicationUser = new ApplicationUser();

        }



        public ApplicationUser ApplicationUser { get; set; }=new ApplicationUser();

        public IEnumerable<Product> ProductsList { get; set; }=new List<Product>();



    }
}
