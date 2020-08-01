using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCoreL2Services.Domain;

namespace ASPCoreL2Services.Controllers
{
    public class HomeController : Controller
    {
        private L2Context db = new L2Context();
        public IActionResult Index()
        {
            var Items = db.DBEntityBase;
            return View(Items);
        }
        public ContentResult Error1()
        {
            return new ContentResult
            {
                ContentType = "text/html",                
                Content = "<h1>Page is not found!</h1>"
            };
        }
        public IActionResult ServicePage(int item_id)
        {
            var Item = db.DBEntityBase.FirstOrDefault(x => x.Id == item_id);
            if (Item == null)
            {
                return Error1();
            }
            return View(Item);
        }  
    }
}