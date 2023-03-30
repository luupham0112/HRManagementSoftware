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
    public partial class frmPhongban : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongban()
        {
            InitializeComponent();
        }

        PhongBan _phongban;
        bool _them;
        int _id;

        private void frmPhongban_Load(object sender, EventArgs e)
        {

            _them = false;
            _phongban = new PhongBan();
            _showHide(true);
            loadData();
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
            txtTen.Enabled = !kt;
            txtChucnang.Enabled = !kt;
        }

        void loadData()
        {
            gcDanhSach.DataSource = _phongban.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtTen.Text = string.Empty;
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
                _phongban.Delete(_id);
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

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                PHONGBAN pb = new PHONGBAN();
                pb.TENPB = txtTen.Text;
                pb.CHUCNANG = txtChucnang.Text;
                _phongban.Add(pb);

            }
            else
            {
                var pb = _phongban.getItem(_id);
                pb.TENPB = txtTen.Text;
                pb.CHUCNANG = txtChucnang.Text;
                _phongban.Update(pb);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDPB").ToString());
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENPB").ToString();
            txtChucnang.Text = gvDanhSach.GetFocusedRowCellValue("CHUCNANG").ToString();
        }
    }
}