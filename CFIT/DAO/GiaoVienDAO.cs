using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CFIT.EF;
namespace CFIT.DAO
{
    public class GiaoVienDAO
    {
        DBContex db = null;
        public GiaoVienDAO()
        {
            db = new DBContex();
        }
        public List<TTCSDL_GiaoVien> getALL()
        {
            return db.TTCSDL_GiaoVien.OrderBy(x=>x.HoTen).ToList();
        }
        public bool Insert(TTCSDL_GiaoVien tTCSDL_GiaoVien)
        {
            db.TTCSDL_GiaoVien.Add(tTCSDL_GiaoVien);
            db.SaveChanges();
            return true;
        }
    }
}