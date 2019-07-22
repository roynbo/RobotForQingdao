// socketclient.cpp : 定义控制台应用程序的入口点.

#include "stdafx.h"
#include"winsock.h"
#include"windows.h"
#include<iostream>
#include<string>
#include <fstream>    
#include <iomanip> 
#include "MFSM.h"
#pragma comment(lib,"ws2_32.lib")
using namespace std;

extern RobotMFSM robotMFSM;
BOOL RecvLine(SOCKET s,char*buf);//读取一行数据
void enable(bool enable);
void halt();
void reset();
void getStatus(double status[]);
void homming();
void goStartPos();
void singleAxisMovVel(int index, double vel);
void singleAxisMovAbs(int index, double pos);
void singleAxisMovRel(int index, double pos);
void carMove(double velx, double vely);
void swingarmCoupling(double velx, double vely);
void setMovePara(double x, double y, double alpha);

ofstream outfile("D://Adata//data.dat");
const int BUF_SIZE = 192;
char buf[BUF_SIZE]; //接收数据缓冲区
char bufRecv[BUF_SIZE];
WSADATA wsd; //WSADATA变量
SOCKET sHost;//服务器套接字
SOCKADDR_IN servAddr; //服务器地址

int retVal; //返回值
int main()
{
	cout << "**************************************************************" << endl;
	cout << "*    命令序号     功能名称                  注释             *" << endl;
	cout << "*       1          上使能                                    *" << endl;
	cout << "*       2          下使能                                    *" << endl;
	cout << "*       3           暂停                                     *" << endl;
	cout << "*       4           复位                                     *" << endl;
	cout << "*       5       单轴恒速运动            输入轴，速度         *" << endl;
	cout << "*       6     单轴绝对位置运动          输入轴，绝对位置     *" << endl;
	cout << "*       7     单轴相对位置运动          输入轴，旋转度数     *" << endl;
	cout << "*       8        车模式运动          输入前进速度，旋转速度  *" << endl;
	cout << "*       9         摆臂运动									  *" << endl;
	cout << "*       10        读取参数                                   *" << endl;
	cout << "*       12        所有摆臂寻参                               *" << endl;
	cout << "*       13        摆臂到运动位置                             *" << endl;
	cout << "**************************************************************" << endl;
	cout << endl;
	cout << endl;
	//初始化套结字动态库
	if(WSAStartup(MAKEWORD(2, 2), &wsd) != 0)
	{
		cout<< "WSAStartup failed!" << endl;
		return - 1;
	}

	//创建套接字
	sHost= socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);
	if (INVALID_SOCKET== sHost)
	{
		cout << "socket failed!" << endl;
		WSACleanup();//释放套接字资源
		return - 1;
	}
	//设置服务器地址
	servAddr.sin_family= AF_INET;
	servAddr.sin_addr.s_addr= inet_addr("192.168.1.200");
	servAddr.sin_port= htons((short)4999);
	int nServAddlen = sizeof(servAddr);
	//连接服务器
	retVal = connect(sHost, (LPSOCKADDR)&servAddr, sizeof(servAddr));
	if (SOCKET_ERROR== retVal)
	{
		cout<< "connect failed!" << endl;
		closesocket(sHost);//关闭套接字
		WSACleanup();//释放套接字资源
		return - 1;
	}
	while (true){
		//向服务器发送数据

		cout << "向服务器发送数据: ";
		string temps;
		cin >> temps;
		if (temps == "1")
		{
			enable(true);
		}
		if (temps == "2")
		{
			enable(false);
		}
		if (temps == "3")
		{
			halt();
		}
		if (temps == "4")
		{
			reset();
		}
		if (temps == "10")
		{
			double status[192];
			getStatus(status);
		}
		if (temps == "12")
		{
			homming();
		}
		if (temps == "13")
		{
			goStartPos();
		}
		if (temps == "5")
		{
			cout << "请输入轴：";
			int index;
			cin >> index;
			double vel;
			cout << "请输入速度：";
			cin >> vel;
			singleAxisMovVel(index, vel);
		}
		if (temps == "6")
		{
			cout << "请输入轴：";
			int index;
			cin >> index;
			double pos;
			cout << "请输入位置：";
			cin >> pos;
			singleAxisMovAbs(index,pos);
		}
		if (temps == "7")
		{
			cout << "请输入轴：";
			int index;
			cin >> index;
			double pos;
			cout << "请输入位置：";
			cin >> pos;
			singleAxisMovRel(index,pos);
		}
		if (temps == "8")
		{
			cout << "前进速度：";
			double velx;
			cin >> velx;
			double vely;
			cout << "旋转速度：";
			cin >> vely;
			carMove(velx, vely);
		}
		if (temps == "9")
		{
			cout << "角速度：";
			double vel;
			cin >> vel;
			double pos;
			cout << "旋转到角度：";
			cin >> pos;
			swingarmCoupling(vel,pos);
			
		}
		//double temp[16] = { 0 };
		//enable(true);
		//enable(false);
		//halt();
		//reset();
		//getStatus(temp);
		//homming();
		//goStartPos();
		//singleAxisMovVel(1, -12.90);
		//singleAxisMovAbs(1, -12.90);
		//singleAxisMovRel(1, -12.90);
		//carMove(13, 13);
		//swingarmCoupling(13, 13);
		//setMovePara(100, 100, 20);
	}
	//退出
	closesocket(sHost); //关闭套接字
	WSACleanup(); //释放套接字资源
	return 0;
}

//上下使能
void enable(bool enable)
{
	ZeroMemory(buf, BUF_SIZE);
	if (enable == true)
	{
		string temp = "AA01AA";
		for (int i = 0; i < temp.size(); i++)
		{
			buf[i] = temp[i];
		}
	}
	else if (enable ==false)
	{
		string temp = "AA02AA";
		for (int i = 0; i < temp.size(); i++)
		{
			buf[i] = temp[i];
		}
	}
	retVal = send(sHost, buf, strlen(buf), 0);
	if (SOCKET_ERROR == retVal)
	{
		cout << "send failed!" << endl;
		closesocket(sHost); //关闭套接字
		WSACleanup(); //释放套接字资源
		return ;
	}
	//RecvLine(sHost, bufRecv);
	ZeroMemory(bufRecv, BUF_SIZE);
	recv(sHost, bufRecv, BUF_SIZE, 0); // 接收服务器端的数据,只接收5个字符
	cout << "从服务器接收数据: " << bufRecv << endl;
	
}

//暂停
void halt()
{
	ZeroMemory(buf, BUF_SIZE);
	string temp = "AA03AA";
	for (int i = 0; i < temp.size(); i++)
	{
		buf[i] = temp[i];
	}
	retVal = send(sHost, buf, strlen(buf), 0);
	if (SOCKET_ERROR == retVal)
	{
		cout << "send failed!" << endl;
		closesocket(sHost); //关闭套接字
		WSACleanup(); //释放套接字资源
		return;
	}
	//RecvLine(sHost, bufRecv);
	ZeroMemory(bufRecv, BUF_SIZE);
	recv(sHost, bufRecv, BUF_SIZE, 0); // 接收服务器端的数据,只接收5个字符


		cout << "从服务器接收数据: " << bufRecv << endl;
	
}

//复位
void reset()
{
	ZeroMemory(buf, BUF_SIZE);
	string temp = "AA04AA";
	for (int i = 0; i < temp.size(); i++)
	{
		buf[i] = temp[i];
	}
	retVal = send(sHost, buf, strlen(buf), 0);
	if (SOCKET_ERROR == retVal)
	{
		cout << "send failed!" << endl;
		closesocket(sHost); //关闭套接字
		WSACleanup(); //释放套接字资源
		return;
	}
	//RecvLine(sHost, bufRecv);
	ZeroMemory(bufRecv, BUF_SIZE);
	recv(sHost, bufRecv, BUF_SIZE, 0); // 接收服务器端的数据,只接收5个字符


		cout << "从服务器接收数据: " << bufRecv << endl;

}

//读取状态
void getStatus(double status[])
{

	while (true)
	{

		ZeroMemory(buf, BUF_SIZE);
		string temp = "AA10AA";
		for (int i = 0; i < temp.size(); i++)
		{
			buf[i] = temp[i];
		}
		retVal = send(sHost, buf, strlen(buf), 0);
		if (SOCKET_ERROR == retVal)
		{
			cout << "send failed!" << endl;
			closesocket(sHost); //关闭套接字
			WSACleanup(); //释放套接字资源
			return;
		}
		//RecvLine(sHost, bufRecv);
		ZeroMemory(bufRecv, BUF_SIZE);
		recv(sHost, bufRecv, BUF_SIZE, 0); // 接收服务器端的数据,只接收5个字符
		double* Sstatus = (double*)bufRecv;
		cout << "各轴速度：" << endl;
		for (int i = 0; i < 4; i++)
		{
			cout << Sstatus[i] << endl;
			outfile << "速度：" << Sstatus[i] << endl;
		}
		/*cout << "各轴位置：" << endl;
		for (int i = 0; i < 8; i++)
		{
			cout << Sstatus[i + 8] << endl;
			outfile << "位置：" << Sstatus[i + 8] << endl;

		}
		cout << "各轴电流：" << endl;
		for (int i = 0; i < 8; i++)
		{
			cout << Sstatus[i + 16] << endl;
			outfile << "电流：" << Sstatus[i + 16] << endl;
		}
		outfile << endl;
		for (int i = 0; i < 8; i++)
		{
		robotMFSM.Input_GetActPosition(&Sstatus[i + 8], 13);
		robotMFSM.Input_GetActVel(&Sstatus[i], 13);
		robotMFSM.Input_GetActInclination(0,0);
		robotMFSM.Input_GetActCurrent(&Sstatus[i + 16], 13);
		}
		cout << *robotMFSM.Output_ShowCG() << endl;
		cout << robotMFSM.Output_ShowMFSM() << endl;*/
		

	}
}

//寻参
void homming()
{
	ZeroMemory(buf, BUF_SIZE);
	string temp = "AA12AA";
	for (int i = 0; i < temp.size(); i++)
	{
		buf[i] = temp[i];
	}
	retVal = send(sHost, buf, strlen(buf), 0);
	if (SOCKET_ERROR == retVal)
	{
		cout << "send failed!" << endl;
		closesocket(sHost); //关闭套接字
		WSACleanup(); //释放套接字资源
		return;
	}
	//RecvLine(sHost, bufRecv);
	ZeroMemory(bufRecv, BUF_SIZE);
	recv(sHost, bufRecv, BUF_SIZE, 0); // 接收服务器端的数据,只接收5个字符

	if (!(buf[2] == '1'&&buf[3] == '0'))
	{
		cout << "从服务器接收数据: " << bufRecv << endl;
	}
	else
	{
		double* temp = (double*)bufRecv;
		for (int j = 0; j < 16; j++)
		{
			cout << "从服务器接收数据: " << temp[j] << endl;
		}
	}
}

//运动到开始位置
void goStartPos()
{
	ZeroMemory(buf, BUF_SIZE);
	string temp = "AA13AA";
	for (int i = 0; i < temp.size(); i++)
	{
		buf[i] = temp[i];
	}
	retVal = send(sHost, buf, strlen(buf), 0);
	if (SOCKET_ERROR == retVal)
	{
		cout << "send failed!" << endl;
		closesocket(sHost); //关闭套接字
		WSACleanup(); //释放套接字资源
		return;
	}
	//RecvLine(sHost, bufRecv);
	ZeroMemory(bufRecv, BUF_SIZE);
	recv(sHost, bufRecv, BUF_SIZE, 0); // 接收服务器端的数据,只接收5个字符

	if (!(buf[2] == '1'&&buf[3] == '0'))
	{
		cout << "从服务器接收数据: " << bufRecv << endl;
	}
	else
	{
		double* temp = (double*)bufRecv;
		for (int j = 0; j < 16; j++)
		{
			cout << "从服务器接收数据: " << temp[j] << endl;
		}
	}
}

//单轴恒速运动
void singleAxisMovVel(int index, double vel)
{
	ZeroMemory(buf, BUF_SIZE);
	string temp = "AA05A0" + to_string(index)+"A"+to_string(vel)+"AA";
	
	for (int i = 0; i < temp.size(); i++)
	{
		buf[i] = temp[i];
	}
	retVal = send(sHost, buf, strlen(buf), 0);
	if (SOCKET_ERROR == retVal)
	{
		cout << "send failed!" << endl;
		closesocket(sHost); //关闭套接字
		WSACleanup(); //释放套接字资源
		return;
	}
	//RecvLine(sHost, bufRecv);
	ZeroMemory(bufRecv, BUF_SIZE);
	recv(sHost, bufRecv, BUF_SIZE, 0); // 接收服务器端的数据,只接收5个字符

	if (!(buf[2] == '1'&&buf[3] == '0'))
	{
		cout << "从服务器接收数据: " << bufRecv << endl;
	}
	else
	{
		double* temp = (double*)bufRecv;
		for (int j = 0; j < 24; j++)
		{
			cout << "从服务器接收数据: " << temp[j] << endl;
		}
	}
}

//单轴绝对位置
void singleAxisMovAbs(int index, double pos)
{
	ZeroMemory(buf, BUF_SIZE);
	string temp = "AA06A0" + to_string(index) + "A" + to_string(pos) + "AA";

	for (int i = 0; i < temp.size(); i++)
	{
		buf[i] = temp[i];
	}
	retVal = send(sHost, buf, strlen(buf), 0);
	if (SOCKET_ERROR == retVal)
	{
		cout << "send failed!" << endl;
		closesocket(sHost); //关闭套接字
		WSACleanup(); //释放套接字资源
		return;
	}
	//RecvLine(sHost, bufRecv);
	ZeroMemory(bufRecv, BUF_SIZE);
	recv(sHost, bufRecv, BUF_SIZE, 0); // 接收服务器端的数据,只接收5个字符

	if (!(buf[2] == '1'&&buf[3] == '0'))
	{
		cout << "从服务器接收数据: " << bufRecv << endl;
	}
	else
	{
		double* temp = (double*)bufRecv;
		for (int j = 0; j < 24; j++)
		{
			cout << "从服务器接收数据: " << temp[j] << endl;
		}
	}
}

//单轴相对运动
void singleAxisMovRel(int index, double pos)
{
	ZeroMemory(buf, BUF_SIZE);
	string temp = "AA07A0" + to_string(index) + "A" + to_string(pos) + "AA";

	for (int i = 0; i < temp.size(); i++)
	{
		buf[i] = temp[i];
	}
	retVal = send(sHost, buf, strlen(buf), 0);
	if (SOCKET_ERROR == retVal)
	{
		cout << "send failed!" << endl;
		closesocket(sHost); //关闭套接字
		WSACleanup(); //释放套接字资源
		return;
	}
	//RecvLine(sHost, bufRecv);
	ZeroMemory(bufRecv, BUF_SIZE);
	recv(sHost, bufRecv, BUF_SIZE, 0); // 接收服务器端的数据,只接收5个字符

	if (!(buf[2] == '1'&&buf[3] == '0'))
	{
		cout << "从服务器接收数据: " << bufRecv << endl;
	}
	else
	{
		double* temp = (double*)bufRecv;
		for (int j = 0; j < 24; j++)
		{
			cout << "从服务器接收数据: " << temp[j] << endl;
		}
	}
}

//车模式
void carMove(double velx, double vely)
{
	ZeroMemory(buf, BUF_SIZE);
	string temp = "AA08A" + to_string(velx) + "A" + to_string(vely) + "AA";

	for (int i = 0; i < temp.size(); i++)
	{
		buf[i] = temp[i];
	}
	retVal = send(sHost, buf, strlen(buf), 0);
	if (SOCKET_ERROR == retVal)
	{
		cout << "send failed!" << endl;
		closesocket(sHost); //关闭套接字
		WSACleanup(); //释放套接字资源
		return;
	}
	//RecvLine(sHost, bufRecv);
	ZeroMemory(bufRecv, BUF_SIZE);
	recv(sHost, bufRecv, BUF_SIZE, 0); // 接收服务器端的数据,只接收5个字符

	if (!(buf[2] == '1'&&buf[3] == '0'))
	{
		cout << "从服务器接收数据: " << bufRecv << endl;
	}
	else
	{
		double* temp = (double*)bufRecv;
		for (int j = 0; j < 24; j++)
		{
			cout << "从服务器接收数据: " << temp[j] << endl;
		}
	}
}

//摆臂耦合模式
void swingarmCoupling(double velx, double vely)
{
	ZeroMemory(buf, BUF_SIZE);
	string temp = "AA09A" + to_string(velx) + "A" + to_string(vely) + "AA";

	for (int i = 0; i < temp.size(); i++)
	{
		buf[i] = temp[i];
	}
	retVal = send(sHost, buf, strlen(buf), 0);
	if (SOCKET_ERROR == retVal)
	{
		cout << "send failed!" << endl;
		closesocket(sHost); //关闭套接字
		WSACleanup(); //释放套接字资源
		return;
	}
	//RecvLine(sHost, bufRecv);
	ZeroMemory(bufRecv, BUF_SIZE);
	recv(sHost, bufRecv, BUF_SIZE, 0); // 接收服务器端的数据,只接收5个字符

	if (!(buf[2] == '1'&&buf[3] == '0'))
	{
		cout << "从服务器接收数据: " << bufRecv << endl;
	}
	else
	{
		double* temp = (double*)bufRecv;
		for (int j = 0; j < 24; j++)
		{
			cout << "从服务器接收数据: " << temp[j] << endl;
		}
	}
}

//运动到目标点
void setMovePara(double x, double y, double alpha)
{
	double pos = alpha * 10;
	singleAxisMovAbs(1, pos);
	singleAxisMovAbs(2, pos);
	singleAxisMovAbs(3, -pos);
	singleAxisMovAbs(4, -pos);
	Sleep(3000);
	pos = sqrt(x*x + y*y);
	singleAxisMovAbs(1, pos);
	singleAxisMovAbs(2, pos);
	singleAxisMovAbs(3, pos);
	singleAxisMovAbs(4, pos);
	Sleep(3000);
}