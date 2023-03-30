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
using DataLayer;
using BusinessLayer;


namespace QLNHANSU
{
    public partial class frmKhenthuong : DevExpress.XtraEditors.XtraForm
    {
        public frmKhenthuong()
        {
            InitializeComponent();
        }
        KhenThuong _ktkl;
        NhanVien _nhanvien;

        bool _them;
        string _soqd;

        private void frmKhenthuong_Load(object sender, EventArgs e)
        {
            _them = false;
            _ktkl = new KhenThuong();
            _nhanvien = new NhanVien();
            loadData();
            _showHide(true);
            LoadNhanvien();
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
            gcDanhSach.Enabled = kt;
            txtSoquyetdinh.Enabled = !kt;
            txtNoidung.Enabled = !kt;
            txtLydo.Enabled = !kt;
            dtNgay.Enabled = !kt;
            slkNhanVien.Enabled = !kt;

        }
        private void _reset()
        {
            txtLydo.Text = string.Empty;
            txtSoquyetdinh.Text = string.Empty;
            txtNoidung.Text = string.Empty;
            dtNgay.Value = DateTime.Now;
           
        }
        void loadData()
        {
            gcDanhSach.DataSource = _ktkl.getListFull(1);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void LoadNhanvien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getListFull();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
            gcDanhSach.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ktkl.Delete(_soqd,1);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void SaveData()
        {
         
            if (_them)
            {

                var maxsoqd = _ktkl.MaxSoQuyetDinh(1);
                int so = int.Parse(maxsoqd.Substring(0, 5)) + 1;

                KHENTHUONGKYLUAT hd = new KHENTHUONGKYLUAT();
                hd.SOQD = so.ToString("00000") + @"/2022/QĐKT";
                hd.LYDO = txtLydo.Text;
                hd.NOIDUNG = txtNoidung.Text;
                hd.NGAY = dtNgay.Value;
                hd.LOAI = 1;
                hd.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                hd.CREATE_BY = 1;
                hd.CREATE_DATE = DateTime.Now;
                _ktkl.Add(hd);

            }
            else
            {
                var hd = _ktkl.getItem(_soqd);
                hd.LYDO = txtLydo.Text;
                hd.NOIDUNG = txtNoidung.Text;
                hd.NGAY = dtNgay.Value;
                hd.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                hd.UPDATE_BY = 1;
                hd.UPDATE_DATE = DateTime.Now;
                _ktkl.Update(hd);
            }
           
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soqd = gvDanhSach.GetFocusedRowCellValue("SOQD").ToString();
                var hd = _ktkl.getItem(_soqd);
                txtSoquyetdinh.Text = _soqd;
                txtNoidung.Text = hd.NOIDUNG.ToString();
                txtLydo.Text = hd.LYDO.ToString();
                dtNgay.Value = hd.NGAY.Value;
                slkNhanVien.EditValue = hd.MANV;

            }
        }
    }
}