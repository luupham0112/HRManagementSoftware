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
using QLNHANSU.ChamCong;

namespace QLNHANSU
{
    public partial class frmCapnhatngaycong : DevExpress.XtraEditors.XtraForm
    {
        public frmCapnhatngaycong()
        {
            InitializeComponent();
        }
        public int _manv;
        public string _hoten;
        public int _makycong;
        public string _ngay;
        public int _cNgay;
        KyCongChiTiet _kcct;
        BangCongNVChiTiet _bcct_nv;
        frmBangcongchitiet frmBCCC = (frmBangcongchitiet) Application.OpenForms["frmBangcongchitiet"];
        private void frmCapnhatngaycong_Load(object sender, EventArgs e)
        {
            _kcct = new KyCongChiTiet();
            lblID.Text = _manv.ToString();
            lblHoten.Text = _hoten;
            string nam = _makycong.ToString().Substring(0, 4);
            string thang = _makycong.ToString().Substring(4);
            string ngay = _ngay.Substring(1);
            DateTime _d = DateTime.Parse(nam + "-" + thang + "-" + ngay);
            crdNgaycong.SetDate(_d);
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string _valueChamCong = rdgChamcong.Properties.Items[rdgChamcong.SelectedIndex].Value.ToString();
            string _valueNgayNghi = rdgNgaynghi.Properties.Items[rdgNgaynghi.SelectedIndex].Value.ToString();
          
            string fieldName = "D" + _cNgay.ToString();
            var kcct = _kcct?.getItem(_makycong, _manv);
           // double? tongngaycong = kcct?.TONGNGAYCONG;
          //  double? tongngayphep = kcct?.NGAYPHEP;
          //  double? tongngaykhongphep = kcct?.NGHIKHONGPHEP; ;
           // double? tongngayle = kcct?.CONGNGAYLE;//2022*100+1=202201
            if (crdNgaycong.SelectionRange.Start.Year * 100 + crdNgaycong.SelectionRange.Start.Month != +_makycong)
            {
                MessageBox.Show("Thực hiện chấm công không đúng kỳ công. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
         //   Cập nhật KYCONGCHITIET=> cập nhật BANGCONG_NV_CT
            function.execQuery("UPDATE KYCONGCHITIET SET " + fieldName + "='" + _valueChamCong + "' WHERE MAKYCONG=" + _makycong + " AND MANV=" + _manv);
            
            BANGCONGNVCHITIET bcctnv = _bcct_nv.getItem(_makycong,_manv,crdNgaycong.SelectionStart.Day);
           
            if(crdNgaycong.SelectionStart.DayOfWeek==DayOfWeek.Sunday)
            {
                if (_valueNgayNghi == "NN")
                {
                    bcctnv.NGAYCONG = 1;
                }
                else
                {
                    bcctnv.NGAYCONG = 0.5;
                    bcctnv.NGAYPHEP = 0.5;
                }
            }
            else
            {
                bcctnv.KYHIEU = _valueChamCong;
                switch (_valueChamCong)
                {
                    case "P":

                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGAYPHEP = 1;
                            bcctnv.NGAYCONG = 0;

                        }
                        else
                        {
                            bcctnv.NGAYPHEP = 0.5;
                            bcctnv.NGAYCONG = 0.5;

                        }
                        break;
                    case "CT":
                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGAYCONG = 1;
                        }
                        else
                        {
                            bcctnv.NGAYCONG = 0.5;
                            bcctnv.NGAYPHEP = 0.5;
                        }
                        break;
                    default:
                        break;
                }

            }
           
            //Update tb_BANGCONG_NV_CT
            _bcct_nv.Update(bcctnv);

            //Tính lại tổng các ngày: ngày phép, ngày công, ngày vắng,...
            double congchunhat= _bcct_nv.tongNgayCongCN(_makycong, _manv);
            double tongngaycong = _bcct_nv.tongNgayCong(_makycong, _manv);
            double tongngayphep = _bcct_nv.tongNgayPhep(_makycong, _manv);
            kcct.NGAYPHEP = tongngayphep;
            kcct.TONGNGAYCONG = tongngaycong;
            kcct.CONGCHUNHAT = congchunhat;
            _kcct.Update(kcct);

             
            frmBCCC.loadBangCong();

            // MessageBox.Show(_manv.ToString()+ " - "+_makycong.ToString() + " - "+ _ngay);
         
        }

         
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crdNgaycong_DateSelected(object sender, DateRangeEventArgs e)
        {
            _cNgay = crdNgaycong.SelectionRange.Start.Day;
        }
    }
}