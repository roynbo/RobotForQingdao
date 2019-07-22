#include"MFSM.h"
#include"windows.h"
#include"stdafx.h"


/*============================================================================
*更新轴数据
*描述：根据传感器输入，更新轴位置
*
==============================================================================*/
void RobotMFSM::Input_GetActPosition(double pos[], double jointnum = JointsFreedom)
{
	memcpy(JointsPos, pos, jointnum * sizeof(double));
}
void RobotMFSM::Input_GetActVel(double vol[], double jointnum = JointsFreedom)
{
	memcpy(JointsVel, vol, jointnum * sizeof(double));
}
/*============================================================================
*更新倾角位置
*描述：根据传感器输入，更新倾角
*
==============================================================================*/
void RobotMFSM::Input_GetActInclination(double rollangle, double pitchangle)
{
	RollAngle = rollangle;
	PichAngle = pitchangle;
}
/*============================================================================
*更新轴力输出
*描述：根据传感器输入，更新轴力矩
*
==============================================================================*/
void RobotMFSM::Input_GetActCurrent(double cur[], double jointnum = 8)
{
	for (int i = 0; i < SupportFreedom; i++)
	{
		JointsTorque[i] = cur[i] * TorqueConstant[i];
	}

}
/*============================================================================
*输出质心位置
*描述：根据轴位置和质心位置，计算机器人质心
*
==============================================================================*/
double* RobotMFSM::Output_ShowCG()
{
	__CalculateCG();
	return CG;
}

/*============================================================================
*输出裕度
*描述：根据轴位置和质心位置，计算机器人质心
*
==============================================================================*/
double RobotMFSM::Output_ShowMFSM()
{
	__CalculateMFSM();
	return MFSM;
}

double RobotMFSM::CalMFSM()
{
	if (__CalculateMFSM() == true)
		return MFSM;
	else return 0;
}

/*============================================================================
*输出质心位置（水平坐标系）
*描述：根据轴位置和质心位置，计算机器人质心,以机器人坐标系为参考
*
==============================================================================*/
bool RobotMFSM::__CalculateCG()
{
	double s1 = sin(JointsPos[8]); double c1 = cos(sin(JointsPos[8]));
	double s2 = sin(JointsPos[9]); double c2 = cos(sin(JointsPos[9]));
	double s3 = sin(JointsPos[10]); double c3 = cos(sin(JointsPos[10]));
	double s4 = sin(JointsPos[11]); double c4 = cos(sin(JointsPos[11]));
	double s5 = sin(JointsPos[12]); double c5 = cos(sin(JointsPos[12]));
	double s6 = 0; double c6 = 1;
	double sw1 = sin(JointsPos[4]); double cw1 = cos(JointsPos[4]);
	double sw2 = sin(JointsPos[4]); double cw2 = cos(JointsPos[4]);
	double sw3 = sin(JointsPos[4]); double cw3 = cos(JointsPos[4]);
	double sw4 = sin(JointsPos[4]); double cw4 = cos(JointsPos[4]);
	double sx = sin(RollAngle);		double cx = cos(RollAngle);
	double sy = sin(PichAngle);		double cy = cos(PichAngle);
	//通过matlab直接推到计算公式
	
	//质心位置，（水平坐标系下）
	CG[0] = sx*sy*(0.5985*s1 - 0.7532*c1 + 0.1772*c1*(5.122*c4 + 26.73*s4*s5 - 6.063) - 0.1772*s1*s2*(158.6*s3 - 5.122*s4 + 26.73*c5*s3 + 26.73*c3*c4*s5) + 0.1772*c2*s1*(158.6*c3 + 26.73*c3*c5 + 5.122*s3*s4 - 26.73*c4*s3*s5 + 399.3) + 0.06689) - 1.0*cy*(8.868*cw3 - 8.868*cw2 - 8.868*cw1 + 8.868*cw4 - 0.5985*c1 + 4.805*sw1 + 4.805*sw2 + 4.805*sw3 + 4.805*sw4 - 0.7532*s1 + 0.1772*s1*(5.122*c4 + 26.73*s4*s5 - 6.063) - 0.1772*c1*c2*(158.6*c3 + 26.73*c3*c5 + 5.122*s3*s4 - 26.73*c4*s3*s5 + 399.3) + 0.1772*c1*s2*(158.6*s3 - 5.122*s4 + 26.73*c5*s3 + 26.73*c3*c4*s5) - 57.12) - 1.0*cx*sy*(4.805*cw1 + 4.805*cw2 + 4.805*cw3 + 4.805*cw4 + 8.868*sw1 + 8.868*sw2 - 8.868*sw3 - 8.868*sw4 + 0.1772*c2*(158.6*s3 - 5.122*s4 + 26.73*c5*s3 + 26.73*c3*c4*s5) + 0.1772*s2*(158.6*c3 + 26.73*c3*c5 + 5.122*s3*s4 - 26.73*c4*s3*s5 + 399.3) - 115.5);
	CG[1] = cx*(0.5985*s1 - 0.7532*c1 + 0.1772*c1*(5.122*c4 + 26.73*s4*s5 - 6.063) - 0.1772*s1*s2*(158.6*s3 - 5.122*s4 + 26.73*c5*s3 + 26.73*c3*c4*s5) + 0.1772*c2*s1*(158.6*c3 + 26.73*c3*c5 + 5.122*s3*s4 - 26.73*c4*s3*s5 + 399.3) + 0.06689) + sx*(4.805*cw1 + 4.805*cw2 + 4.805*cw3 + 4.805*cw4 + 8.868*sw1 + 8.868*sw2 - 8.868*sw3 - 8.868*sw4 + 0.1772*c2*(158.6*s3 - 5.122*s4 + 26.73*c5*s3 + 26.73*c3*c4*s5) + 0.1772*s2*(158.6*c3 + 26.73*c3*c5 + 5.122*s3*s4 - 26.73*c4*s3*s5 + 399.3) - 115.5);
	CG[2] = sy*(8.868*cw3 - 8.868*cw2 - 8.868*cw1 + 8.868*cw4 - 0.5985*c1 + 4.805*sw1 + 4.805*sw2 + 4.805*sw3 + 4.805*sw4 - 0.7532*s1 + 0.1772*s1*(5.122*c4 + 26.73*s4*s5 - 6.063) - 0.1772*c1*c2*(158.6*c3 + 26.73*c3*c5 + 5.122*s3*s4 - 26.73*c4*s3*s5 + 399.3) + 0.1772*c1*s2*(158.6*s3 - 5.122*s4 + 26.73*c5*s3 + 26.73*c3*c4*s5) - 57.12) - 1.0*cx*cy*(4.805*cw1 + 4.805*cw2 + 4.805*cw3 + 4.805*cw4 + 8.868*sw1 + 8.868*sw2 - 8.868*sw3 - 8.868*sw4 + 0.1772*c2*(158.6*s3 - 5.122*s4 + 26.73*c5*s3 + 26.73*c3*c4*s5) + 0.1772*s2*(158.6*c3 + 26.73*c3*c5 + 5.122*s3*s4 - 26.73*c4*s3*s5 + 399.3) - 115.5) + cy*sx*(0.5985*s1 - 0.7532*c1 + 0.1772*c1*(5.122*c4 + 26.73*s4*s5 - 6.063) - 0.1772*s1*s2*(158.6*s3 - 5.122*s4 + 26.73*c5*s3 + 26.73*c3*c4*s5) + 0.1772*c2*s1*(158.6*c3 + 26.73*c3*c5 + 5.122*s3*s4 - 26.73*c4*s3*s5 + 399.3) + 0.06689);

	return true;
}

/*============================================================================
*估计支撑点位置(水平坐标系)
*描述：倾角和摆臂位置估计支撑点
*[左前，左后，右前，右后] 1：主动轮A 2：中间支撑轮B 3：尾轮C
==============================================================================*/
int* RobotMFSM::__EstimateSuppotPoints()
{
	int state[4] = { 1, 1, 1, 1 };
	
	//计算各个轮的位置，结合地形倾角，推算支撑轮
	double x_inclination = RollAngle - TerrainInclination_x;
	double y_inclination = PichAngle - TerrainInclination_x;
	double cx = cos(x_inclination);
	double sx = sin(x_inclination);
	double cy = cos(y_inclination);
	double sy = sin(y_inclination);

	//计算水平坐标系下的支撑点位置
	double c1 = cos(RollAngle);
	double s1 = sin(RollAngle);
	double c2 = cos(PichAngle);
	double s2 = sin(PichAngle);

	// 计算各支撑轮 Z = cx*cy*z - sy*x + cy*sx*y
	//左前轮
	double x = WheelBase / 2;
	double y = WIDTH / 2;
	double z = 0;
	double LF_A_z = cx*cy*z - sy*x + cy*sx*y;
	double x11 = c2*x + c1*s2*z + s1*s2*y;
	double y11 = c1*y - s1*z;
	double z11 = c1*c2*z - s2*x + c2*s1*y;

	x = WheelBase / 2 + Distance_AB;
	y = WIDTH / 2;
	z = 0;
	double LF_B_z = cx*cy*z - sy*x + cy*sx*y;
	double x12 = c2*x + c1*s2*z + s1*s2*y;
	double y12 = c1*y - s1*z;
	double z12 = c1*c2*z - s2*x + c2*s1*y;

	x = WheelBase / 2 + Distance_AC*cos(Angle_A);
	y = WIDTH / 2;
	z = Distance_AC*sin(Angle_A);
	double LF_C_z = cx*cy*z - sy*x + cy*sx*y;
	double x13 = c2*x + c1*s2*z + s1*s2*y;
	double y13 = c1*y - s1*z;
	double z13 = c1*c2*z - s2*x + c2*s1*y;

	if (LF_C_z > LF_B_z &&LF_C_z > LF_A_z)
		state[0] = 3;
	else if (LF_B_z >= LF_C_z && LF_B_z > LF_A_z)
		state[0] = 2;
	else
		state[0] = 1;

	//左后轮
	x = -WheelBase / 2;
	y = WIDTH / 2;
	z = 0;
	double LB_A_z = cx*cy*z - sy*x + cy*sx*y;
	double x21 = c2*x + c1*s2*z + s1*s2*y;
	double y21 = c1*y - s1*z;
	double z21 = c1*c2*z - s2*x + c2*s1*y;

	x = -(WheelBase / 2 + Distance_AB);
	y = WIDTH / 2;
	z = 0;
	double LB_B_z = cx*cy*z - sy*x + cy*sx*y;
	double x22 = c2*x + c1*s2*z + s1*s2*y;
	double y22 = c1*y - s1*z;
	double z22 = c1*c2*z - s2*x + c2*s1*y;

	x = -(WheelBase / 2 + Distance_AC*cos(Angle_A));
	y = WIDTH / 2;
	z = Distance_AC*sin(Angle_A);
	double LB_C_z = cx*cy*z - sy*x + cy*sx*y;
	double x23 = c2*x + c1*s2*z + s1*s2*y;
	double y23 = c1*y - s1*z;
	double z23 = c1*c2*z - s2*x + c2*s1*y;
	if (LB_C_z > LB_B_z &&LB_C_z > LB_A_z)
		state[1] = 3;
	else if (LB_B_z >= LB_C_z && LB_B_z > LB_A_z)
		state[1] = 2;
	else
		state[1] = 1;

	//右前轮
	x = WheelBase / 2;
	y = -WIDTH / 2;
	z = 0;

	double RF_A_z = cx*cy*z - sy*x + cy*sx*y;
	double x31 = c2*x + c1*s2*z + s1*s2*y;
	double y31 = c1*y - s1*z;
	double z31 = c1*c2*z - s2*x + c2*s1*y;
	x = WheelBase / 2 + Distance_AB;
	y = -WIDTH / 2;
	z = 0;
	double RF_B_z = cx*cy*z - sy*x + cy*sx*y;
	double x32 = c2*x + c1*s2*z + s1*s2*y;
	double y32 = c1*y - s1*z;
	double z32 = c1*c2*z - s2*x + c2*s1*y;
	x = WheelBase / 2 + Distance_AC*cos(Angle_A);
	y = -WIDTH / 2;
	z = Distance_AC*sin(Angle_A);
	
	double RF_C_z = cx*cy*z - sy*x + cy*sx*y;
	double x33 = c2*x + c1*s2*z + s1*s2*y;
	double y33 = c1*y - s1*z;
	double z33 = c1*c2*z - s2*x + c2*s1*y;

	if (RF_C_z > RF_B_z && RF_C_z > RF_A_z)
		state[2] = 3;
	else if (RF_B_z >= RF_C_z && RF_B_z > RF_A_z)
		state[2] = 2;
	else
		state[2] = 1;

	//右后轮
	x = -WheelBase / 2;
	y = -WIDTH / 2;
	z = 0;	
	double RB_A_z = cx*cy*z - sy*x + cy*sx*y;
	double x41 = c2*x + c1*s2*z + s1*s2*y;
	double y41 = c1*y - s1*z;
	double z41 = c1*c2*z - s2*x + c2*s1*y;

	x = -(WheelBase / 2 + Distance_AB);
	y = -WIDTH / 2;
	z = 0;	
	double RB_B_z = cx*cy*z - sy*x + cy*sx*y;
	double x42 = c2*x + c1*s2*z + s1*s2*y;
	double y42 = c1*y - s1*z;
	double z42 = c1*c2*z - s2*x + c2*s1*y;
	
	x = -(WheelBase / 2 + Distance_AC*cos(Angle_A));
	y = -WIDTH / 2;
	z = Distance_AC*sin(Angle_A);
	double RB_C_z = cx*cy*z - sy*x + cy*sx*y;
	double x43 = c2*x + c1*s2*z + s1*s2*y;
	double y43 = c1*y - s1*z;
	double z43 = c1*c2*z - s2*x + c2*s1*y;
	
	if (RB_C_z > RB_B_z && RB_C_z > RB_A_z)
		state[2] = 3;
	else if (RB_B_z >= RB_C_z && RB_B_z > RB_A_z)
		state[2] = 2;
	else
		state[2] = 1;

	
	//计算支撑点位置
	switch (state[0])
	{
	case 3:
		Support[0] = x13;
		Support[1] = y13;
		Support[2] = z13 - Radius_C;
		break;
	case 2:
		Support[0] = x12;
		Support[1] = y12;
		Support[2] = z12 - Radius_B;
		break;
	default:
		Support[0] = x11;
		Support[1] = y11;
		Support[2] = z11 - Radius_A;
		break;
	}

	switch (state[1])
	{
	case 3:
		Support[3] = x23;
		Support[4] = y23;
		Support[5] = z23 - Radius_C;
		break;
	case 2:
		Support[3] = x22;
		Support[4] = y22;
		Support[5] = z22 - Radius_B;
		break;
	default:
		Support[3] = x21;
		Support[4] = y21;
		Support[5] = z21 - Radius_A;
		break;
	}
	switch (state[2])
	{
	case 3:
		Support[6] = x33;
		Support[7] = y33;
		Support[8] = z33 - Radius_C;
		break;
	case 2:
		Support[6] = x32;
		Support[7] = y32;
		Support[8] = z32 - Radius_B;
		break;
	default:
		Support[6] = x31;
		Support[7] = y31;
		Support[8] = z31 - Radius_A;
		break;
	}

	switch (state[3])
	{
	case 3:
		Support[9] = x43;
		Support[10] = y43;
		Support[11] = z43 - Radius_C;
		break;
	case 2:
		Support[9] = x42;
		Support[10] = y42;
		Support[11] = z42 - Radius_B;
		break;
	default:
		Support[9] = x41;
		Support[10] = y41;
		Support[11] = z41 - Radius_A;
		break;
	}
	return state;
}


/*============================================================================
*估计支撑力
*描述：倾角和摆臂位置估计支撑点
*[左前，左后，右前，右后] 1：主动轮A 2：中间支撑轮B 3：尾轮C
==============================================================================*/
double* RobotMFSM::__EstimateContactForces()
{
	int *state;

	state = __EstimateSuppotPoints();
	for (int i = 0; i < 4; i++)
	{
		switch (state[i])
		{
		case 2:
			ContactForces[i] = JointsTorque[4+i] / Distance_AB;
			break;
		case 3:
			ContactForces[i] = JointsTorque[4+i] / Distance_AC;
			break;
		default:
			ContactForces[i] = (JointsTorque[i] - k_v*JointsVel[0]) / k_c;
			break;
		}
	}
	return ContactForces;	
}

/*============================================================================
*计算虚支撑点
*描述：迭代法计算
*[左前，左后，右前，右后] 1：主动轮A 2：中间支撑轮B 3：尾轮C
==============================================================================*/
double* RobotMFSM::__EstimateVirtualPoints()
{

	__EstimateContactForces();
	//支撑力系数
	double k[4] = { 1 };
	double sum = ContactForces[0] + ContactForces[1] + ContactForces[2] + ContactForces[3];
	for (int i = 0; i < 4; i++)
	{
		k[i] = 4 * ContactForces[i] / sum;
		if (k[i] > 1)k[i] = 1;
	}
	//迭代计算虚拟点位置
	for (int cnt = 0; cnt < 100; cnt++)
	{
		double temSupport[12];
		memcpy(temSupport, Support, 12 * sizeof(double));
		for (int i = 0; i < 4; i++)
		{
			int m = i - 1;
			if (m < 0) m = 3;
			int n = i + 1;
			if (n > 3) n = 0;
			VirSupport[i * 3 + 0] = (1 - k[i])*(temSupport[m * 3 + 0] + temSupport[n * 3 + 0]) / 2 + k[i] * temSupport[i * 3 + 0];
			VirSupport[i * 3 + 1] = (1 - k[i])*(temSupport[m * 3 + 1] + temSupport[n * 3 + 1]) / 2 + k[i] * temSupport[i * 3 + 1];
			VirSupport[i * 3 + 2] = (1 - k[i])*(temSupport[m * 3 + 2] + temSupport[n * 3 + 2]) / 2 + k[i] * temSupport[i * 3 + 2];
		}
		double temp = 0;
		for (int j = 0; j < 12; j++)
		{
			double diff = fabs(VirSupport[j] - temSupport[j]);
			temp = temp > diff ? temp : diff;
		}
		if (temp < 0.01)
			break;
		else
			memcpy(temSupport, VirSupport, 12 * sizeof(double));
	}
	return VirSupport;
}
//计算稳定裕度，只考虑质心
bool RobotMFSM::__CalculateMFSM()
{
	__CalculateCG();
	__EstimateVirtualPoints();
	double tmp_MFSM = 10;

	for (int i = 0; i < 4; i++)
	{
		int j = i + 1;
		if (j >3) j = 0;
	
		double d_temp = sq(VirSupport[i * 3 + 0] - VirSupport[j * 3 + 0]) + sq(VirSupport[i * 3 + 1] - VirSupport[j * 3 + 1]) + sq(VirSupport[i * 3 + 2] - VirSupport[j * 3 + 2]);
		if (d_temp < 0.0001) return false;
		double product = (CG[0] - VirSupport[i * 3 + 0])*(VirSupport[j * 3 + 0] - VirSupport[i * 3 + 0])
			+ (CG[1] - VirSupport[i * 3 + 1])*(VirSupport[j * 3 + 1] - VirSupport[i * 3 + 1])
			+ (CG[2] - VirSupport[i * 3 + 2])*(VirSupport[j * 3 + 2] - VirSupport[i * 3 + 2]);
		double x_temp = VirSupport[i * 3 + 0] - CG[0] + product / d_temp*(VirSupport[j * 3 + 0] - VirSupport[i * 3 + 0]);
		double y_temp = VirSupport[i * 3 + 1] - CG[1] + product / d_temp*(VirSupport[j * 3 + 1] - VirSupport[i * 3 + 1]);
		double z_temp = VirSupport[i * 3 + 2] - CG[2] + product / d_temp*(VirSupport[j * 3 + 2] - VirSupport[i * 3 + 2]);
		double costh = -z_temp / sqrt(sq(x_temp) + sq(y_temp) + sq(z_temp));
		double theta = acos(costh);
		if (tmp_MFSM > theta)
		{
			tmp_MFSM = theta;
			RiskAxes = i;
		}
	}
	MFSM = tmp_MFSM;

	return true;

}