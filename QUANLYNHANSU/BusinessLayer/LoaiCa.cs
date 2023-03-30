using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class LoaiCa
    {
        QLNhanSuEntities db = new QLNhanSuEntities();
        public LOAICA getItem(int id)
        {
            return db.LOAICAs.FirstOrDefault(x => x.IDLOAICA == id);
        }
        public List<LOAICA>getList()
        {
            return db.LOAICAs.ToList();
        }
        public LOAICA Add(LOAICA lc)
        {
            try
            {
                db.LOAICAs.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: "+ ex.Message);
            }
        }
        public LOAICA Update(LOAICA lc)
        {
            try
            {
                var _lc = db.LOAICAs.FirstOrDefault(x => x.IDLOAICA == lc.IDLOAICA);
                _lc.TENLOAICA = lc.TENLOAICA;
                _lc.HESO = lc.HESO;
                _lc.UPDATE_BY = lc.UPDATE_BY;
                _lc.UPDATE_DATE = lc.UPDATE_DATE;
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id, int iduser)
        {
            var _lc = db.LOAICAs.FirstOrDefault(x => x.IDLOAICA == id);
            _lc.DELETE_BY = iduser;
            _lc.UPDATE_DATE = DateTime.Now;
            db.SaveChanges();
        }

    }
}
