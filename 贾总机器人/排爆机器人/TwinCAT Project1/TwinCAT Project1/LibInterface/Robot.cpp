#include "Robot.h"

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
void Robot::ComdClear(int instruct)
{
	if (instruct != 0)
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
		for (int i = 0; i < 7; i++)
		{
			mainpulator.Mainpu[i].AxisCommand.Home = true;
		}
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
	
}


