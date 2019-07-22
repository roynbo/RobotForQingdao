/*****************************************************************************/
/* 功能：计算机器人稳定裕度
/* 创建者：fengjb
/* 重大改动及时间：
2018.4.17： 创建;
******************************************************************************/
#pragma once
#include "math.h"
#define sq(x) ((x)*(x))

#define JointsFreedom	13
#define SupportFreedom	8
const double TorqueConstant[8] = { 1 };
#define TerrainInclination_x 0
#define TerrainInclination_y 0
/*************机械参数*******************************************************/
const double WIDTH = 400;		//车宽
const double WheelBase = 480;		//轴距
const double Distance_AB = 204;		//AB论轴距
const double Distance_BC = 385;		//BC论轴距
const double Distance_AC = 540;		//AC论轴距
const double Radius_A = 137;		//A轮半径
const double Radius_B = 85;		//B轮半径
const double Radius_C = 85;		//C轮半径
const double Angle_A = 0.5742;	//角BAC
const double Angle_B = 2.2755;	//角ABC
const double Angle_C = 0.2919;	//角ACB
const double Angle_BAE = 0.2832;
const double Angle_CBF = 0;
const double Angle_EF = 2.5587;

const double L_AB = 197;		//AB履带长度
const double L_BC = 385;		//AB履带长度

const double Err_Threshold = 2;			//误差阈值

const double AngleSlide = 1;			//滑动角

const double PositionFrontA_x = 240;	//前A轮相对参考点X坐标
const double PositionFrontA_y = 200;	//前A轮相对参考点Y坐标
const double PositionBackA_x = -240;	//后A轮相对参考点X坐标
const double PositionBackA_y = 0;	//后A轮相对参考点Y坐标

/**************************质量特性******************************************
const double Am1 = 5.43;
const double Am2 = 5.02;
const double Am3 = 2.23;
const double Am4 = 3.18;
const double Am5 = 2.79;
const double Am6 = 0;
const double Acx1 = 11.6;     const double Acy1 = -14.6;    const double Acz1 = -22.5;
const double Acx2 = 372.8;    const double Acy2 = 0;        const double Acz2 = 46;
const double Acx3 = 0;        const double Acy3 = 106;      const double Acz3 = -3.5;
const double Acx4 = 0;        const double Acy4 = 9;        const double Acz4 = -105.6;
const double Acx5 = 0;        const double Acy5 = 178.7;    const double Acz5 = 3.5;
const double Acx6 = 0;        const double Acy6 = 0;        const double Acz6 = 0;*/

const double k_c = 1;			//库伦摩擦系数
const double k_v = 1;			//粘滞摩擦系数

class RobotMFSM
{
public:
	RobotMFSM()
	{
		JointsPos[JointsFreedom] = { 0 };
		JointsVel[JointsFreedom] = {0};
		RollAngle = 0;
		PichAngle = 0;
		JointsTorque[SupportFreedom] = { 0 };
		CG[3] = { 0 };
		MFSM = 0;
		Support[12] = { 0 };
		VirSupport[12] = { 0 };
		RiskAxes = 1;
		ContactForces[4] = {0};
	}
	
	void Input_GetActPosition(double pos[], double jointnum );		//输入轴位置左前、左后、右前、右后，先主动轮，后摆臂，后机械臂
	void Input_GetActVel(double vol[], double jointnum );
	void Input_GetActInclination(double rollangle, double pitchangle);//输入倾角
	void Input_GetActCurrent(double cur[], double jointnum);	//输入摆臂和主动轮电流，左前、左后、右前、右后，先主动轮，后摆臂

	double* Output_ShowCG();
	double Output_ShowMFSM();

	double CalMFSM();

private:
	bool __CalculateCG();						//计算质心
	int* __EstimateSuppotPoints();			//估计支撑点
	double* __EstimateContactForces();
	double* __EstimateVirtualPoints();
	bool __CalculateMFSM();					//计算阈值

//类属性
public:
	double JointsPos[JointsFreedom];
	double JointsVel[JointsFreedom];
	double RollAngle;
	double PichAngle;
	double JointsTorque[SupportFreedom];
	double CG[3];
	double MFSM;
	double Support[12];
	double VirSupport[12];
	double ContactForces[4];
	int RiskAxes;
};