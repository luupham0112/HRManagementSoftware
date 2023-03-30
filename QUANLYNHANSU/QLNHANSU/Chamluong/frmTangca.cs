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
    public partial class frmTangca : DevExpress.XtraEditors.XtraForm
    {
        public frmTangca()
        {
            InitializeComponent();
        }
        TangCa _tangca;
        NhanVien _nhanvien;
        LoaiCa _loaica;
        sys_config _config;
        bool _them;
        int _id;
        private void frmTangca_Load(object sender, EventArgs e)
        {
            _them = false;
            _tangca = new TangCa();
            _loaica = new LoaiCa();
            _nhanvien = new NhanVien();
            _config = new sys_config();

            _showHide(true);
            loadData();
            loadNhanvien();
            loadLoaica();
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
            txtGhichu.Enabled = !kt;
            spSogio.Enabled = !kt;
            slkNhanvien.Enabled = !kt;
            cboLoaica.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _tangca.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadNhanvien()
        {
            slkNhanvien.Properties.DataSource = _nhanvien.getListFull();
            slkNhanvien.Properties.DisplayMember = "HOTEN";
            slkNhanvien.Properties.ValueMember = "MANV";
        }
        void loadLoaica()
        {
            cboLoaica.DataSource = _loaica.getList();
            cboLoaica.DisplayMember = "TENLOAICA";
            cboLoaica.ValueMember = "IDLOAICA";

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtGhichu.Text = string.Empty;
            spSogio.EditValue = 0;
            slkNhanvien.EditValue = 0;
            cboLoaica.SelectedIndex = -1;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tangca.Delete(_id, 1);
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
                TANGCA lc = new TANGCA();
                lc.IDLOAICA = int.Parse(cboLoaica.SelectedValue.ToString());
                lc.MANV = int.Parse(slkNhanvien.EditValue.ToString());
                lc.SOGIO = double.Parse(spSogio.EditValue.ToString());
                lc.GHICHU = txtGhichu.Text;
                lc.NGAY = DateTime.Now.Day;
                lc.THANG = DateTime.Now.Month;
                lc.NAM = DateTime.Now.Year;
                var lca = _loaica.getItem(int.Parse(cboLoaica.SelectedValue.ToString()));
                var cg = _config.getItem("TANGCA");
                lc.SOTIEN = lc.SOGIO * lca.HESO * int.Parse(cg.VALUE);

                lc.CREATE_BY = 1;
                lc.CREATE_DATE = DateTime.Now;
                _tangca.Add(lc);

            }
            else
            {
                var lc = _tangca.getItem(_id);
                lc.IDLOAICA = int.Parse(cboLoaica.SelectedValue.ToString());
                lc.MANV = int.Parse(slkNhanvien.EditValue.ToString());
                lc.SOGIO = double.Parse(spSogio.EditValue.ToString());
                lc.GHICHU = txtGhichu.Text;
                lc.NGAY = DateTime.Now.Day;
                lc.THANG = DateTime.Now.Month;
                lc.NAM = DateTime.Now.Year;
                var lca = _loaica.getItem(int.Parse(cboLoaica.SelectedValue.ToString()));
                var cg = _config.getItem("TANGCA");
                lc.SOTIEN = lc.SOGIO * lca.HESO * int.Parse(cg.VALUE);
                lc.UPDATE_BY = 1;
                lc.UPDATE_DATE = DateTime.Now;
                _tangca.Update(lc);
            }
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtGhichu.Text = gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString();
                spSogio.EditValue = gvDanhSach.GetFocusedRowCellValue("SOGIO");
                slkNhanvien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
                cboLoaica.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDLOAICA");
            }
        }
    }
}