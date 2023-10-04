using BaumarktSystem.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Web.ViewModels.Order
{
    public class OrderListViewModel
    {


        public IEnumerable<OrderHeader> OrderHeadersList { get; set; }

        public IEnumerable<SelectListItem> StatusList { get; set; }

        public string StatusMessage { get; set; }


    }
}
