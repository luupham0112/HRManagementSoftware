using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class KhenThuong
    {
        QLNhanSuEntities db = new QLNhanSuEntities();
        public KHENTHUONGKYLUAT getItem(string soqd)
        {
            return db.KHENTHUONGKYLUATs.FirstOrDefault(x => x.SOQD == soqd);
        }
        public List<KHENTHUONGKYLUAT> getList(int loai)
        {
            return db.KHENTHUONGKYLUATs.Where(x=>x.LOAI==loai).ToList();
        }
        
        public List<KhenthuongKiluat_DTO> getListFull(int loai)
        {
            List<KHENTHUONGKYLUAT> lstKT = db.KHENTHUONGKYLUATs.Where(x=>x.LOAI==loai).ToList();
            List<KhenthuongKiluat_DTO> lstDTO = new List<KhenthuongKiluat_DTO>();
            KhenthuongKiluat_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KhenthuongKiluat_DTO();
                kt.SOQD = item.SOQD;
                kt.NGAYBATDAU = item.NGAYBATDAU;
                kt.NGAYKETTHUC = item.NGAYKETTHUC;
                kt.NGAY = item.NGAY;
                kt.LYDO = item.LYDO;
                kt.NOIDUNG = item.NOIDUNG;
                kt.LOAI = item.LOAI;
                var nv = db.NHANVIENs.FirstOrDefault(n => n.MANV == item.MANV);
                kt.HOTEN = nv.HOTEN;
                kt.CREATE_BY = item.CREATE_BY;
                kt.CREATE_DATE = item.CREATE_DATE;
                kt.UPDATE_BY = item.UPDATE_BY;
                kt.UPDATE_DATE = item.UPDATE_DATE;
                kt.DELETE_BY = item.DELETE_BY;
                kt.DELETE_DATE = item.DELETE_DATE;
                lstDTO.Add(kt);
            }
            return lstDTO;
        }
        
        public KHENTHUONGKYLUAT Add(KHENTHUONGKYLUAT lc)
        {
            try
            {
                db.KHENTHUONGKYLUATs.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public KHENTHUONGKYLUAT Update(KHENTHUONGKYLUAT lc)
        {
            try
            {
                var _lc = db.KHENTHUONGKYLUATs.FirstOrDefault(x => x.SOQD == lc.SOQD);
                _lc.NGAY = lc.NGAY;
                _lc.NGAYBATDAU = lc.NGAYBATDAU;
                _lc.NGAYKETTHUC = lc.NGAYKETTHUC;
                _lc.LYDO = lc.LYDO;
                _lc.NOIDUNG = lc.NOIDUNG;
                _lc.LOAI = lc.LOAI;
                _lc.MANV = lc.MANV;
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
        public void Delete(string soqd, int manv)
        {
            try
            {
                KHENTHUONGKYLUAT _lc = db.KHENTHUONGKYLUATs.FirstOrDefault(x => x.SOQD == soqd);
                _lc.DELETE_BY = manv;
                _lc.UPDATE_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _hd = db.KHENTHUONGKYLUATs.Where(x=>x.LOAI==loai).OrderByDescending(x => x.CREATE_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOQD;
            }
            else
            {
                return "00000";
            }


        }
    }
}
