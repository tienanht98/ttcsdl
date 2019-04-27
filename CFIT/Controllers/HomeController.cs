using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFIT.EF;
using CFIT.DAO;

namespace CFIT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(TTCDL_ThiSinh tTCDL_ThiSinh)
        {
            ThiSinhDAO thiSinhDAO = new ThiSinhDAO();
            thiSinhDAO.Insert(tTCDL_ThiSinh);
            DBContex db = new DBContex();
            db.TTCSDL_NhiemVu.SqlQuery("exec ")
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}