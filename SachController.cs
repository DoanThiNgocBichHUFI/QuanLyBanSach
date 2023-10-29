using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai1.Models;

namespace bai1.Controllers
{
    public class SachController : Controller
    {
        QLBanSachDataContext db = new QLBanSachDataContext();
        //
        // GET: /Sach/
        public ActionResult AllSach()
        {
            return View(db.Saches.ToList());
        }
        public ActionResult SachTheoChuDe(int MaCD)
        {
            var listSach = db.Saches.Where(s => s.MaChuDe == MaCD).OrderBy(s => s.GiaBan).ToList();
            if(listSach.Count == 0)
            {
                ViewBag.TB = "Ko co sach thuoc chu de nay";
            }
            return View(listSach);
        }
	/*hien thi ten nha xuat ban */
	 public ActionResult SachTheoNXB(int manvxb)
	 {
	     var listSach_nxb = db.Saches.Where(s => s.MaNXB == manvxb).OrderBy(s => s.GiaBan).ToList();
	     if (listSach_nxb.Count == 0)
	     {
	         ViewBag.TB = "Ko co sach thuoc nxb nay";
	     }
	     return View(listSach_nxb);
	 }

     }
}
