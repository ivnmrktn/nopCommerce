using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.Demo.Integration.Controllers;

public class DemoIntegrationController : Controller
{
    // GET
    [AutoValidateAntiforgeryToken]
    [AuthorizeAdmin] //confirms access to the admin panel
    [Area(AreaNames.Admin)] //specifies the area containing a controller or action
    public IActionResult Configure()
    {
        return View();
    }
}