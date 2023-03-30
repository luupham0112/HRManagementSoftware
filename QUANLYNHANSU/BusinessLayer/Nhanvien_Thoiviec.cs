using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class Nhanvien_Thoiviec
    {
        QLNhanSuEntities db = new QLNhanSuEntities();
        public NV_THOIVIEC getItem(string soqd)
        {
            return db.NV_THOIVIEC.FirstOrDefault(x => x.SOQD == soqd);
        }
        public List<NV_THOIVIEC> getList()
        {
            return db.NV_THOIVIEC.ToList();
        }
        public List<NV_ThoiViec_DTO> getListFull()
        {
            var lstTV = db.NV_THOIVIEC.ToList();
            List<NV_ThoiViec_DTO> lstDTO = new List<NV_ThoiViec_DTO>();
            NV_ThoiViec_DTO tvDTO;
            foreach (var item in lstTV)
            {
                tvDTO = new NV_ThoiViec_DTO();
                tvDTO.SOQD = item.SOQD;
                tvDTO.NGAYNOPDON = item.NGAYNOPDON;
                tvDTO.NGAYNGHI = item.NGAYNGHI;
                tvDTO.LYDO = item.LYDO;
                tvDTO.GHICHU = item.GHICHU;
                var nv = db.NHANVIENs.FirstOrDefault(n => n.MANV == item.MANV);
                tvDTO.HOTEN = nv.HOTEN;
                tvDTO.CREATE_BY = item.CREATE_BY;
                tvDTO.CREATE_DATE = item.CREATE_DATE;
                tvDTO.UPDATE_BY = item.UPDATE_BY;
                tvDTO.UPDATE_DATE = item.UPDATE_DATE;
                tvDTO.DELETE_BY = item.DELETE_BY;
                tvDTO.DELETE_DATE = item.DELETE_DATE;
                lstDTO.Add(tvDTO);
            }
            return lstDTO;
        }

        public NV_THOIVIEC Add(NV_THOIVIEC lc)
        {
            try
            {
                db.NV_THOIVIEC.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public NV_THOIVIEC Update(NV_THOIVIEC lc)
        {
            try
            {
                var _lc = db.NV_THOIVIEC.FirstOrDefault(x => x.SOQD == lc.SOQD);

                _lc.NGAYNOPDON = lc.NGAYNOPDON;
                _lc.NGAYNGHI = lc.NGAYNGHI;
                _lc.LYDO = lc.LYDO;
                _lc.GHICHU = lc.GHICHU;
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
        public void Delete(string soqd, int iduser)
        {
            var _lc = db.NV_THOIVIEC.FirstOrDefault(x => x.SOQD == soqd);
            _lc.DELETE_BY = iduser;
            _lc.UPDATE_DATE = DateTime.Now;
            db.SaveChanges();
        }
        public string MaxSoQuyetDinh()
        {
            var _hd = db.NV_THOIVIEC.OrderByDescending(x => x.CREATE_DATE).FirstOrDefault();
            if(_hd !=null)
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
