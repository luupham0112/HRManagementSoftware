using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using QLNHANSU.Report;
using DevExpress.XtraReports.UI;

namespace QLNHANSU.Chamluong
{
    public partial class frmBangluong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangluong()
        {
            InitializeComponent();
        }

        BangLuong _bangluong;
        List<BANGLUONG> _lstBL;
        int _namky;
        private void frmBangluong_Load(object sender, EventArgs e)
        {
            _bangluong = new BangLuong();
        }

        private void btnTinhluong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _bangluong.TinhLuongNhanVien(int.Parse(cboNam.Text) *100+ int.Parse(cboThang.Text));
            loadData();
               
        }
        void loadData()
        {
            gcDanhSach.DataSource = _bangluong.getList(int.Parse(cboNam.Text) *100+ int.Parse(cboThang.Text));
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstBL = _bangluong.getList(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            _namky = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnprint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptBangluong rpt = new rptBangluong(_lstBL,_namky);
            rpt.ShowPreview();
        }

        private void spXembangluong_Click(object sender, EventArgs e)
        {

        }
    }
}