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

namespace QLNHANSU.Chamluong
{
    public partial class frmPhucap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhucap()
        {
            InitializeComponent();
        }
        PhuCap _phucap;
        NhanVien _nhanvien;
        bool _them;
        int _id;
        private void frmPhucap_Load(object sender, EventArgs e)
        {
            _them = false;
            _phucap = new PhuCap();
            _nhanvien = new NhanVien();
            _showHide(true);
            loadData();
            loadNhanvien();
            loadPhucap();
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
            txtNoidung.Enabled = !kt;
            spsotien.Enabled = !kt;
            slkNhanvien.Enabled = !kt;
            cboPhucap.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _phucap.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadNhanvien()
        {
            slkNhanvien.Properties.DataSource = _nhanvien.getListFull();
            slkNhanvien.Properties.DisplayMember = "HOTEN";
            slkNhanvien.Properties.ValueMember = "MANV";
        }
        void loadPhucap()
        {
            cboPhucap.DataSource = _phucap.getListPhucap();
            cboPhucap.DisplayMember = "TENPC";
            cboPhucap.ValueMember = "IDPC";

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtNoidung.Text = string.Empty;
            spsotien.EditValue = 0;
            slkNhanvien.EditValue=0 ;
            cboPhucap.SelectedIndex = -1;

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
                _phucap.Delete(_id, 1);
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
        void SaveData()
        {
            if (_them)
            {
                PHUCAP_NV lc = new PHUCAP_NV();
                lc.IDPC = int.Parse(cboPhucap.SelectedValue.ToString());
                lc.MANV = int.Parse(slkNhanvien.EditValue.ToString());
                lc.SOTIEN = double.Parse(spsotien.EditValue.ToString());
                lc.NOIDUNG = txtNoidung.Text;
                lc.NGAY = DateTime.Now;
                lc.CREATE_BY = 1;
                lc.CREATE_DATE = DateTime.Now;
                _phucap.Add(lc);

            }
            else
            {
                var lc = _phucap.getItem(_id);
                lc.IDPC = int.Parse(cboPhucap.SelectedValue.ToString());
                lc.MANV = int.Parse(slkNhanvien.EditValue.ToString());
                lc.SOTIEN = double.Parse(spsotien.EditValue.ToString());
                lc.NOIDUNG = txtNoidung.Text;
                lc.NGAY = DateTime.Now;
                lc.UPDATE_BY = 1;
                lc.UPDATE_DATE = DateTime.Now;
                _phucap.Update(lc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtNoidung.Text = gvDanhSach.GetFocusedRowCellValue("NOIDUNG").ToString();
                spsotien.EditValue = gvDanhSach.GetFocusedRowCellValue("SOTIEN");
                slkNhanvien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
                cboPhucap.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDPC");
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if(e.Column.Name=="DELETE_BY" && e.CellValue!=null)
            {
              //  Image img = Properties.Resources.del_Icon_x16;
             //   e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }    
        }
    }
}