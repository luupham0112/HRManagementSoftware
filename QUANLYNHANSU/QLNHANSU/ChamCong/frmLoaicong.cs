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

namespace QLNHANSU.ChamCong
{
    public partial class frmLoaicong : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaicong()
        {
            InitializeComponent();
        }
        LoaiCong _loaica;
        bool _them;
        int _id;
        private void frmLoaicong_Load(object sender, EventArgs e)
        {
            _them = false;
            _loaica = new LoaiCong();
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
            btnDong.Enabled = kt;
            txtLoaicong.Enabled = !kt;
            spHeso.Enabled = !kt;
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
            txtLoaicong.Text = string.Empty;
            spHeso.EditValue = 1;

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
                _loaica.Delete(_id, 1);
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
                LOAICONG lc = new LOAICONG();
                lc.TENLC= txtLoaicong.Text;
                lc.HESO = double.Parse(spHeso.EditValue.ToString());
                lc.CREATE_BY = 1;
                lc.CREATE_DATE = DateTime.Now;
                _loaica.Add(lc);

            }
            else
            {
                var lc = _loaica.getItem(_id);
                lc.TENLC = txtLoaicong.Text;
                lc.HESO = double.Parse(spHeso.EditValue.ToString());
                lc.CREATE_BY = 1;
                lc.CREATE_DATE = DateTime.Now;
                _loaica.Update(lc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDLOAICONG").ToString());
                txtLoaicong.Text = gvDanhSach.GetFocusedRowCellValue("TENLC").ToString();
                spHeso.Text = gvDanhSach.GetFocusedRowCellValue("HESO").ToString();
            }
               
        }
    }
}