using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BangLuong
    {
        QLNhanSuEntities db = new QLNhanSuEntities();

        public BANGLUONG getItem(int makycong, int manv)
        {
            return db.BANGLUONGs.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == manv);
        }
        public List<BANGLUONG> getList(int makycong)
        {
            return db.BANGLUONGs.Where(x => x.MAKYCONG == makycong).ToList();
        }
        public void TinhLuongNhanVien(int makycong)
        {
            double luongngaythuong, luongphep, luongtangca, luongchunhat, luongngayle, phucap, thuclanh,hesoluong;
            var lstNV = db.NHANVIENs.Where(x => x.DATHOIVIEC == null).ToList();
            foreach(var item in lstNV)
            {
                var hd = db.HOPDONGs.FirstOrDefault(x => x.MANV==item.MANV && x.DELETED_BY == null);
                if(hd!=null)
                {
                    var kcct = db.KYCONGCHITIETs.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == item.MANV);
                    hesoluong = Convert.ToDouble(hd.HESOLUONG);
                    var luong1ngaycong = hd.LUONGCOBAN * hesoluong  / kcct.NGAYCONG;
                    //Tính lương ngày thường
                    luongngaythuong = Convert.ToDouble(kcct.TONGNGAYCONG * luong1ngaycong);
                    luongphep = Convert.ToDouble(kcct.NGAYPHEP * luong1ngaycong * 0.3);
                    luongchunhat = Convert.ToDouble(kcct.CONGCHUNHAT * luong1ngaycong * 2);
                    luongngayle = Convert.ToDouble(kcct.CONGNGAYLE * luong1ngaycong * 3);
                    luongtangca = Convert.ToDouble(db.TANGCAs.Where(x => (x.NAM * 100 + x.THANG) == makycong && x.MANV == item.MANV).Sum(x => x.SOTIEN));
                    phucap = Convert.ToDouble(db.PHUCAP_NV.Where(x => x.MANV == item.MANV).Sum(x => x.SOTIEN));
                    thuclanh = luongngaythuong + luongphep + luongngayle + luongchunhat + luongtangca + phucap;
                    BANGLUONG bl = new BANGLUONG();
                    bl.MAKYCONG = makycong;
                    bl.MANV = item.MANV;
                    bl.HOTEN = item.HOTEN;
                    bl.NGAYCONGTHANG = int.Parse(kcct.NGAYCONG.ToString());
                    bl.NGAYPHEP = luongphep;
                    bl.NGAYCHUNHAT = luongchunhat;
                    bl.NGAYLE = luongngayle;
                    bl.NGAYTHUONG = luongngaythuong;
                    bl.PHUCAP = phucap;
                    bl.TANGCA = luongtangca;
                    bl.THUCLANH = thuclanh;
                    bl.CREATE_BY = 1;
                    bl.CREATE_DATE = DateTime.Now;
                    Add(bl);
                }    
               
            }   

        }
        public BANGLUONG Add(BANGLUONG bl)
        {
            try
            {
                db.BANGLUONGs.Add(bl);
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public BANGLUONG Update(BANGLUONG bl)
        {
            try
            {
                BANGLUONG _bl = db.BANGLUONGs.FirstOrDefault(x => x.MAKYCONG == bl.MAKYCONG && x.MANV == bl.MANV);
                _bl.MANV = bl.MANV;
                _bl.MAKYCONG = bl.MAKYCONG;
                _bl.HOTEN = bl.HOTEN;
                _bl.NGAYPHEP = bl.NGAYPHEP;
                _bl.KHONGPHEP = bl.KHONGPHEP;
                _bl.NGAYCHUNHAT = bl.NGAYCHUNHAT;
                _bl.NGAYLE = bl.NGAYLE;
                _bl.NGAYCONGTHANG = bl.NGAYCONGTHANG;
                _bl.NGAYTHUONG = bl.NGAYTHUONG;
                _bl.TANGCA = bl.TANGCA;
                _bl.PHUCAP = bl.PHUCAP;
                _bl.THUCLANH= bl.THUCLANH;
                _bl.UPDATE_BY = bl.UPDATE_BY;
                _bl.UPDATE_DATE = bl.UPDATE_DATE;
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        
    }
}
