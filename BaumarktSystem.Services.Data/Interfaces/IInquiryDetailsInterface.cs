using BaumarktSystem.Data.Models;
using BaumarktSystem.Web.ViewModels.Inquiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data.Interfaces
{
    public interface IInquiryDetailsInterface
    {
        IEnumerable<InquiryViewModel> GetInquiryDetails(int id);

        IEnumerable<InquiryDetails> GetDetailsByHeaderId(int headerId);


    }
}
