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
    public partial class frmThoiviec : DevExpress.XtraEditors.XtraForm
    {
        public frmThoiviec()
        {
            InitializeComponent();
        }
        NhanVien _nhanvien;
        Nhanvien_Thoiviec _nvtv;
        bool _them;
        string _soqd;
        private void frmThoiviec_Load(object sender, EventArgs e)
        {

            _them = false;
            _nvtv = new Nhanvien_Thoiviec();
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
            dtNgaynghi.Enabled = !kt;
            dtNgaynopdon.Enabled = !kt;
            txtGhichu.Enabled = !kt;
            txtLydo.Enabled = !kt;
            slkNhanVien.Enabled = !kt;

        }
        private void _reset()
        {
            txtLydo.Text = string.Empty;
            txtSoquyetdinh.Text = string.Empty;
            txtGhichu.Text = string.Empty;
            dtNgaynopdon.Value = DateTime.Now;
            dtNgaynghi.Value = dtNgaynopdon.Value.AddDays(45);
        }
        void loadData()
        {
            gcDanhSach.DataSource = _nvtv.getListFull();
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
                _nvtv.Delete(_soqd, 1);
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
            NV_THOIVIEC hd;
            if (_them)
            {
            
                var maxsoqd = _nvtv.MaxSoQuyetDinh();
                int so = int.Parse(maxsoqd.Substring(0, 5)) + 1;

                hd = new NV_THOIVIEC();
                hd.SOQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QDTV";
                hd.NGAYNOPDON = dtNgaynopdon.Value;
                hd.NGAYNGHI = dtNgaynghi.Value;
                hd.LYDO = txtLydo.Text;
                hd.GHICHU = txtGhichu.Text;
                hd.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                hd.CREATE_BY = 1;
                hd.CREATE_DATE = DateTime.Now;
                _nvtv.Add(hd);

            }
            else
            {
                hd = _nvtv.getItem(_soqd);
                hd.NGAYNOPDON = dtNgaynopdon.Value;
                hd.NGAYNGHI = dtNgaynghi.Value;
                hd.LYDO = txtLydo.Text;
                hd.GHICHU = txtGhichu.Text;
                hd.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                hd.UPDATE_BY = 1;
                hd.UPDATE_DATE = DateTime.Now;
                _nvtv.Update(hd);
            }
            var nv = _nhanvien.getItem(hd.MANV.Value);
            nv.DATHOIVIEC = true;
            _nhanvien.Update(nv);
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soqd = gvDanhSach.GetFocusedRowCellValue("SOQD").ToString();
                var hd = _nvtv.getItem(_soqd);
                txtSoquyetdinh.Text = _soqd;
                dtNgaynopdon.Value = hd.NGAYNOPDON.Value;
                dtNgaynghi.Value = hd.NGAYNGHI.Value;        
                txtGhichu.Text = hd.GHICHU.ToString();
                txtLydo.Text = hd.LYDO.ToString();
                slkNhanVien.EditValue = hd.MANV;

            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETE_BY" && e.CellValue != null)
            {
                //  Image img = Properties.Resources.del_Icon_x16;
                //   e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}