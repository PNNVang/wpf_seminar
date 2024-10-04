using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public partial class SecurityCodeWindow : Window // Kế thừa từ Window
    {
        public SecurityCodeWindow() // Constructor
        {
            InitializeComponent(); // Gọi phương thức khởi tạo
        }

        private void ConfirmCodeButton_Click(object sender, RoutedEventArgs e)
        {
            // Xử lý sự kiện khi nút xác nhận được nhấn
            string enteredCode = securityCodeTextBox.Text; // Lấy mã bảo mật từ TextBox

            // Thực hiện kiểm tra mã ở đây
            if (IsValidCode(enteredCode))
            {
                confirmationMessageTextBlock.Text = "Mã bảo mật hợp lệ!";
            }
            else
            {
                confirmationMessageTextBlock.Text = "Mã bảo mật không hợp lệ. Vui lòng thử lại.";
            }
        }

        private bool IsValidCode(string code)
        {
            // Giả sử mã bảo mật hợp lệ là "12345"
            return code == "12345";
        }
    }
}
