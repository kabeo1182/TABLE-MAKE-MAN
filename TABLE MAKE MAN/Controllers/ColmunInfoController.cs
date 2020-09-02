using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TABLE_MAKE_MAN.Models;

namespace TABLE_MAKE_MAN.Controllers
{
    public class ColmunInfoController : Controller
    {
        // GET: ColmunInfo
        public ActionResult ColumnInfo(ColumnInfoModel model)
        {
            return View(model);
        }
    }
}