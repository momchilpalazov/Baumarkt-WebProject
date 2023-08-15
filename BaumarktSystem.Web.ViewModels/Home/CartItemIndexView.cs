using BaumarktSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Web.ViewModels.Home
{
    public class CartItemIndexView
    {


    



        public int Id { get; set; }     
        



      

        public ICollection<ProductIndexViewModel> Products { get; set; } = new HashSet<ProductIndexViewModel>();


    }
}
