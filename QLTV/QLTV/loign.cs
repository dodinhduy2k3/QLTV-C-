using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTV
{
    public partial class loign : Form
    {
        private string connectionString = "Data Source=xe;User ID=QL-Thu-Vien;Password=123456;Unicode=True";

        public loign()
        {
            InitializeComponent();
        }

        private void btnloign_Click(object sender, EventArgs e)
        {
            

            string tenNguoiDung = txtus.Text;
            string pass = txtpass.Text;
            string vaitro = layvaitro(tenNguoiDung, pass);

            if (vaitro == "admin")
            {
                
                MessageBox.Show("Đăng Nhập Thành Công với cài trò Admin");
                admin1 formAdmin = new admin1();
                formAdmin.Show();
                
            }
            else if (vaitro == "user")
            {
                // Đăng nhập thành công với vai trò người dùng, chuyển hướng đến FormUser
               
                MessageBox.Show("Đăng nhập thành công với vai trò Người dùng!");
                user formUser = new user();
                formUser.Show();
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }

            

        }

        private string layvaitro(string tenNguoiDung,string pass)
        {
            if(tenNguoiDung == "admin")
            {
                return "admin";
            }
            else
            {
                return "user";
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
