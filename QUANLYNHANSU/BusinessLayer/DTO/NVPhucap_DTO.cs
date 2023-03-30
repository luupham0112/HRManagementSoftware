using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class NVPhucap_DTO
    {
        public int ID { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<int> IDPC { get; set; }
        public string TENPC { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<double> SOTIEN { get; set; }
        public Nullable<int> CREATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<int> UPDATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<int> DELETE_BY { get; set; }
        public Nullable<System.DateTime> DELETE_DATE { get; set; }

      
    }
}
