using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;


namespace BusinessLayer
{
   public class TangCa
    {
        QLNhanSuEntities db = new QLNhanSuEntities();
        public TANGCA getItem(int id)
        {
            return db.TANGCAs.FirstOrDefault(x => x.ID == id);
        }
        public List<TANGCA> getList()
        {
            return db.TANGCAs.ToList();
        }
        public List<Tangca_DTO> getListFull()
        {
            var lstTangca = db.TANGCAs.ToList();
            List<Tangca_DTO> lstDTO = new List<Tangca_DTO>();
            Tangca_DTO tc;
            foreach(var item in lstTangca)
            {
                tc = new Tangca_DTO();
                tc.ID = item.ID;
                tc.NAM = item.NAM;
                tc.THANG = item.THANG;
                tc.NGAY = item.NGAY;
                tc.SOGIO = item.SOGIO;
                tc.MANV = item.MANV;
                var nv = db.NHANVIENs.FirstOrDefault(x => x.MANV == item.MANV);
                tc.HOTEN = nv.HOTEN;
                tc.IDLOAICA = item.IDLOAICA;
                var lc = db.LOAICAs.FirstOrDefault(l => l.IDLOAICA == item.IDLOAICA);
                tc.TENLOAICA = lc.TENLOAICA;
                tc.HESO = lc.HESO;
                tc.SOTIEN = item.SOTIEN;
                tc.GHICHU = item.GHICHU;
                tc.CREATE_BY = lc.CREAT_BY;
                tc.CREATE_DATE = lc.CREAT_DATE;
                tc.UPDATE_BY = lc.UPDATE_BY;
                tc.UPDATE_DATE = lc.UPDATE_DATE;
                tc.DELETE_BY = lc.DELETE_BY;
                tc.DELETE_DATE = lc.DELETE_DATE;
                lstDTO.Add(tc);
            }
            return lstDTO;

        }
        public TANGCA Add(TANGCA lc)
        {
            try
            {
                db.TANGCAs.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public TANGCA Update(TANGCA lc)
        {
            try
            {
                var _lc = db.TANGCAs.FirstOrDefault(x => x.ID == lc.ID);
                _lc.NAM = lc.NAM;
                _lc.THANG = lc.THANG;
                _lc.NGAY = lc.THANG;
                _lc.SOGIO = lc.SOGIO;
                _lc.MANV = lc.MANV;
                _lc.IDLOAICA = lc.IDLOAICA;
                _lc.SOTIEN = lc.SOTIEN;
                _lc.THANG = lc.THANG;
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
            var _lc = db.TANGCAs.FirstOrDefault(x => x.ID == id);
            _lc.DELETE_BY = iduser;
            _lc.UPDATE_DATE = DateTime.Now;
            db.SaveChanges();
        }
    }
}
