using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEG.Models;

namespace MVCEG.Controllers
{
    public class DictController : Controller
    {

        public ActionResult ShowDict()
        {
            
            /*
            Dict dict = new Dict()
            {
                Key = "Key1",
                Value = "Value1"
            };
            */

            string requestedKey = Request.QueryString["key"];
            DictContext dictContext = new DictContext();
            Dict oneEntry = dictContext.DictEntries.Single(e => e.Key.Equals(requestedKey));
            return View(oneEntry);
        }

    }
}
