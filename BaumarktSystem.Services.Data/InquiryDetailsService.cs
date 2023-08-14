using BaumarktSystem.Data;
using BaumarktSystem.Services.Data.Interfaces;
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



    }
}
