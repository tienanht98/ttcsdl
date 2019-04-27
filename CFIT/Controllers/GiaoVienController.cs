using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFIT.DAO;
using CFIT.EF;

namespace CFIT.Controllers
{
    public class GiaoVienController : Controller
    {
        // GET: GiaoVien
        public ActionResult Index()
        {
            GiaoVienDAO giaovien = new GiaoVienDAO();

            return View(giaovien.getALL());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(TTCSDL_GiaoVien tTCSDL_GiaoVien)
        {
            if (ModelState.IsValid)
            {
                GiaoVienDAO giaoVien = new GiaoVienDAO();
                giaoVien.Insert(tTCSDL_GiaoVien);
            }
            else
            {
                ModelState.AddModelError("", " không thành công");

            }

            return View();
        }
        public ActionResult Edit(int id)
        {
            GiaoVienDAO giaoVien = new GiaoVienDAO();

            return View(giaoVien.getByid(id));
        }
        [HttpPost]
        public ActionResult Edit(TTCSDL_GiaoVien tTCSDL_GiaoVien)
        {
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            DBContex db = new DBContex();
            var TTCSDL_GiaoVien = db.TTCSDL_GiaoVien.Find(id);
            db.TTCSDL_GiaoVien.Remove(TTCSDL_GiaoVien);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}