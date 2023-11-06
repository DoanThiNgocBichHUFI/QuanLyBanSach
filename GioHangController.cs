using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai1.Models;

namespace bai1.Controllers
{
    public class GioHangController : Controller
    {
        dbQuanLyBanSachDataContext db = new dbQuanLyBanSachDataContext();
        //
        // GET: /GioHang/
        
        public List<GioHang> layGioHang()
        {
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang == null)
            {
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }
        
	}
}
