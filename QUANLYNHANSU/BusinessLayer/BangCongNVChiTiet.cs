using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BangCongNVChiTiet
    {
        QLNhanSuEntities db = new QLNhanSuEntities();

        public BANGCONGNVCHITIET getItem(int makycong, int manv, int ngay)
        {
            return db.BANGCONGNVCHITIETs.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == manv && x.NGAY.Value.Day == ngay);
        }
        public BANGCONGNVCHITIET Add(BANGCONGNVCHITIET bcct)
        {
            try
            {
                db.BANGCONGNVCHITIETs.Add(bcct);
                db.SaveChanges();
                return bcct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public BANGCONGNVCHITIET Update(BANGCONGNVCHITIET bcct)
        {
            try
            {
                BANGCONGNVCHITIET bcnv = db.BANGCONGNVCHITIETs.FirstOrDefault(x => x.MAKYCONG == bcct.MAKYCONG && x.MANV == bcct.MANV && x.NGAY == bcct.NGAY);
                bcnv.KYHIEU = bcnv.KYHIEU;
                bcnv.GIOVAO = bcct.GIOVAO;
                bcnv.GIORA = bcct.GIORA;
                bcnv.NGAYPHEP = bcct.NGAYPHEP;
                bcnv.GHICHU = bcct.GHICHU;
                bcnv.CONGCHUNHAT = bcct.CONGCHUNHAT;
                bcnv.CONGNGAYLE = bcct.CONGNGAYLE;
                bcnv.NGAYCONG = bcct.NGAYCONG;
                bcnv.UPDATE_BY = bcct.UPDATE_BY;
                bcnv.UPDATE_DATE = bcct.UPDATE_DATE;
                db.SaveChanges();
                return bcct;
            }
            catch (Exception ex)
            { 
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public double tongNgayPhep(int makycong, int manv)
        {
            return db.BANGCONGNVCHITIETs.Where(x => x.MAKYCONG == makycong && x.MANV == manv && x.NGAYPHEP != null).ToList().Sum(p => p.NGAYPHEP.Value);
        }
        public double tongNgayCongCN(int makycong, int manv)
        {
            return db.BANGCONGNVCHITIETs.Where(x => x.MAKYCONG == makycong && x.MANV == manv && x.CONGCHUNHAT != null).ToList().Sum(p => p.NGAYPHEP.Value);
        }


        public double tongNgayCong(int makycong, int manv)
        {
            return db.BANGCONGNVCHITIETs.Where(x => x.MAKYCONG == makycong && x.MANV == manv && x.NGAYCONG != null).ToList().Sum(p => p.NGAYCONG.Value);
        }
    }
}
