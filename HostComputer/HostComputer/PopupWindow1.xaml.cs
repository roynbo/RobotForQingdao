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
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }
        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {

        }
        public void PopWindowClose()
        {
            this.Close();
        }
        public void PopWindowMsgShow(string msg)
        {
            txblk.Text = msg;
        }
    }
}
