using BaumarktSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data.Interfaces
{
    public interface IOrderHeaderInterface
    {

        IEnumerable<OrderHeader> GetAll();
        IEnumerable<OrderHeader> GetById(int id);
    }
}
