using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace PICcs
{
    /// <summary>
    /// Menu.xaml 的交互逻辑
    /// </summary>
    public partial class Menu : Window
    {
        private MainWindow _mainWindow;

        public Menu(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
                Title = "选择图片文件"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                //MessageBox.Show("打开: " + openFileDialog.FileName);
                _mainWindow.Title = "PIC " + openFileDialog.FileName;
                _mainWindow.Visibility = Visibility.Visible;
                Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "http://dataseven.hongshiite.cn/Help.html"; 
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法打开链接: " + ex.Message);
            }
        }
    }
}
