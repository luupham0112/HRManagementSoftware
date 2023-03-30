using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class PhuCap
    {
        QLNhanSuEntities db = new QLNhanSuEntities();

        public PHUCAP_NV getItem(int id)
        {
            return db.PHUCAP_NV.FirstOrDefault(x => x.ID == id);
        }
        
       public List<PHUCAP_NV> getList()
       {
           return db.PHUCAP_NV.ToList();
       }
       

        public List<NVPhucap_DTO> getListFull()
        {
            var lstNVPC = db.PHUCAP_NV.ToList();
            List<NVPhucap_DTO> lstDTO = new List<NVPhucap_DTO>();
            NVPhucap_DTO nvpc;
            NhanVien _nhanvien = new NhanVien();
            foreach (var item in lstNVPC)
            {
                nvpc = new NVPhucap_DTO();
                nvpc.ID = item.ID;
                nvpc.MANV = item.MANV;
                var nv = _nhanvien.getItemFull(int.Parse(item.MANV.ToString()));
                nvpc.HOTEN = nv.HOTEN;
                nvpc.IDPC = item.IDPC;
                var pc = db.PHUCAPs.FirstOrDefault(x => x.IDPC == item.IDPC);
                nvpc.TENPC = pc.TENPC;
                nvpc.NOIDUNG = item.NOIDUNG;
                nvpc.NGAY = item.NGAY;
                nvpc.SOTIEN = item.SOTIEN;
                nvpc.CREATE_BY = item.CREATE_BY;
                nvpc.CREATE_DATE = item.CREATE_DATE;
                nvpc.UPDATE_BY = item.UPDATE_BY;
                nvpc.UPDATE_DATE = item.UPDATE_DATE;
                nvpc.DELETE_BY = item.DELETE_BY;
                nvpc.DELETE_DATE = item.DELETE_DATE;
                lstDTO.Add(nvpc);
    
            }
            return lstDTO;
        }
       
        public List<PHUCAP> getListPhucap()
        {
            return db.PHUCAPs.ToList();
        }
        public PHUCAP_NV Add(PHUCAP_NV lc)
        {
            try
            {
                db.PHUCAP_NV.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public PHUCAP_NV Update(PHUCAP_NV lc)
        {
            try
            {
                var _lc = db.PHUCAP_NV.FirstOrDefault(x => x.ID == lc.ID);
                _lc.IDPC = lc.IDPC;
                _lc.MANV = lc.MANV;
                _lc.NGAY = lc.NGAY;
                _lc.NOIDUNG = lc.NOIDUNG;
                _lc.SOTIEN = lc.SOTIEN;
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
            var _lc = db.PHUCAP_NV.FirstOrDefault(x => x.ID == id);
            _lc.DELETE_BY = iduser;
            _lc.UPDATE_DATE = DateTime.Now;
            db.SaveChanges();
        }

    }
}

    
