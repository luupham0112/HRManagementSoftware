
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


namespace QLNHANSU
{
    public partial class frmTrinhdo : DevExpress.XtraEditors.XtraForm
    {
        public frmTrinhdo()
        {
            InitializeComponent();
        }

        TrinhDo _trinhdo;
        bool _them;
        int _id;

        private void frmTrinhdo_Load(object sender, EventArgs e)
        {

            _them = false;
            _trinhdo = new TrinhDo();
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
            txtBangcap.Enabled = !kt;
        }

        void loadData()
        {
            gcDanhSach.DataSource = _trinhdo.getList();
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
                _trinhdo.Delete(_id);
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
                TRINHDO td = new TRINHDO();
                td.TENTD = txtTen.Text;
                td.BANGCAP = txtBangcap.Text;

                _trinhdo.Add(td);

            }
            else
            {
                var td = _trinhdo.getItem(_id);
                td.TENTD = txtTen.Text;
                td.BANGCAP = txtBangcap.Text;
                _trinhdo.Update(td);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTD").ToString());
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENTD").ToString();
            txtBangcap.Text = gvDanhSach.GetFocusedRowCellValue("BANGCAP").ToString();
        }
    }

}