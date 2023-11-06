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
        // xd phương thức lấy giỏ hàng
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
	private int tongSoLuong()
        {
            int tsl = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                tsl += lstGioHang.Sum(sp => sp.iSoLuong);
            }
            return tsl;
        }
	private double tongThanhTien()
        {
            double ttt = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                ttt += lstGioHang.Sum(sp => sp.dThanhTien);
            }
            return ttt;
        }
 	//xd trang gio hang
        public ActionResult gioHang()
        {
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index1", "Home");
            }
            List<GioHang> lstGioHang = layGioHang();
            ViewBag.tongSoLuong = tongSoLuong();
            ViewBag.tongThanhTien = tongThanhTien();
            return View(lstGioHang);
        }
 	public ActionResult GioHangPartial()
        {
            ViewBag.tongSoLuong = tongSoLuong();

            return PartialView();
        }
 
	}
}
