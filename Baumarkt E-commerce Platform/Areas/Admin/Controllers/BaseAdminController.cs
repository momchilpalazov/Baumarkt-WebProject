using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BaumarktSystem.Common.GeneralApplicationConstants;

namespace BaumarktSystem.Areas.Admin.Controllers
{
    [Area(AdminAreaName)]
    [Authorize(Roles = roleAdmin)]
    public class BaseAdminController : Controller
    {
        
    }
}
