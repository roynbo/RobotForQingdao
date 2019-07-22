using TwinCAT.Ads;
namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btConnect = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbNetID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.btn_BackSwing = new System.Windows.Forms.Button();
            this.btn_FrontSwing = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.tx_DoubleSwingArmVel = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.lab_ChosenAxis2 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tx_pos = new System.Windows.Forms.TextBox();
            this.btn_MoveRelative = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.tx_vel = new System.Windows.Forms.TextBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.lab_ChosenAxis1 = new System.Windows.Forms.Label();
            this.btn_MoveVelocity = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.tx_SingleVel = new System.Windows.Forms.TextBox();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.btn_BackZero = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Halt = new System.Windows.Forms.Button();
            this.btn_Enable = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.ClampActCur = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.ClampActPos = new System.Windows.Forms.TextBox();
            this.ClampActVel = new System.Windows.Forms.TextBox();
            this.ClampEnable = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.RotationActCur = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.RotationActPos = new System.Windows.Forms.TextBox();
            this.RotationActVel = new System.Windows.Forms.TextBox();
            this.RotationEnable = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.SmallArmActCur = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.SmallArmActPos = new System.Windows.Forms.TextBox();
            this.SmallArmActVel = new System.Windows.Forms.TextBox();
            this.SmallArmEnable = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.MiddleArmActCur = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.MiddleArmActPos = new System.Windows.Forms.TextBox();
            this.MiddleArmActVel = new System.Windows.Forms.TextBox();
            this.MiddleArmEnable = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.FlexActCur = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.FlexActPos = new System.Windows.Forms.TextBox();
            this.FlexActVel = new System.Windows.Forms.TextBox();
            this.FlexEnable = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.WaistActCur = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.WaistActPos = new System.Windows.Forms.TextBox();
            this.WaistActVel = new System.Windows.Forms.TextBox();
            this.WaistEnable = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.BigArmActCur = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.BigArmActPos = new System.Windows.Forms.TextBox();
            this.BigArmActVel = new System.Windows.Forms.TextBox();
            this.BigArmEnable = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.SwingArm4ActCur = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.SwingArm4ActPos = new System.Windows.Forms.TextBox();
            this.SwingArm4ActVel = new System.Windows.Forms.TextBox();
            this.SwingArm4Enable = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.SwingArm3ActCur = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.SwingArm3ActPos = new System.Windows.Forms.TextBox();
            this.SwingArm3ActVel = new System.Windows.Forms.TextBox();
            this.SwingArm3Enable = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.SwingArm2ActCur = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.SwingArm2ActPos = new System.Windows.Forms.TextBox();
            this.SwingArm2ActVel = new System.Windows.Forms.TextBox();
            this.SwingArm2Enable = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.SwingArm1ActCur = new System.Windows.Forms.TextBox();
            this.SwingArm1ActPos = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.SwingArm1ActVel = new System.Windows.Forms.TextBox();
            this.SwingArm1Enable = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DrivingWheel4ActCur = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.DrivingWheel4ActPos = new System.Windows.Forms.TextBox();
            this.DrivingWheel4ActVel = new System.Windows.Forms.TextBox();
            this.DrivingWheel4Enable = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DrivingWheel3ActCur = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.DrivingWheel3ActPos = new System.Windows.Forms.TextBox();
            this.DrivingWheel3ActVel = new System.Windows.Forms.TextBox();
            this.DrivingWheel3Enable = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DrivingWheel2ActCur = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.DrivingWheel2ActPos = new System.Windows.Forms.TextBox();
            this.DrivingWheel2ActVel = new System.Windows.Forms.TextBox();
            this.DrivingWheel2Enable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DrivingWheel1ActCur = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.DrivingWheel1ActPos = new System.Windows.Forms.TextBox();
            this.DrivingWheel1ActVel = new System.Windows.Forms.TextBox();
            this.DrivingWheel1Enable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.ArmMoveZ = new System.Windows.Forms.TextBox();
            this.ArmMoveY = new System.Windows.Forms.TextBox();
            this.ArmMoveX = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.ArmPosZ = new System.Windows.Forms.TextBox();
            this.ArmPosY = new System.Windows.Forms.TextBox();
            this.ArmPosX = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1644, 666);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btConnect);
            this.tabPage1.Controls.Add(this.btRun);
            this.tabPage1.Controls.Add(this.lbOutput);
            this.tabPage1.Controls.Add(this.tbPort);
            this.tabPage1.Controls.Add(this.tbNetID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1636, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.Color.Transparent;
            this.btConnect.Location = new System.Drawing.Point(133, 114);
            this.btConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(123, 50);
            this.btConnect.TabIndex = 13;
            this.btConnect.Text = "连接";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(133, 168);
            this.btRun.Margin = new System.Windows.Forms.Padding(4);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(123, 50);
            this.btRun.TabIndex = 12;
            this.btRun.Text = "运行";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 15;
            this.lbOutput.Location = new System.Drawing.Point(409, 8);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(239, 229);
            this.lbOutput.TabIndex = 11;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(181, 76);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(144, 25);
            this.tbPort.TabIndex = 9;
            this.tbPort.Text = "0xbf02";
            // 
            // tbNetID
            // 
            this.tbNetID.Location = new System.Drawing.Point(181, 42);
            this.tbNetID.Margin = new System.Windows.Forms.Padding(4);
            this.tbNetID.Name = "tbNetID";
            this.tbNetID.Size = new System.Drawing.Size(144, 25);
            this.tbNetID.TabIndex = 8;
            this.tbNetID.Text = "192.168.1.222.1.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "NetID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox22);
            this.tabPage2.Controls.Add(this.groupBox19);
            this.tabPage2.Controls.Add(this.radioButton15);
            this.tabPage2.Controls.Add(this.radioButton14);
            this.tabPage2.Controls.Add(this.radioButton13);
            this.tabPage2.Controls.Add(this.radioButton12);
            this.tabPage2.Controls.Add(this.radioButton9);
            this.tabPage2.Controls.Add(this.radioButton10);
            this.tabPage2.Controls.Add(this.radioButton11);
            this.tabPage2.Controls.Add(this.radioButton8);
            this.tabPage2.Controls.Add(this.radioButton7);
            this.tabPage2.Controls.Add(this.radioButton6);
            this.tabPage2.Controls.Add(this.radioButton5);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.groupBox18);
            this.tabPage2.Controls.Add(this.groupBox15);
            this.tabPage2.Controls.Add(this.groupBox14);
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.groupBox17);
            this.tabPage2.Controls.Add(this.groupBox16);
            this.tabPage2.Controls.Add(this.groupBox13);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1636, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.btn_BackSwing);
            this.groupBox22.Controls.Add(this.btn_FrontSwing);
            this.groupBox22.Controls.Add(this.label38);
            this.groupBox22.Controls.Add(this.tx_DoubleSwingArmVel);
            this.groupBox22.Location = new System.Drawing.Point(1287, 404);
            this.groupBox22.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox22.Size = new System.Drawing.Size(185, 200);
            this.groupBox22.TabIndex = 93;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "双摆运动";
            // 
            // btn_BackSwing
            // 
            this.btn_BackSwing.Location = new System.Drawing.Point(55, 132);
            this.btn_BackSwing.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BackSwing.Name = "btn_BackSwing";
            this.btn_BackSwing.Size = new System.Drawing.Size(100, 29);
            this.btn_BackSwing.TabIndex = 95;
            this.btn_BackSwing.Text = "后双摆";
            this.btn_BackSwing.UseVisualStyleBackColor = true;
            this.btn_BackSwing.Click += new System.EventHandler(this.btn_BackSwing_Click);
            // 
            // btn_FrontSwing
            // 
            this.btn_FrontSwing.Location = new System.Drawing.Point(55, 96);
            this.btn_FrontSwing.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FrontSwing.Name = "btn_FrontSwing";
            this.btn_FrontSwing.Size = new System.Drawing.Size(100, 29);
            this.btn_FrontSwing.TabIndex = 94;
            this.btn_FrontSwing.Text = "前双摆";
            this.btn_FrontSwing.UseVisualStyleBackColor = true;
            this.btn_FrontSwing.Click += new System.EventHandler(this.btn_FrontSwing_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(8, 44);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(37, 15);
            this.label38.TabIndex = 7;
            this.label38.Text = "速度";
            // 
            // tx_DoubleSwingArmVel
            // 
            this.tx_DoubleSwingArmVel.Location = new System.Drawing.Point(55, 40);
            this.tx_DoubleSwingArmVel.Margin = new System.Windows.Forms.Padding(4);
            this.tx_DoubleSwingArmVel.Name = "tx_DoubleSwingArmVel";
            this.tx_DoubleSwingArmVel.Size = new System.Drawing.Size(91, 25);
            this.tx_DoubleSwingArmVel.TabIndex = 6;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.groupBox21);
            this.groupBox19.Controls.Add(this.groupBox20);
            this.groupBox19.Location = new System.Drawing.Point(1272, 34);
            this.groupBox19.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox19.Size = new System.Drawing.Size(219, 362);
            this.groupBox19.TabIndex = 92;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "单轴运动";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.lab_ChosenAxis2);
            this.groupBox21.Controls.Add(this.label37);
            this.groupBox21.Controls.Add(this.tx_pos);
            this.groupBox21.Controls.Add(this.btn_MoveRelative);
            this.groupBox21.Controls.Add(this.label36);
            this.groupBox21.Controls.Add(this.tx_vel);
            this.groupBox21.Location = new System.Drawing.Point(8, 166);
            this.groupBox21.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox21.Size = new System.Drawing.Size(192, 188);
            this.groupBox21.TabIndex = 93;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "单轴匀速";
            // 
            // lab_ChosenAxis2
            // 
            this.lab_ChosenAxis2.AutoSize = true;
            this.lab_ChosenAxis2.Font = new System.Drawing.Font("宋体", 11F);
            this.lab_ChosenAxis2.Location = new System.Drawing.Point(8, 108);
            this.lab_ChosenAxis2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ChosenAxis2.Name = "lab_ChosenAxis2";
            this.lab_ChosenAxis2.Size = new System.Drawing.Size(85, 19);
            this.lab_ChosenAxis2.TabIndex = 94;
            this.lab_ChosenAxis2.Text = "选中的轴";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(8, 70);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(37, 15);
            this.label37.TabIndex = 46;
            this.label37.Text = "位置";
            // 
            // tx_pos
            // 
            this.tx_pos.Location = new System.Drawing.Point(55, 66);
            this.tx_pos.Margin = new System.Windows.Forms.Padding(4);
            this.tx_pos.Name = "tx_pos";
            this.tx_pos.Size = new System.Drawing.Size(91, 25);
            this.tx_pos.TabIndex = 45;
            // 
            // btn_MoveRelative
            // 
            this.btn_MoveRelative.Location = new System.Drawing.Point(80, 134);
            this.btn_MoveRelative.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MoveRelative.Name = "btn_MoveRelative";
            this.btn_MoveRelative.Size = new System.Drawing.Size(100, 29);
            this.btn_MoveRelative.TabIndex = 44;
            this.btn_MoveRelative.Text = "相对运动";
            this.btn_MoveRelative.UseVisualStyleBackColor = true;
            this.btn_MoveRelative.Click += new System.EventHandler(this.btn_MoveRelative_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(8, 35);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(37, 15);
            this.label36.TabIndex = 5;
            this.label36.Text = "速度";
            // 
            // tx_vel
            // 
            this.tx_vel.Location = new System.Drawing.Point(55, 31);
            this.tx_vel.Margin = new System.Windows.Forms.Padding(4);
            this.tx_vel.Name = "tx_vel";
            this.tx_vel.Size = new System.Drawing.Size(91, 25);
            this.tx_vel.TabIndex = 4;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.lab_ChosenAxis1);
            this.groupBox20.Controls.Add(this.btn_MoveVelocity);
            this.groupBox20.Controls.Add(this.label35);
            this.groupBox20.Controls.Add(this.tx_SingleVel);
            this.groupBox20.Location = new System.Drawing.Point(8, 25);
            this.groupBox20.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox20.Size = new System.Drawing.Size(192, 134);
            this.groupBox20.TabIndex = 0;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "单轴匀速";
            // 
            // lab_ChosenAxis1
            // 
            this.lab_ChosenAxis1.AutoSize = true;
            this.lab_ChosenAxis1.Font = new System.Drawing.Font("宋体", 11F);
            this.lab_ChosenAxis1.Location = new System.Drawing.Point(8, 75);
            this.lab_ChosenAxis1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ChosenAxis1.Name = "lab_ChosenAxis1";
            this.lab_ChosenAxis1.Size = new System.Drawing.Size(85, 19);
            this.lab_ChosenAxis1.TabIndex = 93;
            this.lab_ChosenAxis1.Text = "选中的轴";
            // 
            // btn_MoveVelocity
            // 
            this.btn_MoveVelocity.Location = new System.Drawing.Point(80, 98);
            this.btn_MoveVelocity.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MoveVelocity.Name = "btn_MoveVelocity";
            this.btn_MoveVelocity.Size = new System.Drawing.Size(100, 29);
            this.btn_MoveVelocity.TabIndex = 44;
            this.btn_MoveVelocity.Text = "匀速运动";
            this.btn_MoveVelocity.UseVisualStyleBackColor = true;
            this.btn_MoveVelocity.Click += new System.EventHandler(this.btn_MoveVelocity_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(8, 35);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(37, 15);
            this.label35.TabIndex = 5;
            this.label35.Text = "速度";
            // 
            // tx_SingleVel
            // 
            this.tx_SingleVel.Location = new System.Drawing.Point(55, 31);
            this.tx_SingleVel.Margin = new System.Windows.Forms.Padding(4);
            this.tx_SingleVel.Name = "tx_SingleVel";
            this.tx_SingleVel.Size = new System.Drawing.Size(91, 25);
            this.tx_SingleVel.TabIndex = 4;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(940, 330);
            this.radioButton15.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(58, 19);
            this.radioButton15.TabIndex = 91;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "夹紧";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(940, 302);
            this.radioButton14.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(58, 19);
            this.radioButton14.TabIndex = 90;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "旋转";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(940, 275);
            this.radioButton13.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(58, 19);
            this.radioButton13.TabIndex = 89;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "小臂";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(940, 248);
            this.radioButton12.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(58, 19);
            this.radioButton12.TabIndex = 88;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "中臂";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(940, 165);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(43, 19);
            this.radioButton9.TabIndex = 87;
            this.radioButton9.Text = "腰";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(940, 192);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(58, 19);
            this.radioButton10.TabIndex = 86;
            this.radioButton10.Text = "大臂";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(940, 220);
            this.radioButton11.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(58, 19);
            this.radioButton11.TabIndex = 85;
            this.radioButton11.Text = "伸缩";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(847, 249);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(66, 19);
            this.radioButton8.TabIndex = 80;
            this.radioButton8.Text = "摆臂4";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(847, 221);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(66, 19);
            this.radioButton7.TabIndex = 79;
            this.radioButton7.Text = "摆臂3";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(847, 194);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(66, 19);
            this.radioButton6.TabIndex = 78;
            this.radioButton6.Text = "摆臂2";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(847, 166);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(66, 19);
            this.radioButton5.TabIndex = 77;
            this.radioButton5.Text = "摆臂1";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(724, 249);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(81, 19);
            this.radioButton4.TabIndex = 76;
            this.radioButton4.Text = "驱动轮4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(724, 221);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 19);
            this.radioButton3.TabIndex = 75;
            this.radioButton3.Text = "驱动轮3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(724, 194);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 19);
            this.radioButton2.TabIndex = 74;
            this.radioButton2.Text = "驱动轮2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(724, 166);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 19);
            this.radioButton1.TabIndex = 73;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "驱动轮1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.btn_BackZero);
            this.groupBox18.Controls.Add(this.btn_Home);
            this.groupBox18.Controls.Add(this.button7);
            this.groupBox18.Controls.Add(this.btn_Reset);
            this.groupBox18.Controls.Add(this.btn_Halt);
            this.groupBox18.Controls.Add(this.btn_Enable);
            this.groupBox18.Location = new System.Drawing.Point(717, 28);
            this.groupBox18.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox18.Size = new System.Drawing.Size(463, 118);
            this.groupBox18.TabIndex = 71;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "控制台";
            // 
            // btn_BackZero
            // 
            this.btn_BackZero.Location = new System.Drawing.Point(345, 25);
            this.btn_BackZero.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BackZero.Name = "btn_BackZero";
            this.btn_BackZero.Size = new System.Drawing.Size(100, 29);
            this.btn_BackZero.TabIndex = 87;
            this.btn_BackZero.Text = "归位";
            this.btn_BackZero.UseVisualStyleBackColor = true;
            this.btn_BackZero.Click += new System.EventHandler(this.btn_BackZero_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(237, 61);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(100, 29);
            this.btn_Home.TabIndex = 86;
            this.btn_Home.Text = "寻参";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(237, 25);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 29);
            this.button7.TabIndex = 47;
            this.button7.Text = "开灯";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(129, 62);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(100, 29);
            this.btn_Reset.TabIndex = 46;
            this.btn_Reset.Text = "复位";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Halt
            // 
            this.btn_Halt.Location = new System.Drawing.Point(20, 62);
            this.btn_Halt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Halt.Name = "btn_Halt";
            this.btn_Halt.Size = new System.Drawing.Size(100, 29);
            this.btn_Halt.TabIndex = 45;
            this.btn_Halt.Text = "暂停";
            this.btn_Halt.UseVisualStyleBackColor = true;
            this.btn_Halt.Click += new System.EventHandler(this.btn_Halt_Click);
            // 
            // btn_Enable
            // 
            this.btn_Enable.Location = new System.Drawing.Point(20, 25);
            this.btn_Enable.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Enable.Name = "btn_Enable";
            this.btn_Enable.Size = new System.Drawing.Size(100, 29);
            this.btn_Enable.TabIndex = 43;
            this.btn_Enable.Text = "上使能";
            this.btn_Enable.UseVisualStyleBackColor = true;
            this.btn_Enable.Click += new System.EventHandler(this.btn_Enable_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.ClampActCur);
            this.groupBox15.Controls.Add(this.label58);
            this.groupBox15.Controls.Add(this.ClampActPos);
            this.groupBox15.Controls.Add(this.ClampActVel);
            this.groupBox15.Controls.Add(this.ClampEnable);
            this.groupBox15.Controls.Add(this.label59);
            this.groupBox15.Controls.Add(this.label60);
            this.groupBox15.Controls.Add(this.label61);
            this.groupBox15.Location = new System.Drawing.Point(879, 441);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox15.Size = new System.Drawing.Size(133, 188);
            this.groupBox15.TabIndex = 68;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "夹紧";
            // 
            // ClampActCur
            // 
            this.ClampActCur.Location = new System.Drawing.Point(71, 126);
            this.ClampActCur.Margin = new System.Windows.Forms.Padding(4);
            this.ClampActCur.Name = "ClampActCur";
            this.ClampActCur.Size = new System.Drawing.Size(51, 25);
            this.ClampActCur.TabIndex = 9;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(8, 130);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(37, 15);
            this.label58.TabIndex = 8;
            this.label58.Text = "电流";
            // 
            // ClampActPos
            // 
            this.ClampActPos.Location = new System.Drawing.Point(71, 92);
            this.ClampActPos.Margin = new System.Windows.Forms.Padding(4);
            this.ClampActPos.Name = "ClampActPos";
            this.ClampActPos.Size = new System.Drawing.Size(51, 25);
            this.ClampActPos.TabIndex = 5;
            // 
            // ClampActVel
            // 
            this.ClampActVel.Location = new System.Drawing.Point(71, 59);
            this.ClampActVel.Margin = new System.Windows.Forms.Padding(4);
            this.ClampActVel.Name = "ClampActVel";
            this.ClampActVel.Size = new System.Drawing.Size(51, 25);
            this.ClampActVel.TabIndex = 4;
            // 
            // ClampEnable
            // 
            this.ClampEnable.Location = new System.Drawing.Point(71, 25);
            this.ClampEnable.Margin = new System.Windows.Forms.Padding(4);
            this.ClampEnable.Name = "ClampEnable";
            this.ClampEnable.Size = new System.Drawing.Size(51, 25);
            this.ClampEnable.TabIndex = 3;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(8, 96);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(37, 15);
            this.label59.TabIndex = 2;
            this.label59.Text = "位置";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(8, 62);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(37, 15);
            this.label60.TabIndex = 1;
            this.label60.Text = "速度";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(8, 29);
            this.label61.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(37, 15);
            this.label61.TabIndex = 0;
            this.label61.Text = "使能";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.RotationActCur);
            this.groupBox14.Controls.Add(this.label53);
            this.groupBox14.Controls.Add(this.RotationActPos);
            this.groupBox14.Controls.Add(this.RotationActVel);
            this.groupBox14.Controls.Add(this.RotationEnable);
            this.groupBox14.Controls.Add(this.label55);
            this.groupBox14.Controls.Add(this.label56);
            this.groupBox14.Controls.Add(this.label57);
            this.groupBox14.Location = new System.Drawing.Point(737, 441);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox14.Size = new System.Drawing.Size(133, 188);
            this.groupBox14.TabIndex = 67;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "旋转";
            // 
            // RotationActCur
            // 
            this.RotationActCur.Location = new System.Drawing.Point(71, 126);
            this.RotationActCur.Margin = new System.Windows.Forms.Padding(4);
            this.RotationActCur.Name = "RotationActCur";
            this.RotationActCur.Size = new System.Drawing.Size(51, 25);
            this.RotationActCur.TabIndex = 9;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(8, 130);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(37, 15);
            this.label53.TabIndex = 8;
            this.label53.Text = "电流";
            // 
            // RotationActPos
            // 
            this.RotationActPos.Location = new System.Drawing.Point(71, 92);
            this.RotationActPos.Margin = new System.Windows.Forms.Padding(4);
            this.RotationActPos.Name = "RotationActPos";
            this.RotationActPos.Size = new System.Drawing.Size(51, 25);
            this.RotationActPos.TabIndex = 5;
            // 
            // RotationActVel
            // 
            this.RotationActVel.Location = new System.Drawing.Point(71, 59);
            this.RotationActVel.Margin = new System.Windows.Forms.Padding(4);
            this.RotationActVel.Name = "RotationActVel";
            this.RotationActVel.Size = new System.Drawing.Size(51, 25);
            this.RotationActVel.TabIndex = 4;
            // 
            // RotationEnable
            // 
            this.RotationEnable.Location = new System.Drawing.Point(71, 25);
            this.RotationEnable.Margin = new System.Windows.Forms.Padding(4);
            this.RotationEnable.Name = "RotationEnable";
            this.RotationEnable.Size = new System.Drawing.Size(51, 25);
            this.RotationEnable.TabIndex = 3;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(8, 96);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(37, 15);
            this.label55.TabIndex = 2;
            this.label55.Text = "位置";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(8, 62);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(37, 15);
            this.label56.TabIndex = 1;
            this.label56.Text = "速度";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(8, 29);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(37, 15);
            this.label57.TabIndex = 0;
            this.label57.Text = "使能";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.SmallArmActCur);
            this.groupBox11.Controls.Add(this.label41);
            this.groupBox11.Controls.Add(this.SmallArmActPos);
            this.groupBox11.Controls.Add(this.SmallArmActVel);
            this.groupBox11.Controls.Add(this.SmallArmEnable);
            this.groupBox11.Controls.Add(this.label42);
            this.groupBox11.Controls.Add(this.label43);
            this.groupBox11.Controls.Add(this.label44);
            this.groupBox11.Location = new System.Drawing.Point(596, 440);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox11.Size = new System.Drawing.Size(133, 188);
            this.groupBox11.TabIndex = 66;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "小臂";
            // 
            // SmallArmActCur
            // 
            this.SmallArmActCur.Location = new System.Drawing.Point(71, 126);
            this.SmallArmActCur.Margin = new System.Windows.Forms.Padding(4);
            this.SmallArmActCur.Name = "SmallArmActCur";
            this.SmallArmActCur.Size = new System.Drawing.Size(51, 25);
            this.SmallArmActCur.TabIndex = 9;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(8, 130);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(37, 15);
            this.label41.TabIndex = 8;
            this.label41.Text = "电流";
            // 
            // SmallArmActPos
            // 
            this.SmallArmActPos.Location = new System.Drawing.Point(71, 92);
            this.SmallArmActPos.Margin = new System.Windows.Forms.Padding(4);
            this.SmallArmActPos.Name = "SmallArmActPos";
            this.SmallArmActPos.Size = new System.Drawing.Size(51, 25);
            this.SmallArmActPos.TabIndex = 5;
            // 
            // SmallArmActVel
            // 
            this.SmallArmActVel.Location = new System.Drawing.Point(71, 59);
            this.SmallArmActVel.Margin = new System.Windows.Forms.Padding(4);
            this.SmallArmActVel.Name = "SmallArmActVel";
            this.SmallArmActVel.Size = new System.Drawing.Size(51, 25);
            this.SmallArmActVel.TabIndex = 4;
            // 
            // SmallArmEnable
            // 
            this.SmallArmEnable.Location = new System.Drawing.Point(71, 25);
            this.SmallArmEnable.Margin = new System.Windows.Forms.Padding(4);
            this.SmallArmEnable.Name = "SmallArmEnable";
            this.SmallArmEnable.Size = new System.Drawing.Size(51, 25);
            this.SmallArmEnable.TabIndex = 3;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(8, 96);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(37, 15);
            this.label42.TabIndex = 2;
            this.label42.Text = "位置";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(8, 62);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(37, 15);
            this.label43.TabIndex = 1;
            this.label43.Text = "速度";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(8, 29);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(37, 15);
            this.label44.TabIndex = 0;
            this.label44.Text = "使能";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.MiddleArmActCur);
            this.groupBox12.Controls.Add(this.label45);
            this.groupBox12.Controls.Add(this.MiddleArmActPos);
            this.groupBox12.Controls.Add(this.MiddleArmActVel);
            this.groupBox12.Controls.Add(this.MiddleArmEnable);
            this.groupBox12.Controls.Add(this.label46);
            this.groupBox12.Controls.Add(this.label47);
            this.groupBox12.Controls.Add(this.label48);
            this.groupBox12.Location = new System.Drawing.Point(455, 440);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox12.Size = new System.Drawing.Size(133, 188);
            this.groupBox12.TabIndex = 65;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "中臂";
            // 
            // MiddleArmActCur
            // 
            this.MiddleArmActCur.Location = new System.Drawing.Point(71, 126);
            this.MiddleArmActCur.Margin = new System.Windows.Forms.Padding(4);
            this.MiddleArmActCur.Name = "MiddleArmActCur";
            this.MiddleArmActCur.Size = new System.Drawing.Size(51, 25);
            this.MiddleArmActCur.TabIndex = 9;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(8, 130);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(37, 15);
            this.label45.TabIndex = 8;
            this.label45.Text = "电流";
            // 
            // MiddleArmActPos
            // 
            this.MiddleArmActPos.Location = new System.Drawing.Point(71, 92);
            this.MiddleArmActPos.Margin = new System.Windows.Forms.Padding(4);
            this.MiddleArmActPos.Name = "MiddleArmActPos";
            this.MiddleArmActPos.Size = new System.Drawing.Size(51, 25);
            this.MiddleArmActPos.TabIndex = 5;
            // 
            // MiddleArmActVel
            // 
            this.MiddleArmActVel.Location = new System.Drawing.Point(71, 59);
            this.MiddleArmActVel.Margin = new System.Windows.Forms.Padding(4);
            this.MiddleArmActVel.Name = "MiddleArmActVel";
            this.MiddleArmActVel.Size = new System.Drawing.Size(51, 25);
            this.MiddleArmActVel.TabIndex = 4;
            // 
            // MiddleArmEnable
            // 
            this.MiddleArmEnable.Location = new System.Drawing.Point(71, 25);
            this.MiddleArmEnable.Margin = new System.Windows.Forms.Padding(4);
            this.MiddleArmEnable.Name = "MiddleArmEnable";
            this.MiddleArmEnable.Size = new System.Drawing.Size(51, 25);
            this.MiddleArmEnable.TabIndex = 3;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(8, 96);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(37, 15);
            this.label46.TabIndex = 2;
            this.label46.Text = "位置";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(8, 62);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(37, 15);
            this.label47.TabIndex = 1;
            this.label47.Text = "速度";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(8, 29);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(37, 15);
            this.label48.TabIndex = 0;
            this.label48.Text = "使能";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.FlexActCur);
            this.groupBox17.Controls.Add(this.label72);
            this.groupBox17.Controls.Add(this.FlexActPos);
            this.groupBox17.Controls.Add(this.FlexActVel);
            this.groupBox17.Controls.Add(this.FlexEnable);
            this.groupBox17.Controls.Add(this.label73);
            this.groupBox17.Controls.Add(this.label74);
            this.groupBox17.Controls.Add(this.label75);
            this.groupBox17.Location = new System.Drawing.Point(315, 440);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox17.Size = new System.Drawing.Size(133, 188);
            this.groupBox17.TabIndex = 64;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "伸缩";
            // 
            // FlexActCur
            // 
            this.FlexActCur.Location = new System.Drawing.Point(71, 126);
            this.FlexActCur.Margin = new System.Windows.Forms.Padding(4);
            this.FlexActCur.Name = "FlexActCur";
            this.FlexActCur.Size = new System.Drawing.Size(51, 25);
            this.FlexActCur.TabIndex = 9;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(8, 130);
            this.label72.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(37, 15);
            this.label72.TabIndex = 8;
            this.label72.Text = "电流";
            // 
            // FlexActPos
            // 
            this.FlexActPos.Location = new System.Drawing.Point(71, 92);
            this.FlexActPos.Margin = new System.Windows.Forms.Padding(4);
            this.FlexActPos.Name = "FlexActPos";
            this.FlexActPos.Size = new System.Drawing.Size(51, 25);
            this.FlexActPos.TabIndex = 5;
            // 
            // FlexActVel
            // 
            this.FlexActVel.Location = new System.Drawing.Point(71, 59);
            this.FlexActVel.Margin = new System.Windows.Forms.Padding(4);
            this.FlexActVel.Name = "FlexActVel";
            this.FlexActVel.Size = new System.Drawing.Size(51, 25);
            this.FlexActVel.TabIndex = 4;
            // 
            // FlexEnable
            // 
            this.FlexEnable.Location = new System.Drawing.Point(71, 25);
            this.FlexEnable.Margin = new System.Windows.Forms.Padding(4);
            this.FlexEnable.Name = "FlexEnable";
            this.FlexEnable.Size = new System.Drawing.Size(51, 25);
            this.FlexEnable.TabIndex = 3;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(8, 96);
            this.label73.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(37, 15);
            this.label73.TabIndex = 2;
            this.label73.Text = "位置";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(8, 62);
            this.label74.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(37, 15);
            this.label74.TabIndex = 1;
            this.label74.Text = "速度";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(8, 29);
            this.label75.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(37, 15);
            this.label75.TabIndex = 0;
            this.label75.Text = "使能";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.WaistActCur);
            this.groupBox16.Controls.Add(this.label62);
            this.groupBox16.Controls.Add(this.WaistActPos);
            this.groupBox16.Controls.Add(this.WaistActVel);
            this.groupBox16.Controls.Add(this.WaistEnable);
            this.groupBox16.Controls.Add(this.label63);
            this.groupBox16.Controls.Add(this.label64);
            this.groupBox16.Controls.Add(this.label65);
            this.groupBox16.Location = new System.Drawing.Point(32, 440);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox16.Size = new System.Drawing.Size(133, 188);
            this.groupBox16.TabIndex = 62;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "腰";
            // 
            // WaistActCur
            // 
            this.WaistActCur.Location = new System.Drawing.Point(71, 126);
            this.WaistActCur.Margin = new System.Windows.Forms.Padding(4);
            this.WaistActCur.Name = "WaistActCur";
            this.WaistActCur.Size = new System.Drawing.Size(51, 25);
            this.WaistActCur.TabIndex = 9;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(8, 130);
            this.label62.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(37, 15);
            this.label62.TabIndex = 8;
            this.label62.Text = "电流";
            // 
            // WaistActPos
            // 
            this.WaistActPos.Location = new System.Drawing.Point(71, 92);
            this.WaistActPos.Margin = new System.Windows.Forms.Padding(4);
            this.WaistActPos.Name = "WaistActPos";
            this.WaistActPos.Size = new System.Drawing.Size(51, 25);
            this.WaistActPos.TabIndex = 5;
            // 
            // WaistActVel
            // 
            this.WaistActVel.Location = new System.Drawing.Point(71, 59);
            this.WaistActVel.Margin = new System.Windows.Forms.Padding(4);
            this.WaistActVel.Name = "WaistActVel";
            this.WaistActVel.Size = new System.Drawing.Size(51, 25);
            this.WaistActVel.TabIndex = 4;
            // 
            // WaistEnable
            // 
            this.WaistEnable.Location = new System.Drawing.Point(71, 25);
            this.WaistEnable.Margin = new System.Windows.Forms.Padding(4);
            this.WaistEnable.Name = "WaistEnable";
            this.WaistEnable.Size = new System.Drawing.Size(51, 25);
            this.WaistEnable.TabIndex = 3;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(8, 96);
            this.label63.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(37, 15);
            this.label63.TabIndex = 2;
            this.label63.Text = "位置";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(8, 62);
            this.label64.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(37, 15);
            this.label64.TabIndex = 1;
            this.label64.Text = "速度";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(8, 29);
            this.label65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(37, 15);
            this.label65.TabIndex = 0;
            this.label65.Text = "使能";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.BigArmActCur);
            this.groupBox13.Controls.Add(this.label49);
            this.groupBox13.Controls.Add(this.BigArmActPos);
            this.groupBox13.Controls.Add(this.BigArmActVel);
            this.groupBox13.Controls.Add(this.BigArmEnable);
            this.groupBox13.Controls.Add(this.label50);
            this.groupBox13.Controls.Add(this.label51);
            this.groupBox13.Controls.Add(this.label52);
            this.groupBox13.Location = new System.Drawing.Point(173, 440);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox13.Size = new System.Drawing.Size(133, 188);
            this.groupBox13.TabIndex = 55;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "大臂";
            // 
            // BigArmActCur
            // 
            this.BigArmActCur.Location = new System.Drawing.Point(71, 126);
            this.BigArmActCur.Margin = new System.Windows.Forms.Padding(4);
            this.BigArmActCur.Name = "BigArmActCur";
            this.BigArmActCur.Size = new System.Drawing.Size(51, 25);
            this.BigArmActCur.TabIndex = 7;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(8, 130);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(37, 15);
            this.label49.TabIndex = 6;
            this.label49.Text = "电流";
            // 
            // BigArmActPos
            // 
            this.BigArmActPos.Location = new System.Drawing.Point(71, 92);
            this.BigArmActPos.Margin = new System.Windows.Forms.Padding(4);
            this.BigArmActPos.Name = "BigArmActPos";
            this.BigArmActPos.Size = new System.Drawing.Size(51, 25);
            this.BigArmActPos.TabIndex = 5;
            // 
            // BigArmActVel
            // 
            this.BigArmActVel.Location = new System.Drawing.Point(71, 59);
            this.BigArmActVel.Margin = new System.Windows.Forms.Padding(4);
            this.BigArmActVel.Name = "BigArmActVel";
            this.BigArmActVel.Size = new System.Drawing.Size(51, 25);
            this.BigArmActVel.TabIndex = 4;
            // 
            // BigArmEnable
            // 
            this.BigArmEnable.Location = new System.Drawing.Point(71, 25);
            this.BigArmEnable.Margin = new System.Windows.Forms.Padding(4);
            this.BigArmEnable.Name = "BigArmEnable";
            this.BigArmEnable.Size = new System.Drawing.Size(51, 25);
            this.BigArmEnable.TabIndex = 3;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(8, 96);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(37, 15);
            this.label50.TabIndex = 2;
            this.label50.Text = "位置";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(8, 62);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(37, 15);
            this.label51.TabIndex = 1;
            this.label51.Text = "速度";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(8, 29);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(37, 15);
            this.label52.TabIndex = 0;
            this.label52.Text = "使能";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Location = new System.Drawing.Point(352, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(336, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "摆臂";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.SwingArm4ActCur);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.SwingArm4ActPos);
            this.groupBox7.Controls.Add(this.SwingArm4ActVel);
            this.groupBox7.Controls.Add(this.SwingArm4Enable);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Location = new System.Drawing.Point(176, 228);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(133, 188);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "摆臂4";
            // 
            // SwingArm4ActCur
            // 
            this.SwingArm4ActCur.Location = new System.Drawing.Point(71, 126);
            this.SwingArm4ActCur.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm4ActCur.Name = "SwingArm4ActCur";
            this.SwingArm4ActCur.Size = new System.Drawing.Size(51, 25);
            this.SwingArm4ActCur.TabIndex = 13;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(8, 130);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(37, 15);
            this.label34.TabIndex = 12;
            this.label34.Text = "电流";
            // 
            // SwingArm4ActPos
            // 
            this.SwingArm4ActPos.Location = new System.Drawing.Point(71, 92);
            this.SwingArm4ActPos.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm4ActPos.Name = "SwingArm4ActPos";
            this.SwingArm4ActPos.Size = new System.Drawing.Size(51, 25);
            this.SwingArm4ActPos.TabIndex = 5;
            // 
            // SwingArm4ActVel
            // 
            this.SwingArm4ActVel.Location = new System.Drawing.Point(71, 59);
            this.SwingArm4ActVel.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm4ActVel.Name = "SwingArm4ActVel";
            this.SwingArm4ActVel.Size = new System.Drawing.Size(51, 25);
            this.SwingArm4ActVel.TabIndex = 4;
            // 
            // SwingArm4Enable
            // 
            this.SwingArm4Enable.Location = new System.Drawing.Point(71, 25);
            this.SwingArm4Enable.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm4Enable.Name = "SwingArm4Enable";
            this.SwingArm4Enable.Size = new System.Drawing.Size(51, 25);
            this.SwingArm4Enable.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 96);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "位置";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 62);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "速度";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 29);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "使能";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.SwingArm3ActCur);
            this.groupBox8.Controls.Add(this.label33);
            this.groupBox8.Controls.Add(this.SwingArm3ActPos);
            this.groupBox8.Controls.Add(this.SwingArm3ActVel);
            this.groupBox8.Controls.Add(this.SwingArm3Enable);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Location = new System.Drawing.Point(31, 228);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(133, 188);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "摆臂3";
            // 
            // SwingArm3ActCur
            // 
            this.SwingArm3ActCur.Location = new System.Drawing.Point(71, 126);
            this.SwingArm3ActCur.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm3ActCur.Name = "SwingArm3ActCur";
            this.SwingArm3ActCur.Size = new System.Drawing.Size(51, 25);
            this.SwingArm3ActCur.TabIndex = 11;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(8, 130);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 15);
            this.label33.TabIndex = 10;
            this.label33.Text = "电流";
            // 
            // SwingArm3ActPos
            // 
            this.SwingArm3ActPos.Location = new System.Drawing.Point(71, 92);
            this.SwingArm3ActPos.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm3ActPos.Name = "SwingArm3ActPos";
            this.SwingArm3ActPos.Size = new System.Drawing.Size(51, 25);
            this.SwingArm3ActPos.TabIndex = 5;
            // 
            // SwingArm3ActVel
            // 
            this.SwingArm3ActVel.Location = new System.Drawing.Point(71, 59);
            this.SwingArm3ActVel.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm3ActVel.Name = "SwingArm3ActVel";
            this.SwingArm3ActVel.Size = new System.Drawing.Size(51, 25);
            this.SwingArm3ActVel.TabIndex = 4;
            // 
            // SwingArm3Enable
            // 
            this.SwingArm3Enable.Location = new System.Drawing.Point(71, 25);
            this.SwingArm3Enable.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm3Enable.Name = "SwingArm3Enable";
            this.SwingArm3Enable.Size = new System.Drawing.Size(51, 25);
            this.SwingArm3Enable.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 96);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "位置";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 62);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "速度";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 29);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "使能";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.SwingArm2ActCur);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.SwingArm2ActPos);
            this.groupBox9.Controls.Add(this.SwingArm2ActVel);
            this.groupBox9.Controls.Add(this.SwingArm2Enable);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Location = new System.Drawing.Point(176, 26);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(133, 188);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "摆臂2";
            // 
            // SwingArm2ActCur
            // 
            this.SwingArm2ActCur.Location = new System.Drawing.Point(71, 126);
            this.SwingArm2ActCur.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm2ActCur.Name = "SwingArm2ActCur";
            this.SwingArm2ActCur.Size = new System.Drawing.Size(51, 25);
            this.SwingArm2ActCur.TabIndex = 9;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(8, 130);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 15);
            this.label30.TabIndex = 8;
            this.label30.Text = "电流";
            // 
            // SwingArm2ActPos
            // 
            this.SwingArm2ActPos.Location = new System.Drawing.Point(71, 92);
            this.SwingArm2ActPos.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm2ActPos.Name = "SwingArm2ActPos";
            this.SwingArm2ActPos.Size = new System.Drawing.Size(51, 25);
            this.SwingArm2ActPos.TabIndex = 5;
            // 
            // SwingArm2ActVel
            // 
            this.SwingArm2ActVel.Location = new System.Drawing.Point(71, 59);
            this.SwingArm2ActVel.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm2ActVel.Name = "SwingArm2ActVel";
            this.SwingArm2ActVel.Size = new System.Drawing.Size(51, 25);
            this.SwingArm2ActVel.TabIndex = 4;
            // 
            // SwingArm2Enable
            // 
            this.SwingArm2Enable.Location = new System.Drawing.Point(71, 25);
            this.SwingArm2Enable.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm2Enable.Name = "SwingArm2Enable";
            this.SwingArm2Enable.Size = new System.Drawing.Size(51, 25);
            this.SwingArm2Enable.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 96);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 15);
            this.label21.TabIndex = 2;
            this.label21.Text = "位置";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 62);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 15);
            this.label22.TabIndex = 1;
            this.label22.Text = "速度";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 29);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 15);
            this.label23.TabIndex = 0;
            this.label23.Text = "使能";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.SwingArm1ActCur);
            this.groupBox10.Controls.Add(this.SwingArm1ActPos);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.SwingArm1ActVel);
            this.groupBox10.Controls.Add(this.SwingArm1Enable);
            this.groupBox10.Controls.Add(this.label24);
            this.groupBox10.Controls.Add(this.label25);
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Location = new System.Drawing.Point(31, 26);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(133, 188);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "摆臂1";
            // 
            // SwingArm1ActCur
            // 
            this.SwingArm1ActCur.Location = new System.Drawing.Point(71, 126);
            this.SwingArm1ActCur.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm1ActCur.Name = "SwingArm1ActCur";
            this.SwingArm1ActCur.Size = new System.Drawing.Size(51, 25);
            this.SwingArm1ActCur.TabIndex = 9;
            // 
            // SwingArm1ActPos
            // 
            this.SwingArm1ActPos.Location = new System.Drawing.Point(71, 92);
            this.SwingArm1ActPos.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm1ActPos.Name = "SwingArm1ActPos";
            this.SwingArm1ActPos.Size = new System.Drawing.Size(51, 25);
            this.SwingArm1ActPos.TabIndex = 5;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 130);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(37, 15);
            this.label29.TabIndex = 8;
            this.label29.Text = "电流";
            // 
            // SwingArm1ActVel
            // 
            this.SwingArm1ActVel.Location = new System.Drawing.Point(71, 59);
            this.SwingArm1ActVel.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm1ActVel.Name = "SwingArm1ActVel";
            this.SwingArm1ActVel.Size = new System.Drawing.Size(51, 25);
            this.SwingArm1ActVel.TabIndex = 4;
            // 
            // SwingArm1Enable
            // 
            this.SwingArm1Enable.Location = new System.Drawing.Point(71, 25);
            this.SwingArm1Enable.Margin = new System.Windows.Forms.Padding(4);
            this.SwingArm1Enable.Name = "SwingArm1Enable";
            this.SwingArm1Enable.Size = new System.Drawing.Size(51, 25);
            this.SwingArm1Enable.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 96);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 15);
            this.label24.TabIndex = 2;
            this.label24.Text = "位置";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 62);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 15);
            this.label25.TabIndex = 1;
            this.label25.Text = "速度";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 29);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 15);
            this.label26.TabIndex = 0;
            this.label26.Text = "使能";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(336, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "车体";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DrivingWheel4ActCur);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.DrivingWheel4ActPos);
            this.groupBox6.Controls.Add(this.DrivingWheel4ActVel);
            this.groupBox6.Controls.Add(this.DrivingWheel4Enable);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(176, 228);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(133, 188);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "车轮4";
            // 
            // DrivingWheel4ActCur
            // 
            this.DrivingWheel4ActCur.Location = new System.Drawing.Point(71, 126);
            this.DrivingWheel4ActCur.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel4ActCur.Name = "DrivingWheel4ActCur";
            this.DrivingWheel4ActCur.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel4ActCur.TabIndex = 9;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(8, 130);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 15);
            this.label32.TabIndex = 8;
            this.label32.Text = "电流";
            // 
            // DrivingWheel4ActPos
            // 
            this.DrivingWheel4ActPos.Location = new System.Drawing.Point(71, 92);
            this.DrivingWheel4ActPos.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel4ActPos.Name = "DrivingWheel4ActPos";
            this.DrivingWheel4ActPos.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel4ActPos.TabIndex = 5;
            // 
            // DrivingWheel4ActVel
            // 
            this.DrivingWheel4ActVel.Location = new System.Drawing.Point(71, 59);
            this.DrivingWheel4ActVel.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel4ActVel.Name = "DrivingWheel4ActVel";
            this.DrivingWheel4ActVel.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel4ActVel.TabIndex = 4;
            // 
            // DrivingWheel4Enable
            // 
            this.DrivingWheel4Enable.Location = new System.Drawing.Point(71, 25);
            this.DrivingWheel4Enable.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel4Enable.Name = "DrivingWheel4Enable";
            this.DrivingWheel4Enable.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel4Enable.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "位置";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "速度";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "使能";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DrivingWheel3ActCur);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.DrivingWheel3ActPos);
            this.groupBox5.Controls.Add(this.DrivingWheel3ActVel);
            this.groupBox5.Controls.Add(this.DrivingWheel3Enable);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(31, 228);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(133, 188);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "车轮3";
            // 
            // DrivingWheel3ActCur
            // 
            this.DrivingWheel3ActCur.Location = new System.Drawing.Point(71, 126);
            this.DrivingWheel3ActCur.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel3ActCur.Name = "DrivingWheel3ActCur";
            this.DrivingWheel3ActCur.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel3ActCur.TabIndex = 9;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(8, 130);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 15);
            this.label31.TabIndex = 8;
            this.label31.Text = "电流";
            // 
            // DrivingWheel3ActPos
            // 
            this.DrivingWheel3ActPos.Location = new System.Drawing.Point(71, 92);
            this.DrivingWheel3ActPos.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel3ActPos.Name = "DrivingWheel3ActPos";
            this.DrivingWheel3ActPos.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel3ActPos.TabIndex = 5;
            // 
            // DrivingWheel3ActVel
            // 
            this.DrivingWheel3ActVel.Location = new System.Drawing.Point(71, 59);
            this.DrivingWheel3ActVel.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel3ActVel.Name = "DrivingWheel3ActVel";
            this.DrivingWheel3ActVel.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel3ActVel.TabIndex = 4;
            // 
            // DrivingWheel3Enable
            // 
            this.DrivingWheel3Enable.Location = new System.Drawing.Point(71, 25);
            this.DrivingWheel3Enable.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel3Enable.Name = "DrivingWheel3Enable";
            this.DrivingWheel3Enable.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel3Enable.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "位置";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "速度";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "使能";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DrivingWheel2ActCur);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.DrivingWheel2ActPos);
            this.groupBox4.Controls.Add(this.DrivingWheel2ActVel);
            this.groupBox4.Controls.Add(this.DrivingWheel2Enable);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(176, 26);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(133, 188);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "车轮2";
            // 
            // DrivingWheel2ActCur
            // 
            this.DrivingWheel2ActCur.Location = new System.Drawing.Point(71, 126);
            this.DrivingWheel2ActCur.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel2ActCur.Name = "DrivingWheel2ActCur";
            this.DrivingWheel2ActCur.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel2ActCur.TabIndex = 9;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 130);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 15);
            this.label28.TabIndex = 8;
            this.label28.Text = "电流";
            // 
            // DrivingWheel2ActPos
            // 
            this.DrivingWheel2ActPos.Location = new System.Drawing.Point(71, 92);
            this.DrivingWheel2ActPos.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel2ActPos.Name = "DrivingWheel2ActPos";
            this.DrivingWheel2ActPos.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel2ActPos.TabIndex = 5;
            // 
            // DrivingWheel2ActVel
            // 
            this.DrivingWheel2ActVel.Location = new System.Drawing.Point(71, 59);
            this.DrivingWheel2ActVel.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel2ActVel.Name = "DrivingWheel2ActVel";
            this.DrivingWheel2ActVel.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel2ActVel.TabIndex = 4;
            // 
            // DrivingWheel2Enable
            // 
            this.DrivingWheel2Enable.Location = new System.Drawing.Point(71, 25);
            this.DrivingWheel2Enable.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel2Enable.Name = "DrivingWheel2Enable";
            this.DrivingWheel2Enable.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel2Enable.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "位置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "速度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "使能";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DrivingWheel1ActCur);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.DrivingWheel1ActPos);
            this.groupBox3.Controls.Add(this.DrivingWheel1ActVel);
            this.groupBox3.Controls.Add(this.DrivingWheel1Enable);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(31, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(133, 188);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "车轮1";
            // 
            // DrivingWheel1ActCur
            // 
            this.DrivingWheel1ActCur.Location = new System.Drawing.Point(71, 126);
            this.DrivingWheel1ActCur.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel1ActCur.Name = "DrivingWheel1ActCur";
            this.DrivingWheel1ActCur.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel1ActCur.TabIndex = 7;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 130);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 15);
            this.label27.TabIndex = 6;
            this.label27.Text = "电流";
            // 
            // DrivingWheel1ActPos
            // 
            this.DrivingWheel1ActPos.Location = new System.Drawing.Point(71, 92);
            this.DrivingWheel1ActPos.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel1ActPos.Name = "DrivingWheel1ActPos";
            this.DrivingWheel1ActPos.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel1ActPos.TabIndex = 5;
            // 
            // DrivingWheel1ActVel
            // 
            this.DrivingWheel1ActVel.Location = new System.Drawing.Point(71, 59);
            this.DrivingWheel1ActVel.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel1ActVel.Name = "DrivingWheel1ActVel";
            this.DrivingWheel1ActVel.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel1ActVel.TabIndex = 4;
            // 
            // DrivingWheel1Enable
            // 
            this.DrivingWheel1Enable.Location = new System.Drawing.Point(71, 25);
            this.DrivingWheel1Enable.Margin = new System.Windows.Forms.Padding(4);
            this.DrivingWheel1Enable.Name = "DrivingWheel1Enable";
            this.DrivingWheel1Enable.Size = new System.Drawing.Size(51, 25);
            this.DrivingWheel1Enable.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "位置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "速度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "使能";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button22);
            this.tabPage3.Controls.Add(this.button21);
            this.tabPage3.Controls.Add(this.button20);
            this.tabPage3.Controls.Add(this.button19);
            this.tabPage3.Controls.Add(this.label71);
            this.tabPage3.Controls.Add(this.label70);
            this.tabPage3.Controls.Add(this.label69);
            this.tabPage3.Controls.Add(this.ArmMoveZ);
            this.tabPage3.Controls.Add(this.ArmMoveY);
            this.tabPage3.Controls.Add(this.ArmMoveX);
            this.tabPage3.Controls.Add(this.label68);
            this.tabPage3.Controls.Add(this.label67);
            this.tabPage3.Controls.Add(this.label66);
            this.tabPage3.Controls.Add(this.ArmPosZ);
            this.tabPage3.Controls.Add(this.ArmPosY);
            this.tabPage3.Controls.Add(this.ArmPosX);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1636, 637);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(0, 0);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(100, 29);
            this.button22.TabIndex = 0;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(0, 0);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(100, 29);
            this.button21.TabIndex = 1;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(0, 0);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 29);
            this.button20.TabIndex = 2;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(0, 0);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(100, 29);
            this.button19.TabIndex = 3;
            // 
            // label71
            // 
            this.label71.Location = new System.Drawing.Point(0, 0);
            this.label71.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(133, 29);
            this.label71.TabIndex = 4;
            // 
            // label70
            // 
            this.label70.Location = new System.Drawing.Point(0, 0);
            this.label70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(133, 29);
            this.label70.TabIndex = 5;
            // 
            // label69
            // 
            this.label69.Location = new System.Drawing.Point(0, 0);
            this.label69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(133, 29);
            this.label69.TabIndex = 6;
            // 
            // ArmMoveZ
            // 
            this.ArmMoveZ.Location = new System.Drawing.Point(0, 0);
            this.ArmMoveZ.Margin = new System.Windows.Forms.Padding(4);
            this.ArmMoveZ.Name = "ArmMoveZ";
            this.ArmMoveZ.Size = new System.Drawing.Size(132, 25);
            this.ArmMoveZ.TabIndex = 7;
            // 
            // ArmMoveY
            // 
            this.ArmMoveY.Location = new System.Drawing.Point(0, 0);
            this.ArmMoveY.Margin = new System.Windows.Forms.Padding(4);
            this.ArmMoveY.Name = "ArmMoveY";
            this.ArmMoveY.Size = new System.Drawing.Size(132, 25);
            this.ArmMoveY.TabIndex = 8;
            // 
            // ArmMoveX
            // 
            this.ArmMoveX.Location = new System.Drawing.Point(0, 0);
            this.ArmMoveX.Margin = new System.Windows.Forms.Padding(4);
            this.ArmMoveX.Name = "ArmMoveX";
            this.ArmMoveX.Size = new System.Drawing.Size(132, 25);
            this.ArmMoveX.TabIndex = 9;
            // 
            // label68
            // 
            this.label68.Location = new System.Drawing.Point(0, 0);
            this.label68.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(133, 29);
            this.label68.TabIndex = 10;
            // 
            // label67
            // 
            this.label67.Location = new System.Drawing.Point(0, 0);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(133, 29);
            this.label67.TabIndex = 11;
            // 
            // label66
            // 
            this.label66.Location = new System.Drawing.Point(0, 0);
            this.label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(133, 29);
            this.label66.TabIndex = 12;
            // 
            // ArmPosZ
            // 
            this.ArmPosZ.Location = new System.Drawing.Point(0, 0);
            this.ArmPosZ.Margin = new System.Windows.Forms.Padding(4);
            this.ArmPosZ.Name = "ArmPosZ";
            this.ArmPosZ.Size = new System.Drawing.Size(132, 25);
            this.ArmPosZ.TabIndex = 13;
            // 
            // ArmPosY
            // 
            this.ArmPosY.Location = new System.Drawing.Point(0, 0);
            this.ArmPosY.Margin = new System.Windows.Forms.Padding(4);
            this.ArmPosY.Name = "ArmPosY";
            this.ArmPosY.Size = new System.Drawing.Size(132, 25);
            this.ArmPosY.TabIndex = 14;
            // 
            // ArmPosX
            // 
            this.ArmPosX.Location = new System.Drawing.Point(0, 0);
            this.ArmPosX.Margin = new System.Windows.Forms.Padding(4);
            this.ArmPosX.Name = "ArmPosX";
            this.ArmPosX.Size = new System.Drawing.Size(132, 25);
            this.ArmPosX.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 696);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TcAdsClient _tcClient;
        private AdsStream adsWriteStream;
        private AdsStream adsReadStream;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbNetID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DrivingWheel1ActPos;
        private System.Windows.Forms.TextBox DrivingWheel1ActVel;
        private System.Windows.Forms.TextBox DrivingWheel1Enable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox SwingArm4ActPos;
        private System.Windows.Forms.TextBox SwingArm4ActVel;
        private System.Windows.Forms.TextBox SwingArm4Enable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox SwingArm3ActPos;
        private System.Windows.Forms.TextBox SwingArm3ActVel;
        private System.Windows.Forms.TextBox SwingArm3Enable;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox SwingArm2ActPos;
        private System.Windows.Forms.TextBox SwingArm2ActVel;
        private System.Windows.Forms.TextBox SwingArm2Enable;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox SwingArm1ActPos;
        private System.Windows.Forms.TextBox SwingArm1ActVel;
        private System.Windows.Forms.TextBox SwingArm1Enable;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox DrivingWheel4ActPos;
        private System.Windows.Forms.TextBox DrivingWheel4ActVel;
        private System.Windows.Forms.TextBox DrivingWheel4Enable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox DrivingWheel3ActPos;
        private System.Windows.Forms.TextBox DrivingWheel3ActVel;
        private System.Windows.Forms.TextBox DrivingWheel3Enable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox DrivingWheel2ActPos;
        private System.Windows.Forms.TextBox DrivingWheel2ActVel;
        private System.Windows.Forms.TextBox DrivingWheel2Enable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox SwingArm4ActCur;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox SwingArm3ActCur;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox SwingArm2ActCur;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox SwingArm1ActCur;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox DrivingWheel4ActCur;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox DrivingWheel3ActCur;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox DrivingWheel2ActCur;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox DrivingWheel1ActCur;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox BigArmActCur;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox BigArmActPos;
        private System.Windows.Forms.TextBox BigArmActVel;
        private System.Windows.Forms.TextBox BigArmEnable;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox WaistActCur;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox WaistActPos;
        private System.Windows.Forms.TextBox WaistActVel;
        private System.Windows.Forms.TextBox WaistEnable;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox ArmPosX;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox ArmMoveZ;
        private System.Windows.Forms.TextBox ArmMoveY;
        private System.Windows.Forms.TextBox ArmMoveX;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox ArmPosZ;
        private System.Windows.Forms.TextBox ArmPosY;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox ClampActCur;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox ClampActPos;
        private System.Windows.Forms.TextBox ClampActVel;
        private System.Windows.Forms.TextBox ClampEnable;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox RotationActCur;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox RotationActPos;
        private System.Windows.Forms.TextBox RotationActVel;
        private System.Windows.Forms.TextBox RotationEnable;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox SmallArmActCur;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox SmallArmActPos;
        private System.Windows.Forms.TextBox SmallArmActVel;
        private System.Windows.Forms.TextBox SmallArmEnable;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox MiddleArmActCur;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox MiddleArmActPos;
        private System.Windows.Forms.TextBox MiddleArmActVel;
        private System.Windows.Forms.TextBox MiddleArmEnable;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox FlexActCur;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox FlexActPos;
        private System.Windows.Forms.TextBox FlexActVel;
        private System.Windows.Forms.TextBox FlexEnable;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Button btn_BackZero;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Halt;
        private System.Windows.Forms.Button btn_Enable;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label lab_ChosenAxis2;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tx_pos;
        private System.Windows.Forms.Button btn_MoveRelative;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tx_vel;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label lab_ChosenAxis1;
        private System.Windows.Forms.Button btn_MoveVelocity;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tx_SingleVel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Button btn_BackSwing;
        private System.Windows.Forms.Button btn_FrontSwing;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tx_DoubleSwingArmVel;
    }
}

