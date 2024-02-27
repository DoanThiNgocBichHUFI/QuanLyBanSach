using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai1.Models;

namespace bai1.Controllers
{
    public class ChuDeController : Controller
    {
        QLBanSachDataContext db = new QLBanSachDataContext();   
        //
        // GET: /ChuDe/
        public ActionResult ChuDePartial()
        {
            var listCD = db.ChuDes.Take(7).ToList();
            return View(listCD);
        }
        public ActionResult NXBPartial()
        {
            var listNXB = db.NhaXuatBans.Take(7).ToList();
            return View(listNXB);
        }
	}
}