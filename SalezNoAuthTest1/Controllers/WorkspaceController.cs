using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalezNoAuthTest1.Data;

namespace SalezNoAuthTest1.Controllers
{
    public class WorkspaceController : Controller
    {
        public IActionResult Index()
        {
            WatsonContext context = HttpContext.RequestServices.GetService(typeof(SalezNoAuthTest1.Data.WatsonContext)) as WatsonContext;

            return View(context.GetAllWorkspaces());
        }
    }
}