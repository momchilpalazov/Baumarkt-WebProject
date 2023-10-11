using BaumarktSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data.Interfaces
{
    public interface IOrderDetailsInterface
    {

        IEnumerable<OrderDetails> GetDetailsByHeaderId(int headerId);
        void Delete(int id);
        IEnumerable<OrderDetails> GetDetailsByHeaderId();
        IEnumerable<OrderDetails> GetAll();
    }
}
