using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class NhanVien_DTO
    {
        public int MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public System.DateTime NGAYSINH { get; set; }
        public string DIENTHOAI { get; set; }
        public string CCCD { get; set; }
        public string DIACHI { get; set; }
        public string QUEQUAN { get; set; }
        public bool? DATHOIVIEC { get; set; }
        public Nullable<int> IDPB { get; set; }
        public string TENPB { get; set; }
      //  public Nullable<int> IDBP { get; set; }
    //    public string TENBP { get; set; }
        public Nullable<int> IDCV { get; set; }
        public string TENCV { get; set; }
        public Nullable<int> IDTD { get; set; }
        public string TENTD { get; set; }
        public Nullable<int> IDDT { get; set; }
        public string TENDT { get; set; }
    }
}
