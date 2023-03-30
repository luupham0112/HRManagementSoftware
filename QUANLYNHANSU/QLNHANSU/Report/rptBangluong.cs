using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DataLayer;
using System.Collections.Generic;

namespace QLNHANSU.Report
{
    public partial class rptBangluong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangluong()
        {
            InitializeComponent();
        }
        List<BANGLUONG> _lst;
        int _namky;
        public rptBangluong(List<BANGLUONG> _lstBL, int namky)
        {
            InitializeComponent();
            this._lst = _lstBL;
            this._namky = namky;
            this.DataSource = _lst;
            lblThang.Text = "Tháng " + _namky.ToString().Substring(4) + " Năm " + _namky.ToString().Substring(0,4);
            loadData();
        }
        void loadData()
        {
            lblID.DataBindings.Add("Text", DataSource, "MANV");
            lblHoten.DataBindings.Add("Text", DataSource, "HOTEN");
            lblNgaycong.DataBindings.Add("Text", DataSource, "NGAYCONGTHANG");
            lblNgayphep.DataBindings.Add("Text", DataSource, "NGAYPHEP");
            lblchunhat.DataBindings.Add("Text", DataSource, "NGAYCHUNHAT");
            lblngaythuong.DataBindings.Add("Text", DataSource, "NGAYTHUONG");
            lblphucap.DataBindings.Add("Text", DataSource, "PHUCAP");
            lbltangca.DataBindings.Add("Text", DataSource, "TANGCA");
         //   lblThang.DataBindings.Add("Text", DataSource, "MANV");
            lblThuclanh.DataBindings.Add("Text", DataSource, "THUCLANH");
            lblngayle.DataBindings.Add("Text", DataSource, "NGAYLE");
        }

    }
}

