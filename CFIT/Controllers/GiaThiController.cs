using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFIT.EF;
namespace CFIT.Controllers
{
    public class GiaThiController : Controller
    {
        // GET: GiaThi
        DBContex db = new DBContex();
        public ActionResult Index()
        {
            DBContex db = new DBContex();
            return View(db.TTCSDL_GiaOnThi.ToList());
        }
        public ActionResult Create()
        {
            DBContex db = new DBContex();
            List<TTCSDL_TrinhDo> cate = db.TTCSDL_TrinhDo.ToList();
            SelectList TrinhDoList = new SelectList(cate, "TrinhDo", "LoaiTrinhDo");
            ViewBag.TrinhDoList = TrinhDoList;

            List<TTCSDL_NhuCau> catea = db.TTCSDL_NhuCau.ToList();
            SelectList NhuCauList = new SelectList(catea, "NhuCau", "LoaiNhuCau");
            ViewBag.NhuCauList = NhuCauList;

            List<TTCSDL_HocVien> cateab = db.TTCSDL_HocVien.ToList();
            SelectList HocVienList = new SelectList(cateab, "LaHocVien", "HocTaiHocVien");
            ViewBag.HocVienList = HocVienList;
            return View();
        }
    }
}