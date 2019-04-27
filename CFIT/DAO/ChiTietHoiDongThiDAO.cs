using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CFIT.EF;
namespace CFIT.DAO
{
    public class ChiTietHoiDongThiDAO
    {
        DBContex db = null;
        public ChiTietHoiDongThiDAO()
        {
            db = new DBContex();
        }
        public List<TTCSDL_ChiTietHoiDongThi> getALL()
        {
            return db.TTCSDL_ChiTietHoiDongThi.OrderBy(x=>x.TTCSDL_NhiemVu).ToList();
        }
        public bool Insert(TTCSDL_ChiTietHoiDongThi tTCSDL_GiaoVien)
        {
            db.TTCSDL_ChiTietHoiDongThi.Add(tTCSDL_GiaoVien);
            db.SaveChanges();
            return true;
        }
        public TTCSDL_ChiTietHoiDongThi getByid(int id)
        {
            return db.TTCSDL_ChiTietHoiDongThi.SingleOrDefault(x => x.IDGiaoVien == id);
        }
    }
}