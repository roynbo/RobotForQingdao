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
using System.Windows.Threading;
using System.Threading;
using TwinCAT.Ads;
using System.Timers;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;
using System.Windows.Interop;
using System.IO.Ports;
using CircularGauge;

namespace HostComputer
{
    public partial class MainWindow : Window
    {
        #region 变量声明
        Process p;
        private double[] robotPos;
        private Upper_Lower_Com uplowcom;
        private RobotInteraction robotInteraction;
        SerialInterface serialinterface;
        MatrixCaculation matrixCaculation;
        Thread dataProcessThread;
        Thread carMoveDataSendThread;
        System.Timers.Timer timer1;
        int[] count = new int[5] { 0, 0, 0, 0, 0 };

        private double GlobalVelocity = 0.0;   //全局速率
        private double frontwheelvelocity = 0.0; //前轮速率
        private double backwheelvelocity = 0.0; //后轮速率
        private double pointvelocity = 0.0; //一般模式速率
        private double velocityToLower = 0.0; //发送给下位机的速度，车轮和摆臂不同
        private double carmovex = 0.0; //标准化的车移动摇杆值x
        private double carmovey = 0.0; //标准化的车移动摇杆值x
        private double carmovesendx = 0.0; //发送给下位机的车移动x
        private double carmovesendy = 0.0; //发送给下位机的车移动y
        private double armx = 0.0; //标准化的机械臂摇杆值x
        private double army = 0.0; //标准化的机械臂摇杆值y
        private double armz = 0.0; //标准化的机械臂摇杆值z
        private double armsendx = 0.0; //发送给下位机的机械臂速度x
        private double armsendy = 0.0; //发送给下位机的机械臂速度y
        private double armsendz = 0.0; //发送给下位机的机械臂速度z
        private double xcoefficient;
        private double ycoefficient;
        double[,] wvCaculatingMatrix = new double[2, 2] { { 0, 0 }, { 0, 0 } }; //逆推机械臂各轴角速度计算矩阵
        double[,] wvCaculatingMatrixReverse = new double[2, 2] { { 0, 0 }, { 0, 0 } }; //逆推机械臂各轴角速度逆矩阵
        double[,] armAngularVelocityMatrix = new double[2, 1] { { 0 }, { 0 } }; //机械臂各轴角速度，假定中臂、小臂速度相同，简化计算量
        double[,] armXYVelocityMatrix = new double[2, 1] { { 0 }, { 0 } }; //机械臂末端x\y速度
        double armAngel1 = 0; double armLength1 = 0.55; //机械臂三轴长度、当前相对地面角度
        double armAngel2 = 0; double armLength2 = 0.43;
        double armAngel3 = 0; double armLength3 = 0.33;
        private byte buttonNum = 0; //机械手抓取值
        private bool clawflag = false;//抓取标志
        private bool stopflag = false;//暂停标志
        private bool NormalModeFlag = true;//是否一般模式
        private bool handmode = false;//是否手模式
        private int carmoveflag = 0; //控制模式标志位\一般模式0\车模式10\手模式9
        private float guagecurrentvalue = 0.0f; //指示表控件当前值
                                                //0-3车轮旋转，4-7摆臂，8-12机械臂轴，13抓取
        Thread threadSendMSg;
        #endregion

        #region 窗体初始化
        public MainWindow()
        {
            //对客户端和数据流进行初始化
            robotPos = new double[7];
            Upper_Lower_Com.tcAdsClient = new TcAdsClient();
            Upper_Lower_Com.adsReadStream = new AdsStream(100);
            Upper_Lower_Com.adsWriteStream = new AdsStream(100);
            robotInteraction = new RobotInteraction();
            serialinterface = new SerialInterface();
            uplowcom = new Upper_Lower_Com();
            matrixCaculation = new MatrixCaculation();
            serialinterface.InitialPort();
            serialinterface.serialport1.DataReceived += new SerialDataReceivedEventHandler(Data_Received1);
            serialinterface.serialport2.DataReceived += new SerialDataReceivedEventHandler(Data_Received2);
            serialinterface.timer = new System.Timers.Timer(10);
            serialinterface.timer.Elapsed += new ElapsedEventHandler(serialinterface.SendCommandToSerial);
            serialinterface.timer.Enabled = false;
            InitializeComponent();
            robotInteraction.udp_Client();
            OpenU3d();
            threadSendMSg = new Thread(robotInteraction.udp_SendMessage);//开启UDP发送线程
            threadSendMSg.IsBackground = true;
            threadSendMSg.Start();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;  //在中间位置启动窗口
            this.WindowState = System.Windows.WindowState.Maximized;      //最大化启动
            //开数据采集、数据收发、数据处理线程
            dataProcessThread = new Thread(DataProcess);
            dataProcessThread.Start();
            //机器人运动摇杆数据发送线程
            carMoveDataSendThread = new Thread(carMoveDataSend);
            carMoveDataSendThread.Start();
        }
        #endregion
        #region 窗体加载事件（鼠标按下与抬起事件绑定）
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //OpenU3d();
            //鼠标点击事件绑定，鼠标按下与抬起分开定义
            slider1.AddHandler(Slider.MouseLeftButtonUpEvent, new MouseButtonEventHandler(slider1_MouseLeftButtonUp), true); //全局速率滑动条事件
            //点动模式车履带运动与摆动鼠标按下与抬起事件
            //CarBtn1.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
           // CarBtn2.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            //CarBtn3.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            //CarBtn4.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            CarBtn5.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            CarBtn6.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            CarBtn7.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            CarBtn8.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            //CarBtn9.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
           // CarBtn10.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
           // CarBtn11.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
          //  CarBtn12.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            CarBtn13.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            CarBtn14.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            CarBtn15.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            CarBtn16.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            //CarBtn1.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            //CarBtn2.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            //CarBtn3.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            //CarBtn4.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            CarBtn5.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            CarBtn6.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            CarBtn7.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            CarBtn8.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
           // CarBtn9.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
           // CarBtn10.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
           // CarBtn11.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
           // CarBtn12.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            CarBtn13.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            CarBtn14.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            CarBtn15.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            CarBtn16.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            //点动模式机械臂运动鼠标按下与抬起事件
            ArmBtn1.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn2.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn3.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn4.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn5.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn6.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn7.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn8.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn9.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn10.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn11.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn12.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(btn_MouseDown), true);
            ArmBtn1.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            ArmBtn2.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            ArmBtn3.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            ArmBtn4.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            ArmBtn5.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            ArmBtn6.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            ArmBtn7.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            ArmBtn8.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            ArmBtn9.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            ArmBtn10.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            ArmBtn11.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            ArmBtn12.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(btn_MouseUp), true);
            //点动模式履带摆动分组控制
            CarFrontUp.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(CarFrontUp_MouseUp), true);
            CarFrontUp.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(CarFrontUp_MouseDown), true);
            CarFrontDown.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(CarFrontDown_MouseUp), true);
            CarFrontDown.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(CarFrontDown_MouseDown), true);
            CarBackUp.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(CarBackUp_MouseUp), true);
            CarBackUp.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(CarBackUp_MouseDown), true);
            CarBackDown.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(CarBackDown_MouseUp), true);
            CarBackDown.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(CarBackDown_MouseDown), true);
            CoupleMoveUp.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(CoupleMoveUp_MouseUp), true);
            CoupleMoveUp.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(CoupleMoveUp_MouseDown), true);
            CoupleMoveDown.AddHandler(Button.MouseUpEvent, new MouseButtonEventHandler(CoupleMoveDown_MouseUp), true);
            CoupleMoveDown.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(CoupleMoveDown_MouseDown), true);
        }
        #endregion

        #region 窗体关闭事件（机器人下使能）
        private void Window_Closed(object sender, EventArgs e)
        {
            dataProcessThread.Abort();
            carMoveDataSendThread.Abort();
            if (serialinterface.serialport1.IsOpen)
            {
                serialinterface.serialport1.Close();
            }
            if (serialinterface.serialport2.IsOpen)
            {
                serialinterface.serialport2.Close();
            }
            uplowcom.SendUintInstruct(40, 0x1);//车体下使能
            uplowcom.SendUintInstruct(50, 0x1);//机械臂下使能

            uplowcom.SendDoubleInstruct(0, 0x3);
            uplowcom.SendDoubleInstruct(0, 0x4);
            uplowcom.SendDoubleInstruct(0, 0x5);
            uplowcom.SendDoubleInstruct(0, 0x6);
            uplowcom.SendDoubleInstruct(0, 0x7);
            uplowcom.SendDoubleInstruct(0, 0x8);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("您是否要关闭窗体？", "窗体关闭提示信息", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                uplowcom.SendUintInstruct(40, 0x1);//车体下使能
                Thread.Sleep(10);
                //uplowcom.SendUintInstruct(10, 0x1);//清错
                Thread.Sleep(10);
                uplowcom.SendUintInstruct(50, 0x1);//机械臂下使能
                Thread.Sleep(10);
                //uplowcom.SendUintInstruct(10, 0x1);//清错
                Thread.Sleep(10);
                //uplowcom.SendUintInstruct(10, 0x1);//清错
                Thread.Sleep(10);

                Application.Current.MainWindow.Close();
            }
            else if (result == MessageBoxResult.No)
            {
                return;
            }
        }
        #endregion

        #region 异步显示数据更新函数
        #region 异步显示数据所需委托声明
        public delegate void UpdataLight(Image image);  //声明委托用来更新使能状态灯
        public delegate void UpdataErrorMessage(ListBox listbox, string str);//声明委托用来更新错误消息
        public delegate void UpdataPositionMessage(TextBlock textbox, double position);//声明委托用来更新位置消息
        public delegate void UpdataArmVelo(TextBox textbox, double velocity);// 声明委托用来更新末端速度
        public delegate void UpdataInstrumentPanelMessage(float value, CircularGaugeControl guage);// 声明委托用来更新仪表盘数据
        public delegate void AppIdleEvent(Process app);
        #endregion
        #region 位置显示更新
        private void UpdataPosition(TextBlock textbox, double position)
        {
            textbox.Text = position.ToString();
        }
        private void CallPositionDeleget(TextBlock textbox, double position)
        {
            this.Dispatcher.Invoke(new UpdataPositionMessage(UpdataPosition), new object[] { textbox, position });
        }
        #endregion
        #region 末端速度显示更新
        private void UpdataVelocity(TextBox textbox, double velocity)
        {

            if (velocity.ToString() == "0")
                textbox.Text = velocity.ToString();
            else
            {
                if (velocity.ToString().Length > 5)
                    textbox.Text = velocity.ToString().Substring(0, 5);
                else
                    textbox.Text = velocity.ToString().Substring(0, velocity.ToString().Length);
            }
        }
        private void CallVelocityDeleget(TextBox textbox, double velocity)
        {
            this.Dispatcher.Invoke(new UpdataArmVelo(UpdataVelocity), new object[] { textbox, velocity });
        }
        #endregion
        #region 错误消息更新
        private void UpdataError(ListBox listbox, string str)
        {
            listbox.Items.Add(str);
        }
        private void CallErrorDeleget(ListBox listbox, string str)
        {
            this.Dispatcher.Invoke(new UpdataErrorMessage(UpdataError), new object[] { listbox, str });
        }
        #endregion
        #region 使能状态红绿灯更新
        private void UpdataBlueLight(Image image)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"skin/blue_light.png", UriKind.Relative);
            bi.EndInit();
            image.Source = bi;
        }
        private void UpdataRedLight(Image image)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"skin/red_light.png", UriKind.Relative);
            bi.EndInit();
            image.Source = bi;
        }
        private void CallBlueDeleget(Image image)
        {
            this.Dispatcher.Invoke(new UpdataLight(UpdataBlueLight), new object[] { image });
        }
        private void CallRedDeleget(Image image)
        {
            this.Dispatcher.Invoke(new UpdataLight(UpdataRedLight), new object[] { image });
        }
        #endregion
        #region 仪表盘数据更新
        private void UpdataInstrumentPanel(float value, CircularGaugeControl guage)
        {
            guage.CurrentValue = value;
        }
        private void CallInstrumentPanelDeleget(float value, CircularGaugeControl guage)
        {
            this.Dispatcher.Invoke(new UpdataInstrumentPanelMessage(UpdataInstrumentPanel), new object[] { value, guage });
        }
        #endregion
        #endregion

        #region 数据通信与处理
        #region 摇杆\上位机间串口的数据处理
        public void Data_Received1(object sender, SerialDataReceivedEventArgs e)  //摇杆1控制机械臂XYZ轴
        {
            double armxExchange;
            double armyExchange;
            double armzExchange;
            try
            {
                int num1;
                byte[] buf1 = new byte[9];
                num1 = serialinterface.serialport1.Read(buf1, 0, 9); //不断去读摇杆1值
                if (buf1[0] == 255)
                {
                    //获取摇杆XYZ轴速率
                    SerialInterface.angley = (double)(buf1[1] * 256 + buf1[2]);
                    SerialInterface.anglex = (double)(buf1[3] * 256 + buf1[4]);
                    SerialInterface.anglez = (double)(buf1[5] * 256 + buf1[6]);
                    buttonNum = buf1[7];
                    //转换为-100 - +100速率值，与下位机通讯
                    armxExchange = GlobalVelocity * (SerialInterface.anglex - 512.0) / 256.0 * 10.0;
                    armyExchange = GlobalVelocity * (SerialInterface.angley - 512.0) / 256.0 * 10.0;
                    armzExchange = GlobalVelocity * (SerialInterface.anglez - 512.0) / 256.0 * 10.0;
                    //保护数据，转化为armx、y、z进行读取，防止对同一数据的读取\写入
                    Interlocked.Exchange(ref armx, armxExchange);
                    Interlocked.Exchange(ref army, armyExchange);
                    Interlocked.Exchange(ref armz, armzExchange);

                    if (buttonNum == 32)
                    {
                        clawflag = true;
                    }
                    else
                    {
                        clawflag = false;
                    }
                    guagecurrentvalue = (float)(((float)(Math.Sqrt(armx * armx + army * army + armz * armz))) / 173.2f); //指示表值计算
                }
            }
            catch (Exception ex1)
            {
                //MessageBox.Show(ex1.Message+"手摇杆错误");
                return;
            }
        }
        public void Data_Received2(object sender, SerialDataReceivedEventArgs e)  //摇杆2控制车方向XY
        {
            double carxExchange;
            double caryExchange;
            try
            {
                int num2;
                byte[] buf2 = new byte[9];
                num2 = serialinterface.serialport2.Read(buf2, 0, 9); //不断去读摇杆2值
                if (buf2[0] == 255)  //用头FF去做判断
                {
                    SerialInterface.cary = (double)(buf2[1] * 256 + buf2[2]);
                    SerialInterface.carx = (double)(buf2[3] * 256 + buf2[4]);
                    carxExchange = GlobalVelocity * (SerialInterface.carx - 512.0) / 256.0 * 10.0; //转化为-100-100
                    caryExchange = GlobalVelocity * (SerialInterface.cary - 512.0) / 256.0 * 10.0;
                    Interlocked.Exchange(ref carmovex, carxExchange);
                    Interlocked.Exchange(ref carmovey, caryExchange);
                }
            }
            catch (Exception ex1)
            {
                //MessageBox.Show(ex1.Message + "车摇杆错误");
                return;
            }
        }
        #endregion
        #region 上\下位机数据收集与处理
        private void DataProcess()
        {
            while (true) //不断执行
            {
                Moniter_Data_Cycle();
                Thread.Sleep(300);
            }
        }

        public void Moniter_Data_Cycle()   //上下位机数据交互监视函数
        {
            //if (clawflag == true && handmode == true) //若在手模式下且按下抓取
            //{
            //    uplowcom.SendDoubleInstruct(pointvelocity, 0x3);
            //    Thread.Sleep(1);
            //    uplowcom.SendUintInstruct(13, 0x2);
            //    Thread.Sleep(1);
            //    uplowcom.SendUintInstruct(120, 0x1);
            //}
            //else if (handmode == true && clawflag == false) //若在手模式下但未按下抓取
            //{
            //    uplowcom.SendDoubleInstruct(0, 0x3);
            //    Thread.Sleep(1);
            //    uplowcom.SendUintInstruct(13, 0x2);
            //    Thread.Sleep(1);
            //    uplowcom.SendUintInstruct(120, 0x1);
            //}

            int count = 1;

            //联网状态灯更新
            try
            {
                if (Upper_Lower_Com.tcAdsClient.IsConnected != true) //自动连接，但会引起卡死
                {
                    //uplowcom.ConnectUpLow(); //连接上下位机
                    CallRedDeleget(ConnectLight);
                }
                else
                {
                    CallBlueDeleget(ConnectLight);
                }
            }
            catch { }

            ////读机械臂xyz轴
            //try
            //{
            //    Upper_Lower_Com.tcAdsClient.ReadWrite(0x1, 0x6, Upper_Lower_Com.adsReadStream, Upper_Lower_Com.adsWriteStream);
            //    byte[] databuffer5 = Upper_Lower_Com.adsReadStream.ToArray();
            //    Upper_Lower_Com.R_ArmPosition_x = BitConverter.ToDouble(databuffer5, 0);
            //    CallVelocityDeleget(armxTextBox, Upper_Lower_Com.R_ArmPosition_x);
            //    //CallPositionDeleget(armxTextBox, Upper_Lower_Com.R_ArmPosition_x);
            //}
            //catch { }
            ////catch(Exception ex1) 
            ////{
            ////    MessageBox.Show(ex1.Message + "读手x错误");
            ////    return;
            ////}
            //try
            //{
            //    Upper_Lower_Com.tcAdsClient.ReadWrite(0x1, 0x7, Upper_Lower_Com.adsReadStream, Upper_Lower_Com.adsWriteStream);
            //    byte[] databuffer6 = Upper_Lower_Com.adsReadStream.ToArray();
            //    Upper_Lower_Com.R_ArmPosition_y = BitConverter.ToDouble(databuffer6, 0);
            //    CallVelocityDeleget(armyTextBox, Upper_Lower_Com.R_ArmPosition_y);
            //    //CallPositionDeleget(armyTextBox, Upper_Lower_Com.R_ArmPosition_y);
            //}
            //catch { }
            ////catch (Exception ex2)
            ////{
            ////    MessageBox.Show(ex2.Message + "读手y错误");
            ////    return;
            ////}
            //try
            //{
            //    Upper_Lower_Com.tcAdsClient.ReadWrite(0x1, 0x8, Upper_Lower_Com.adsReadStream, Upper_Lower_Com.adsWriteStream);
            //    byte[] databuffer7 = Upper_Lower_Com.adsReadStream.ToArray();
            //    Upper_Lower_Com.R_ArmPosition_z = BitConverter.ToDouble(databuffer7, 0);
            //    CallVelocityDeleget(armzTextBox, Upper_Lower_Com.R_ArmPosition_z);
            //    //CallPositionDeleget(armzTextBox, Upper_Lower_Com.R_ArmPosition_z);
            //}
            //catch { }
            ////catch (Exception ex3)
            ////{
            ////    MessageBox.Show(ex3.Message + "读手z错误");
            ////    return;
            ////}
            //try
            //{
            //    Upper_Lower_Com.tcAdsClient.ReadWrite(0x1, 0x9, Upper_Lower_Com.adsReadStream, Upper_Lower_Com.adsWriteStream);
            //    byte[] databuffer8 = Upper_Lower_Com.adsReadStream.ToArray();
            //    Upper_Lower_Com.Alpha = BitConverter.ToDouble(databuffer8, 0);
            //    CallVelocityDeleget(alpahTextBox, Upper_Lower_Com.Alpha);
            //    //CallPositionDeleget(alpahTextBox, Upper_Lower_Com.Alpha);
            //}
            //catch { }
            //try
            //{
            //    Upper_Lower_Com.tcAdsClient.ReadWrite(0x1, 0x10, Upper_Lower_Com.adsReadStream, Upper_Lower_Com.adsWriteStream);
            //    byte[] databuffer9 = Upper_Lower_Com.adsReadStream.ToArray();
            //    Upper_Lower_Com.Beta = BitConverter.ToDouble(databuffer9, 0);
            //    CallVelocityDeleget(betaTextBox, Upper_Lower_Com.Beta);
            //    //CallPositionDeleget(betaTextBox, Upper_Lower_Com.Beta);
            //}
            //catch { }
            //try
            //{
            //    Upper_Lower_Com.tcAdsClient.ReadWrite(0x1, 0x11, Upper_Lower_Com.adsReadStream, Upper_Lower_Com.adsWriteStream);
            //    byte[] databuffer10 = Upper_Lower_Com.adsReadStream.ToArray();
            //    Upper_Lower_Com.Gamma = BitConverter.ToDouble(databuffer10, 0);
            //    CallVelocityDeleget(gammaTextBox, Upper_Lower_Com.Gamma);
            //    //CallPositionDeleget(gammaTextBox, Upper_Lower_Com.Gamma);
            //}
            //catch { }

            //去读14（8）根轴(车轮与摆臂)的相关量，并更新状态灯及数值
            for (count = 0; count < 15; count++) //0-3是车轮，4-7是摆臂，9-15是机械臂
            {
                #region 读各轴情况
                //写轴的索引
                try
                {
                    AdsBinaryWriter binWriter = new AdsBinaryWriter(Upper_Lower_Com.adsWriteStream);
                    Upper_Lower_Com.adsWriteStream.Position = 0;
                    binWriter.Write(count);
                    Upper_Lower_Com.tcAdsClient.ReadWrite(0x2, 0x9, Upper_Lower_Com.adsReadStream, Upper_Lower_Com.adsWriteStream);
                    //byte[] dataBuffer = adsReadStream.ToArray();
                    //lbOutput.Items.Add("读取下位机状态发送的轴的索引为： " + BitConverter.ToUInt32(dataBuffer, 0));
                }
                catch { }
                //catch (Exception ex4)
                //{
                //    MessageBox.Show(ex4.Message + "写轴的索引错误");
                //    return;
                //}

                ////读错误代码
                //try
                //{
                //    Upper_Lower_Com.tcAdsClient.ReadWrite(0x1, 0x1, Upper_Lower_Com.adsReadStream, Upper_Lower_Com.adsWriteStream);
                //    byte[] databuffer1 = Upper_Lower_Com.adsReadStream.ToArray();
                //    Upper_Lower_Com.R_ErrCode = BitConverter.ToUInt32(databuffer1, 0);
                //}
                //catch { }

                //读轴的使能情况
                try
                {
                    Upper_Lower_Com.tcAdsClient.ReadWrite(0x1, 0x1, Upper_Lower_Com.adsReadStream, Upper_Lower_Com.adsWriteStream);
                    byte[] databuffer3 = Upper_Lower_Com.adsReadStream.ToArray();
                    Upper_Lower_Com.R_Enable = BitConverter.ToUInt32(databuffer3, 0);
                    //enableflag[count] = Upper_Lower_Com.R_Enable;
                }
                catch { }
                //catch (Exception ex6)
                //{
                //    MessageBox.Show(ex6.Message + "读轴的使能情况错误");
                //    return;
                //}

                //读轴的当前速度
                try
                {
                    Upper_Lower_Com.tcAdsClient.ReadWrite(0x1, 0x2, Upper_Lower_Com.adsReadStream, Upper_Lower_Com.adsWriteStream);
                    byte[] databuffer4 = Upper_Lower_Com.adsReadStream.ToArray();
                    Upper_Lower_Com.R_ActVelo = BitConverter.ToDouble(databuffer4, 0);
                }
                catch { }
                //catch (Exception ex7)
                //{
                //    MessageBox.Show(ex7.Message + "读轴的当前速度错误");
                //    return;
                //}

                //读轴的当前位置
                try
                {
                    Upper_Lower_Com.tcAdsClient.ReadWrite(0x1, 0x3, Upper_Lower_Com.adsReadStream, Upper_Lower_Com.adsWriteStream);
                    byte[] databuffer5 = Upper_Lower_Com.adsReadStream.ToArray();
                    Upper_Lower_Com.R_ActPos = BitConverter.ToDouble(databuffer5, 0);
                }
                catch { }
                //catch (Exception ex8)
                //{
                //    MessageBox.Show(ex8.Message + "读轴的当前位置错误");
                //    return;
                //}

                #endregion

                #region 将各轴位置及使能情况显示到界面上
                try //总使能灯更新
                {
                    if (Upper_Lower_Com.R_Enable != 0)
                    {
                        CallBlueDeleget(EnableLight);
                    }
                    else
                    {
                        CallRedDeleget(EnableLight);
                    }
                }
                catch { }

                switch (count) //各个轴的使能灯更新
                {
                    case 0:
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            //CallBlueDeleget(Image1);
                        }
                        else
                        {
                            //CallRedDeleget(Image1);
                        }
                       // CallPositionDeleget(TextBox1, Upper_Lower_Com.R_ActPos);
                        break;
                    case 1:
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            //CallBlueDeleget(Image2);
                        }
                        else
                        {
                           // CallRedDeleget(Image2);
                        }
                       // CallPositionDeleget(TextBox2, Upper_Lower_Com.R_ActPos);
                        break;
                    case 2:
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                         //  CallBlueDeleget(Image3);
                        }
                        else
                        {
                          //  CallRedDeleget(Image3);
                        }
                        //CallPositionDeleget(TextBox3, Upper_Lower_Com.R_ActPos);
                        break;
                    case 3:
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                           // CallBlueDeleget(Image4);
                        }
                        else
                        {
                           // CallRedDeleget(Image4);
                        }
                       // CallPositionDeleget(TextBox4, Upper_Lower_Com.R_ActPos);
                        break;
                    case 4:
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            CallBlueDeleget(Image5);
                        }
                        else
                        {
                            CallRedDeleget(Image5);
                        }
                        CallPositionDeleget(TextBox5, Upper_Lower_Com.R_ActPos);
                        robotPos[0] = Upper_Lower_Com.R_ActPos;
                        break;
                    case 5:
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            CallBlueDeleget(Image6);
                        }
                        else
                        {
                            CallRedDeleget(Image6);
                        }
                        CallPositionDeleget(TextBox6, Upper_Lower_Com.R_ActPos);
                        robotPos[1] = Upper_Lower_Com.R_ActPos;
                        break;
                    case 6:
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            CallBlueDeleget(Image7);
                        }
                        else
                        {
                            CallRedDeleget(Image7);
                        }
                        CallPositionDeleget(TextBox7, Upper_Lower_Com.R_ActPos);
                        robotPos[2] = Upper_Lower_Com.R_ActPos;
                        break;
                    case 7:
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            CallBlueDeleget(Image8);
                        }
                        else
                        {
                            CallRedDeleget(Image8);
                        }
                        CallPositionDeleget(TextBox8, Upper_Lower_Com.R_ActPos);
                        robotPos[3] = Upper_Lower_Com.R_ActPos;
                        break;
                    case 8: //腰
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            CallBlueDeleget(Image9);
                        }
                        else
                        {
                            CallRedDeleget(Image9);
                        }
                        CallPositionDeleget(TextBox9, Upper_Lower_Com.R_ActPos);
                        break;
                    case 9: //大臂
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            CallBlueDeleget(Image10);
                        }
                        else
                        {
                            CallRedDeleget(Image10);
                        }
                        armAngel1 = Upper_Lower_Com.R_ActPos;
                        CallPositionDeleget(TextBox10, Upper_Lower_Com.R_ActPos);
                        robotPos[4] = Upper_Lower_Com.R_ActPos;
                        //robotPos[4] = 45.0f;
                        break;
                    case 10:
                        break;

                    case 11: //中臂
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            CallBlueDeleget(Image11);
                        }
                        else
                        {
                            CallRedDeleget(Image11);
                        }
                        armAngel2 = Upper_Lower_Com.R_ActPos;
                        CallPositionDeleget(TextBox11, Upper_Lower_Com.R_ActPos);
                        robotPos[5] = Upper_Lower_Com.R_ActPos;
                        break;
                    case 12: //小臂
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            CallBlueDeleget(Image12);
                        }
                        else
                        {
                            CallRedDeleget(Image12);
                        }
                        armAngel3 = Upper_Lower_Com.R_ActPos;
                        CallPositionDeleget(TextBox12, Upper_Lower_Com.R_ActPos);
                        robotPos[6] = Upper_Lower_Com.R_ActPos;
                        break;
                    case 13: //腕转动
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            CallBlueDeleget(Image13);
                        }
                        else
                        {
                            CallRedDeleget(Image13);
                        }
                        CallPositionDeleget(TextBox13, Upper_Lower_Com.R_ActPos);
                        break;
                    case 14: //手夹紧
                        if (Upper_Lower_Com.R_Enable != 0)
                        {
                            CallBlueDeleget(Image14);
                        }
                        else
                        {
                            CallRedDeleget(Image14);
                        }
                        CallPositionDeleget(TextBox14, Upper_Lower_Com.R_ActPos);
                        break;
                    default:
                        break;
                }
                robotInteraction.UpdatePos(robotPos);
                #endregion

                #region 错误解析及状态指示更新
                switch (Upper_Lower_Com.R_ErrCode)
                {
                    case 0:
                        //CallErrorDeleget(Error, "下位机当前错误为：无");
                        CallBlueDeleget(ErrorLight);
                        //this.Error.Dispatcher.Invoke(new Action(() =>
                        //    {
                        //        this.Error.Items.Add("下位机当前错误为：无");
                        //    })); //此种方法可以实现，但是同样存在关闭窗口的时候崩溃
                        break;
                    case 1:
                        CallErrorDeleget(Error, "下位机当前错误为：车体抱闸警告");
                        CallRedDeleget(ErrorLight);
                        ////uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        //Error.Items.Add("下位机当前错误为：车体抱闸警告");
                        break;
                    case 2:
                        CallErrorDeleget(Error, "下位机当前错误为：机械臂下使能警告");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 500:
                        CallErrorDeleget(Error, "下位机当前错误为：初始化失败");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 501:
                        CallErrorDeleget(Error, "下位机当前错误为：自由度错误");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 502:
                        CallErrorDeleget(Error, "下位机当前错误为：机械臂轴限错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 503:
                        CallErrorDeleget(Error, "下位机当前错误为：机械臂末端位置限制错误");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1000:
                        CallErrorDeleget(Error, "下位机当前错误为：轴初始化错误");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1001:
                        CallErrorDeleget(Error, "下位机当前错误为：车体初始化错误");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1002:
                        CallErrorDeleget(Error, "下位机当前错误为：机械臂初始化错误");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1003:
                        CallErrorDeleget(Error, "下位机当前错误为：车体写伺服错误");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1004:
                        CallErrorDeleget(Error, "下位机当前错误为：机械臂写伺服错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1005:
                        CallErrorDeleget(Error, "下位机当前错误为：不支持力矩控制模式");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1006:
                        CallErrorDeleget(Error, "下位机当前错误为：不支持位置控制模式");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1500:
                        CallErrorDeleget(Error, "下位机当前错误为：车体轴索引错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1501:
                        CallErrorDeleget(Error, "下位机当前错误为：机械臂轴索引错误");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1502:
                        CallErrorDeleget(Error, "下位机当前错误为：轴状态错误");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1503:
                        CallErrorDeleget(Error, "下位机当前错误为：车体状态错误");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1504:
                        CallErrorDeleget(Error, "下位机当前错误为：机械臂状态错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 1505:
                        CallErrorDeleget(Error, "下位机当前错误为：机器人状态错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 2000:
                        CallErrorDeleget(Error, "下位机当前错误为：轴使能错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 2001:
                        CallErrorDeleget(Error, "下位机当前错误为：轴点动错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 2002:
                        CallErrorDeleget(Error, "下位机当前错误为：轴设置零点错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 2003:
                        CallErrorDeleget(Error, "下位机当前错误为：轴暂停错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 2004:
                        CallErrorDeleget(Error, "下位机当前错误为：轴急停错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 2005:
                        CallErrorDeleget(Error, "下位机当前错误为：轴复位错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 2006:
                        CallErrorDeleget(Error, "下位机当前错误为：轴寻零错误");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 2007:
                        CallErrorDeleget(Error, "下位机当前错误为：轴速度运动错误");
                        CallRedDeleget(ErrorLight);
                        //     //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 2008:
                        CallErrorDeleget(Error, "下位机当前错误为：轴设置位置错误");
                        CallRedDeleget(ErrorLight);
                        //  //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    case 2009:
                        CallErrorDeleget(Error, "下位机当前错误为：逆解错误");
                        CallRedDeleget(ErrorLight);
                        // //uplowcom.SendUintInstruct(10, 0x1);//清错
                        Thread.Sleep(50);

                        break;
                    default:
                        break;
                }
                #endregion
            }
            if (count > 0)
            {
                count = 0;  //轴索引清零
            }
        }
        #endregion
        #region 上\下位机机器人运动数据发送
        private void carMoveDataSend()
        {
            while (true) //不断执行
            {
                Robot_Move_Data();
                Thread.Sleep(200); //周期0.2秒
            }
        }
        private void Robot_Move_Data()
        {
            //机器人运动速度实时更新
            try
            {
                switch (carmoveflag)
                {
                    case 0:   //一般模式
                        CallInstrumentPanelDeleget(0.0f, myGauge3);
                        break;

                    case 9:   //手模式                  
                        armsendx = armx * 0.0005; //x速度转化为-0.05 - 0.05;
                        armsendy = army * 0.0005; //y速度转化为-0.05 - 0.05;
                        armsendz = -armz * 0.04; //z速度转化为-4 - 4; 腰左右旋

                        if (armsendx < 0.05 && armsendx > -0.05 &&
                             armsendy < 0.05 && armsendy > -0.05)
                        {
                            //发机械臂xy速度
                            uplowcom.SendDoubleInstruct(-armsendy, 0x5);
                            Thread.Sleep(1);
                            uplowcom.SendDoubleInstruct(armsendx, 0x6);
                            Thread.Sleep(1);
                            uplowcom.SendUintInstruct(100, 0x1);
                            Thread.Sleep(1);

                            //发腰速度
                            uplowcom.SendDoubleInstruct(armsendz, 0x4);
                            Thread.Sleep(1);
                            uplowcom.SendUintInstruct(8, 0x2);
                            Thread.Sleep(1);
                            uplowcom.SendUintInstruct(130, 0x1);
                        }

                        ////上位机空间坐标转换计算
                        //armXYVelocityMatrix[0, 0] = armsendx;
                        //armXYVelocityMatrix[1, 0] = armsendy;
                        //wvCaculatingMatrix[0, 0] = -armLength1 * Math.Sin(armAngel1 * Math.PI / 180);
                        //wvCaculatingMatrix[0, 1] = -armLength2 * Math.Sin(armAngel2 * Math.PI / 180) - armLength3 * Math.Sin(armAngel3 * Math.PI / 180);
                        //wvCaculatingMatrix[1, 0] = armLength1 * Math.Cos(armAngel1 * Math.PI / 180);
                        //wvCaculatingMatrix[1, 1] = armLength2 * Math.Cos(armAngel2 * Math.PI / 180) + armLength3 * Math.Cos(armAngel3 * Math.PI / 180);

                        //CallInstrumentPanelDeleget(guagecurrentvalue, myGauge3); //更新表盘数据

                        //bool isReverse = matrixCaculation.MatrixOpp(wvCaculatingMatrix, ref wvCaculatingMatrixReverse); //计算逆矩阵

                        //if (isReverse)
                        //{ //有逆矩阵才赋值
                        //    matrixCaculation.MatrixMultiply(wvCaculatingMatrixReverse, armXYVelocityMatrix, ref armAngularVelocityMatrix); //计算机械臂三轴角速度
                        //    armAngularVelocityMatrix[0, 0] = armAngularVelocityMatrix[0, 0] / Math.PI * 180; //从弧度转化为角度
                        //    armAngularVelocityMatrix[1, 0] = armAngularVelocityMatrix[1, 0] / Math.PI * 180;

                        //    //最大角速度保护
                        //    if (armAngularVelocityMatrix[0, 0] < 3 && armAngularVelocityMatrix[0, 0] > -3 &&
                        //        armAngularVelocityMatrix[1, 0] < 3 && armAngularVelocityMatrix[1, 0] > -3 && armsendz < 2 && armsendz > -2)
                        //    {
                        //        //发大臂速度
                        //        uplowcom.SendDoubleInstruct(armAngularVelocityMatrix[0, 0], 0x4);
                        //        Thread.Sleep(1);
                        //        uplowcom.SendUintInstruct(9, 0x2);
                        //        Thread.Sleep(1);
                        //        uplowcom.SendUintInstruct(130, 0x1);
                        //        Thread.Sleep(1);

                        //        //发中臂速度
                        //        uplowcom.SendDoubleInstruct(armAngularVelocityMatrix[1, 0], 0x4);
                        //        Thread.Sleep(1);
                        //        uplowcom.SendUintInstruct(10, 0x2);
                        //        Thread.Sleep(1);
                        //        uplowcom.SendUintInstruct(130, 0x1);
                        //        Thread.Sleep(1);

                        //        //发小臂速度
                        //        uplowcom.SendDoubleInstruct(armAngularVelocityMatrix[1, 0], 0x4);
                        //        Thread.Sleep(1);
                        //        uplowcom.SendUintInstruct(11, 0x2);
                        //        Thread.Sleep(1);
                        //        uplowcom.SendUintInstruct(130, 0x1);

                        //        //发腰速度
                        //        uplowcom.SendDoubleInstruct(armsendz, 0x4);
                        //        Thread.Sleep(1);
                        //        uplowcom.SendUintInstruct(8, 0x2);
                        //        Thread.Sleep(1);
                        //        uplowcom.SendUintInstruct(130, 0x1);
                        //    }


                        //    CallErrorDeleget(Error, "——————————");
                        //    CallErrorDeleget(Error, "终端线速度-" + "x:" + armXYVelocityMatrix[0, 0].ToString() + "," + "y:" + armXYVelocityMatrix[1, 0].ToString());
                        //    CallErrorDeleget(Error, "三轴角速度-" + "1:" + armAngularVelocityMatrix[0, 0].ToString() + "," + "2:" + armAngularVelocityMatrix[1, 0].ToString() + "," + "3:" + armAngularVelocityMatrix[1, 0].ToString());
                        //    CallErrorDeleget(Error, "机械臂三个角度：" + armAngel1.ToString() + "," + armAngel2.ToString() + "," + armAngel3.ToString());
                        //    CallErrorDeleget(Error, "计算矩阵" + wvCaculatingMatrix[0, 0] + "," + wvCaculatingMatrix[0, 1] + "," + wvCaculatingMatrix[1, 0] + "," + wvCaculatingMatrix[1, 1]);
                        //    CallErrorDeleget(Error, "计逆矩阵" + wvCaculatingMatrixReverse[0, 0] + "," + wvCaculatingMatrixReverse[0, 1] + "," + wvCaculatingMatrixReverse[1, 0] + "," + wvCaculatingMatrixReverse[1, 1]);
                        //}
                        break;

                    case 10:   //车模式
                        xcoefficient = 0.005;
                        ycoefficient = 0.3;

                        carmovesendx = carmovex * xcoefficient; //线速度转化为-0.5 - 0.5
                        carmovesendy = carmovey * ycoefficient; //转角速度转化为-30 - 30

                        //CallErrorDeleget(Error, carmovesendx.ToString() + "," + carmovesendy.ToString()); //测试串口数据

                        if (carmovesendx < xcoefficient * 100 && carmovesendy < ycoefficient * 100 && carmovesendx > -xcoefficient * 100 && carmovesendy > -ycoefficient * 100)
                        {
                            //机器人速度保护
                            uplowcom.SendDoubleInstruct(carmovesendx, 0x5);
                            uplowcom.SendDoubleInstruct(carmovesendy, 0x6);
                            uplowcom.SendUintInstruct(90, 0x1);
                        }

                        break;

                    default:
                        break;
                }
            }
            catch //(Exception ex10)
            {
                //MessageBox.Show(ex10.Message + "模式信息发送错误");
            }
        }
        #endregion
        #endregion

        #region 鼠标点动控制
        #region 车和机械臂点动
        private void btn_MouseDown(object sender, MouseButtonEventArgs e) //鼠标按下
        {
            velocityToLower = 0.0; //先归零
            if (stopflag == false)
            {
                Button btn = sender as Button;
                if (btn.Name == "CarBtn1")
                {
                    // carmoveflag = 7;
                    // uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity / 1000;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(0, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(110, 0x1);
                }
                if (btn.Name == "CarBtn2")
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity / 1000;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(1, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(110, 0x1);
                }
                if (btn.Name == "CarBtn3")
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity / 1000;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(2, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(110, 0x1);
                }
                if (btn.Name == "CarBtn4")
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity / 1000;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(3, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(110, 0x1);
                }
                if (btn.Name == "CarBtn5") //右前摆臂抬升
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity * 0.03;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(4, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(120, 0x1);
                }
                if (btn.Name == "CarBtn6") //左前摆臂抬升
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity * 0.03;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(5, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(120, 0x1);
                }
                if (btn.Name == "CarBtn7") //左后摆臂抬升
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity * 0.03;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(6, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(120, 0x1);
                }
                if (btn.Name == "CarBtn8") //右后摆臂抬升
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity * 0.03;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(7, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(120, 0x1);
                }
                if (btn.Name == "CarBtn9")
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity / 1000;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(0, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(110, 0x1);
                }
                if (btn.Name == "CarBtn10")
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity / 1000;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(1, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(110, 0x1);
                }
                if (btn.Name == "CarBtn11")
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity / 1000;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(2, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(110, 0x1);
                }
                if (btn.Name == "CarBtn12")
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity / 1000;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(3, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(110, 0x1);
                }
                if (btn.Name == "CarBtn13")
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity * 0.03;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(4, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(120, 0x1);
                }
                if (btn.Name == "CarBtn14")
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity * 0.03;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(5, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(120, 0x1);
                }
                if (btn.Name == "CarBtn15")
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity * 0.03;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(6, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(120, 0x1);
                }
                if (btn.Name == "CarBtn16")
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity * 0.03;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(7, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(120, 0x1);
                }


                //从这开始是机械臂
                if (btn.Name == "ArmBtn1") //腰左旋
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity * 0.04;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(8, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
                if (btn.Name == "ArmBtn2") //大臂上
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity * 0.02;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(9, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
                if (btn.Name == "ArmBtn3") //中臂上
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity * 0.02;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(11, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
                if (btn.Name == "ArmBtn4") //小臂上
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity * 0.02;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(12, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
                if (btn.Name == "ArmBtn5") //腕左旋
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity * 0.02;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(13, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
                if (btn.Name == "ArmBtn6") //手开
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity * 0.08;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(14, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
                if (btn.Name == "ArmBtn7") //腰右旋
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity * 0.04;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(8, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
                if (btn.Name == "ArmBtn8") //大臂下
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity * 0.02;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(9, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
                if (btn.Name == "ArmBtn9") //中臂下
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity * 0.02;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(11, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
                if (btn.Name == "ArmBtn10") //小臂下
                {
                    //carmoveflag = 7;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity * 0.02;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(12, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
                if (btn.Name == "ArmBtn11") //腕右旋
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = pointvelocity * 0.02;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(13, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
                if (btn.Name == "ArmBtn12") //手合
                {
                    //carmoveflag = 8;
                    //uplowcom.SendUintInstruct(20, 0x2);
                    velocityToLower = -pointvelocity * 0.08;
                    uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(14, 0x2);
                    Thread.Sleep(1);
                    uplowcom.SendUintInstruct(130, 0x1);
                }
            }
        }

        private void btn_MouseUp(object sender, MouseButtonEventArgs e) //鼠标抬起所有运动停止
        {
            if (stopflag == false)
            {
                Button btn = sender as Button;
                if (btn.Name == "CarBtn1")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn2")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn3")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn4")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn5")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn6")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn7")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn8")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn9")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn10")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn11")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn12")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn13")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn14")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn15")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "CarBtn16")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn1")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn2")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn3")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn4")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn5")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn6")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn7")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn8")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn9")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn10")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn11")
                {
                    SetInstructToZero();
                }
                if (btn.Name == "ArmBtn12")
                {
                    SetInstructToZero();
                }
            }
        }

        private void SetInstructToZero() //停止运动
        {
            uplowcom.SendUintInstruct(70, 0x1); //车和摆臂停止
        }
        #endregion
        #region 双摆臂同步控制（所有模式有效）
        private void CarFrontUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                velocityToLower = -frontwheelvelocity * 0.09;

                Thread.Sleep(1);
                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(4, 0x2); //右前
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
                Thread.Sleep(1);

                Thread.Sleep(1);
                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(5, 0x2); //左前
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
            }
        }

        private void CarFrontUp_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                uplowcom.SendUintInstruct(70, 0x1);
            }

        }

        private void CarFrontDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                velocityToLower = frontwheelvelocity * 0.09;

                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(4, 0x2); //右前
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
                Thread.Sleep(1);
                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(5, 0x2); //左前
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
            }
        }

        private void CarFrontDown_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                uplowcom.SendUintInstruct(70, 0x1);

            }
        }

        private void CarBackUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                velocityToLower = -frontwheelvelocity * 0.09;

                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(6, 0x2); //左后
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
                Thread.Sleep(1);
                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(7, 0x2); //右后
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
            }
        }

        private void CarBackUp_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                uplowcom.SendUintInstruct(70, 0x1);

            }
        }

        private void CarBackDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                velocityToLower = frontwheelvelocity * 0.09;

                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(6, 0x2); //左后
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
                Thread.Sleep(1);
                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(7, 0x2); //右后
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
            }
        }

        private void CarBackDown_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                uplowcom.SendUintInstruct(70, 0x1);
            }
        }

        private void CoupleMoveUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                velocityToLower = -frontwheelvelocity * 0.09;

                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(4, 0x2); //右前
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
                Thread.Sleep(1);
                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(5, 0x2); //左前
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(6, 0x2); //左后
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
                Thread.Sleep(1);
                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(7, 0x2); //右后
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
            }
        }

        private void CoupleMoveUp_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                uplowcom.SendUintInstruct(70, 0x1);

            }
        }

        private void CoupleMoveDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                velocityToLower = frontwheelvelocity * 0.09;

                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(4, 0x2); //右前
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
                Thread.Sleep(1);
                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(5, 0x2); //左前
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
                Thread.Sleep(1);
                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(6, 0x2); //左后
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
                Thread.Sleep(1);
                uplowcom.SendDoubleInstruct(velocityToLower, 0x4);
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(7, 0x2); //右后
                Thread.Sleep(1);
                uplowcom.SendUintInstruct(120, 0x1);
            }
        }

        private void CoupleMoveDown_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (stopflag == false)
            {
                uplowcom.SendUintInstruct(70, 0x1);

            }
        }
        #endregion
        #endregion

        #region 滚动条数据处理
        //滚动条数据以百分比数据形式显示
        private void sliderValueShowInTextBlock()
        {
            float value = 0.0f;
            string stringval = null;
            double percentage = slider1.Value * 100.0 / slider1.Maximum;
            value = (float)(slider1.Value / slider1.Maximum);
            //全局速率大小百分比显示，保留小数点后一位
            if (!percentage.ToString().Contains("."))
            {
                stringval = percentage.ToString() + ".0";
            }
            else
            {
                int index = percentage.ToString().IndexOf(".");
                stringval = percentage.ToString().Substring(0, index + 2);
            }
            PercentageShow.Text = stringval + "%"; //全局速率百分比录入
            myGauge2.CurrentValue = value; //当前速率仪表盘值
        }
        private double value_Decide(double value) //全局速率格式化
        {
            string stringval = null;
            double value1 = 0.0;
            if (value >= 0.0)
            {
                if (!value.ToString().Contains("."))
                {
                    stringval = value.ToString() + ".0";
                }
                else
                {
                    int index = value.ToString().IndexOf(".");
                    stringval = value.ToString().Substring(0, index + 2);
                }
            }
            double.TryParse(stringval, out value1);
            return value1;
        }

        private void slider1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) //滚动条拖动鼠标抬起事件
        {
            GlobalVelocity = value_Decide(slider1.Value);
            pointvelocity = GlobalVelocity * 20.0;
            frontwheelvelocity = GlobalVelocity * 20.0;
            backwheelvelocity = GlobalVelocity * 20.0;
            sliderValueShowInTextBlock();
        }
        //鼠标按键精调，每次加0.1，即加2%
        private void SliderLeftButton_Click(object sender, RoutedEventArgs e) //左边减小键鼠标按下事件
        {
            if ((slider1.Value - 0.1) >= 0.0)
            {
                slider1.Value -= 0.1;
            }
            else
            {
                slider1.Value = 0.0;
            }
            GlobalVelocity = value_Decide(slider1.Value); //滑块是0-5
            pointvelocity = GlobalVelocity * 20.0;
            frontwheelvelocity = GlobalVelocity * 20.0;
            backwheelvelocity = GlobalVelocity * 20.0;
            sliderValueShowInTextBlock();
        }

        private void SliderRightButton_Click(object sender, RoutedEventArgs e) //右边增加键鼠标按下事件
        {
            if ((slider1.Value + 0.1) <= 5.0)
            {
                slider1.Value += 0.1;
            }
            else
            {
                slider1.Value = 5.0;
            }
            GlobalVelocity = value_Decide(slider1.Value);
            pointvelocity = GlobalVelocity * 20.0;
            frontwheelvelocity = GlobalVelocity * 20.0;
            backwheelvelocity = GlobalVelocity * 20.0;
            sliderValueShowInTextBlock();
        }
        #endregion

        #region 设置功能
        #region 设置列表功能
        private void Connect_Up_Low_ClickEnvent(object sender, RoutedEventArgs e)
        {
            uplowcom.ConnectUpLow(); //连接上下位机
        }

        private void MI_Click(object sender, RoutedEventArgs e)
        {
            MenuItem m = sender as MenuItem;
            if ((string)m.Header == "车灯关")
            {
                uplowcom.SendUintInstruct(310, 0x1);
            }
            if ((string)m.Header == "车灯开")
            {
                uplowcom.SendUintInstruct(320, 0x1);
            }

            if (stopflag == false)
            {
                MenuItem mi = sender as MenuItem;
                if ((string)mi.Header == "机器人异常处理")
                {
                    //uplowcom.SendUintInstruct(10, 0x1);
                    Thread.Sleep(10);

                }
                if ((string)m.Header == "连接")
                {
                    try
                    {
                        if (Upper_Lower_Com.tcAdsClient.IsConnected != true)
                        {
                            uplowcom.ConnectUpLow();
                        }
                    }
                    catch (Exception ex9)
                    {
                        MessageBox.Show(ex9.Message + "联网错误");
                    }
                }
                if ((string)mi.Header == "机器人重置")
                {
                    uplowcom.SendUintInstruct(60, 0x1);
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "机械臂归原位")
                {
                    uplowcom.SendUintInstruct(80, 0x1);   //寻参
                }
                if ((string)mi.Header == "摆姿态")
                {
                    uplowcom.SendUintInstruct(360, 0x1);
                }
                if ((string)mi.Header == "机器人暂停")
                {
                    uplowcom.SendUintInstruct(70, 0x1);
                }
                if ((string)mi.Header == "机械臂腰寻零")
                {
                    uplowcom.SendUintInstruct(8, 0x2);
                    uplowcom.SendUintInstruct(240, 0x1);
                }
                if ((string)mi.Header == "设置所有轴零点")
                {

                }
                if ((string)mi.Header == "右前轮置零")
                {
                    uplowcom.SendUintInstruct(1, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "左前轮置零")
                {
                    uplowcom.SendUintInstruct(2, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "左后轮置零")
                {
                    uplowcom.SendUintInstruct(3, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "右后轮置零")
                {
                    uplowcom.SendUintInstruct(4, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "右前摆臂置零")
                {
                    uplowcom.SendUintInstruct(5, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "左前摆臂置零")
                {
                    uplowcom.SendUintInstruct(6, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "左后摆臂置零")
                {
                    uplowcom.SendUintInstruct(7, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "右后摆臂置零")
                {
                    uplowcom.SendUintInstruct(8, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "机械臂腰置零")
                {
                    uplowcom.SendUintInstruct(9, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "机械臂大臂置零")
                {
                    uplowcom.SendUintInstruct(10, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "机械臂中臂置零")
                {
                    uplowcom.SendUintInstruct(11, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "机械臂小臂置零")
                {
                    uplowcom.SendUintInstruct(13, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "机械臂腕置零")
                {
                    uplowcom.SendUintInstruct(12, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "机械臂手爪置零")
                {
                    uplowcom.SendUintInstruct(14, 0x2);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "摆臂下使能")
                {

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                }
                if ((string)mi.Header == "右前摆臂寻零")
                {
                    uplowcom.SendUintInstruct(5, 0x2);
                    uplowcom.SendUintInstruct(240, 0x1);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                    //robotInteraction.Udp_SendMessageInt("7");
                }
                if ((string)mi.Header == "左前摆臂寻零")
                {
                    uplowcom.SendUintInstruct(6, 0x2);

                    uplowcom.SendUintInstruct(240, 0x1);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                    //robotInteraction.Udp_SendMessageInt("8");
                }
                if ((string)mi.Header == "左后摆臂寻零")
                {
                    uplowcom.SendUintInstruct(7, 0x2);

                    uplowcom.SendUintInstruct(240, 0x1);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                    //robotInteraction.Udp_SendMessageInt("9");
                }
                if ((string)mi.Header == "右后摆臂寻零")
                {
                    uplowcom.SendUintInstruct(8, 0x2);

                    uplowcom.SendUintInstruct(240, 0x1);
                    Thread.Sleep(10);
                    uplowcom.SendUintInstruct(20, 0x2);

                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);

                    // robotInteraction.Udp_SendMessageInt("0");
                }
                //if ((string)mi.Header == "关闭机械臂抱闸")
                //{
                //    uplowcom.SendUintInstruct(250, 0x1);
                //    Thread.Sleep(50);
                //    //uplowcom.SendUintInstruct(10, 0x1);//清错
                //    Thread.Sleep(50);
                //    
                //}
                if ((string)mi.Header == "摆臂上使能")
                {

                }
                //if ((string)mi.Header == "关闭车体抱闸")
                //{
                //    uplowcom.SendUintInstruct(240, 0x1);
                //    Thread.Sleep(50);
                //    //uplowcom.SendUintInstruct(10, 0x1);//清错
                //    Thread.Sleep(50);
                //    
                //}
            }
        }
        #endregion
        #region 设置车体和机械臂使能
        private void MI_Checked(object sender, RoutedEventArgs e)
        {
            if (stopflag == false)
            {
                MenuItem Mi = sender as MenuItem;
                if ((string)Mi.Header == "车体上使能")
                {
                    uplowcom.SendUintInstruct(20, 0x1);
                }
                if ((string)Mi.Header == "机械臂上使能")
                {
                    uplowcom.SendUintInstruct(30, 0x1);
                }
                //if ((string)Mi.Header == "基坐标系")
                //{
                //  //  EndMenuItem.IsCheckable = false;
                //    modeflag = false;
                //    carmoveflag = 9;
                //    uplowcom.SendUintInstruct(1, 0x16);//基坐标系
                //    uplowcom.SendUintInstruct(40, 0x1);//车体下使能
                //    Thread.Sleep(10);
                //    //uplowcom.SendUintInstruct(10, 0x1);//清错
                //    Thread.Sleep(10);
                //    
                //    Thread.Sleep(10);
                //    
                //    Thread.Sleep(10);
                //    //uplowcom.SendUintInstruct(10, 0x1);//清错
                //    Thread.Sleep(10);
                //    
                //    Thread.Sleep(10);
                //    uplowcom.SendUintInstruct(30, 0x1);//机械臂上使能
                //    Thread.Sleep(10);
                //    //uplowcom.SendUintInstruct(10, 0x1);//清错
                //    Thread.Sleep(10);
                //    
                //    Thread.Sleep(10);
                //    uplowcom.SendUintInstruct(160, 0x1);
                //    if (!serialinterface.timer.Enabled)
                //    {
                //        serialinterface.timer.Enabled = true;
                //    }
                //    if (serialinterface.serialport2.IsOpen)
                //    {
                //        serialinterface.serialport2.Close();
                //    }
                //    if (!serialinterface.serialport2.IsOpen)
                //    {
                //        if (serialinterface.serialport1.IsOpen)
                //        {
                //            serialinterface.serialport1.Close();
                //            if (!serialinterface.serialport1.IsOpen)
                //            {
                //                try
                //                {
                //                    serialinterface.serialport1.Open();
                //                    MessageBox.Show("基于基坐标系手模式打开");
                //                }
                //                catch (Exception ex)
                //                {
                //                    MessageBox.Show(ex.Message);
                //                    return;
                //                }
                //            }
                //        }
                //        else
                //        {
                //            try
                //            {
                //                serialinterface.serialport1.Open();
                //                MessageBox.Show("基于基坐标系手模式打开");
                //            }
                //            catch (Exception ex)
                //            {
                //                MessageBox.Show(ex.Message);
                //                return;
                //            }
                //        }
                //    }
                //}
                //if ((string)Mi.Header == "末端坐标系")
                //{
                //    BaseMenuItem.IsCheckable = false;
                //    modeflag = false;
                //    carmoveflag = 9;
                //    uplowcom.SendUintInstruct(2, 0x16);//末端坐标系
                //    uplowcom.SendUintInstruct(40, 0x1);//车体下使能
                //    Thread.Sleep(10);
                //    //uplowcom.SendUintInstruct(10, 0x1);//清错
                //    Thread.Sleep(10);
                //    
                //    Thread.Sleep(10);
                //    
                //    Thread.Sleep(10);
                //    //uplowcom.SendUintInstruct(10, 0x1);//清错
                //    Thread.Sleep(10);
                //    
                //    Thread.Sleep(10);
                //    uplowcom.SendUintInstruct(30, 0x1);//机械臂上使能
                //    Thread.Sleep(10);
                //    //uplowcom.SendUintInstruct(10, 0x1);//清错
                //    Thread.Sleep(10);
                //    
                //    Thread.Sleep(10);
                //    uplowcom.SendUintInstruct(160, 0x1);
                //    Thread.Sleep(10);
                //    //uplowcom.SendUintInstruct(180, 0x1);
                //    //Thread.Sleep(50);
                //    
                //    if (!serialinterface.timer.Enabled)
                //    {
                //        serialinterface.timer.Enabled = true;
                //    }
                //    if (serialinterface.serialport2.IsOpen)
                //    {
                //        serialinterface.serialport2.Close();
                //    }
                //    if (!serialinterface.serialport2.IsOpen)
                //    {
                //        if (serialinterface.serialport1.IsOpen)
                //        {
                //            serialinterface.serialport1.Close();
                //            if (!serialinterface.serialport1.IsOpen)
                //            {
                //                try
                //                {
                //                    serialinterface.serialport1.Open();
                //                    MessageBox.Show("基于末端坐标系手模式打开");
                //                }
                //                catch (Exception ex)
                //                {
                //                    MessageBox.Show(ex.Message);
                //                    return;
                //                }
                //            }
                //        }
                //        else
                //        {
                //            try
                //            {
                //                serialinterface.serialport1.Open();
                //                MessageBox.Show("基于末端坐标系手模式打开");
                //            }
                //            catch (Exception ex)
                //            {
                //                MessageBox.Show(ex.Message);
                //                return;
                //            }
                //        }
                //    }                
                //}

            }
        }

        private void MI_Uchecked(object sender, RoutedEventArgs e)
        {
            if (stopflag == false)
            {
                MenuItem Mi = sender as MenuItem;
                if ((string)Mi.Header == "车体上使能")
                {
                    uplowcom.SendUintInstruct(20, 0x1);
                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);
                }
                if ((string)Mi.Header == "机械臂上使能")
                {
                    uplowcom.SendUintInstruct(30, 0x1);
                    Thread.Sleep(10);
                    //uplowcom.SendUintInstruct(10, 0x1);//清错
                    Thread.Sleep(10);
                }
                //if ((string)Mi.Header == "基坐标系")
                //{
                //    EndMenuItem.IsCheckable = true;
                //}
                //if ((string)Mi.Header == "末端坐标系")
                //{
                //    BaseMenuItem.IsCheckable = true;
                //}
            }
        }
        #endregion
        #region 设置机器人急停
        private void RobotResetOrStop_Click(object sender, RoutedEventArgs e)
        {
            MenuItem Mi = sender as MenuItem;
            if ((string)Mi.Header == "机器人急停")
            {
                stopflag = true;
            }
            if ((string)Mi.Header == "机器人急停复位")
            {
                stopflag = false;
            }
        }
        #endregion
        #region 设置暂停和复位
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            if (stopflag == false)
            {
                uplowcom.SendUintInstruct(70, 0x1);
            }
        }
        private void ErrorClear_Click(object sender, RoutedEventArgs e)
        {
            if (stopflag == false)
            {
                uplowcom.SendUintInstruct(60, 0x1); //总复位
            }
        }
        #endregion
        #endregion

        #region 车模式\手模式\一般模式切换
        private void CarModeButton_Click(object sender, RoutedEventArgs e) //车模式
        {
            NormalModeFlag = false; //一般模式关闭
            //车模式下 手模式两个选项都可选，都处于未选定状态
            carmoveflag = 10;
            handmode = false; //手模式关闭
            uplowcom.SendUintInstruct(20, 0x1);//车体上使能         
            uplowcom.SendUintInstruct(30, 0x1);//机械臂上使能      

            if (!serialinterface.timer.Enabled)
            {
                serialinterface.timer.Enabled = true;
            }
            //关闭Port1，开启Port2
            if (serialinterface.serialport1.IsOpen)
            {
                serialinterface.serialport1.Close();
            }
            if (!serialinterface.serialport1.IsOpen)
            {
                if (serialinterface.serialport2.IsOpen)
                {
                    serialinterface.serialport2.Close();
                    if (!serialinterface.serialport2.IsOpen)
                    {
                        try
                        {
                            serialinterface.serialport2.Open();
                            MessageBox.Show("车模式打开");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
                else
                {
                    try
                    {
                        serialinterface.serialport2.Open();
                        MessageBox.Show("车模式打开");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }
        private void handModeButton_Click(object sender, RoutedEventArgs e) //手模式
        {
            NormalModeFlag = false; //一般模式关闭
            handmode = true;  //手模式开启
            carmoveflag = 9;
            uplowcom.SendUintInstruct(20, 0x1);//车体上使能         
            uplowcom.SendUintInstruct(30, 0x1);//机械臂上使能     


            //for (uint i = 9; i < 12; i++) {
            //    //轴索引
            //    uplowcom.SendUintInstruct(i, 0x9);   //轴索引
            //    uplowcom.SendUintInstruct(15, 0x1);   //寻参
            //}

            if (!serialinterface.timer.Enabled)
            {
                serialinterface.timer.Enabled = true;
            }
            //开启Port1，关闭Port2
            if (serialinterface.serialport2.IsOpen)
            {
                serialinterface.serialport2.Close();
            }
            if (!serialinterface.serialport2.IsOpen)
            {
                if (serialinterface.serialport1.IsOpen)
                {
                    serialinterface.serialport1.Close();
                    if (!serialinterface.serialport1.IsOpen)
                    {
                        try
                        {
                            serialinterface.serialport1.Open();
                            MessageBox.Show("手模式打开");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
                else
                {
                    try
                    {
                        serialinterface.serialport1.Open();
                        MessageBox.Show("手模式打开");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }
        private void NormalModeButton_Click(object sender, RoutedEventArgs e) //一般模式
        {
            NormalModeFlag = true; //一般模式开启
            //车模式下 手模式两个选项都可选，都处于未选定状
            carmoveflag = 0;
            handmode = false;
            uplowcom.SendUintInstruct(20, 0x1);//车体上使能 
            uplowcom.SendUintInstruct(30, 0x1);//机械臂上使能    

            MessageBox.Show("一般模式打开");
            if (serialinterface.timer.Enabled)
                serialinterface.timer.Enabled = false;
            //1、2port都关闭
            if (serialinterface.serialport1.IsOpen)
            {
                serialinterface.serialport1.Close();
            }
            if (serialinterface.serialport2.IsOpen)
            {
                serialinterface.serialport2.Close();
            }
        }
        #endregion

        #region 水炮枪操作
        private void WaterWeapon_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("您是否要操作水炮枪？", "水炮枪操作提示信息", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                uplowcom.SendUintInstruct(340, 0x1);
            }
            else if (result == MessageBoxResult.No)
            {
                return;
            }
        }
        #endregion

        #region 摄像头相关功能
        #region 与视频窗口的通信
        public const int WM_COPYDATA = 0x004A;
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string lpClassName, string lpWindowName);
        //在DLL库中的发送消息函数
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage
            (
            int hWnd,                         // 目标窗口的句柄  
            int Msg,                          // 在这里是WM_COPYDATA
            int wParam,                       // 第一个消息参数
            ref CopyDataStruct lParam        // 第二个消息参数
           );

        public struct CopyDataStruct
        {
            public IntPtr dwData;
            public int cbData;

            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }
        #endregion
        #region 视频切换功能
        private void Vedio1_Click(object sender, RoutedEventArgs e)
        {

            string strURL = "1";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "RobotCameraForm"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”

        }

        private void Vedio2_Click(object sender, RoutedEventArgs e)
        {

            string strURL = "2";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "RobotCameraForm"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void Vedio3_Click(object sender, RoutedEventArgs e)
        {

            string strURL = "3";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "RobotCameraForm"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void Vedio4_Click(object sender, RoutedEventArgs e)
        {

            string strURL = "4";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "RobotCameraForm"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void Vedio5_Click(object sender, RoutedEventArgs e)
        {
            string strURL = "5";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "RobotCameraForm"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }
        private void Vedio10_Click(object sender, RoutedEventArgs e)
        {

            string strURL = "10";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "RobotCameraForm"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }
        #endregion
        #region  视频录像功能
        private void Vedio6_Click(object sender, RoutedEventArgs e)
        {
            count[0]++;
            if (count[0] == 1)
            {
                Btn6.Content = "停止";
            }
            else if (count[0] == 2)
            {
                Btn6.Content = "录像1";
                count[0] = 0;
            }
            string strURL = "6";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void Vedio7_Click(object sender, RoutedEventArgs e)
        {
            count[1]++;
            if (count[1] == 1)
            {
                Btn7.Content = "停止";
            }
            else if (count[1] == 2)
            {
                Btn7.Content = "录像2";
                count[1] = 0;
            }
            string strURL = "7";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void Vedio8_Click(object sender, RoutedEventArgs e)
        {
            count[2]++;
            if (count[2] == 1)
            {
                Btn8.Content = "停止";
            }
            else if (count[2] == 2)
            {
                Btn8.Content = "录像3";
                count[2] = 0;
            }
            string strURL = "8";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void Vedio9_Click(object sender, RoutedEventArgs e)
        {
            count[3]++;
            if (count[3] == 1)
            {
                Btn9.Content = "停止";
            }
            else if (count[3] == 2)
            {
                Btn9.Content = "录像4";
                count[3] = 0;
            }
            string strURL = "9";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }
        private void Vedio11_Click(object sender, RoutedEventArgs e)
        {
            count[4]++;
            if (count[4] == 1)
            {
                Btn11.Content = "停止";
            }
            else if (count[4] == 2)
            {
                Btn11.Content = "录像5";
                count[4] = 0;
            }
            string strURL = "11";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }
        #endregion
        #region 视频注销功能
        private void Vedio12_Click(object sender, RoutedEventArgs e)
        {
            string strURL = "12";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void Vedio13_Click(object sender, RoutedEventArgs e)
        {
            string strURL = "13";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void Vedio14_Click(object sender, RoutedEventArgs e)
        {
            string strURL = "14";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void Vedio15_Click(object sender, RoutedEventArgs e)
        {
            string strURL = "15";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void Vedio16_Click(object sender, RoutedEventArgs e)
        {
            string strURL = "16";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }
        #endregion
        #endregion

        #region 云台控制
        private void btn_UPMouseDown(object sender, MouseButtonEventArgs e)
        {
            string strURL = "6";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void btn_UPMouseUp(object sender, MouseButtonEventArgs e)
        {
            string strURL = "7";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void btn_HOMEMouseDown(object sender, MouseButtonEventArgs e)
        {
            string strURL = "8";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void btn_HOMEMouseUp(object sender, MouseButtonEventArgs e)
        {
            string strURL = "9";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void btn_DOWNMouseDown(object sender, MouseButtonEventArgs e)
        {
            string strURL = "10";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void btn_DOWNMouseUp(object sender, MouseButtonEventArgs e)
        {
            string strURL = "11";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void btn_LEFTMouseDown(object sender, MouseButtonEventArgs e)
        {
            string strURL = "12";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void btn_LEFTMouseUp(object sender, MouseButtonEventArgs e)
        {
            string strURL = "13";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void btn_RIGHTMouseDown(object sender, MouseButtonEventArgs e)
        {
            string strURL = "14";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }

        private void btn_RIGHTMouseUp(object sender, MouseButtonEventArgs e)
        {
            string strURL = "15";
            CopyDataStruct cds = new CopyDataStruct();
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "Form1"), WM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
        }
        #endregion

        #region U3D功能
        #region 引入所需C++函数
        [DllImport("user32.dll")]
        static extern Int32 StWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, Int32 X, Int32 Y, Int32 cx, Int32 cy, UInt32 uFlags);
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndParent);
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowLong(IntPtr hwnd, int _nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRePaint);
        #endregion
        #region 打开U3D应用程序
        private void OpenU3d()
        {
            AppIdleEvent appIdleEvent = new AppIdleEvent(appIdleHandle);
            ProcessStartInfo startinfo = new ProcessStartInfo(@"car\game.exe");
            //ProcessStartInfo startinfo = new ProcessStartInfo(@"video\bin\Screen.exe");
            startinfo.UseShellExecute = true;
            p = Process.Start(startinfo);
            Thread.Sleep(500);
            p.WaitForInputIdle();//等待进程被创建以及进入理想环境
            this.Dispatcher.BeginInvoke(
            System.Windows.Threading.DispatcherPriority.ApplicationIdle,
            appIdleEvent, p);   //这个是对采用一个参数方法的委托，第三个参数就是传递到方法中的参数。当然还有多个参数方法的委托。       
        }
        public void appIdleHandle(Process p)
        {
            const int GWL_STYLE = -16;
            const int WS_VISIBLE = 0x10000000;
            //Thread.Sleep(1000);
            //// WindowInteropHelper helper = new WindowInteropHelper(Window.GetWindow(this));
            // IntPtr ptr = helper.Handle;
            ////SetParent(p.MainWindowHandle, helper.Handle);   //将窗体以子窗体嵌入
            var hwndPanel = Panel11.Handle;
            // MessageBox.Show(hwndPanel.ToString());
            Thread.Sleep(1000);
            SetParent(p.MainWindowHandle, hwndPanel);   //将窗体以子窗体嵌入
            //Thread.Sleep(100);
            HandleRef hanref = new HandleRef(this, p.MainWindowHandle);
            //SetWindowLong(HandleRef.ToIntPtr(hanref), GWL_STYLE, WS_VISIBLE);    //需要使用user32.dll,这SetWindowLong(HandleRef.ToIntPtr(hanref), GWL_STYLE, WS_VISIBLE);    //需要使用user32.dll,这样就去除了unity3D画面windows边界，并且使得画面能够显示出来样就去除了unity3D画面windows边界，并且使得画面能够显示出来
            MoveWindow(p.MainWindowHandle, 0, 0, (int)this.Panel11.Width, (int)this.Panel11.Height, true);
            //Thread.Sleep(500);
            // MoveWindow(p.MainWindowHandle, 309, 112, 390, 390, true); //(int)this.PContainer.Left, (int)this.PContainer.Top, (int)this.PContainer.Width, (int)this.PContainer.Height, true);
            SetWindowLong(HandleRef.ToIntPtr(hanref), GWL_STYLE, WS_VISIBLE);    //需要使用user32.dll,这样就去除了unity3D画面windows边界，并且使得画面能够显示出来
            Thread.Sleep(1000);
            MoveWindow(p.MainWindowHandle, 0, 0, (int)this.Panel11.Width, (int)this.Panel11.Height, true);
            SetWindowLong(HandleRef.ToIntPtr(hanref), GWL_STYLE, WS_VISIBLE);
            // SetWindowLong(HandleRef.ToIntPtr(hanref), GWL_STYLE, WS_VISIBLE);
            //Thread.Sleep(1000);
            //一定要注意指定wrapPanel的宽度，不然默认的时候wrappanel宽度是0，于是就显示不出来unity的画面了。
        }
        private void U3DClose()
        {
            robotInteraction.udp_Close();
            threadSendMSg.Abort();
            p.Kill();
        }
        #endregion
        #endregion
    }
}