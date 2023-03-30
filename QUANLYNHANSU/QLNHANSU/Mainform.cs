using QLNHANSU.ChamCong;
using QLNHANSU.Chamluong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class Mainform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Mainform()
        {
            InitializeComponent();
        }

        void openForm(Type typeForm)
        {
            foreach(var frm in MdiChildren)
            {
                if(frm.GetType()==typeForm)
                {
                    frm.Activate();
                    return;
                }    
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }

        private void btnDantoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(Dantoc));
        }

        private void btnTrinhdo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTrinhdo));
        }

        private void btnPhongban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmPhongban));
        }

        private void btnChucvu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmChucvu));
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmNhanvien));
        }

        private void btnBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // openForm(typeof(frmBophan));
        }

        private void btnHopdong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmHopdonglaodong));
        }

        private void btnLoaica_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmLoaica));
        }

        private void btnLoaicong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmLoaicong));
        }

        private void btnBangcong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBangcong));
        }

        private void btnPhucap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmPhucap));
        }

        private void btnTangca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTangca));
        }

        private void btnBangluong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBangluong));
        }

        private void btnThoiviec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmThoiviec));
        }

        private void btnKTKL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmKhenthuong));
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
