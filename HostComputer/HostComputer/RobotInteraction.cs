using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.Runtime.InteropServices;

namespace HostComputer
{
    public class RobotInteraction //unity类
    {
        public struct status                    //轴状态，大臂中臂小臂，4个摆
        {
            public double bigarm_position;
            public double middlearm_position;
            public double smallarm_position;
            public double swingarm1;
            public double swingarm2;
            public double swingarm3;
            public double swingarm4;
        };
        UdpClient udpClient;
        IPAddress remoteIpAdress;
        IPEndPoint remoteIpEndPoint;
        status handStatus;
        private string GetLocalIp()
        {
            string hostname = Dns.GetHostName();
            IPHostEntry localhost = Dns.GetHostByName(hostname);
            IPAddress localaddr = localhost.AddressList[0];
            return localaddr.ToString();
        }
        //UDP通信设置
        public void udp_Client()
        {
            udpClient = new UdpClient();
            remoteIpAdress = IPAddress.Parse(GetLocalIp());
            remoteIpEndPoint = new IPEndPoint(remoteIpAdress, 10000);
        }
        public void udp_Close()
        {
            udpClient.Close();
        }
        public void udp_SendMessage()
        {
            while (true)
            {
                byte[] sendBytes = StructureToByte<status>(handStatus);
                udpClient.Send(sendBytes, sendBytes.Length, remoteIpEndPoint);
            }
        }
        public void udp_SendMessageint(string flag)
        {
            byte[] sendBytes = System.Text.Encoding.Unicode.GetBytes(flag);
            udpClient.Send(sendBytes, sendBytes.Length, remoteIpEndPoint);
        }
        public static byte[] StructureToByte<T>(T structure)
        {
            int size = Marshal.SizeOf(typeof(T));
            byte[] buffer = new byte[size];
            IntPtr bufferIntPtr = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.StructureToPtr(structure, bufferIntPtr, true);
                Marshal.Copy(bufferIntPtr, buffer, 0, size);
            }
            finally
            {
                Marshal.FreeHGlobal(bufferIntPtr);
            }
            return buffer;
        }
        public void UpdatePos(double[] pos)
        {
            handStatus.swingarm1 = pos[0];
            handStatus.swingarm2 = pos[1];
            handStatus.swingarm3 = pos[2];
            handStatus.swingarm4 = pos[3];
            handStatus.bigarm_position = pos[4];
            handStatus.middlearm_position = pos[5];
            handStatus.smallarm_position = pos[6];
        }
    }
}
