using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using BusinessLayer.DTO;
using System.Collections.Generic;

namespace QLNHANSU.Report
{
    public partial class rptDanhsachNV : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhsachNV()
        {
            InitializeComponent();
        }
        List<NhanVien_DTO> _lstNV;
        public rptDanhsachNV(List<NhanVien_DTO> lstNV)
        {
            InitializeComponent();
            this._lstNV = lstNV;
            this.DataSource = _lstNV;
            loadData();

        }
        void loadData()
        {
            lblID.DataBindings.Add("Text", _lstNV, "MANV");
            lblHoten.DataBindings.Add("Text", _lstNV, "HOTEN");
            lblGioitinh.DataBindings.Add("Text", _lstNV, "GIOITINH");
            lblNgaysinh.DataBindings.Add("Text", _lstNV, "NGAYSINH");
            lblzDienthoai.DataBindings.Add("Text", _lstNV, "DIENTHOAI");
            lblCCCD.DataBindings.Add("Text", _lstNV, "CCCD");
            lblQuequan.DataBindings.Add("Text", _lstNV, "QUEQUAN");
            lblDiachi.DataBindings.Add("Text", _lstNV, "DIACHI");
            lblChucvu.DataBindings.Add("Text", _lstNV, "TENCV");
            lblPhongban.DataBindings.Add("Text", _lstNV, "TENPB");
            lblTrinhdo.DataBindings.Add("Text", _lstNV, "TENTD");
            lblDantoc.DataBindings.Add("Text", _lstNV, "TENDT");


        }
    }
}
