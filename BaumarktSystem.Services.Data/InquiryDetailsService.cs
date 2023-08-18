using BaumarktSystem.Data;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.ViewModels.Inquiry;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data
{
    public class InquiryDetailsService: IInquiryDetailsInterface
    {

        private readonly BaumarktSystemDbContext dbContext;

        public InquiryDetailsService(BaumarktSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<InquiryDetails> GetDetailsByHeaderId(int headerId)
        {

            var inquiryDetails = dbContext.InquiryDetails.Where(x => x.InquiryHeaderId == headerId);
            return inquiryDetails;

            
        }

        //public IEnumerable<InquiryViewModel> GetAll(int id)
        //{

        //    //var inquiryDetails = dbContext.InquiryDetails;
        //    //var inquiryViewModels = new List<InquiryViewModel>();

        //    //foreach (var detail in inquiryDetails)
        //    //{
        //    //    var header = dbContext.InquiryHedaer.Where(x => x.Id == detail.InquiryHeaderId).FirstOrDefault();
        //    //    var inquiryViewModel = new InquiryViewModel
        //    //    {
        //    //        InquiryHedaer = header,
        //    //        InquiryDetails = inquiryDetails.ToList()
        //    //    };
        //    //    inquiryViewModels.Add(inquiryViewModel);
        //    //}

        //    //return inquiryViewModels;


        //}




        public IEnumerable<InquiryViewModel> GetInquiryDetails(int id)
        {

            //var inquiryDetails = dbContext.InquiryDetails.Where(x => x.InquiryHeaderId == id);

             var inquiryDetails = dbContext.InquiryDetails
                .Include(d => d.Product) // Include Product data
                .Where(x => x.InquiryHeaderId == id)
                .ToList();
            var inquiryViewModels = new List<InquiryViewModel>();

            foreach (var detail in inquiryDetails)
            {
                var header = dbContext.InquiryHedaer.Where(x => x.Id == detail.InquiryHeaderId).FirstOrDefault();
                var inquiryViewModel = new InquiryViewModel
                {
                    InquiryHedaer = header,
                    InquiryDetails = inquiryDetails.ToList()
                };
                inquiryViewModels.Add(inquiryViewModel);
            }

            return inquiryViewModels;


            
        }


        
    }
}

