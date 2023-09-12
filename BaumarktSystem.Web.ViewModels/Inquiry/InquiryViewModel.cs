using BaumarktSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Web.ViewModels.Inquiry
{
    public class InquiryViewModel
    {

        public InquiryHedaer InquiryHedaer { get; set; }

        public List<InquiryDetails> InquiryDetails { get; set; }

        public List<Product> Products { get; set; }



    }
}
