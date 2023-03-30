using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class NhanVien
    {
        QLNhanSuEntities db = new QLNhanSuEntities();
        public NHANVIEN getItem(int id)
        {
            return db.NHANVIENs.FirstOrDefault(x => x.MANV == id);
        }

        public List<NHANVIEN> getList()
        {
            return db.NHANVIENs.ToList();
        }

        public NhanVien_DTO getItemFull(int id)
        {
            var item = db.NHANVIENs.FirstOrDefault(x=>x.MANV==id);

            NhanVien_DTO nvDTO = new NhanVien_DTO();
                nvDTO.MANV = item.MANV;
                nvDTO.HOTEN = item.HOTEN;
                nvDTO.GIOITINH = item.GIOITINH;
                nvDTO.NGAYSINH = item.NGAYSINH;
                nvDTO.CCCD = item.CCCD;
                nvDTO.DIACHI = item.DIACHI;
                nvDTO.DIACHI = item.DIENTHOAI;
                nvDTO.QUEQUAN = item.QUEQUAN;
                nvDTO.DIENTHOAI = item.DIENTHOAI;
                nvDTO.DATHOIVIEC = item.DATHOIVIEC;


              //  nvDTO.IDBP = item.IDBP;
             //   var bp = db.BOPHANs.FirstOrDefault(b => b.IDBP == item.IDBP);
             //   nvDTO.TENBP = bp.TENBP;

                nvDTO.IDPB = item.IDPB;
                var pb = db.PHONGBANs.FirstOrDefault(b => b.IDPB == item.IDPB);
                nvDTO.TENPB = pb.TENPB;

                nvDTO.IDCV = item.IDCV;
                var cv = db.CHUCVUs.FirstOrDefault(b => b.IDCV == item.IDCV);
                nvDTO.TENCV = cv.TENCV;

                nvDTO.IDTD = item.IDTD;
                var td = db.TRINHDOes.FirstOrDefault(t => t.IDTD == item.IDTD);
                nvDTO.TENTD = td.TENTD;

                nvDTO.IDDT = item.IDDT;
                var dt = db.DANTOCs.FirstOrDefault(b => b.IDDT == item.IDDT);
                nvDTO.TENDT = dt.TENDT;

               
           
            return nvDTO;
        }
        public List<NhanVien_DTO> getListFull()
        {
            var lstNV = db.NHANVIENs.ToList();
            List<NhanVien_DTO> lstNVDTO = new List<NhanVien_DTO>();
            NhanVien_DTO nvDTO;
            foreach(var item in lstNV)
            {
                nvDTO = new NhanVien_DTO();
                nvDTO.MANV = item.MANV;
                nvDTO.HOTEN = item.HOTEN;
                nvDTO.GIOITINH = item.GIOITINH;
                nvDTO.NGAYSINH = item.NGAYSINH;
                nvDTO.CCCD = item.CCCD;
                nvDTO.DIACHI = item.DIACHI;
                nvDTO.DIENTHOAI = item.DIENTHOAI;
                nvDTO.QUEQUAN = item.QUEQUAN;
                nvDTO.DATHOIVIEC = item.DATHOIVIEC;


              //  nvDTO.IDBP = item.IDBP;
              //  var bp = db.BOPHANs.FirstOrDefault(b => b.IDBP == item.IDBP);
              //  nvDTO.TENBP = bp.TENBP;

                nvDTO.IDPB = item.IDPB;
                var pb = db.PHONGBANs.FirstOrDefault(b => b.IDPB == item.IDPB);
                nvDTO.TENPB = pb.TENPB;

                nvDTO.IDCV = item.IDCV;
                var cv = db.CHUCVUs.FirstOrDefault(c => c.IDCV == item.IDCV);
                nvDTO.TENCV = cv.TENCV;

                nvDTO.IDTD = item.IDTD;
                var td = db.TRINHDOes.FirstOrDefault(t => t.IDTD == item.IDTD);
                nvDTO.TENTD = td.TENTD;

                nvDTO.IDDT = item.IDDT;
                var dt = db.DANTOCs.FirstOrDefault(d => d.IDDT == item.IDDT);
                nvDTO.TENDT = dt.TENDT;

                lstNVDTO.Add(nvDTO);
            }
            return lstNVDTO;
        }
        public NHANVIEN Add(NHANVIEN nv)
        {
            try
            {
                db.NHANVIENs.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public NHANVIEN Update(NHANVIEN nv)
        {
            try
            {
                var _nv = db.NHANVIENs.FirstOrDefault(x => x.MANV == nv.MANV);
                _nv.HOTEN = nv.HOTEN;
                _nv.GIOITINH = nv.GIOITINH;
                _nv.NGAYSINH = nv.NGAYSINH;
                _nv.CCCD = nv.CCCD;
                _nv.DIENTHOAI = nv.DIENTHOAI;
                _nv.DIACHI = nv.DIACHI;
                _nv.QUEQUAN = nv.QUEQUAN;
              //  _nv.IDBP = nv.IDBP;
                _nv.IDCV = nv.IDCV;
                _nv.IDPB = nv.IDPB;
                _nv.IDTD = nv.IDTD;
                _nv.IDDT = nv.IDDT;
                _nv.DATHOIVIEC = nv.DATHOIVIEC;

                db.SaveChanges();
                return nv;
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
                var _nv = db.NHANVIENs.FirstOrDefault(x => x.MANV == id);
                db.NHANVIENs.Remove(_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
