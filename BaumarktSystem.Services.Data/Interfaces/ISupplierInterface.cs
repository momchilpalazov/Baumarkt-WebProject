using BaumarktSystem.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data.Interfaces
{
    public interface ISupplierInterface
    {
        Task<bool> BeASupplierAsync(Guid userId);


        Task<bool> ExistSupplierByPhoneNumber(string phoneNumber);


        Task  CreateSupplier(Guid userId, SupplierIndexViewModel supplier);
    }
}
