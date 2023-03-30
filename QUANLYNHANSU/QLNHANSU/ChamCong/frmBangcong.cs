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

namespace QLNHANSU.ChamCong
{
    public partial class frmBangcong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangcong()
        {
            InitializeComponent();
        }
        BangCong _loaica;
        bool _them;
        int _makycong;
        private void frmBangcong_Load(object sender, EventArgs e)
        {
            _them = false;
            _loaica = new BangCong();
            _showHide(true);
            loadData();
            cbNam.Text = DateTime.Now.Year.ToString();
            cbThang.Text = DateTime.Now.Month.ToString();
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            btnDong.Enabled = kt;
            cbKhoa.Enabled = !kt;
            cbNam.Enabled = !kt;
            cbThang.Enabled = !kt;
            chktrangthai.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _loaica.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            cbNam.Text = DateTime.Now.Year.ToString();
            cbThang.Text = DateTime.Now.Month.ToString();
            cbKhoa.Checked = false;
            chktrangthai.Checked = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _loaica.Delete(_makycong, 1);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        void SaveData()
        {
            if (_them)
            {
                KYCONG lc = new KYCONG();
                lc.MAKYCONG = int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text);
                lc.NAM = int.Parse(cbNam.Text);
                lc.THANG = int.Parse(cbThang.Text);
                lc.KHOA = cbKhoa.Checked;
                lc.TRANGTHAI = chktrangthai.Checked;
                lc.NGAYCONGTHANG = function.demSoNgayLamViec(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
                lc.NGAYTINHCONG = DateTime.Now;
                lc.CREATE_BY = 1;
                lc.CREATE_DATE = DateTime.Now;
                _loaica.Add(lc);

            }
            else
            {
                var lc = _loaica.getItem(_makycong);
                lc.MAKYCONG = int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text);
                lc.NAM = int.Parse(cbNam.Text);
                lc.THANG = int.Parse(cbThang.Text);
                lc.KHOA = cbKhoa.Checked;
                lc.TRANGTHAI = chktrangthai.Checked;
                lc.NGAYCONGTHANG = function.demSoNgayLamViec(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
                lc.NGAYTINHCONG = DateTime.Now;
                lc.CREATE_BY = 1;
                lc.CREATE_DATE = DateTime.Now;
                _loaica.Update(lc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _makycong = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                cbNam.Text = gvDanhSach.GetFocusedRowCellValue("MAKYCONG").ToString();
                cbThang.Text = gvDanhSach.GetFocusedRowCellValue("THANG").ToString();
                cbNam.Text = gvDanhSach.GetFocusedRowCellValue("NAM").ToString();
                cbKhoa.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("KHOA").ToString());
                chktrangthai.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("TRANGTHAI").ToString());
            }

        }

        private void btnxembc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangcongchitiet frm = new frmBangcongchitiet();
            frm._makycong = _makycong;
            frm._nam = int.Parse(cbNam.Text);
            frm._thang = int.Parse(cbThang.Text);

            frm.ShowDialog();
        }
       
            
    }
}