using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BangCong
    {

        QLNhanSuEntities db = new QLNhanSuEntities();
        public KYCONG getItem(int id)
        {
            return db.KYCONGs.FirstOrDefault(x => x.ID == id);
        }
        public List<KYCONG> getList()
        {
            return db.KYCONGs.ToList();
        }
        public KYCONG Add(KYCONG lc)
        {
            try
            {
                db.KYCONGs.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public KYCONG Update(KYCONG lc)
        {
            try
            {
                var _lc = db.KYCONGs.FirstOrDefault(x => x.ID == lc.ID);
                _lc.MAKYCONG = lc.MAKYCONG;
                _lc.KHOA = lc.KHOA;
                _lc.NAM = lc.NAM;
                _lc.NGAYTINHCONG = lc.NGAYTINHCONG;
                _lc.NGAYCONGTHANG = lc.NGAYCONGTHANG;
                _lc.TRANGTHAI = lc.TRANGTHAI;
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
            var _lc = db.KYCONGs.FirstOrDefault(x => x.ID == id);
            _lc.DELETE_BY = iduser;
            _lc.UPDATE_DATE = DateTime.Now;
            db.SaveChanges();
        }

       
        public bool KiemTraPhatSinhKyCong(int makycong)
        {
            var kc = db.KYCONGs.FirstOrDefault(x => x.MAKYCONG == makycong);
            if (kc == null)
            {
                return false;
            }
            else
            {
                if (kc.TRANGTHAI == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
