using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TwinCAT.Ads;
using System.Threading;
using adsClientVisu;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Thread thread = null;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Thread threadChosen = new Thread(Chosen);
            threadChosen.IsBackground = true;
            threadChosen.Start();
        }
        private void Chosen()
        {
            while(true)
            {
                int index = GetSelectedIndex();
            }
        }
         //连接ADS


        private void Cycle()
        {
            int indexStatus = 0;
            while (true) { 
            //发送要读取的轴的索引
            try
            {
                AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;
                binWriter.Write(indexStatus);
                _tcClient.ReadWrite(0x2, 0x9, adsReadStream, adsWriteStream);
                byte[] dataBuffer = adsReadStream.ToArray();
                lbOutput.Items.Add("要读取的轴的索引为： " + BitConverter.ToUInt32(dataBuffer, 0));
                lbOutput.SelectedIndex = lbOutput.Items.Count - 1;
            }
            catch
            {
                MessageBox.Show("读写轴索引发生错误！");
            }
            //读取对应索引的轴的使能情况
            try
            {
                _tcClient.ReadWrite(0x1, 0x1, adsReadStream, adsWriteStream);
                byte[] dataBuffer3 = adsReadStream.ToArray();
                lbOutput.Items.Add("当前轴的使能情况为： " + BitConverter.ToInt32(dataBuffer3, 0));
                lbOutput.SelectedIndex = lbOutput.Items.Count - 1;
                GlobalVar.R_Enable = BitConverter.ToUInt32(dataBuffer3, 0);
                //DrivingWheel1Enable.Text = GlobalVar.R_Enable.ToString();
            }
            catch
            {
                MessageBox.Show("读取轴使能出现错误！");
            }
            //读取对应索引的轴的速度大小
            try
            {
                _tcClient.ReadWrite(0x1, 0x2, adsReadStream, adsWriteStream);
                byte[] dataBuffer4 = adsReadStream.ToArray();
                lbOutput.Items.Add("当前轴的速度为： " + BitConverter.ToDouble(dataBuffer4, 0));
                lbOutput.SelectedIndex = lbOutput.Items.Count - 1;
                GlobalVar.R_ActVelo = BitConverter.ToDouble(dataBuffer4, 0);
                GlobalVar.R_ActVelo = ((int)(GlobalVar.R_ActVelo * 100)) / 100.0;
                //DrivingWheel1ActVel.Text = GlobalVar.R_ActVelo.ToString();
            }
            catch
            {
                MessageBox.Show("读取当前轴速度出现错误！");
            }
            //读取对应索引轴的位置
            try
            {
                _tcClient.ReadWrite(0x1, 0x3, adsReadStream, adsWriteStream);
                byte[] dataBuffer5 = adsReadStream.ToArray();
                lbOutput.Items.Add("当前轴的位置为： " + BitConverter.ToDouble(dataBuffer5, 0));
                lbOutput.SelectedIndex = lbOutput.Items.Count - 1;
                GlobalVar.R_ActPos = BitConverter.ToDouble(dataBuffer5, 0);
                GlobalVar.R_ActPos = ((int)(GlobalVar.R_ActPos * 100)) / 100.0;
                //DrivingWheel1ActPos.Text = GlobalVar.R_ActPos.ToString();
            }
            catch
            {
                MessageBox.Show("读取当前轴位置出现错误！");
            }
            
           
            //读取对应索引轴的电流
            try
            {
                _tcClient.ReadWrite(0x1, 0x4, adsReadStream, adsWriteStream);
                byte[] dataBuffer9 = adsReadStream.ToArray();
                lbOutput.Items.Add("当前轴的电流为： " + BitConverter.ToInt16(dataBuffer9, 0));
                lbOutput.SelectedIndex = lbOutput.Items.Count - 1;
                GlobalVar.R_ActCur = BitConverter.ToInt16(dataBuffer9, 0);
                //DrivingWheel1ActPos.Text = GlobalVar.R_ActPos.ToString();
            }
            catch
            {
                MessageBox.Show("读取当前轴位置出现错误！");
            }
            try
            {
                switch (indexStatus)
                {
                    case 0:
                        if (GlobalVar.R_Enable != 0)            //已经使能
                        {
                            DrivingWheel1Enable.Text = "Enable";
                            DrivingWheel1Enable.BackColor = Color.Chartreuse;
                        }
                        else
                        {
                            DrivingWheel1Enable.Text = "Disable";
                            DrivingWheel1Enable.BackColor = Color.Red;
                        }
                        DrivingWheel1ActVel.Text = GlobalVar.R_ActVelo.ToString();
                        DrivingWheel1ActPos.Text = GlobalVar.R_ActPos.ToString();
                        DrivingWheel1ActCur.Text = GlobalVar.R_ActCur.ToString();
                        break;
                    case 1:
                        if (GlobalVar.R_Enable != 0)            //已经使能
                        {
                            DrivingWheel2Enable.Text = "Enable";
                            DrivingWheel2Enable.BackColor = Color.Chartreuse;
                        }
                        else
                        {
                            DrivingWheel2Enable.Text = "Disable";
                            DrivingWheel2Enable.BackColor = Color.Red;
                        }
                        DrivingWheel2ActVel.Text = GlobalVar.R_ActVelo.ToString();
                        DrivingWheel2ActPos.Text = GlobalVar.R_ActPos.ToString();
                        DrivingWheel2ActCur.Text = GlobalVar.R_ActCur.ToString();
                        break;
                    case 2:
                        if (GlobalVar.R_Enable != 0)            //已经使能
                        {
                            DrivingWheel3Enable.Text = "Enable";
                            DrivingWheel3Enable.BackColor = Color.Chartreuse;
                        }
                        else
                        {
                            DrivingWheel3Enable.Text = "Disable";
                            DrivingWheel3Enable.BackColor = Color.Red;
                        }
                        DrivingWheel3ActVel.Text = GlobalVar.R_ActVelo.ToString();
                        DrivingWheel3ActPos.Text = GlobalVar.R_ActPos.ToString();
                        DrivingWheel3ActCur.Text = GlobalVar.R_ActCur.ToString();
                        break;
                    case 3:
                        if (GlobalVar.R_Enable != 0)            //已经使能
                        {
                            DrivingWheel4Enable.Text = "Enable";
                            DrivingWheel4Enable.BackColor = Color.Chartreuse;
                        }
                        else
                        {
                            DrivingWheel4Enable.Text = "Disable";
                            DrivingWheel4Enable.BackColor = Color.Red;
                        }
                        DrivingWheel4ActVel.Text = GlobalVar.R_ActVelo.ToString();
                        DrivingWheel4ActPos.Text = GlobalVar.R_ActPos.ToString();
                        DrivingWheel4ActCur.Text = GlobalVar.R_ActCur.ToString();
                        break;
                    case 4:
                        if (GlobalVar.R_Enable != 0)            //已经使能
                        {
                            SwingArm1Enable.Text = "Enable";
                            SwingArm1Enable.BackColor = Color.Chartreuse;
                        }
                        else
                        {
                            SwingArm1Enable.Text = "Disable";
                            SwingArm1Enable.BackColor = Color.Red;
                        }
                        SwingArm1ActVel.Text = GlobalVar.R_ActVelo.ToString();
                        SwingArm1ActPos.Text = GlobalVar.R_ActPos.ToString();
                        SwingArm1ActCur.Text = GlobalVar.R_ActCur.ToString();
                        break;
                    case 5:
                        if (GlobalVar.R_Enable != 0)            //已经使能
                        {
                            SwingArm2Enable.Text = "Enable";
                            SwingArm2Enable.BackColor = Color.Chartreuse;
                        }
                        else
                        {
                            SwingArm2Enable.Text = "Disable";
                            SwingArm2Enable.BackColor = Color.Red;
                        }
                        SwingArm2ActVel.Text = GlobalVar.R_ActVelo.ToString();
                        SwingArm2ActPos.Text = GlobalVar.R_ActPos.ToString();
                        SwingArm2ActCur.Text = GlobalVar.R_ActCur.ToString();
                        break;
                    case 6:
                        if (GlobalVar.R_Enable != 0)            //已经使能
                        {
                            SwingArm3Enable.Text = "Enable";
                            SwingArm3Enable.BackColor = Color.Chartreuse;
                        }
                        else
                        {
                            SwingArm3Enable.Text = "Disable";
                            SwingArm3Enable.BackColor = Color.Red;
                        }
                        SwingArm3ActVel.Text = GlobalVar.R_ActVelo.ToString();
                        SwingArm3ActPos.Text = GlobalVar.R_ActPos.ToString();
                        SwingArm3ActCur.Text = GlobalVar.R_ActCur.ToString();
                        break;
                    case 7:
                        if (GlobalVar.R_Enable != 0)            //已经使能
                        {
                            SwingArm4Enable.Text = "Enable";
                            SwingArm4Enable.BackColor = Color.Chartreuse;
                        }
                        else
                        {
                            SwingArm4Enable.Text = "Disable";
                            SwingArm4Enable.BackColor = Color.Red;
                        }
                        SwingArm4ActVel.Text = GlobalVar.R_ActVelo.ToString();
                        SwingArm4ActPos.Text = GlobalVar.R_ActPos.ToString();
                        SwingArm4ActCur.Text = GlobalVar.R_ActCur.ToString();
                        break;
                    case 9:
                            if (GlobalVar.R_Enable != 0)            //已经使能
                            {
                                BigArmEnable.Text = "Enable";
                                BigArmEnable.BackColor = Color.Chartreuse;
                            }
                            else
                            {
                                BigArmEnable.Text = "Disable";
                                BigArmEnable.BackColor = Color.Red;
                            }
                            BigArmActVel.Text = GlobalVar.R_ActVelo.ToString();
                            BigArmActPos.Text = GlobalVar.R_ActPos.ToString();
                            BigArmActCur.Text = GlobalVar.R_ActCur.ToString();
                            break;
                    case 10:
                            if (GlobalVar.R_Enable != 0)            //已经使能
                            {
                                FlexEnable.Text = "Enable";
                                FlexEnable.BackColor = Color.Chartreuse;
                            }
                            else
                            {
                                FlexEnable.Text = "Disable";
                                FlexEnable.BackColor = Color.Red;
                            }
                            FlexActVel.Text = GlobalVar.R_ActVelo.ToString();
                            FlexActPos.Text = GlobalVar.R_ActPos.ToString();
                            FlexActCur.Text = GlobalVar.R_ActCur.ToString();
                            break;
                        case 11:
                            if (GlobalVar.R_Enable != 0)            //已经使能
                            {
                                MiddleArmEnable.Text = "Enable";
                                MiddleArmEnable.BackColor = Color.Chartreuse;
                            }
                            else
                            {
                                MiddleArmEnable.Text = "Disable";
                                MiddleArmEnable.BackColor = Color.Red;
                            }
                            MiddleArmActVel.Text = GlobalVar.R_ActVelo.ToString();
                            MiddleArmActPos.Text = GlobalVar.R_ActPos.ToString();
                            MiddleArmActCur.Text = GlobalVar.R_ActCur.ToString();
                            break;
                        case 12:
                            if (GlobalVar.R_Enable != 0)            //已经使能
                            {
                                SmallArmEnable.Text = "Enable";
                                SmallArmEnable.BackColor = Color.Chartreuse;
                            }
                            else
                            {
                                SmallArmEnable.Text = "Disable";
                                SmallArmEnable.BackColor = Color.Red;
                            }
                            SmallArmActVel.Text = GlobalVar.R_ActVelo.ToString();
                            SmallArmActPos.Text = GlobalVar.R_ActPos.ToString();
                            SmallArmActCur.Text = GlobalVar.R_ActCur.ToString();
                            break;
                        case 13:
                            if (GlobalVar.R_Enable != 0)            //已经使能
                            {
                                RotationEnable.Text = "Enable";
                                RotationEnable.BackColor = Color.Chartreuse;
                            }
                            else
                            {
                                RotationEnable.Text = "Disable";
                                RotationEnable.BackColor = Color.Red;
                            }
                            RotationActVel.Text = GlobalVar.R_ActVelo.ToString();
                            RotationActPos.Text = GlobalVar.R_ActPos.ToString();
                            RotationActCur.Text = GlobalVar.R_ActCur.ToString();
                            break;
                        case 14:
                            if (GlobalVar.R_Enable != 0)            //已经使能
                            {
                                ClampEnable.Text = "Enable";
                                ClampEnable.BackColor = Color.Chartreuse;
                            }
                            else
                            {
                                ClampEnable.Text = "Disable";
                                ClampEnable.BackColor = Color.Red;
                            }
                            ClampActVel.Text = GlobalVar.R_ActVelo.ToString();
                            ClampActPos.Text = GlobalVar.R_ActPos.ToString();
                            ClampActCur.Text = GlobalVar.R_ActCur.ToString();
                            break;
                        case 8:
                            if (GlobalVar.R_Enable != 0)            //已经使能
                            {
                                WaistEnable.Text = "Enable";
                                WaistEnable.BackColor = Color.Chartreuse;
                            }
                            else
                            {
                                WaistEnable.Text = "Disable";
                                WaistEnable.BackColor = Color.Red;
                            }
                            WaistActVel.Text = GlobalVar.R_ActVelo.ToString();
                            WaistActPos.Text = GlobalVar.R_ActPos.ToString();
                            WaistActCur.Text = GlobalVar.R_ActCur.ToString();
                            break;
                    }
                indexStatus++;
                if (indexStatus == 15)
                {
                    indexStatus = 0;
                }
            }
            catch
            {

            }
            }
        }
        public static void Delay(int delayTime)
        {
            DateTime now = DateTime.Now;
            double s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.TotalMilliseconds;
                Application.DoEvents();
            }
            while (s < delayTime * 10);
        }

        private void SendInstruct(int instruct)
        {
            try
            {
                AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;
                binWriter.Write(instruct);
                _tcClient.ReadWrite(0x02, 0x01, adsReadStream, adsWriteStream);
                byte[] dataBuffer5 = adsReadStream.ToArray();
            }
            catch
            {
                MessageBox.Show("指令发送错误！");
            }
        }
        private void SendIndexCtr(int indexCtr)                 //发送控制轴的索引
        {
            try
            {
                AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;
                binWriter.Write(indexCtr);
                _tcClient.ReadWrite(0x02, 0x02, adsReadStream, adsWriteStream);
                byte[] dataBuffer2 = adsReadStream.ToArray();
            }
            catch
            {
                MessageBox.Show("索引发送错误！");
            }
        }
        private void SendPos(double Pos)
        {
            try
            {
                AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;
                binWriter.Write(Pos);
                _tcClient.ReadWrite(0x02, 0x03, adsReadStream, adsWriteStream);
                byte[] dataBuffer3 = adsReadStream.ToArray();
            }
            catch
            {
                MessageBox.Show("位置指令发送错误！");
            }
        }
        private void SendVel(double Vel)
        {
            try
            {
                AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;
                binWriter.Write(Vel);
                _tcClient.ReadWrite(0x02, 0x04, adsReadStream, adsWriteStream);
                byte[] dataBuffer4 = adsReadStream.ToArray();
            }
            catch
            {
                MessageBox.Show("速度指令发送错误！");
            }
        }

        private void SendVelX(double VelX)
        {
            try
            {
                AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;
                binWriter.Write(VelX);
                _tcClient.ReadWrite(0x02, 0x05, adsReadStream, adsWriteStream);
                byte[] dataBuffer5 = adsReadStream.ToArray();
            }
            catch
            {
                MessageBox.Show("x速度指令发送错误！");
            }
        }
        private void SendVelY(double VelY)
        {
            try
            {
                AdsBinaryWriter binWriter = new AdsBinaryWriter(adsWriteStream);
                adsWriteStream.Position = 0;
                binWriter.Write(VelY);
                _tcClient.ReadWrite(0x02, 0x06, adsReadStream, adsWriteStream);
                byte[] dataBuffer6 = adsReadStream.ToArray();
            }
            catch
            {
                MessageBox.Show("Y速度指令发送错误！");
            }
        }
        private int GetSelectedIndex()
        {
            try
            {
                if (radioButton1.Checked == true)        //驱动轮1被选中
                {
                    lab_ChosenAxis1.Text = "轮1";
                    lab_ChosenAxis2.Text = "轮1";
                    return 0;
                }
                else if (radioButton2.Checked == true)   //驱动轮2被选中
                {
                    lab_ChosenAxis1.Text = "轮2";
                    lab_ChosenAxis2.Text = "轮2";
                    return 1;
                }
                else if (radioButton3.Checked == true)     //驱动轮3被选中
                {
                    lab_ChosenAxis1.Text = "轮3";
                    lab_ChosenAxis2.Text = "轮3";
                    return 2;
                }
                else if (radioButton4.Checked == true) //驱动轮4被选中
                {
                    lab_ChosenAxis1.Text = "轮4";
                    lab_ChosenAxis2.Text = "轮4";
                    return 3;
                }
                else if (radioButton5.Checked == true)     //摆臂1被选中
                {
                    lab_ChosenAxis1.Text = "摆1";
                    lab_ChosenAxis2.Text = "摆1";
                    return 4;
                }
                else if (radioButton6.Checked == true)         //摆臂2被选中
                {
                    lab_ChosenAxis1.Text = "摆2";
                    lab_ChosenAxis2.Text = "摆2";
                    return 5;
                }
                else if (radioButton7.Checked == true)         //摆臂3被选中
                {
                    lab_ChosenAxis1.Text = "摆3";
                    lab_ChosenAxis2.Text = "摆3";
                    return 6;
                }
                else if (radioButton8.Checked == true)          //摆臂4被选中
                {
                    lab_ChosenAxis1.Text = "摆4";
                    lab_ChosenAxis2.Text = "摆4";
                    return 7;
                }
                else if (radioButton9.Checked == true)          //腰被选中
                {
                    lab_ChosenAxis1.Text = "腰";
                    lab_ChosenAxis2.Text = "腰";
                    return 8;
                }
                else if (radioButton10.Checked == true)          //大臂被选中
                {
                    lab_ChosenAxis1.Text = "大臂";
                    lab_ChosenAxis2.Text = "大臂";
                    return 9;
                }

                else if (radioButton11.Checked == true)          //伸缩被选中
                {
                    lab_ChosenAxis1.Text = "伸缩";
                    lab_ChosenAxis2.Text = "伸缩";
                    return 10;
                }
                else if (radioButton12.Checked == true)          //中臂被选中
                {
                    lab_ChosenAxis1.Text = "中臂";
                    lab_ChosenAxis2.Text = "中臂";
                    return 11;
                }
                else if (radioButton13.Checked == true)          //小臂被选中
                {
                    lab_ChosenAxis1.Text = "小臂";
                    lab_ChosenAxis2.Text = "小臂";
                    return 12;
                }
                else if (radioButton14.Checked == true)          //旋转被选中
                {
                    lab_ChosenAxis1.Text = "旋转";
                    lab_ChosenAxis2.Text = "旋转";
                    return 13;
                }
                else if (radioButton15.Checked == true)          //夹紧被选中
                {
                    lab_ChosenAxis1.Text = "手爪";
                    lab_ChosenAxis2.Text = "手爪";
                    return 14;
                }
                else                                            //没有有效的轴被选中
                {
                    lab_ChosenAxis1.Text = "选中的轴";
                    lab_ChosenAxis2.Text = "选中的轴";
                    return -1;
                }
            }
            catch
            {
                MessageBox.Show("获取单轴控制轴的索引出错！");
                return -1;
            }
        }
        private void btRun_Click(object sender, EventArgs e)
        {
            btRun.Enabled = false;
            thread = new Thread(Cycle);
            thread.IsBackground = true;
            thread.Start();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            btConnect.Enabled = false;
            AmsAddress serverAddress = null;             //服务器的ADS地址
            try
            {
                if (tbPort.Text.StartsWith("0x") || tbPort.Text.StartsWith("0X"))
                {
                    string temp = tbPort.Text.Substring(2);
                    serverAddress = new AmsAddress(tbNetID.Text, Int32.Parse(temp, System.Globalization.NumberStyles.HexNumber));
                }
                else
                {
                    serverAddress = new AmsAddress(tbNetID.Text, Int32.Parse(tbPort.Text));
                }
            }
            catch
            {
                MessageBox.Show("ADS Port 或 NetID 输入有误!");
                return;
            }
            try
            {
                _tcClient.Connect(serverAddress.NetId, serverAddress.Port);
                lbOutput.Items.Add("端口" + _tcClient.ClientAddress.Port + "打开成功！");
                lbOutput.SelectedIndex = lbOutput.Items.Count - 1;
            }
            catch
            {
                MessageBox.Show("连接服务器失败！");
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            _tcClient = new TcAdsClient();
            adsReadStream = new AdsStream(100);
            adsWriteStream = new AdsStream(100);
            tabPage1.Text = "通讯";
            tabPage2.Text = "控制";
            tabPage3.Text = "机械臂";
        }
        private void btn_Enable_Click(object sender, EventArgs e)
        {
            if (btn_Enable.Text == "上使能")
            {
                SendInstruct(20);
                Delay(1);
                SendInstruct(30);
                Delay(1);
                btn_Enable.Text = "下使能";
            }
            else
            {
                SendInstruct(40);
                Delay(1);
                SendInstruct(50);
                Delay(1);
                btn_Enable.Text = "上使能";
            }
        }

        private void btn_Halt_Click(object sender, EventArgs e)
        {
            SendInstruct(70);
            Delay(1);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            SendInstruct(60);
            Delay(1);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            SendInstruct(80);
            Delay(1);
        }

        private void btn_BackZero_Click(object sender, EventArgs e)
        {
            SendInstruct(290);
            Delay(1);
        }

        private void btn_MoveVelocity_Click(object sender, EventArgs e)
        {
            int index = GetSelectedIndex();
            double singleVel;
            if (tx_SingleVel.Text != "")
                singleVel = Convert.ToDouble(tx_SingleVel.Text);
            else
                singleVel = 0;
            if (index>=0&&index<=3)
            {
                SendIndexCtr(index);
                Delay(1);
                SendVel(singleVel);
                Delay(1);
                SendInstruct(110);
                Delay(1);
            }
            else if(index>3&&index<=7)
            {
                SendIndexCtr(index);
                Delay(1);
                SendVel(singleVel);
                Delay(1);
                SendInstruct(120);
                Delay(1);
            }
            else if (index > 7 && index <= 14)
            {
                SendIndexCtr(index);
                Delay(1);
                SendVel(singleVel);
                Delay(1);
                SendInstruct(130);
                Delay(1);
            }
        }

        private void btn_MoveRelative_Click(object sender, EventArgs e)
        {
            int index = GetSelectedIndex();
            double singleVel;
            double singlePos;
            if (tx_vel.Text != "")
                singleVel = Convert.ToDouble(tx_vel.Text);
            else
                singleVel = 0;
            if (tx_pos.Text != "")
                singlePos = Convert.ToDouble(tx_pos.Text);
            else
                singlePos = 0;
            if (index > 3 && index <= 7)
            {
                SendIndexCtr(index);
                Delay(1);
                SendVel(singleVel);
                Delay(1);
                SendInstruct(140);
                Delay(1);
            }
            else if (index > 7 && index <= 14)
            {
                SendIndexCtr(index);
                Delay(1);
                SendVel(singleVel);
                Delay(1);
                SendInstruct(150);
                Delay(1);
            }
        }

        private void btn_FrontSwing_Click(object sender, EventArgs e)
        {
            double singleVel;
            if (tx_DoubleSwingArmVel.Text != "")
                singleVel = Convert.ToDouble(tx_DoubleSwingArmVel.Text);
            else
                singleVel = 0;
            SendVel(singleVel);
            Delay(1);
            SendInstruct(260);
            Delay(1);
        }

        private void btn_BackSwing_Click(object sender, EventArgs e)
        {
            double singleVel;
            if (tx_DoubleSwingArmVel.Text != "")
                singleVel = Convert.ToDouble(tx_DoubleSwingArmVel.Text);
            else
                singleVel = 0;
            SendVel(singleVel);
            Delay(1);
            SendInstruct(270);
            Delay(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SendInstruct(410);
            Delay(1);
        }
    }
}
