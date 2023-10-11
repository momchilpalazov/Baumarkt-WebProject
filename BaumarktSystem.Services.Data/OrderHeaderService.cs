using BaumarktSystem.Data;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data
{
    public class OrderHeaderService: IOrderHeaderInterface
    {

        private readonly BaumarktSystemDbContext dbContext;

        public OrderHeaderService(BaumarktSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<OrderHeader> GetAll()
        {

            var orderHeaders = dbContext.OrderHeader;
            return orderHeaders;


            
        }

        

        IEnumerable<OrderHeader> IOrderHeaderInterface.GetById(int id)
        {

            var orderHeader = dbContext.OrderHeader.Where(x => x.Id == id);
            if (orderHeader == null) 
            {
                return null;
            
            }

            return orderHeader;


            
        }
    }
}
