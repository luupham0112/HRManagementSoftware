
namespace QLNHANSU
{
    partial class frmCapnhatngaycong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapnhatngaycong));
            this.btnCapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.crdNgaycong = new System.Windows.Forms.MonthCalendar();
            this.rdChamcong = new DevExpress.XtraEditors.GroupControl();
            this.rdgChamcong = new DevExpress.XtraEditors.RadioGroup();
            this.rdNgaynghi = new DevExpress.XtraEditors.GroupControl();
            this.rdgNgaynghi = new DevExpress.XtraEditors.RadioGroup();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rdChamcong)).BeginInit();
            this.rdChamcong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgChamcong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdNgaynghi)).BeginInit();
            this.rdNgaynghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgNgaynghi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapnhat.ImageOptions.SvgImage")));
            this.btnCapnhat.Location = new System.Drawing.Point(375, 299);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(139, 49);
            this.btnCapnhat.TabIndex = 0;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // crdNgaycong
            // 
            this.crdNgaycong.Location = new System.Drawing.Point(18, 27);
            this.crdNgaycong.Name = "crdNgaycong";
            this.crdNgaycong.TabIndex = 1;
            this.crdNgaycong.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.crdNgaycong_DateSelected);
            // 
            // rdChamcong
            // 
            this.rdChamcong.Controls.Add(this.rdgChamcong);
            this.rdChamcong.Location = new System.Drawing.Point(362, 27);
            this.rdChamcong.Name = "rdChamcong";
            this.rdChamcong.Size = new System.Drawing.Size(300, 172);
            this.rdChamcong.TabIndex = 2;
            this.rdChamcong.Text = "Chấm công";
            // 
            // rdgChamcong
            // 
            this.rdgChamcong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgChamcong.Location = new System.Drawing.Point(2, 34);
            this.rdgChamcong.Name = "rdgChamcong";
            this.rdgChamcong.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Nghỉ phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Vắng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("VR", "Việc riêng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CT", "Công tác", true, null, "")});
            this.rdgChamcong.Size = new System.Drawing.Size(296, 136);
            this.rdgChamcong.TabIndex = 0;
            // 
            // rdNgaynghi
            // 
            this.rdNgaynghi.Controls.Add(this.rdgNgaynghi);
            this.rdNgaynghi.Location = new System.Drawing.Point(362, 205);
            this.rdNgaynghi.Name = "rdNgaynghi";
            this.rdNgaynghi.Size = new System.Drawing.Size(296, 75);
            this.rdNgaynghi.TabIndex = 3;
            this.rdNgaynghi.Text = "Thời gian nghỉ";
            this.rdNgaynghi.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // rdgNgaynghi
            // 
            this.rdgNgaynghi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgNgaynghi.Location = new System.Drawing.Point(2, 34);
            this.rdgNgaynghi.Name = "rdgNgaynghi";
            this.rdgNgaynghi.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Sáng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Chiều"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NN", "Cả ngày")});
            this.rdgNgaynghi.Size = new System.Drawing.Size(292, 39);
            this.rdgNgaynghi.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Location = new System.Drawing.Point(532, 299);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 49);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblHoten);
            this.groupControl2.Controls.Add(this.lbHoten);
            this.groupControl2.Controls.Add(this.lblID);
            this.groupControl2.Controls.Add(this.lbID);
            this.groupControl2.Location = new System.Drawing.Point(18, 299);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(300, 126);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Thông tin";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(108, 87);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(51, 19);
            this.lblHoten.TabIndex = 9;
            this.lblHoten.Text = "Hoten";
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(21, 87);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(67, 19);
            this.lbHoten.TabIndex = 8;
            this.lbHoten.Text = "Họ Tên:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(91, 52);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 19);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(21, 52);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(32, 19);
            this.lbID.TabIndex = 6;
            this.lbID.Text = "ID:";
            // 
            // frmCapnhatngaycong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 446);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.rdNgaynghi);
            this.Controls.Add(this.rdChamcong);
            this.Controls.Add(this.crdNgaycong);
            this.Controls.Add(this.btnCapnhat);
            this.MaximizeBox = false;
            this.Name = "frmCapnhatngaycong";
            this.Text = "Cập nhật ngày công";
            this.Load += new System.EventHandler(this.frmCapnhatngaycong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rdChamcong)).EndInit();
            this.rdChamcong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgChamcong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdNgaynghi)).EndInit();
            this.rdNgaynghi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgNgaynghi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCapnhat;
        private System.Windows.Forms.MonthCalendar crdNgaycong;
        private DevExpress.XtraEditors.GroupControl rdChamcong;
        private DevExpress.XtraEditors.RadioGroup rdgChamcong;
        private DevExpress.XtraEditors.GroupControl rdNgaynghi;
        private DevExpress.XtraEditors.RadioGroup rdgNgaynghi;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbID;
    }
}