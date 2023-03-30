using DataLayer;
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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;

namespace QLNHANSU.ChamCong
{
    public partial class frmBangcongchitiet : DevExpress.XtraEditors.XtraForm
    {
        public frmBangcongchitiet()
        {
            InitializeComponent();
        }
        KyCongChiTiet _kcct;
		BangCong _kycong;
		NhanVien _nhanvien;
		BangCongNVChiTiet _bangcongCT;

        public int _makycong;
        public int _thang;
        public int _nam;
        private void frmBangcongchitiet_Load(object sender, EventArgs e)
        {
			_nhanvien = new NhanVien();
			_bangcongCT = new BangCongNVChiTiet();
            _kcct = new KyCongChiTiet();
			_kycong = new BangCong();
            gcBangCongChiTiet.DataSource = _kcct.getList(_makycong);
			gvBangCongChiTiet.OptionsBehavior.Editable = false;
			CustomView(_thang, _nam);
            cbThang.Text = _thang.ToString();
            cbNam.Text = _nam.ToString();
        }
        public void loadBangCong()
        {
			_kcct = new KyCongChiTiet();
            gcBangCongChiTiet.DataSource = _kcct.getList(int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text));
            CustomView(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
			gvBangCongChiTiet.OptionsBehavior.Editable = false;

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			
			SplashScreenManager.ShowForm(typeof(frmWaiting), true, true);
			/*
			if (_kycong.KiemTraPhatSinhKyCong(int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text)))
            {
				MessageBox.Show("Kỳ công đã được phát sinh", "Thông báo");
				SplashScreenManager.CloseForm();
				return;
			}
			*/
			//List<NHANVIEN> lstNhanVien = _nhanvien.getList();
			_kcct.phatSinhKyCongChiTiet(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
			/*
			foreach (var item in lstNhanVien)
			{
				for (int i = 1; i <= GetDayNumber(int.Parse(cbThang.Text), int.Parse(cbNam.Text)); i++)
				{
					BANGCONGNVCHITIET bcct = new BANGCONGNVCHITIET();
					bcct.MANV = item.MANV;
					bcct.HOTEN = item.HOTEN;
					bcct.GIOVAO = "08:00";
					bcct.GIORA = "17:00";
					bcct.NGAY = DateTime.Parse(cbNam.Text + "-" + cbThang.Text + "-" + i.ToString());
					bcct.THU = function.layThuTrongTuan(int.Parse(cbNam.Text), int.Parse(cbThang.Text), i);
					bcct.NGAYPHEP = 0;
					bcct.CONGNGAYLE = 0;
					bcct.CONGCHUNHAT = 0;
					
					if (bcct.THU == "Chủ nhật")
			        {
							bcct.KYHIEU = "CN";
			            bcct.NGAYCONG = 0;
			}
						else if (bcct.THU == "Thứ bảy")
			{
							bcct.KYHIEU = "T7";
			 bcct.NGAYCONG = 0;
			}
						else
			{
							bcct.KYHIEU = "X";
			bcct.NGAYCONG = 1;
			}
					bcct.MAKYCONG = _makycong;
					bcct.CREATE_DATE = DateTime.Now;
					bcct.CREATE_BY = 1;
					_bangcongCT.Add(bcct);
				}
			}
			
			var kc = _kycong.getItem(int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text));
			kc.TRANGTHAI = true;
			_kycong.Update(kc);
			*/
			SplashScreenManager.CloseForm();
            loadBangCong();
        }

        private void btnxembc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadBangCong();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadBangCong();
        }
		private void CustomView(int thang, int nam)
		{
			//gvBangCongChiTiet.RestoreLayoutFromXml(Application.StartupPath + @"\BangCong_Layout.xml");
			int i;
			foreach (GridColumn gridColumn in gvBangCongChiTiet.Columns)
			{
				if (gridColumn.FieldName == "HOTEN") continue;

				RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
				textEdit.Mask.MaskType = MaskType.RegEx;
				textEdit.Mask.EditMask = @"\p{Lu}+";
				gridColumn.ColumnEdit = textEdit;
			}

			for (i = 1; i <= GetDayNumber(thang, nam); i++)
			{
				DateTime newDate = new DateTime(nam, thang, i);

				GridColumn column = new GridColumn();
				column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
				string fieldName = "D" + i;
				switch (newDate.DayOfWeek.ToString())
				{
					case "Monday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Hai " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Blue;
						column.AppearanceHeader.BackColor = Color.Transparent;
						column.AppearanceHeader.BackColor2 = Color.Transparent;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Transparent;
						column.OptionsColumn.AllowFocus = true;
						//column.Width = 30;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						break;

					case "Tuesday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Ba " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Blue;
						column.AppearanceHeader.BackColor = Color.Transparent;
						column.AppearanceHeader.BackColor2 = Color.Transparent;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Transparent;
						column.OptionsColumn.AllowFocus = true;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						break;

					case "Wednesday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Tư " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Blue;
						column.AppearanceHeader.BackColor = Color.Transparent;
						column.AppearanceHeader.BackColor2 = Color.Transparent;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Transparent;
						column.OptionsColumn.AllowFocus = true;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						break;
					case "Thursday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Năm " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Blue;
						column.AppearanceHeader.BackColor = Color.Transparent;
						column.AppearanceHeader.BackColor2 = Color.Transparent;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Transparent;
						column.OptionsColumn.AllowFocus = true;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						break;
					case "Friday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Sáu " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Blue;
						column.AppearanceHeader.BackColor = Color.Transparent;
						column.AppearanceHeader.BackColor2 = Color.Transparent;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Transparent;
						column.OptionsColumn.AllowFocus = true;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						break;
					case "Saturday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Bảy " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Red;
						column.AppearanceHeader.BackColor = Color.Violet;
						column.AppearanceHeader.BackColor2 = Color.Violet;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Khaki;
						column.OptionsColumn.AllowFocus = true;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						break;
					case "Sunday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "CN " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = false;
						column.AppearanceHeader.ForeColor = Color.Red;
						column.AppearanceHeader.BackColor = Color.GreenYellow;
						column.AppearanceHeader.BackColor2 = Color.GreenYellow;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Orange;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						//column.OptionsColumn.AllowFocus = false;
						break;
				}
			}

			while (i <= 31)
			{
				gvBangCongChiTiet.Columns[i + 1].Visible = false;
				i++;
			}

		}
		private int GetDayNumber(int thang, int nam)
		{
			int dayNumber = 0;
			switch (thang)
			{
				case 2:
					dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
					break;

				case 4:
				case 6:
				case 9:
				case 11:
					dayNumber = 30;
					break;

				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					dayNumber = 31;
					break;
			}

			return dayNumber;
		}

        private void mnCapnhatngaycong_Click(object sender, EventArgs e)
        {
			frmCapnhatngaycong frm = new frmCapnhatngaycong();
			frm._makycong = _makycong;
			frm._manv = int.Parse(gvBangCongChiTiet.GetFocusedRowCellValue("MANV").ToString());
			frm._hoten = gvBangCongChiTiet.GetFocusedRowCellValue("HOTEN").ToString();
			frm._ngay = gvBangCongChiTiet.FocusedColumn.FieldName.ToString();
			frm.ShowDialog();
        }

        private void gvBangCongChiTiet_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

			if (e.CellValue == null)
			{

			}
			else
			{
				if (e.CellValue.ToString() == "VR")
				{
					e.Appearance.BackColor = Color.DarkGreen;
					e.Appearance.ForeColor = Color.White;
				}
				if (e.CellValue.ToString() == "CT")
				{
					e.Appearance.BackColor = Color.DeepSkyBlue;
					e.Appearance.ForeColor = Color.White;
				}
				if (e.CellValue.ToString() == "P")
				{
					e.Appearance.BackColor = Color.LightBlue;
				}
				if (e.CellValue.ToString() == "V")
				{
					e.Appearance.BackColor = Color.IndianRed;
					e.Appearance.ForeColor = Color.White;
				}
			}
		}
    }
}