using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TrinhDo
    {

        QLNhanSuEntities db = new QLNhanSuEntities();
        public TRINHDO getItem(int id)
        {
            return db.TRINHDOes.FirstOrDefault(x => x.IDTD == id);
        }

        public List<TRINHDO> getList()
        {
            return db.TRINHDOes.ToList();
        }

        public TRINHDO Add(TRINHDO td)
        {
            try
            {
                db.TRINHDOes.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TRINHDO Update(TRINHDO td)
        {
            try
            {
                var _td = db.TRINHDOes.FirstOrDefault(x => x.IDTD == td.IDTD);
                _td.TENTD = td.TENTD;
                _td.BANGCAP = td.BANGCAP;
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var _td = db.TRINHDOes.FirstOrDefault(x => x.IDTD == id);
                db.TRINHDOes.Remove(_td);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}
