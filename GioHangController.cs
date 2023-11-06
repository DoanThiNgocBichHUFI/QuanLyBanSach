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
	public ActionResult ThemGioHang(int ms, string strUrl)
        {
            List<GioHang> lstGioHang = layGioHang();
            GioHang SanPham = lstGioHang.Find(sp => sp.iMaSach == ms);
            if (SanPham == null)
            {
                SanPham = new GioHang(ms);
                lstGioHang.Add(SanPham);
                return Redirect(strUrl);
            }
            else
            {
                SanPham.iSoLuong++;
                return Redirect(strUrl);
            }
        }

 
	}
}
