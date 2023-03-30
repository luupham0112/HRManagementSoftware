using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNHANSU.Report
{
    public partial class rptHopdonglaodong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHopdonglaodong()
        {
            InitializeComponent();
        }
        public rptHopdonglaodong(List<Hopdong_DTO> lstHD)
        {
            InitializeComponent();
            this._lstHD = lstHD;
            this.DataSource = _lstHD;
            loadData();
        }

        List<Hopdong_DTO> _lstHD;
        void loadData()
        {
            lblSohd.DataBindings.Add("Text", _lstHD, "SOHD");
        }
    }
}
