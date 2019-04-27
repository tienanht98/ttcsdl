using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFIT.EF;
using CFIT.DAO;

namespace CFIT.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: HomeAdmin
        public ActionResult Index()
        {
            GiaoVienDAO giaoVien = new GiaoVienDAO();

            return View(giaoVien.getALL());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Create(TTCSDL_GiaoVien tTCSDL_GiaoVien)
        {
            if(ModelState.IsValid)
            {
                GiaoVienDAO giaoVien = new GiaoVienDAO();
                giaoVien.Insert(tTCSDL_GiaoVien);
            }
            else
            {
                ModelState.AddModelError("", "Đăng nhập không thành công");

            }


            return  RedirectToAction("Index");
        }
        public ActionResult Edit()
        {
            return View();
        }


    }
}