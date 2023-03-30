
namespace QLNHANSU
{
    partial class frmNhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboTrinhDo = new System.Windows.Forms.ComboBox();
            this.cboDanToc = new System.Windows.Forms.ComboBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.chkGioiTinh = new System.Windows.Forms.CheckBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CCCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QUEQUAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENDT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.barButtonItem7,
            this.btnIn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(304, 198);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem7, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 4;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Đóng";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 7;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1406, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 686);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1406, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 652);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1406, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 652);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboTrinhDo);
            this.splitContainer1.Panel1.Controls.Add(this.cboDanToc);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl11);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl10);
            this.splitContainer1.Panel1.Controls.Add(this.cboChucVu);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.cboPhongBan);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.txtQueQuan);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.txtDienThoai);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.txtCCCD);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtDiaChi);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgaySinh);
            this.splitContainer1.Panel1.Controls.Add(this.chkGioiTinh);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.txtHoTen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1406, 652);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 4;
            // 
            // cboTrinhDo
            // 
            this.cboTrinhDo.FormattingEnabled = true;
            this.cboTrinhDo.Location = new System.Drawing.Point(1070, 19);
            this.cboTrinhDo.Name = "cboTrinhDo";
            this.cboTrinhDo.Size = new System.Drawing.Size(290, 27);
            this.cboTrinhDo.TabIndex = 26;
            // 
            // cboDanToc
            // 
            this.cboDanToc.FormattingEnabled = true;
            this.cboDanToc.Location = new System.Drawing.Point(538, 55);
            this.cboDanToc.Name = "cboDanToc";
            this.cboDanToc.Size = new System.Drawing.Size(204, 27);
            this.cboDanToc.TabIndex = 24;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(438, 58);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(59, 19);
            this.labelControl11.TabIndex = 23;
            this.labelControl11.Text = "Dân Tộc";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(973, 23);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(61, 19);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "Trình độ";
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(1070, 104);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(290, 27);
            this.cboChucVu.TabIndex = 20;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(973, 108);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 19);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Chức Vụ";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(1070, 63);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(290, 27);
            this.cboPhongBan.TabIndex = 18;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(973, 67);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(76, 19);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Phòng Ban";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(32, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 19);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Ngày Sinh";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(32, 63);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 19);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Giới Tính";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(438, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 19);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Quê quán";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(538, 19);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(261, 27);
            this.txtQueQuan.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(438, 154);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 19);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Số ĐT";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(538, 148);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(261, 27);
            this.txtDienThoai.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 19);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Số CCCD";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(117, 151);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(261, 27);
            this.txtCCCD.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(438, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 19);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(538, 104);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(391, 27);
            this.txtDiaChi.TabIndex = 7;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(117, 95);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(261, 27);
            this.dtNgaySinh.TabIndex = 6;
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.AutoSize = true;
            this.chkGioiTinh.Location = new System.Drawing.Point(117, 66);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Size = new System.Drawing.Size(95, 23);
            this.chkGioiTinh.TabIndex = 5;
            this.chkGioiTinh.Text = "Nam/Nữ";
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(117, 19);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(261, 27);
            this.txtHoTen.TabIndex = 3;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1406, 448);
            this.gcDanhSach.TabIndex = 1;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MANV,
            this.HOTEN,
            this.GIOITINH,
            this.NGAYSINH,
            this.CCCD,
            this.DIENTHOAI,
            this.DIACHI,
            this.QUEQUAN,
            this.IDPB,
            this.TENPB,
            this.IDCV,
            this.TENCV,
            this.IDTD,
            this.TENTD,
            this.IDDT,
            this.TENDT});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // MANV
            // 
            this.MANV.Caption = "MÃ NV";
            this.MANV.FieldName = "MANV";
            this.MANV.MaxWidth = 30;
            this.MANV.MinWidth = 30;
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 0;
            this.MANV.Width = 30;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "Họ Tên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 200;
            this.HOTEN.MinWidth = 200;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 200;
            // 
            // GIOITINH
            // 
            this.GIOITINH.Caption = "Giới Tính";
            this.GIOITINH.FieldName = "GIOITINH";
            this.GIOITINH.MaxWidth = 120;
            this.GIOITINH.MinWidth = 120;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Visible = true;
            this.GIOITINH.VisibleIndex = 2;
            this.GIOITINH.Width = 120;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.Caption = "Ngày sinh";
            this.NGAYSINH.FieldName = "NGAYSINH";
            this.NGAYSINH.MaxWidth = 120;
            this.NGAYSINH.MinWidth = 120;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Visible = true;
            this.NGAYSINH.VisibleIndex = 3;
            this.NGAYSINH.Width = 120;
            // 
            // CCCD
            // 
            this.CCCD.Caption = "Số CCCD";
            this.CCCD.FieldName = "CCCD";
            this.CCCD.MaxWidth = 120;
            this.CCCD.MinWidth = 120;
            this.CCCD.Name = "CCCD";
            this.CCCD.Visible = true;
            this.CCCD.VisibleIndex = 4;
            this.CCCD.Width = 120;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.Caption = "Số ĐT";
            this.DIENTHOAI.FieldName = "DIENTHOAI";
            this.DIENTHOAI.MaxWidth = 120;
            this.DIENTHOAI.MinWidth = 120;
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Visible = true;
            this.DIENTHOAI.VisibleIndex = 5;
            this.DIENTHOAI.Width = 120;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "Địa Chỉ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.MaxWidth = 350;
            this.DIACHI.MinWidth = 350;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 6;
            this.DIACHI.Width = 350;
            // 
            // QUEQUAN
            // 
            this.QUEQUAN.Caption = "Quê Quán";
            this.QUEQUAN.FieldName = "QUEQUAN";
            this.QUEQUAN.MaxWidth = 120;
            this.QUEQUAN.MinWidth = 120;
            this.QUEQUAN.Name = "QUEQUAN";
            this.QUEQUAN.Visible = true;
            this.QUEQUAN.VisibleIndex = 7;
            this.QUEQUAN.Width = 120;
            // 
            // IDPB
            // 
            this.IDPB.Caption = "IDPB";
            this.IDPB.FieldName = "IDPB";
            this.IDPB.MinWidth = 30;
            this.IDPB.Name = "IDPB";
            this.IDPB.Width = 112;
            // 
            // TENPB
            // 
            this.TENPB.Caption = "Phòng Ban";
            this.TENPB.FieldName = "TENPB";
            this.TENPB.MaxWidth = 200;
            this.TENPB.MinWidth = 200;
            this.TENPB.Name = "TENPB";
            this.TENPB.Visible = true;
            this.TENPB.VisibleIndex = 8;
            this.TENPB.Width = 200;
            // 
            // IDCV
            // 
            this.IDCV.Caption = "IDCV";
            this.IDCV.FieldName = "IDCV";
            this.IDCV.MinWidth = 30;
            this.IDCV.Name = "IDCV";
            this.IDCV.Width = 112;
            // 
            // TENCV
            // 
            this.TENCV.Caption = "Chức vụ";
            this.TENCV.FieldName = "TENCV";
            this.TENCV.MaxWidth = 120;
            this.TENCV.MinWidth = 120;
            this.TENCV.Name = "TENCV";
            this.TENCV.Visible = true;
            this.TENCV.VisibleIndex = 10;
            this.TENCV.Width = 120;
            // 
            // IDTD
            // 
            this.IDTD.Caption = "IDTD";
            this.IDTD.FieldName = "IDTD";
            this.IDTD.MinWidth = 30;
            this.IDTD.Name = "IDTD";
            this.IDTD.Width = 112;
            // 
            // TENTD
            // 
            this.TENTD.Caption = "Trình Độ";
            this.TENTD.FieldName = "TENTD";
            this.TENTD.MaxWidth = 120;
            this.TENTD.MinWidth = 120;
            this.TENTD.Name = "TENTD";
            this.TENTD.Visible = true;
            this.TENTD.VisibleIndex = 9;
            this.TENTD.Width = 120;
            // 
            // IDDT
            // 
            this.IDDT.Caption = "IDDT";
            this.IDDT.FieldName = "IDDT";
            this.IDDT.MinWidth = 30;
            this.IDDT.Name = "IDDT";
            this.IDDT.Width = 112;
            // 
            // TENDT
            // 
            this.TENDT.Caption = "Dân tộc";
            this.TENDT.FieldName = "TENDT";
            this.TENDT.MaxWidth = 120;
            this.TENDT.MinWidth = 120;
            this.TENDT.Name = "TENDT";
            this.TENDT.Visible = true;
            this.TENDT.VisibleIndex = 11;
            this.TENDT.Width = 120;
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 706);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhanvien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cboTrinhDo;
        private System.Windows.Forms.ComboBox cboDanToc;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.ComboBox cboChucVu;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtQueQuan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtCCCD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.CheckBox chkGioiTinh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn CCCD;
        private DevExpress.XtraGrid.Columns.GridColumn DIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn QUEQUAN;
        private DevExpress.XtraGrid.Columns.GridColumn IDPB;
        private DevExpress.XtraGrid.Columns.GridColumn TENPB;
        private DevExpress.XtraGrid.Columns.GridColumn IDCV;
        private DevExpress.XtraGrid.Columns.GridColumn IDTD;
        private DevExpress.XtraGrid.Columns.GridColumn TENTD;
        private DevExpress.XtraGrid.Columns.GridColumn IDDT;
        private DevExpress.XtraGrid.Columns.GridColumn TENDT;
        private DevExpress.XtraGrid.Columns.GridColumn TENCV;
    }
}