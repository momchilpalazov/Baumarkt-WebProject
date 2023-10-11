using BaumarktSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Web.ViewModels.Order
{
    public  class OrderViewModel
    {

        public OrderHeader OrderHeader { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }

        public List<Product> Products { get; set; }



    }
}
