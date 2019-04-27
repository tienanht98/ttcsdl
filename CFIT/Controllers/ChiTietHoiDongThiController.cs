using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFIT.DAO;
using CFIT.EF;

namespace CFIT.Controllers
{
    public class ChiTietHoiDongThiController : Controller
    {
        // GET: ChiTietHoiDongThi
        public ActionResult Index()
        {
            DBContex db = new DBContex();

            return View(db.TTCSDL_ChiTietHoiDongThi.ToList());
        }
        public ActionResult Create()
        {
            DBContex db = new DBContex();
            List<TTCSDL_NhiemVu> cate = db.TTCSDL_NhiemVu.ToList();
            SelectList NhiemVuList = new SelectList(cate, "IDNhiemVu", "TenNhiemVu");
            ViewBag.NhiemVuList = NhiemVuList;
            List<TTCSDL_GiaoVien> catea = db.TTCSDL_GiaoVien.ToList();
            SelectList GiaoVienList = new SelectList(catea, "IDGiaoVien", "HoTen");
            ViewBag.GiaoVienList = GiaoVienList;
            return View();
        }
        [HttpPost]
        public ActionResult Create(TTCSDL_ChiTietHoiDongThi tTCSDL_ChiTietHoiDongThi)
        {
            tTCSDL_ChiTietHoiDongThi.ID_Hoi_Dong_Thi = 1;
            DBContex db = new DBContex();
            db.TTCSDL_ChiTietHoiDongThi.Add(tTCSDL_ChiTietHoiDongThi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
           
            DBContex db = new DBContex();
            var model = db.TTCSDL_ChiTietHoiDongThi.SingleOrDefault(x => x.IDGiaoVien == id);
            return View(model);
        }
    }
}