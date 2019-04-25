using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFIT.DAO;
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
    }
}