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

namespace QLNHANSU
{
    public partial class frmDangnhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }
        string taikhoan = "admin";
        string matkhau = "12345678";
        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(KiemTraDangNhap(txtTaikhoan.Text,txtMk.Text))
            {
                Mainform frm = new Mainform();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản và mật khẩu", "Lỗi");
                txtTaikhoan.Focus();
            } 
                
        }
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            if(taikhoan==this.taikhoan && matkhau==this.matkhau)
            {
                return true;
            }
            return false;
        }
    }
}