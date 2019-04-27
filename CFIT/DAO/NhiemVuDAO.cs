using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CFIT.EF;
namespace CFIT.DAO
{
    public class NhiemVuDAO
    {
        DBContex db = null;
        public NhiemVuDAO()
        {
            db = new DBContex();
        }
        public List<TTCSDL_NhiemVu> getALL()
        {
            return db.TTCSDL_NhiemVu.OrderBy(x=>x.IDNhiemVu).ToList();
        }
        
    }
}