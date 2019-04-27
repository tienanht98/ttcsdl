using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFIT.DAO;
using CFIT.EF;

namespace CFIT.Controllers
{
    public class ThiSinhController : Controller
    {
        // GET: ThiSinh
        public ActionResult Index()
        {
            DBContex dBContex = new DBContex();
            ThiSinhDAO thiSinhDAO = new ThiSinhDAO();
            return View(thiSinhDAO.getALL());
        }
    }
}