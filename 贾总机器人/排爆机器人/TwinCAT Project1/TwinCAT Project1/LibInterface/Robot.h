/*************************************************************************/
/*���ܣ��������࣬�������
/*������:������
/*�ش�Ķ���ʱ��:
2018/5/22
*************************************************************************/

#include "Axis.h"
#include "Vehicle.h"
#include "SwingArm.h"
#include "Mainpulator.h"

class Robot
{
public:
	Vehicle vehicle;
	SwingArms arm;
	Mainpulator mainpulator;
	virtual void ComdClear(int instruct);
	virtual void Init();
	virtual void DecoderInstruct(int instruct, int axisID, double velo, double pos, double velX, double velY, double velZ);

};