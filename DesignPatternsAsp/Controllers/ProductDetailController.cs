using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Earn;

namespace DesignPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index()
        {
            LocalEarn localEarnFactory = new LocalEarn(0.20m);
            
            
            return View();
        }
    }
}
