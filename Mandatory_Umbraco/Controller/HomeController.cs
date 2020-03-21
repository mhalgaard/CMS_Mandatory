using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;

namespace Mandatory_Umbraco.Controller
{
    public class HomeController : Umbraco.Web.Mvc.RenderMvcController
    {
        public override ActionResult Index(ContentModel model)
        {
            return base.Index(model);
        }
    }
}