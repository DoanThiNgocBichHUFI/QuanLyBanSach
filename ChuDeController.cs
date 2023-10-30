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
        //
        // GET: /ChuDe/
        dbQuanLyBanSachDataContext db = new dbQuanLyBanSachDataContext();
        public ActionResult ChuDePartial()
        {
            var listChuDe = db.ChuDes.Take(7).OrderBy(cd => cd.TenChuDe).ToList();
            return View(listChuDe);
        }
	public ActionResult NXBPartial()
        {
            var listChuDe = db.NhaXuatBans.Take(7).OrderBy(cd => cd.TenNXB).ToList();
            return View(listChuDe);
        }
   }
}
