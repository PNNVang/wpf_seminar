using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Sự kiện khi nhấn vào nhãn "Quên mật khẩu?"
        private void ForgetPasswordLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Mở cửa sổ khôi phục mật khẩu
            ForgetPassword paw = new ForgetPassword();
            paw.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
