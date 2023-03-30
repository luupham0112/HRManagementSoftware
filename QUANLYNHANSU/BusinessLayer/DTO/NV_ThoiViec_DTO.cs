using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class NV_ThoiViec_DTO
    {
        public string SOQD { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAYNOPDON { get; set; }
        public Nullable<System.DateTime> NGAYNGHI { get; set; }
        public string LYDO { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<int> UPDATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<int> DELETE_BY { get; set; }
        public Nullable<System.DateTime> DELETE_DATE { get; set; }
    }
}
