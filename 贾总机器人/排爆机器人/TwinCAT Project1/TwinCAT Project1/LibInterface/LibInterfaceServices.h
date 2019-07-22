///////////////////////////////////////////////////////////////////////////////
// LibInterfaceServices.h

#pragma once

#include "TcServices.h"

const ULONG DrvID_LibInterface = 0x3F000000;
#define SRVNAME_LIBINTERFACE "LibInterface"

///<AutoGeneratedContent id="ClassIDs">
const CTCID CID_LibInterfaceCLibInterface = {0x4967ee39,0x496d,0x46d8,{0x98,0x1a,0xcb,0xf8,0x9a,0x68,0x2a,0x58}};
///</AutoGeneratedContent>

///<AutoGeneratedContent id="ParameterIDs">
const PTCID PID_LibInterfaceDefaultAdsPort = 0x00000001;
const PTCID PID_LibInterfaceCounter = 0x00000003;
///</AutoGeneratedContent>

///<AutoGeneratedContent id="DataTypes">
#if !defined(_TC_TYPE_1687C4D7_9C55_4BA6_BCF9_27EE69BEC61A_INCLUDED_)
#define _TC_TYPE_1687C4D7_9C55_4BA6_BCF9_27EE69BEC61A_INCLUDED_
typedef struct _AxisCmdLib
{
	bool Enable;
	bool MoveAbsolute;
	bool MoveRelative;
	bool MoveVelocity;
	bool Reset;
	bool Halt;
	bool Home;
	bool SetZero;
	double Velocity;
	double Position;
} AxisCmdLib, *PAxisCmdLib;
#endif // !defined(_TC_TYPE_1687C4D7_9C55_4BA6_BCF9_27EE69BEC61A_INCLUDED_)

#if !defined(_TC_TYPE_5C1BB340_871E_416C_81A0_B5A33450C57B_INCLUDED_)
#define _TC_TYPE_5C1BB340_871E_416C_81A0_B5A33450C57B_INCLUDED_
#pragma pack(push,1)
typedef struct _AxisStatusLib
{
	bool Enable;
	double Velocity;
	double Position;
	SHORT Current;
} AxisStatusLib, *PAxisStatusLib;
#pragma pack(pop)
#endif // !defined(_TC_TYPE_5C1BB340_871E_416C_81A0_B5A33450C57B_INCLUDED_)

#pragma pack(push,1)
typedef struct _LibInterfaceInputs
{
	ULONG Value;
	ULONG Status;
	ULONG Data;
	AxisStatusLib DrivingWheel1Output;
	AxisStatusLib DrivingWheel2Output;
	AxisStatusLib DrivingWheel3Output;
	AxisStatusLib DrivingWheel4Output;
	AxisStatusLib SwingArm1Output;
	AxisStatusLib SwingArm2Output;
	AxisStatusLib SwingArm3Output;
	AxisStatusLib SwingArm4Output;
	AxisStatusLib WaistOutput;
	AxisStatusLib BigArmOutput;
	AxisStatusLib FlexOutput;
	AxisStatusLib MiddleArmOutput;
	AxisStatusLib SmallArmOutput;
	AxisStatusLib RotationOutput;
	AxisStatusLib ClampOutput;
} LibInterfaceInputs, *PLibInterfaceInputs;
#pragma pack(pop)

#pragma pack(push,1)
typedef struct _LibInterfaceOutputs
{
	ULONG Value;
	ULONG Control;
	ULONG Data;
	AxisCmdLib DrivingWheel1Input;
	AxisCmdLib DrivingWheel2Input;
	AxisCmdLib DrivingWheel3Input;
	AxisCmdLib DrivingWheel4Input;
	AxisCmdLib SwingArm1Input;
	AxisCmdLib SwingArm2Input;
	AxisCmdLib SwingArm3Input;
	AxisCmdLib SwingArm4Input;
	AxisCmdLib WaistInput;
	AxisCmdLib BigArmInput;
	AxisCmdLib FlexInput;
	AxisCmdLib MiddleArmInput;
	AxisCmdLib SmallArmInput;
	AxisCmdLib RotationInput;
	AxisCmdLib ClampInput;
} LibInterfaceOutputs, *PLibInterfaceOutputs;
#pragma pack(pop)

///</AutoGeneratedContent>



///<AutoGeneratedContent id="DataAreaIDs">
#define ADI_LibInterfaceInputs 0
#define ADI_LibInterfaceOutputs 1
///</AutoGeneratedContent>
