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
    public class OrderDetailsService: IOrderDetailsInterface
    {

        private readonly BaumarktSystemDbContext dbContext;

        public OrderDetailsService(BaumarktSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(int id)
        {
            var order = dbContext.OrderDetails.Find(id);
            if (order != null)
            {
                dbContext.OrderDetails.Remove(order);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<OrderDetails> GetDetailsByHeaderId(int headerId)
        {

            var orderDetails = dbContext.OrderDetails.Where(x => x.OrderHeaderId == headerId);
            return orderDetails;

            
        }

        




    }
}
