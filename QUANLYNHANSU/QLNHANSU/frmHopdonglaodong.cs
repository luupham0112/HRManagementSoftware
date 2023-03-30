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
using QLNHANSU.Report;
using DevExpress.XtraReports.UI;
using BusinessLayer.DTO;

namespace QLNHANSU
{
    public partial class frmHopdonglaodong : DevExpress.XtraEditors.XtraForm
    {
        public frmHopdonglaodong()
        {
            InitializeComponent();
        }
        NhanVien _nhanvien;

        HopDongLD _hdld;
        bool _them;
        string _sohd;
        string _maxsohd;
        List<Hopdong_DTO> _lstHD;//report
        private void frmHopdonglaodong_Load(object sender, EventArgs e)
        {
            _them = false;
            _hdld = new HopDongLD();
            _nhanvien = new NhanVien();
            loadData();
            _showHide(true);
            LoadNhanvien();
            splitContainer1.Panel1Collapsed = true;
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
            txtSoHopDong.Enabled = !kt;
            dtNgaybatdau.Enabled = !kt;
            dtNgayketthuc.Enabled = !kt;
            dtNgayKy.Enabled = !kt;
            spHeSoLuong.Enabled = !kt;
            spLanKy.Enabled = !kt;
            slkNhanVien.Enabled = !kt;
            spLuongcoban.Enabled = !kt;
            cboThoihan.Enabled = !kt;   
        }

        void _reset()
        {
            txtSoHopDong.Text = string.Empty;
            dtNgaybatdau.Value = DateTime.Now;
            dtNgayketthuc.Value = dtNgaybatdau.Value.AddMonths(6);
            dtNgayKy.Value = DateTime.Now;
            spLanKy.Text = "1";
            spHeSoLuong.Text = "1";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _hdld.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void LoadNhanvien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
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
                _hdld.Delete(_sohd,1);
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

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _lstHD = _hdld.getItemFull(_sohd);
            rptHopdonglaodong rpt = new rptHopdonglaodong(_lstHD);
            rpt.ShowPreviewDialog();
        }
        
        void SaveData()
        {
            if (_them)
            {
                var maxsohd = _hdld.MaxSoHDLD();
                int so = int.Parse(maxsohd.Substring(0, 5)) + 1;

                HOPDONG hd = new HOPDONG();
                hd.SOHD = so.ToString("00000") + @"/2022/HDLĐ";
                hd.NGAYBATDAU = dtNgaybatdau.Value;
                hd.NGAYKETTHUC = dtNgayketthuc.Value;
                hd.NGAYKI = dtNgayKy.Value;
                hd.THOIHAN = cboThoihan.Text;
                hd.HESOLUONG = double.Parse(spHeSoLuong.EditValue.ToString());
                hd.LUONGCOBAN = int.Parse(spLuongcoban.EditValue.ToString());
                hd.LANKY = int.Parse(spLanKy.EditValue.ToString());
                hd.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                hd.NOIDUNG = txtNoidung.RtfText;
                hd.CREATED_BY = 1;
                hd.CREATED_DATE = DateTime.Now;
                _hdld.Add(hd);

            }
            else
            {
                var hd = _hdld.getItem(_sohd);
                hd.NGAYBATDAU = dtNgaybatdau.Value;
                hd.NGAYKETTHUC = dtNgayketthuc.Value;
                hd.NGAYKI = dtNgayKy.Value;
                hd.THOIHAN = cboThoihan.Text;
                hd.HESOLUONG = double.Parse(spHeSoLuong.EditValue.ToString());
                hd.LUONGCOBAN = int.Parse(spLuongcoban.EditValue.ToString());
                hd.LANKY = int.Parse(spLanKy.EditValue.ToString());
                hd.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                hd.NOIDUNG = txtNoidung.RtfText;
                hd.UPDATE_BY = 1;
                hd.UPDATE_DATE = DateTime.Now;
                _hdld.Update(hd);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount>0)
            {
                _sohd = gvDanhSach.GetFocusedRowCellValue("SOHD").ToString();
                var hd = _hdld.getItem(_sohd);
                txtSoHopDong.Text = _sohd;
                dtNgaybatdau.Value = hd.NGAYBATDAU.Value;
                dtNgayketthuc.Value = hd.NGAYKETTHUC.Value;
                dtNgayKy.Value = hd.NGAYKI.Value;
                cboThoihan.Text = hd.THOIHAN.ToString();
                spHeSoLuong.Text = hd.HESOLUONG.ToString();
                spLuongcoban.Text = hd.LUONGCOBAN.ToString();
                spLanKy.Text = hd.LANKY.ToString();
                slkNhanVien.EditValue = hd.MANV;
                txtNoidung.RtfText= hd.NOIDUNG;
                _lstHD = _hdld.getItemFull(_sohd); //report
            }    
        }
    }
}