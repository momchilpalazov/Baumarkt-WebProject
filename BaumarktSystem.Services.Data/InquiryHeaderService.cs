using BaumarktSystem.Data;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.ViewModels.Inquiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data
{
    public class InquiryHeaderService : IInquiryHeaderInterface
    {

        private readonly BaumarktSystemDbContext dbContext; 

       

        public InquiryHeaderService(BaumarktSystemDbContext dbContext)
        {   this.dbContext = dbContext;
            
        }

        




        public IEnumerable<InquiryViewModel> GetAll()
        {
            var inquiryHeaders = dbContext.InquiryHedaer;
            var inquiryViewModels = new List<InquiryViewModel>();

            foreach (var header in inquiryHeaders)
            {
                var details = dbContext.InquiryDetails.Where(x => x.InquiryHeaderId == header.Id);
                var inquiryViewModel = new InquiryViewModel
                {
                    InquiryHedaer = header,
                    InquiryDetails = details.ToList()
                };
                inquiryViewModels.Add(inquiryViewModel);
            }

            return inquiryViewModels;
        }

    }
}
