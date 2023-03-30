using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class Tangca_DTO
    {
        public int ID { get; set; }
        public Nullable<int> NAM { get; set; }
        public Nullable<int> THANG { get; set; }
        public Nullable<int> NGAY { get; set; }
        public Nullable<double> SOGIO { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<int> IDLOAICA { get; set; }
        public double? SOTIEN { get; set; }
        public string TENLOAICA { get; set; }
        public double? HESO { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<int> UPDATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<int> DELETE_BY { get; set; }
        public Nullable<System.DateTime> DELETE_DATE { get; set; }
    }
}
