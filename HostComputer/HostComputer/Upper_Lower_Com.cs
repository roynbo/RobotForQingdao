using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinCAT.Ads;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Timers;
using System.Windows.Threading;
using System.Threading;

namespace HostComputer
{
     public class Upper_Lower_Com
    {
       // public static uint S_FunctionInstruct;   //功能码
       // public static uint S_AxisIndex;          //轴索引
       // public static double S_Velocity;         //速度
        //public static double S_VehicleVelo_x;    // 车体X轴速度
       // public static double S_VehicleVelo_y;    // 车体Y轴速度
        public static double R_ArmPosition_x;        //末端X位置
        public static double R_ArmPosition_y;       //末端Y位置
        public static double R_ArmPosition_z;       //末端Z位置
        public static uint R_ErrCode;            //错误码
        public static uint R_AxisIndex;           //轴索引错误
        public static uint R_Enable;               //使能情况
        public static double R_ActVelo;            //速度
        public static double R_ActPos;              //位置
        public static double Alpha;                 //末端角度Alpha
        public static double Beta;                 //末端角度Beta
        public static double Gamma;                 //末端角度Gamma
        public static TcAdsClient tcAdsClient;
        public static AdsStream adsReadStream;
        public static AdsStream adsWriteStream; 
        public static bool m_NetConnection=false;//网络连接状态标志,默认为0未连接


        #region 连接下位机
        public void ConnectUpLow()
        {          
                AmsAddress serverAddress = new AmsAddress("192.168.1.222.1.1", Int32.Parse("bf02", System.Globalization.NumberStyles.HexNumber));
                try
                {
                    tcAdsClient.Connect(serverAddress.NetId, serverAddress.Port);
                }
                catch(Exception ex1)
                {
                      MessageBox.Show(ex1.Message+"网络无法连接");
                }
            
          
        }
        //public void ConnectThread()
        //{
        //    connectthread = new Thread(ConnectUpLow);
        //    connectthread.Start();       
        //}

        #endregion

        //发送整型指令
        public void SendUintInstruct(uint Instruct,Int32 offset)
        {
            try
            {
                //MessageBox.Show(Instruct.ToString());
                AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;
                binWriter.Write(Instruct);
                tcAdsClient.ReadWrite(0x2, offset, adsReadStream, adsWriteStream);
                //byte[] dataBuffer = adsReadStream.ToArray();
                ////lbOutput.Items.Add("发送的功能指令为： " + BitConverter.ToUInt32(dataBuffer, 0));
            }
            catch { }
            //catch (Exception err)
            //{
            //     MessageBox.Show(err.Message+"发送整型指令错误");
            //}
        }
        //发送double型指令
        public void SendDoubleInstruct(double speed, Int32 offset)
        {
            try
            {
                //MessageBox.Show(speed.ToString());
                AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;
                binWriter.Write(speed);
                tcAdsClient.ReadWrite(0x2, offset, adsReadStream, adsWriteStream);
                //byte[] dataBuffer = adsReadStream.ToArray();
                //lbOutput.Items.Add("发送的车体速度y为： " + BitConverter.ToDouble(dataBuffer, 0));
            }
            catch { };
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message + "发送浮点型指令错误");
            //}
        }

     }
}
