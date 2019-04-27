using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFIT.EF;
namespace CFIT.Controllers
{
    public class DanhSachNopTienController : Controller
    {
        DBContex db = new DBContex();
        // GET: DanhSachNopTien
        public ActionResult Index()
        {
           
            return View(db.TTCSDL_DSNopTien.ToList());
        }
    }
}