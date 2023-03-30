
namespace QLNHANSU
{
    partial class frmHopdonglaodong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopdonglaodong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.spLuongcoban = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboThoihan = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoidung = new DevExpress.XtraRichEdit.RichEditControl();
            this.slkNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spHeSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.spLanKy = new DevExpress.XtraEditors.SpinEdit();
            this.dtNgayKy = new System.Windows.Forms.DateTimePicker();
            this.dtNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.dtNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.txtSoHopDong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SOHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKETTHUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LANKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOIHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LUONGCOBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spLuongcoban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHopDong.Properties)).BeginInit();
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
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnDong,
            this.btnIn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1728, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 792);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1728, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 758);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1728, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 758);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.spLuongcoban);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.cboThoihan);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.txtNoidung);
            this.splitContainer1.Panel1.Controls.Add(this.slkNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.spHeSoLuong);
            this.splitContainer1.Panel1.Controls.Add(this.spLanKy);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKy);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayketthuc);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgaybatdau);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoHopDong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl10);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1728, 758);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.TabIndex = 4;
            // 
            // spLuongcoban
            // 
            this.spLuongcoban.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spLuongcoban.Location = new System.Drawing.Point(553, 106);
            this.spLuongcoban.MenuManager = this.barManager1;
            this.spLuongcoban.Name = "spLuongcoban";
            this.spLuongcoban.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spLuongcoban.Size = new System.Drawing.Size(150, 28);
            this.spLuongcoban.TabIndex = 27;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(426, 111);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(97, 19);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "Lương cơ bản";
            // 
            // cboThoihan
            // 
            this.cboThoihan.FormattingEnabled = true;
            this.cboThoihan.Items.AddRange(new object[] {
            "3 tháng",
            "6 tháng",
            "12 tháng"});
            this.cboThoihan.Location = new System.Drawing.Point(906, 58);
            this.cboThoihan.Name = "cboThoihan";
            this.cboThoihan.Size = new System.Drawing.Size(174, 27);
            this.cboThoihan.TabIndex = 25;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(805, 66);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 19);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Thời hạn";
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(230, 196);
            this.txtNoidung.MenuManager = this.barManager1;
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(1190, 474);
            this.txtNoidung.TabIndex = 23;
            // 
            // slkNhanVien
            // 
            this.slkNhanVien.Location = new System.Drawing.Point(906, 20);
            this.slkNhanVien.MenuManager = this.barManager1;
            this.slkNhanVien.Name = "slkNhanVien";
            this.slkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkNhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkNhanVien.Size = new System.Drawing.Size(224, 28);
            this.slkNhanVien.TabIndex = 22;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coMANV,
            this.coHOTEN});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coMANV
            // 
            this.coMANV.Caption = "Mã Nhân Viên";
            this.coMANV.FieldName = "MANV";
            this.coMANV.MaxWidth = 80;
            this.coMANV.MinWidth = 80;
            this.coMANV.Name = "coMANV";
            this.coMANV.Visible = true;
            this.coMANV.VisibleIndex = 0;
            this.coMANV.Width = 80;
            // 
            // coHOTEN
            // 
            this.coHOTEN.Caption = "Họ Tên";
            this.coHOTEN.FieldName = "HOTEN";
            this.coHOTEN.MaxWidth = 250;
            this.coHOTEN.MinWidth = 250;
            this.coHOTEN.Name = "coHOTEN";
            this.coHOTEN.Visible = true;
            this.coHOTEN.VisibleIndex = 1;
            this.coHOTEN.Width = 250;
            // 
            // spHeSoLuong
            // 
            this.spHeSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHeSoLuong.Location = new System.Drawing.Point(553, 54);
            this.spHeSoLuong.MenuManager = this.barManager1;
            this.spHeSoLuong.Name = "spHeSoLuong";
            this.spHeSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHeSoLuong.Size = new System.Drawing.Size(150, 28);
            this.spHeSoLuong.TabIndex = 21;
            // 
            // spLanKy
            // 
            this.spLanKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spLanKy.Location = new System.Drawing.Point(553, 15);
            this.spLanKy.MenuManager = this.barManager1;
            this.spLanKy.Name = "spLanKy";
            this.spLanKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spLanKy.Properties.IsFloatValue = false;
            this.spLanKy.Properties.Mask.EditMask = "N00";
            this.spLanKy.Size = new System.Drawing.Size(150, 28);
            this.spLanKy.TabIndex = 20;
            // 
            // dtNgayKy
            // 
            this.dtNgayKy.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKy.Location = new System.Drawing.Point(163, 115);
            this.dtNgayKy.Name = "dtNgayKy";
            this.dtNgayKy.Size = new System.Drawing.Size(200, 27);
            this.dtNgayKy.TabIndex = 19;
            // 
            // dtNgayketthuc
            // 
            this.dtNgayketthuc.CustomFormat = "dd/MM/yyyy";
            this.dtNgayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayketthuc.Location = new System.Drawing.Point(163, 82);
            this.dtNgayketthuc.Name = "dtNgayketthuc";
            this.dtNgayketthuc.Size = new System.Drawing.Size(200, 27);
            this.dtNgayketthuc.TabIndex = 18;
            // 
            // dtNgaybatdau
            // 
            this.dtNgaybatdau.CustomFormat = "dd/MM/yyyy";
            this.dtNgaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaybatdau.Location = new System.Drawing.Point(162, 49);
            this.dtNgaybatdau.Name = "dtNgaybatdau";
            this.dtNgaybatdau.Size = new System.Drawing.Size(200, 27);
            this.dtNgaybatdau.TabIndex = 17;
            // 
            // txtSoHopDong
            // 
            this.txtSoHopDong.Location = new System.Drawing.Point(163, 15);
            this.txtSoHopDong.MenuManager = this.barManager1;
            this.txtSoHopDong.Name = "txtSoHopDong";
            this.txtSoHopDong.Properties.ReadOnly = true;
            this.txtSoHopDong.Size = new System.Drawing.Size(199, 28);
            this.txtSoHopDong.TabIndex = 16;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(805, 29);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(73, 19);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "Nhân Viên";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(426, 58);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(92, 19);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "Hệ Số Lương";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(426, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 19);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Lần Ký";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(46, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 19);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Ngày Ký";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(46, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 19);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Ngày Kết Thúc";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 19);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Ngày Bắt Đầu";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(74, 261);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 19);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Nội Dung";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(46, 19);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(95, 19);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Số Hợp Đồng";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1728, 277);
            this.gcDanhSach.TabIndex = 23;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SOHD,
            this.NGAYBATDAU,
            this.NGAYKETTHUC,
            this.LANKY,
            this.MANV,
            this.THOIHAN,
            this.NGAYKI,
            this.LUONGCOBAN,
            this.HESOLUONG,
            this.HOTEN});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // SOHD
            // 
            this.SOHD.Caption = "Số Hợp Đồng";
            this.SOHD.FieldName = "SOHD";
            this.SOHD.MaxWidth = 150;
            this.SOHD.MinWidth = 150;
            this.SOHD.Name = "SOHD";
            this.SOHD.Visible = true;
            this.SOHD.VisibleIndex = 0;
            this.SOHD.Width = 150;
            // 
            // NGAYBATDAU
            // 
            this.NGAYBATDAU.Caption = "Ngày Bắt Đầu";
            this.NGAYBATDAU.FieldName = "NGAYBATDAU";
            this.NGAYBATDAU.MaxWidth = 150;
            this.NGAYBATDAU.MinWidth = 150;
            this.NGAYBATDAU.Name = "NGAYBATDAU";
            this.NGAYBATDAU.Visible = true;
            this.NGAYBATDAU.VisibleIndex = 1;
            this.NGAYBATDAU.Width = 150;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.Caption = "Ngày Kết Thúc";
            this.NGAYKETTHUC.FieldName = "NGAYKETTHUC";
            this.NGAYKETTHUC.MaxWidth = 150;
            this.NGAYKETTHUC.MinWidth = 150;
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.Visible = true;
            this.NGAYKETTHUC.VisibleIndex = 2;
            this.NGAYKETTHUC.Width = 150;
            // 
            // LANKY
            // 
            this.LANKY.Caption = "Lần Ký";
            this.LANKY.FieldName = "LANKY";
            this.LANKY.MaxWidth = 70;
            this.LANKY.MinWidth = 70;
            this.LANKY.Name = "LANKY";
            this.LANKY.Visible = true;
            this.LANKY.VisibleIndex = 4;
            this.LANKY.Width = 70;
            // 
            // MANV
            // 
            this.MANV.Caption = "MANV";
            this.MANV.FieldName = "MANV";
            this.MANV.MinWidth = 30;
            this.MANV.Name = "MANV";
            this.MANV.Width = 112;
            // 
            // THOIHAN
            // 
            this.THOIHAN.Caption = "Thời Hạn";
            this.THOIHAN.FieldName = "THOIHAN";
            this.THOIHAN.MaxWidth = 150;
            this.THOIHAN.MinWidth = 150;
            this.THOIHAN.Name = "THOIHAN";
            this.THOIHAN.Visible = true;
            this.THOIHAN.VisibleIndex = 5;
            this.THOIHAN.Width = 150;
            // 
            // NGAYKI
            // 
            this.NGAYKI.Caption = "Ngày ký";
            this.NGAYKI.FieldName = "NGAYKI";
            this.NGAYKI.MaxWidth = 100;
            this.NGAYKI.MinWidth = 100;
            this.NGAYKI.Name = "NGAYKI";
            this.NGAYKI.Visible = true;
            this.NGAYKI.VisibleIndex = 6;
            this.NGAYKI.Width = 100;
            // 
            // LUONGCOBAN
            // 
            this.LUONGCOBAN.Caption = "Lương cơ bản";
            this.LUONGCOBAN.FieldName = "LUONGCOBAN";
            this.LUONGCOBAN.MaxWidth = 100;
            this.LUONGCOBAN.MinWidth = 100;
            this.LUONGCOBAN.Name = "LUONGCOBAN";
            this.LUONGCOBAN.Visible = true;
            this.LUONGCOBAN.VisibleIndex = 7;
            this.LUONGCOBAN.Width = 100;
            // 
            // HESOLUONG
            // 
            this.HESOLUONG.Caption = "Hệ số lương";
            this.HESOLUONG.FieldName = "HESOLUONG";
            this.HESOLUONG.MaxWidth = 100;
            this.HESOLUONG.MinWidth = 100;
            this.HESOLUONG.Name = "HESOLUONG";
            this.HESOLUONG.Visible = true;
            this.HESOLUONG.VisibleIndex = 8;
            this.HESOLUONG.Width = 100;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "Tên Nhân Viên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 250;
            this.HOTEN.MinWidth = 250;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 3;
            this.HOTEN.Width = 250;
            // 
            // frmHopdonglaodong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 812);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHopdonglaodong";
            this.Text = "Hợp đồng lao động";
            this.Load += new System.EventHandler(this.frmHopdonglaodong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spLuongcoban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHopDong.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SearchLookUpEdit slkNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SpinEdit spHeSoLuong;
        private DevExpress.XtraEditors.SpinEdit spLanKy;
        private System.Windows.Forms.DateTimePicker dtNgayKy;
        private System.Windows.Forms.DateTimePicker dtNgayketthuc;
        private System.Windows.Forms.DateTimePicker dtNgaybatdau;
        private DevExpress.XtraEditors.TextEdit txtSoHopDong;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn SOHD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYBATDAU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKETTHUC;
        private DevExpress.XtraGrid.Columns.GridColumn LANKY;
        private DevExpress.XtraGrid.Columns.GridColumn THOIHAN;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraRichEdit.RichEditControl txtNoidung;
        private DevExpress.XtraGrid.Columns.GridColumn coMANV;
        private DevExpress.XtraGrid.Columns.GridColumn coHOTEN;
        private System.Windows.Forms.ComboBox cboThoihan;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit spLuongcoban;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKI;
        private DevExpress.XtraGrid.Columns.GridColumn LUONGCOBAN;
        private DevExpress.XtraGrid.Columns.GridColumn HESOLUONG;
    }
}