#include "Robot.h"

#define length_BigArm 0.54
#define length_MiddleArm 0.44
#define length_SmallArm 0.3

void Robot::Init()
{
	{
		for (int i = 0; i < 4; i++)
		{
			memset(&vehicle.DrivingWheel[i].AxisCommand, 0, sizeof(vehicle.DrivingWheel[i].AxisCommand));
			memset(&vehicle.DrivingWheel[i].AxisStatus, 0, sizeof(vehicle.DrivingWheel[i].AxisStatus));
		}
		for (int i = 0; i < 4; i++)
		{
			memset(&arm.SwingArm[i].AxisCommand, 0, sizeof(vehicle.DrivingWheel[i].AxisCommand));
			memset(&arm.SwingArm[i].AxisStatus, 0, sizeof(vehicle.DrivingWheel[i].AxisStatus));
		}
		for (int i = 0; i < 7; i++)
		{
			memset(&mainpulator.Mainpu[i].AxisCommand, 0, sizeof(mainpulator.Mainpu[i].AxisCommand));
			memset(&mainpulator.Mainpu[i].AxisStatus, 0, sizeof(mainpulator.Mainpu[i].AxisStatus));
		}
	}
}
void Robot::HandStop()
{
	mainpulator.Mainpu[1].AxisCommand.MoveVelocity = false;
	mainpulator.Mainpu[3].AxisCommand.MoveVelocity = false;
	mainpulator.Mainpu[4].AxisCommand.MoveVelocity = false;
}
void Robot::ComdClear( int instruct)
{
	if (instruct != 0 )
	{
		for (int i = 0; i < 4; i++)
		{
			vehicle.DrivingWheel[i].AxisCommand.Halt = false;
			vehicle.DrivingWheel[i].AxisCommand.MoveAbsolute = false;
			vehicle.DrivingWheel[i].AxisCommand.MoveRelative = false;
			vehicle.DrivingWheel[i].AxisCommand.MoveVelocity = false;
			vehicle.DrivingWheel[i].AxisCommand.Reset = false;
			arm.SwingArm[i].AxisCommand.Halt = false;
			arm.SwingArm[i].AxisCommand.MoveAbsolute = false;
			arm.SwingArm[i].AxisCommand.MoveRelative = false;
			arm.SwingArm[i].AxisCommand.MoveVelocity = false;
			arm.SwingArm[i].AxisCommand.Reset = false;
		}
		for (int i = 0; i < 7; i++)
		{
			mainpulator.Mainpu[i].AxisCommand.Halt = false;
			mainpulator.Mainpu[i].AxisCommand.MoveAbsolute = false;
			mainpulator.Mainpu[i].AxisCommand.MoveRelative = false;
			mainpulator.Mainpu[i].AxisCommand.MoveVelocity = false;
			mainpulator.Mainpu[i].AxisCommand.Reset = false;
			mainpulator.Mainpu[i].AxisCommand.Home = false;
		}
		instruct = 0;
	}
	
}
void Robot::CalculateHandVelo(double velX, double velY,int instruct)
{
	{
		double a = mainpulator.Mainpu[1].AxisStatus.position;
		double b = mainpulator.Mainpu[3].AxisStatus.position;
		double c = mainpulator.Mainpu[4].AxisStatus.position;
		double tempa = a;
		double tempb = b;
		a = 156.0 + a;
		b = 29.8 + b + tempa;
		c = -12.55 + c + tempa + tempb;
		a = a / 180 * PI;
		b = b / 180 * PI;
		c = c / 180 * PI;
		mainpulator.Mainpu[1].AxisCommand.Velocity = (velX*cos_(b) + velY * sin_(b)) / (length_BigArm*sin_(b - a));
		mainpulator.Mainpu[3].AxisCommand.Velocity = (velY - mainpulator.Mainpu[1].AxisCommand.Velocity*(length_BigArm*cos_(a) + length_MiddleArm * cos_(b))) / (length_MiddleArm*cos_(b));
		mainpulator.Mainpu[4].AxisCommand.Velocity = -mainpulator.Mainpu[1].AxisCommand.Velocity - mainpulator.Mainpu[3].AxisCommand.Velocity;
		mainpulator.Mainpu[1].AxisCommand.Velocity = mainpulator.Mainpu[1].AxisCommand.Velocity / PI * 180;
		mainpulator.Mainpu[3].AxisCommand.Velocity = mainpulator.Mainpu[3].AxisCommand.Velocity / PI * 180;
		mainpulator.Mainpu[4].AxisCommand.Velocity = mainpulator.Mainpu[4].AxisCommand.Velocity / PI * 180;
		mainpulator.Mainpu[1].AxisCommand.MoveVelocity = true;
		mainpulator.Mainpu[3].AxisCommand.MoveVelocity = true;
		mainpulator.Mainpu[4].AxisCommand.MoveVelocity = true;
	}
}
void Robot::DecoderInstruct(int instruct, int axisID, double velo, double pos, double velX, double velY, double velZ)
{
	if (instruct == 20)				//车体上使能
	{
		for (int i = 0; i < 4; i++)
		{
			vehicle.DrivingWheel[i].AxisCommand.Enable = true;
			arm.SwingArm[i].AxisCommand.Enable = true;
		}
	}

	else if (instruct == 30)			//机械臂上使能
	{
		for (int i = 0; i < 7; i++)
		{
			mainpulator.Mainpu[i].AxisCommand.Enable = true;
		}
	}

	else if (instruct == 40)				//车体下使能
	{
		for (int i = 0; i < 4; i++)
		{
			vehicle.DrivingWheel[i].AxisCommand.Enable = false;
			arm.SwingArm[i].AxisCommand.Enable = false;
		}
	}
	else if (instruct == 50)				//机械臂下使能
	{
		for (int i = 0; i < 7; i++)
		{
			mainpulator.Mainpu[i].AxisCommand.Enable = false;
		}
	}
	else if (instruct == 60)				//全体复位
	{
		for (int i = 0; i < 4; i++)
		{
			vehicle.DrivingWheel[i].AxisCommand.Reset = true;
			arm.SwingArm[i].AxisCommand.Reset = true;
			vehicle.DrivingWheel[i].AxisCommand.Enable = false;
			arm.SwingArm[i].AxisCommand.Enable = false;
		}
		for (int i = 0; i < 7; i++)
		{
			mainpulator.Mainpu[i].AxisCommand.Reset = true;
			mainpulator.Mainpu[i].AxisCommand.Enable = false;
		}
	}
	else if (instruct == 70)				//全体暂停
	{
		for (int i = 0; i < 4; i++)
		{
			vehicle.DrivingWheel[i].AxisCommand.Halt = true;
			arm.SwingArm[i].AxisCommand.Halt = true;
		}
		for (int i = 0; i < 7; i++)
		{
			mainpulator.Mainpu[i].AxisCommand.Halt = true;
		}
	}
	else if (instruct == 80)				//机械臂寻0
	{
		mainpulator.Mainpu[1].AxisCommand.Home = true;
		mainpulator.Mainpu[3].AxisCommand.Home = true;
		mainpulator.Mainpu[4].AxisCommand.Home = true;
	}
	else if (instruct == 90)				//车模式
	{


		double VeloL = 0;
		double VeloR = 0;
		VeloL = velX - velY / 120;
		VeloR = velX + velY / 120;
		vehicle.DrivingWheel[0].AxisCommand.Velocity = VeloL;
		vehicle.DrivingWheel[3].AxisCommand.Velocity = VeloL;
		vehicle.DrivingWheel[1].AxisCommand.Velocity = VeloR;
		vehicle.DrivingWheel[2].AxisCommand.Velocity = VeloR;

		for (int i = 0; i < 4; i++)
		{
			vehicle.DrivingWheel[i].AxisCommand.MoveVelocity = true;

		}
	}
	else if (instruct == 100)				//手模式
	{
		
	}
	else if (instruct == 110)				//车轮单轴点动
	{
		vehicle.DrivingWheel[axisID].AxisCommand.Velocity = velo;
		vehicle.DrivingWheel[axisID].AxisCommand.MoveVelocity = true;
	}
	else if (instruct == 120)				//摆臂单轴点动
	{
		arm.SwingArm[axisID].AxisCommand.Velocity = velo;
		arm.SwingArm[axisID].AxisCommand.MoveVelocity = true;
	}

	else if (instruct == 130)				//机械臂单轴点动
	{
		mainpulator.Mainpu[axisID].AxisCommand.Velocity = velo;
		mainpulator.Mainpu[axisID].AxisCommand.MoveVelocity = true;
	}
	else if (instruct == 140)				//摆臂相对运动
	{
		arm.SwingArm[axisID].AxisCommand.Velocity = velo;
		arm.SwingArm[axisID].AxisCommand.Position = pos;
		arm.SwingArm[axisID].AxisCommand.MoveRelative = true;
	}
	else if (instruct == 150)
	{
		mainpulator.Mainpu[axisID].AxisCommand.Velocity = velo;
		mainpulator.Mainpu[axisID].AxisCommand.Position = pos;
		mainpulator.Mainpu[axisID].AxisCommand.MoveRelative = true;
	}
	else if (instruct == 260)				//前双摆匀速运动
	{
		arm.SwingArm[0].AxisCommand.Velocity = velo;
		arm.SwingArm[0].AxisCommand.MoveVelocity = true;
		arm.SwingArm[1].AxisCommand.Velocity = velo;
		arm.SwingArm[1].AxisCommand.MoveVelocity = true;
	}
	else if (instruct == 270)				//后双摆匀速运动
	{
		arm.SwingArm[2].AxisCommand.Velocity = velo;
		arm.SwingArm[2].AxisCommand.MoveVelocity = true;
		arm.SwingArm[3].AxisCommand.Velocity = velo;
		arm.SwingArm[3].AxisCommand.MoveVelocity = true;
	}
	else if (instruct == 280)				//所有双摆匀速运动
	{
		arm.SwingArm[0].AxisCommand.Velocity = velo;
		arm.SwingArm[0].AxisCommand.MoveVelocity = true;
		arm.SwingArm[1].AxisCommand.Velocity = velo;
		arm.SwingArm[1].AxisCommand.MoveVelocity = true;
		arm.SwingArm[2].AxisCommand.Velocity = velo;
		arm.SwingArm[2].AxisCommand.MoveVelocity = true;
		arm.SwingArm[3].AxisCommand.Velocity = velo;
		arm.SwingArm[3].AxisCommand.MoveVelocity = true;
	}
	else if (instruct == 290||instruct==330)
	{
	for (int i = 0; i < 4; i++)
	{
		arm.SwingArm[i].AxisCommand.Velocity = 8;
		arm.SwingArm[i].AxisCommand.Position = -75;
		arm.SwingArm[i].AxisCommand.MoveAbsolute = true;
	}
		mainpulator.Mainpu[1].AxisCommand.Velocity = 8;
		mainpulator.Mainpu[1].AxisCommand.Position = -19.89;
		mainpulator.Mainpu[1].AxisCommand.MoveAbsolute = true;
		mainpulator.Mainpu[3].AxisCommand.Velocity = 5;
		mainpulator.Mainpu[3].AxisCommand.Position = -12.98;
		mainpulator.Mainpu[3].AxisCommand.MoveAbsolute = true;
		mainpulator.Mainpu[4].AxisCommand.Velocity = 3;
		mainpulator.Mainpu[4].AxisCommand.Position = -39.58;
		mainpulator.Mainpu[4].AxisCommand.MoveAbsolute = true;
	}
	else if (instruct == 340)
	{
		for (int i = 0; i < 4; i++)
		{
			arm.SwingArm[i].AxisCommand.Velocity = 8;
			arm.SwingArm[i].AxisCommand.Position = -10;
			arm.SwingArm[i].AxisCommand.MoveAbsolute = true;
		}
		mainpulator.Mainpu[1].AxisCommand.Velocity = 8;
		mainpulator.Mainpu[1].AxisCommand.Position = -115;
		mainpulator.Mainpu[1].AxisCommand.MoveAbsolute = true;
		mainpulator.Mainpu[3].AxisCommand.Velocity = 8;
		mainpulator.Mainpu[3].AxisCommand.Position = 60;
		mainpulator.Mainpu[3].AxisCommand.MoveAbsolute = true;
		mainpulator.Mainpu[4].AxisCommand.Velocity = 5;
		mainpulator.Mainpu[4].AxisCommand.Position = -20;
		mainpulator.Mainpu[4].AxisCommand.MoveAbsolute = true;
	}
	else if (instruct == 400)
	vehicle.DrivingWheel[1].AxisCommand.lighting = 0xffffffff;
	else if (instruct == 410)
	vehicle.DrivingWheel[1].AxisCommand.lighting = 0;
}


