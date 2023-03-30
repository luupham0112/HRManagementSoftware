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
using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;

namespace QLNHANSU
{
    public partial class frmNhanvien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        NhanVien _nhanvien;
        ChucVu _chucvu;
        DanToc _dantoc;
        PhongBan _phongban;
        TrinhDo _trinhdo;
        List<NhanVien_DTO> _lstNVDTO;//report
        bool _them;
        int _id;
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            _them = false;
            _nhanvien = new NhanVien();
            _chucvu = new ChucVu();
            _dantoc = new DanToc();
            _phongban = new PhongBan();
            _trinhdo = new TrinhDo();
            _showHide(true);
            loadData();
            loadCombo();
        }
        void loadCombo()
        {
           // cboBoPhan.DataSource = _bophan.getList();
           // cboBoPhan.DisplayMember = "TENBP";
           // cboBoPhan.ValueMember = "IDBP";

            cboPhongBan.DataSource = _phongban.getList();
            cboPhongBan.DisplayMember = "TENPB";
            cboPhongBan.ValueMember = "IDPB";

            cboChucVu.DataSource = _chucvu.getList();
            cboChucVu.DisplayMember = "TENCV";
            cboChucVu.ValueMember = "IDCV";

            cboTrinhDo.DataSource = _trinhdo.getList();
            cboTrinhDo.DisplayMember = "TENTD";
            cboTrinhDo.ValueMember = "IDTD";

            cboDanToc.DataSource = _dantoc.getList();
            cboDanToc.DisplayMember = "TENDT";
            cboDanToc.ValueMember = "IDDT";

        }

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            barButtonItem7.Enabled = kt;
            txtHoTen.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtQueQuan.Enabled = !kt;
            chkGioiTinh.Enabled = !kt;
           // cboBoPhan.Enabled = !kt;
            cboPhongBan.Enabled = !kt;
            cboChucVu.Enabled = !kt;
            cboTrinhDo.Enabled = !kt;
            cboDanToc.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
        }

        private void _reset()
        {
            txtHoTen.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtQueQuan.Text = string.Empty;
            chkGioiTinh.Checked = false;
        }
        private void loadData()
        {
            gcDanhSach.DataSource = _nhanvien.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstNVDTO = _nhanvien.getListFull(); // report
                
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
                _nhanvien.Delete(_id);
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

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptDanhsachNV rpt = new rptDanhsachNV(_lstNVDTO);
            rpt.ShowPreview();
        }
        void SaveData()
        {
            if (_them)
            {
                NHANVIEN nv = new NHANVIEN();
                nv.HOTEN = txtHoTen.Text;
                nv.GIOITINH = chkGioiTinh.Checked;
                nv.NGAYSINH = dtNgaySinh.Value;
                nv.CCCD = txtCCCD.Text;
                nv.DIENTHOAI = txtDienThoai.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.QUEQUAN = txtQueQuan.Text;
             //   nv.IDBP = int.Parse(cboBoPhan.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPhongBan.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboChucVu.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTrinhDo.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDanToc.SelectedValue.ToString());
                _nhanvien.Add(nv);

            }
            else
            {
                var nv = _nhanvien.getItem(_id);
                nv.HOTEN = txtHoTen.Text;
                nv.GIOITINH = chkGioiTinh.Checked;
                nv.NGAYSINH = dtNgaySinh.Value;
                nv.CCCD = txtCCCD.Text;
                nv.DIENTHOAI = txtDienThoai.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.QUEQUAN = txtQueQuan.Text;
              //  nv.IDBP = int.Parse(cboBoPhan.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPhongBan.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboChucVu.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTrinhDo.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDanToc.SelectedValue.ToString());
                _nhanvien.Update(nv);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount>0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MANV").ToString());
                var nv = _nhanvien.getItem(_id);
                txtHoTen.Text = nv.HOTEN;
                chkGioiTinh.Checked = nv.GIOITINH.Value;
                dtNgaySinh.Value=nv.NGAYSINH;
                txtCCCD.Text = nv.CCCD;
                txtDienThoai.Text = nv.DIENTHOAI;
                txtDiaChi.Text = nv.DIACHI;
                txtQueQuan.Text = nv.QUEQUAN;
                
                cboPhongBan.SelectedValue = nv.IDPB;
                cboChucVu.SelectedValue = nv.IDCV;
            //    cboBoPhan.SelectedValue = nv.IDBP;
                cboTrinhDo.SelectedValue = nv.IDTD;
                cboDanToc.SelectedValue = nv.IDDT;
            }    
        }
    }
}