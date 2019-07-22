using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HostComputer
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class PopupWindow1 : Window
    {
        public PopupWindow1()
        {
            InitializeComponent();
        }
        public PopupWindow1(string txmsg,string leftbtnmsg,string rightbtnmsg)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            txblk.Text = txmsg;
            btnLeft.Content = leftbtnmsg;
            btnRight.Content = rightbtnmsg;
        }
        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            txblk.Text = "寻参完毕";
        }
        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            txblk.Text = "寻参失败";
            this.Close();
        }
    }
}
