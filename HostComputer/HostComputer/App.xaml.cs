using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;

namespace HostComputer
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : System.Windows.Application
    {
        //WPF处理没注意到的异常，程序启动时注册事件，
        //程序中漏网之鱼发生时，程序会立刻崩溃，WPF提供了application. DispatcherUnhandledException
        public App()
        {
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            System.Windows.MessageBox.Show("遇到错误" + Environment.NewLine + e.Exception.Message,"错误提示",MessageBoxButton.OK);
            e.Handled = true;
        }
    }
}
