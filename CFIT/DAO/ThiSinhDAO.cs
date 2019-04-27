using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CFIT.EF;
namespace CFIT.DAO
{
    public class ThiSinhDAO
    {
        DBContex db = null;
        public ThiSinhDAO()
        {
            db = new DBContex();
        }
        public int Insert(TTCDL_ThiSinh entity)
        {
            db.TTCDL_ThiSinh.Add(entity);
            db.SaveChanges();
            return entity.IDThiSinh;

        }
        public List<TTCDL_ThiSinh> getALL()
        {
            return db.TTCDL_ThiSinh.OrderBy(x => x.HoTen).ToList();
        }
    }
}