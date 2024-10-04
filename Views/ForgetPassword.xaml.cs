using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public partial class ForgetPassword : Window
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi nhấn nút gửi mã
        private void SendCodeButton_Click(object sender, RoutedEventArgs e)
        {
            string email = emailTextBox.Text;

            if (IsValidEmail(email))
            {
                // Giả sử bạn gửi mã xác nhận tới email của người dùng ở đây
                messageTextBlock.Text = "Mã xác nhận đã được gửi tới email của bạn!";
                messageTextBlock.Foreground = System.Windows.Media.Brushes.Green; // Thay đổi màu nếu thành công
            }
            else
            {
                messageTextBlock.Text = "Vui lòng nhập email hợp lệ.";
                messageTextBlock.Foreground = System.Windows.Media.Brushes.Red; // Màu đỏ nếu có lỗi
            }
        }

        // Hàm kiểm tra tính hợp lệ của email
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Sử dụng Regex để kiểm tra định dạng email
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private void SendCodeButton_Click1(object sender, RoutedEventArgs e)
        {
            // Hiển thị cửa sổ mã bảo mật
            SecurityCodeWindow securityCodeWindow = new SecurityCodeWindow();
            securityCodeWindow.Show();
            this.Close(); // Đóng cửa sổ hiện tại nếu muốn
        }
    }
}
