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
    }
}