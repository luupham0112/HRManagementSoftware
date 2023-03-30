using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class HopDongLD
    {

        QLNhanSuEntities db = new QLNhanSuEntities();
        public HOPDONG getItem(string sohd)
        {
            return db.HOPDONGs.FirstOrDefault(x => x.SOHD == sohd);
        }
        // report
        public List<Hopdong_DTO> getItemFull(string sohd)
        {
            List<HOPDONG> lstHD = db.HOPDONGs.Where(x => x.SOHD == sohd).ToList();
           // var item = db.HOPDONGs.FirstOrDefault(x => x.SOHD == sohd);
            List<Hopdong_DTO> lstDTO = new List<Hopdong_DTO>();
            Hopdong_DTO hdDTO;
            foreach (var item in lstHD)
            {
                hdDTO = new Hopdong_DTO();
                hdDTO.SOHD = item.SOHD;
                hdDTO.NGAYBATDAU = item.NGAYBATDAU;
                hdDTO.NGAYKETTHUC = item.NGAYKETTHUC;
                hdDTO.NGAYKI = item.NGAYKI;
                hdDTO.HESOLUONG = item.HESOLUONG;
                hdDTO.LUONGCOBAN = item.LUONGCOBAN;
                hdDTO.NOIDUNG = item.NOIDUNG;
                hdDTO.THOIHAN = item.THOIHAN;
                hdDTO.MANV = item.MANV;
                hdDTO.LANKY = item.LANKY;
                var nv = db.NHANVIENs.FirstOrDefault(n => n.MANV == item.MANV);
                hdDTO.HOTEN = nv.HOTEN;
                hdDTO.CCCD = nv.CCCD;
                hdDTO.DIACHI = nv.DIACHI;
                hdDTO.QUEQUAN = nv.QUEQUAN;
                hdDTO.DIENTHOAI = nv.DIENTHOAI;
                hdDTO.NGAYSINH = nv.NGAYSINH;
                hdDTO.CREATED_BY = item.CREATED_BY;
                hdDTO.CREATED_DATE = item.CREATED_DATE;
                hdDTO.UPDATE_BY = item.UPDATE_BY;
                hdDTO.UPDATE_DATE = item.UPDATE_DATE;
                hdDTO.DELETED_BY = item.DELETED_BY;
                hdDTO.DELETE_DATE = item.DELETE_DATE;
                lstDTO.Add(hdDTO);
            }
            return lstDTO;
        }
        
        public List<HOPDONG> getList()
        {
            return db.HOPDONGs.ToList();
        }
        
        public List<Hopdong_DTO> getListFull()
        {
            List<HOPDONG> lstHD = db.HOPDONGs.ToList();
            List<Hopdong_DTO> lstDTO = new List<Hopdong_DTO>();
            Hopdong_DTO hdDTO;
            foreach(var item in lstHD)
            {
                hdDTO = new Hopdong_DTO();
                hdDTO.SOHD = item.SOHD;
                hdDTO.NGAYBATDAU = item.NGAYBATDAU;
                hdDTO.NGAYKETTHUC = item.NGAYKETTHUC;
                hdDTO.NGAYKI = item.NGAYKI;
                hdDTO.HESOLUONG = item.HESOLUONG;
                hdDTO.LUONGCOBAN = item.LUONGCOBAN;
                hdDTO.NOIDUNG = item.NOIDUNG;
                hdDTO.THOIHAN = item.THOIHAN;
                hdDTO.MANV = item.MANV;
                hdDTO.LANKY = item.LANKY;
                var nv = db.NHANVIENs.FirstOrDefault(n => n.MANV == item.MANV);
                hdDTO.HOTEN = nv.HOTEN;
                hdDTO.CCCD = nv.CCCD;
                hdDTO.DIACHI = nv.DIACHI;
                hdDTO.QUEQUAN = nv.QUEQUAN;
                hdDTO.DIENTHOAI = nv.DIENTHOAI;
                hdDTO.NGAYSINH = nv.NGAYSINH;
                hdDTO.CREATED_BY = item.CREATED_BY;
                hdDTO.CREATED_DATE = item.CREATED_DATE;
                hdDTO.UPDATE_BY = item.UPDATE_BY;
                hdDTO.UPDATE_DATE = item.UPDATE_DATE;
                hdDTO.DELETED_BY = item.DELETED_BY;
                hdDTO.DELETE_DATE = item.DELETE_DATE;
                lstDTO.Add(hdDTO);
            }
            return lstDTO;
        }
        
        public HOPDONG Add(HOPDONG hd)
        {
            try
            {
                db.HOPDONGs.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public HOPDONG Update(HOPDONG hd)
        {
            try
            {
                var _hd = db.HOPDONGs.FirstOrDefault(x => x.SOHD == hd.SOHD);
                _hd.NGAYBATDAU = hd.NGAYBATDAU;
                _hd.NGAYKETTHUC = hd.NGAYKETTHUC;
                _hd.NGAYKI = hd.NGAYKI;
                _hd.LANKY = hd.LANKY;
                _hd.MANV = hd.MANV;
                _hd.HESOLUONG = hd.HESOLUONG;
                _hd.LUONGCOBAN = hd.LUONGCOBAN;
                _hd.SOHD = hd.SOHD;
                _hd.THOIHAN = hd.THOIHAN;
                _hd.NOIDUNG = hd.NOIDUNG;
                _hd.DELETED_BY = hd.DELETED_BY;
                _hd.DELETE_DATE = hd.DELETE_DATE;
                _hd.UPDATE_BY = hd.UPDATE_BY;
                _hd.UPDATE_DATE = hd.UPDATE_DATE;

                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(string sohd, int manv)
        {
            try
            {
                var _hd = db.HOPDONGs.FirstOrDefault(x => x.SOHD == sohd);
                _hd.DELETED_BY = manv;
                _hd.DELETE_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoHDLD()
        {
            var _hd = db.HOPDONGs.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOHD;
            }
            else
                return "00000";
        }

    }
}

    

