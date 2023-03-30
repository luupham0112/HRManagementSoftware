using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class LoaiCong
    {
        QLNhanSuEntities db = new QLNhanSuEntities();
        public LOAICONG getItem(int id)
        {
            return db.LOAICONGs.FirstOrDefault(x => x.IDLOAICONG == id);
        }
        public List<LOAICONG> getList()
        {
            return db.LOAICONGs.ToList();
        }
        public LOAICONG Add(LOAICONG lc)
        {
            try
            {
                db.LOAICONGs.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public LOAICONG Update(LOAICONG lc)
        {
            try
            {
                var _lc = db.LOAICONGs.FirstOrDefault(x => x.IDLOAICONG == lc.IDLOAICONG);
                _lc.TENLC = lc.TENLC;
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
            var _lc = db.LOAICONGs.FirstOrDefault(x => x.IDLOAICONG == id);
            _lc.DELETE_BY = iduser;
            _lc.UPDATE_DATE = DateTime.Now;
            db.SaveChanges();
        }

    }
}
