using BaumarktSystem.Data;
using BaumarktSystem.Services.Data.Interfaces;
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
        {
            this.dbContext = dbContext;
        }


    }
}
