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
            this.button6 = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbNetID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tx_waist = new System.Windows.Forms.TextBox();
            this.btnAutoOFF = new System.Windows.Forms.Button();
            this.btnAutoOn = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.tx_roll = new System.Windows.Forms.TextBox();
            this.tx_smallarm = new System.Windows.Forms.TextBox();
            this.tx_middlearm = new System.Windows.Forms.TextBox();
            this.tx_bigarm = new System.Windows.Forms.TextBox();
            this.tx_handz = new System.Windows.Forms.TextBox();
            this.tx_handy = new System.Windows.Forms.TextBox();
            this.tx_handx = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
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
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.WaistActCur = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.WaistActPos = new System.Windows.Forms.TextBox();
            this.WaistActVel = new System.Windows.Forms.TextBox();
            this.WaistEnable = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.BigArmActCur = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.BigArmActPos = new System.Windows.Forms.TextBox();
            this.BigArmActVel = new System.Windows.Forms.TextBox();
            this.BigArmEnable = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.button18 = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.ArmVel = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.TbPosition = new System.Windows.Forms.TextBox();
            this.TbVelocity = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.TbAngle = new System.Windows.Forms.TextBox();
            this.Tbw = new System.Windows.Forms.TextBox();
            this.TbVelz = new System.Windows.Forms.TextBox();
            this.TbVely = new System.Windows.Forms.TextBox();
            this.TbVelx = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.GripVel = new System.Windows.Forms.TextBox();
            this.SpinVel = new System.Windows.Forms.TextBox();
            this.SmallArmVel = new System.Windows.Forms.TextBox();
            this.GripMove = new System.Windows.Forms.Button();
            this.SpinMove = new System.Windows.Forms.Button();
            this.SmallArmMove = new System.Windows.Forms.Button();
            this.MidArmVel = new System.Windows.Forms.TextBox();
            this.MidArmMove = new System.Windows.Forms.Button();
            this.BigArmVel = new System.Windows.Forms.TextBox();
            this.BigArmMove = new System.Windows.Forms.Button();
            this.WaistVel = new System.Windows.Forms.TextBox();
            this.WaistMove = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1133, 660);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.btConnect);
            this.tabPage1.Controls.Add(this.btRun);
            this.tabPage1.Controls.Add(this.lbOutput);
            this.tabPage1.Controls.Add(this.tbPort);
            this.tabPage1.Controls.Add(this.tbNetID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1125, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(100, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 40);
            this.button6.TabIndex = 14;
            this.button6.Text = "测试";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.Color.Transparent;
            this.btConnect.Location = new System.Drawing.Point(100, 91);
            this.btConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(92, 40);
            this.btConnect.TabIndex = 13;
            this.btConnect.Text = "连接";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(100, 134);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(92, 40);
            this.btRun.TabIndex = 12;
            this.btRun.Text = "运行";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 12;
            this.lbOutput.Location = new System.Drawing.Point(307, 6);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(693, 556);
            this.lbOutput.TabIndex = 11;
            this.lbOutput.SelectedIndexChanged += new System.EventHandler(this.lbOutput_SelectedIndexChanged);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(136, 61);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(109, 21);
            this.tbPort.TabIndex = 9;
            this.tbPort.Text = "0xbf02";
            this.tbPort.TextChanged += new System.EventHandler(this.tbPort_TextChanged);
            // 
            // tbNetID
            // 
            this.tbNetID.Location = new System.Drawing.Point(136, 34);
            this.tbNetID.Name = "tbNetID";
            this.tbNetID.Size = new System.Drawing.Size(109, 21);
            this.tbNetID.TabIndex = 8;
            this.tbNetID.Text = "192.168.1.200.1.1";
            this.tbNetID.TextChanged += new System.EventHandler(this.tbNetID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "NetID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label76);
            this.tabPage2.Controls.Add(this.label71);
            this.tabPage2.Controls.Add(this.label70);
            this.tabPage2.Controls.Add(this.label69);
            this.tabPage2.Controls.Add(this.label79);
            this.tabPage2.Controls.Add(this.label78);
            this.tabPage2.Controls.Add(this.label77);
            this.tabPage2.Controls.Add(this.label68);
            this.tabPage2.Controls.Add(this.tx_waist);
            this.tabPage2.Controls.Add(this.btnAutoOFF);
            this.tabPage2.Controls.Add(this.btnAutoOn);
            this.tabPage2.Controls.Add(this.button37);
            this.tabPage2.Controls.Add(this.button36);
            this.tabPage2.Controls.Add(this.button35);
            this.tabPage2.Controls.Add(this.button34);
            this.tabPage2.Controls.Add(this.button33);
            this.tabPage2.Controls.Add(this.button32);
            this.tabPage2.Controls.Add(this.button31);
            this.tabPage2.Controls.Add(this.button30);
            this.tabPage2.Controls.Add(this.button29);
            this.tabPage2.Controls.Add(this.button28);
            this.tabPage2.Controls.Add(this.tx_roll);
            this.tabPage2.Controls.Add(this.tx_smallarm);
            this.tabPage2.Controls.Add(this.tx_middlearm);
            this.tabPage2.Controls.Add(this.tx_bigarm);
            this.tabPage2.Controls.Add(this.tx_handz);
            this.tabPage2.Controls.Add(this.tx_handy);
            this.tabPage2.Controls.Add(this.tx_handx);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.radioButton15);
            this.tabPage2.Controls.Add(this.groupBox15);
            this.tabPage2.Controls.Add(this.groupBox14);
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.groupBox17);
            this.tabPage2.Controls.Add(this.radioButton14);
            this.tabPage2.Controls.Add(this.groupBox16);
            this.tabPage2.Controls.Add(this.radioButton13);
            this.tabPage2.Controls.Add(this.radioButton12);
            this.tabPage2.Controls.Add(this.groupBox13);
            this.tabPage2.Controls.Add(this.radioButton9);
            this.tabPage2.Controls.Add(this.radioButton10);
            this.tabPage2.Controls.Add(this.radioButton11);
            this.tabPage2.Controls.Add(this.button18);
            this.tabPage2.Controls.Add(this.label54);
            this.tabPage2.Controls.Add(this.ArmVel);
            this.tabPage2.Controls.Add(this.button17);
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.button15);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.label40);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.TbPosition);
            this.tabPage2.Controls.Add(this.TbVelocity);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.label66);
            this.tabPage2.Controls.Add(this.label67);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.TbAngle);
            this.tabPage2.Controls.Add(this.Tbw);
            this.tabPage2.Controls.Add(this.TbVelz);
            this.tabPage2.Controls.Add(this.TbVely);
            this.tabPage2.Controls.Add(this.TbVelx);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.radioButton8);
            this.tabPage2.Controls.Add(this.radioButton7);
            this.tabPage2.Controls.Add(this.radioButton6);
            this.tabPage2.Controls.Add(this.radioButton5);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1125, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tx_waist
            // 
            this.tx_waist.Location = new System.Drawing.Point(879, 325);
            this.tx_waist.Name = "tx_waist";
            this.tx_waist.Size = new System.Drawing.Size(76, 21);
            this.tx_waist.TabIndex = 88;
            // 
            // btnAutoOFF
            // 
            this.btnAutoOFF.Location = new System.Drawing.Point(130, 553);
            this.btnAutoOFF.Name = "btnAutoOFF";
            this.btnAutoOFF.Size = new System.Drawing.Size(75, 23);
            this.btnAutoOFF.TabIndex = 87;
            this.btnAutoOFF.Text = "展示关";
            this.btnAutoOFF.UseVisualStyleBackColor = true;
            this.btnAutoOFF.Click += new System.EventHandler(this.btnAutoOFF_Click);
            // 
            // btnAutoOn
            // 
            this.btnAutoOn.Location = new System.Drawing.Point(24, 553);
            this.btnAutoOn.Name = "btnAutoOn";
            this.btnAutoOn.Size = new System.Drawing.Size(75, 23);
            this.btnAutoOn.TabIndex = 86;
            this.btnAutoOn.Text = "展示开";
            this.btnAutoOn.UseVisualStyleBackColor = true;
            this.btnAutoOn.Click += new System.EventHandler(this.btnAutoOn_Click);
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(1021, 553);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(75, 23);
            this.button37.TabIndex = 85;
            this.button37.Text = "关灯";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(895, 553);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(75, 23);
            this.button36.TabIndex = 84;
            this.button36.Text = "开灯";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(733, 581);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(75, 23);
            this.button35.TabIndex = 83;
            this.button35.Text = "位置3";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(619, 581);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(75, 23);
            this.button34.TabIndex = 82;
            this.button34.Text = "位置4";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(733, 533);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(75, 23);
            this.button33.TabIndex = 81;
            this.button33.Text = "位置2";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(619, 533);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(75, 23);
            this.button32.TabIndex = 80;
            this.button32.Text = "位置1";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(441, 533);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(75, 23);
            this.button31.TabIndex = 79;
            this.button31.Text = "放置";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(264, 533);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 23);
            this.button30.TabIndex = 78;
            this.button30.Text = "抓取";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(880, 457);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(75, 23);
            this.button29.TabIndex = 77;
            this.button29.Text = "归位";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(778, 457);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(75, 23);
            this.button28.TabIndex = 76;
            this.button28.Text = "就绪";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // tx_roll
            // 
            this.tx_roll.Location = new System.Drawing.Point(879, 430);
            this.tx_roll.Margin = new System.Windows.Forms.Padding(2);
            this.tx_roll.Name = "tx_roll";
            this.tx_roll.Size = new System.Drawing.Size(76, 21);
            this.tx_roll.TabIndex = 75;
            // 
            // tx_smallarm
            // 
            this.tx_smallarm.Location = new System.Drawing.Point(880, 402);
            this.tx_smallarm.Margin = new System.Windows.Forms.Padding(2);
            this.tx_smallarm.Name = "tx_smallarm";
            this.tx_smallarm.Size = new System.Drawing.Size(76, 21);
            this.tx_smallarm.TabIndex = 75;
            // 
            // tx_middlearm
            // 
            this.tx_middlearm.Location = new System.Drawing.Point(880, 376);
            this.tx_middlearm.Margin = new System.Windows.Forms.Padding(2);
            this.tx_middlearm.Name = "tx_middlearm";
            this.tx_middlearm.Size = new System.Drawing.Size(76, 21);
            this.tx_middlearm.TabIndex = 74;
            // 
            // tx_bigarm
            // 
            this.tx_bigarm.Location = new System.Drawing.Point(880, 352);
            this.tx_bigarm.Margin = new System.Windows.Forms.Padding(2);
            this.tx_bigarm.Name = "tx_bigarm";
            this.tx_bigarm.Size = new System.Drawing.Size(76, 21);
            this.tx_bigarm.TabIndex = 73;
            // 
            // tx_handz
            // 
            this.tx_handz.Location = new System.Drawing.Point(800, 406);
            this.tx_handz.Margin = new System.Windows.Forms.Padding(2);
            this.tx_handz.Name = "tx_handz";
            this.tx_handz.Size = new System.Drawing.Size(76, 21);
            this.tx_handz.TabIndex = 72;
            // 
            // tx_handy
            // 
            this.tx_handy.Location = new System.Drawing.Point(800, 381);
            this.tx_handy.Margin = new System.Windows.Forms.Padding(2);
            this.tx_handy.Name = "tx_handy";
            this.tx_handy.Size = new System.Drawing.Size(76, 21);
            this.tx_handy.TabIndex = 72;
            // 
            // tx_handx
            // 
            this.tx_handx.Location = new System.Drawing.Point(800, 356);
            this.tx_handx.Margin = new System.Windows.Forms.Padding(2);
            this.tx_handx.Name = "tx_handx";
            this.tx_handx.Size = new System.Drawing.Size(76, 21);
            this.tx_handx.TabIndex = 71;
            this.tx_handx.TextChanged += new System.EventHandler(this.tx_handx_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 70;
            this.button2.Text = "一键归位";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(923, 305);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(47, 16);
            this.radioButton15.TabIndex = 69;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "夹紧";
            this.radioButton15.UseVisualStyleBackColor = true;
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
            this.groupBox15.Location = new System.Drawing.Point(659, 353);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(100, 150);
            this.groupBox15.TabIndex = 68;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "张合";
            // 
            // ClampActCur
            // 
            this.ClampActCur.Location = new System.Drawing.Point(53, 101);
            this.ClampActCur.Name = "ClampActCur";
            this.ClampActCur.Size = new System.Drawing.Size(39, 21);
            this.ClampActCur.TabIndex = 9;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(6, 104);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(29, 12);
            this.label58.TabIndex = 8;
            this.label58.Text = "电流";
            // 
            // ClampActPos
            // 
            this.ClampActPos.Location = new System.Drawing.Point(53, 74);
            this.ClampActPos.Name = "ClampActPos";
            this.ClampActPos.Size = new System.Drawing.Size(39, 21);
            this.ClampActPos.TabIndex = 5;
            // 
            // ClampActVel
            // 
            this.ClampActVel.Location = new System.Drawing.Point(53, 47);
            this.ClampActVel.Name = "ClampActVel";
            this.ClampActVel.Size = new System.Drawing.Size(39, 21);
            this.ClampActVel.TabIndex = 4;
            // 
            // ClampEnable
            // 
            this.ClampEnable.Location = new System.Drawing.Point(53, 20);
            this.ClampEnable.Name = "ClampEnable";
            this.ClampEnable.Size = new System.Drawing.Size(39, 21);
            this.ClampEnable.TabIndex = 3;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(6, 77);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(29, 12);
            this.label59.TabIndex = 2;
            this.label59.Text = "位置";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(6, 50);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(29, 12);
            this.label60.TabIndex = 1;
            this.label60.Text = "速度";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(6, 23);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(29, 12);
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
            this.groupBox14.Location = new System.Drawing.Point(553, 353);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(100, 150);
            this.groupBox14.TabIndex = 67;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "旋转";
            // 
            // RotationActCur
            // 
            this.RotationActCur.Location = new System.Drawing.Point(53, 101);
            this.RotationActCur.Name = "RotationActCur";
            this.RotationActCur.Size = new System.Drawing.Size(39, 21);
            this.RotationActCur.TabIndex = 9;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(6, 104);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(29, 12);
            this.label53.TabIndex = 8;
            this.label53.Text = "电流";
            // 
            // RotationActPos
            // 
            this.RotationActPos.Location = new System.Drawing.Point(53, 74);
            this.RotationActPos.Name = "RotationActPos";
            this.RotationActPos.Size = new System.Drawing.Size(39, 21);
            this.RotationActPos.TabIndex = 5;
            // 
            // RotationActVel
            // 
            this.RotationActVel.Location = new System.Drawing.Point(53, 47);
            this.RotationActVel.Name = "RotationActVel";
            this.RotationActVel.Size = new System.Drawing.Size(39, 21);
            this.RotationActVel.TabIndex = 4;
            // 
            // RotationEnable
            // 
            this.RotationEnable.Location = new System.Drawing.Point(53, 20);
            this.RotationEnable.Name = "RotationEnable";
            this.RotationEnable.Size = new System.Drawing.Size(39, 21);
            this.RotationEnable.TabIndex = 3;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 77);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(29, 12);
            this.label55.TabIndex = 2;
            this.label55.Text = "位置";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(6, 50);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(29, 12);
            this.label56.TabIndex = 1;
            this.label56.Text = "速度";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(6, 23);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(29, 12);
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
            this.groupBox11.Location = new System.Drawing.Point(447, 352);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(100, 150);
            this.groupBox11.TabIndex = 66;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "小臂";
            // 
            // SmallArmActCur
            // 
            this.SmallArmActCur.Location = new System.Drawing.Point(53, 101);
            this.SmallArmActCur.Name = "SmallArmActCur";
            this.SmallArmActCur.Size = new System.Drawing.Size(39, 21);
            this.SmallArmActCur.TabIndex = 9;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 104);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(29, 12);
            this.label41.TabIndex = 8;
            this.label41.Text = "电流";
            // 
            // SmallArmActPos
            // 
            this.SmallArmActPos.Location = new System.Drawing.Point(53, 74);
            this.SmallArmActPos.Name = "SmallArmActPos";
            this.SmallArmActPos.Size = new System.Drawing.Size(39, 21);
            this.SmallArmActPos.TabIndex = 5;
            // 
            // SmallArmActVel
            // 
            this.SmallArmActVel.Location = new System.Drawing.Point(53, 47);
            this.SmallArmActVel.Name = "SmallArmActVel";
            this.SmallArmActVel.Size = new System.Drawing.Size(39, 21);
            this.SmallArmActVel.TabIndex = 4;
            // 
            // SmallArmEnable
            // 
            this.SmallArmEnable.Location = new System.Drawing.Point(53, 20);
            this.SmallArmEnable.Name = "SmallArmEnable";
            this.SmallArmEnable.Size = new System.Drawing.Size(39, 21);
            this.SmallArmEnable.TabIndex = 3;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 77);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(29, 12);
            this.label42.TabIndex = 2;
            this.label42.Text = "位置";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 50);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(29, 12);
            this.label43.TabIndex = 1;
            this.label43.Text = "速度";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 23);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(29, 12);
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
            this.groupBox12.Location = new System.Drawing.Point(341, 352);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(100, 150);
            this.groupBox12.TabIndex = 65;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "中臂";
            // 
            // MiddleArmActCur
            // 
            this.MiddleArmActCur.Location = new System.Drawing.Point(53, 101);
            this.MiddleArmActCur.Name = "MiddleArmActCur";
            this.MiddleArmActCur.Size = new System.Drawing.Size(39, 21);
            this.MiddleArmActCur.TabIndex = 9;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 104);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(29, 12);
            this.label45.TabIndex = 8;
            this.label45.Text = "电流";
            // 
            // MiddleArmActPos
            // 
            this.MiddleArmActPos.Location = new System.Drawing.Point(53, 74);
            this.MiddleArmActPos.Name = "MiddleArmActPos";
            this.MiddleArmActPos.Size = new System.Drawing.Size(39, 21);
            this.MiddleArmActPos.TabIndex = 5;
            // 
            // MiddleArmActVel
            // 
            this.MiddleArmActVel.Location = new System.Drawing.Point(53, 47);
            this.MiddleArmActVel.Name = "MiddleArmActVel";
            this.MiddleArmActVel.Size = new System.Drawing.Size(39, 21);
            this.MiddleArmActVel.TabIndex = 4;
            // 
            // MiddleArmEnable
            // 
            this.MiddleArmEnable.Location = new System.Drawing.Point(53, 20);
            this.MiddleArmEnable.Name = "MiddleArmEnable";
            this.MiddleArmEnable.Size = new System.Drawing.Size(39, 21);
            this.MiddleArmEnable.TabIndex = 3;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 77);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(29, 12);
            this.label46.TabIndex = 2;
            this.label46.Text = "位置";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 50);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(29, 12);
            this.label47.TabIndex = 1;
            this.label47.Text = "速度";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 23);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(29, 12);
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
            this.groupBox17.Location = new System.Drawing.Point(236, 352);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(100, 150);
            this.groupBox17.TabIndex = 64;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "伸缩";
            // 
            // FlexActCur
            // 
            this.FlexActCur.Location = new System.Drawing.Point(53, 101);
            this.FlexActCur.Name = "FlexActCur";
            this.FlexActCur.Size = new System.Drawing.Size(39, 21);
            this.FlexActCur.TabIndex = 9;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(6, 104);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(29, 12);
            this.label72.TabIndex = 8;
            this.label72.Text = "电流";
            // 
            // FlexActPos
            // 
            this.FlexActPos.Location = new System.Drawing.Point(53, 74);
            this.FlexActPos.Name = "FlexActPos";
            this.FlexActPos.Size = new System.Drawing.Size(39, 21);
            this.FlexActPos.TabIndex = 5;
            // 
            // FlexActVel
            // 
            this.FlexActVel.Location = new System.Drawing.Point(53, 47);
            this.FlexActVel.Name = "FlexActVel";
            this.FlexActVel.Size = new System.Drawing.Size(39, 21);
            this.FlexActVel.TabIndex = 4;
            // 
            // FlexEnable
            // 
            this.FlexEnable.Location = new System.Drawing.Point(53, 20);
            this.FlexEnable.Name = "FlexEnable";
            this.FlexEnable.Size = new System.Drawing.Size(39, 21);
            this.FlexEnable.TabIndex = 3;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(6, 77);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(29, 12);
            this.label73.TabIndex = 2;
            this.label73.Text = "位置";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(6, 50);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(29, 12);
            this.label74.TabIndex = 1;
            this.label74.Text = "速度";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(6, 23);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(29, 12);
            this.label75.TabIndex = 0;
            this.label75.Text = "使能";
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(923, 283);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(47, 16);
            this.radioButton14.TabIndex = 63;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "旋转";
            this.radioButton14.UseVisualStyleBackColor = true;
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
            this.groupBox16.Location = new System.Drawing.Point(24, 352);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(100, 150);
            this.groupBox16.TabIndex = 62;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "腰";
            // 
            // WaistActCur
            // 
            this.WaistActCur.Location = new System.Drawing.Point(53, 101);
            this.WaistActCur.Name = "WaistActCur";
            this.WaistActCur.Size = new System.Drawing.Size(39, 21);
            this.WaistActCur.TabIndex = 9;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 104);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(29, 12);
            this.label62.TabIndex = 8;
            this.label62.Text = "电流";
            // 
            // WaistActPos
            // 
            this.WaistActPos.Location = new System.Drawing.Point(53, 74);
            this.WaistActPos.Name = "WaistActPos";
            this.WaistActPos.Size = new System.Drawing.Size(39, 21);
            this.WaistActPos.TabIndex = 5;
            // 
            // WaistActVel
            // 
            this.WaistActVel.Location = new System.Drawing.Point(53, 47);
            this.WaistActVel.Name = "WaistActVel";
            this.WaistActVel.Size = new System.Drawing.Size(39, 21);
            this.WaistActVel.TabIndex = 4;
            // 
            // WaistEnable
            // 
            this.WaistEnable.Location = new System.Drawing.Point(53, 20);
            this.WaistEnable.Name = "WaistEnable";
            this.WaistEnable.Size = new System.Drawing.Size(39, 21);
            this.WaistEnable.TabIndex = 3;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(6, 77);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(29, 12);
            this.label63.TabIndex = 2;
            this.label63.Text = "位置";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 50);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(29, 12);
            this.label64.TabIndex = 1;
            this.label64.Text = "速度";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 23);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(29, 12);
            this.label65.TabIndex = 0;
            this.label65.Text = "使能";
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(923, 261);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(47, 16);
            this.radioButton13.TabIndex = 59;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "小臂";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(923, 239);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(47, 16);
            this.radioButton12.TabIndex = 58;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "中臂";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
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
            this.groupBox13.Location = new System.Drawing.Point(130, 352);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(100, 150);
            this.groupBox13.TabIndex = 55;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "大臂";
            // 
            // BigArmActCur
            // 
            this.BigArmActCur.Location = new System.Drawing.Point(53, 101);
            this.BigArmActCur.Name = "BigArmActCur";
            this.BigArmActCur.Size = new System.Drawing.Size(39, 21);
            this.BigArmActCur.TabIndex = 7;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 104);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(29, 12);
            this.label49.TabIndex = 6;
            this.label49.Text = "电流";
            // 
            // BigArmActPos
            // 
            this.BigArmActPos.Location = new System.Drawing.Point(53, 74);
            this.BigArmActPos.Name = "BigArmActPos";
            this.BigArmActPos.Size = new System.Drawing.Size(39, 21);
            this.BigArmActPos.TabIndex = 5;
            // 
            // BigArmActVel
            // 
            this.BigArmActVel.Location = new System.Drawing.Point(53, 47);
            this.BigArmActVel.Name = "BigArmActVel";
            this.BigArmActVel.Size = new System.Drawing.Size(39, 21);
            this.BigArmActVel.TabIndex = 4;
            // 
            // BigArmEnable
            // 
            this.BigArmEnable.Location = new System.Drawing.Point(53, 20);
            this.BigArmEnable.Name = "BigArmEnable";
            this.BigArmEnable.Size = new System.Drawing.Size(39, 21);
            this.BigArmEnable.TabIndex = 3;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 77);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(29, 12);
            this.label50.TabIndex = 2;
            this.label50.Text = "位置";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 50);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(29, 12);
            this.label51.TabIndex = 1;
            this.label51.Text = "速度";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 23);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(29, 12);
            this.label52.TabIndex = 0;
            this.label52.Text = "使能";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(923, 173);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(35, 16);
            this.radioButton9.TabIndex = 49;
            this.radioButton9.Text = "腰";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(923, 195);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(47, 16);
            this.radioButton10.TabIndex = 48;
            this.radioButton10.Text = "大臂";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(923, 217);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(47, 16);
            this.radioButton11.TabIndex = 47;
            this.radioButton11.Text = "伸缩";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(883, 133);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 46;
            this.button18.Text = "匀速运动";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click_1);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(858, 98);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 12);
            this.label54.TabIndex = 45;
            this.label54.Text = "速度：";
            // 
            // ArmVel
            // 
            this.ArmVel.Location = new System.Drawing.Point(904, 94);
            this.ArmVel.Name = "ArmVel";
            this.ArmVel.Size = new System.Drawing.Size(53, 21);
            this.ArmVel.TabIndex = 44;
            this.ArmVel.TextChanged += new System.EventHandler(this.ArmVel_TextChanged);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(904, 56);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 43;
            this.button17.Text = "寻参";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(823, 56);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 42;
            this.button16.Text = "复位";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click_1);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(904, 27);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 41;
            this.button15.Text = "暂停";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(823, 27);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 40;
            this.button14.Text = "上使能";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(731, 141);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(41, 12);
            this.label40.TabIndex = 34;
            this.label40.Text = "位置：";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(731, 113);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(41, 12);
            this.label39.TabIndex = 33;
            this.label39.Text = "速度：";
            // 
            // TbPosition
            // 
            this.TbPosition.Location = new System.Drawing.Point(778, 138);
            this.TbPosition.Name = "TbPosition";
            this.TbPosition.Size = new System.Drawing.Size(53, 21);
            this.TbPosition.TabIndex = 32;
            // 
            // TbVelocity
            // 
            this.TbVelocity.Location = new System.Drawing.Point(778, 110);
            this.TbVelocity.Name = "TbVelocity";
            this.TbVelocity.Size = new System.Drawing.Size(53, 21);
            this.TbVelocity.TabIndex = 31;
            this.TbVelocity.TextChanged += new System.EventHandler(this.TbVelocity_TextChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(648, 328);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 12);
            this.label38.TabIndex = 30;
            this.label38.Text = "角度:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(648, 302);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(47, 12);
            this.label37.TabIndex = 29;
            this.label37.Text = "角速度:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(704, 206);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(41, 12);
            this.label66.TabIndex = 28;
            this.label66.Text = "X速度:";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(704, 263);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(41, 12);
            this.label67.TabIndex = 28;
            this.label67.Text = "Z速度:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(704, 233);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 12);
            this.label36.TabIndex = 28;
            this.label36.Text = "Y速度:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(706, 2);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(41, 12);
            this.label35.TabIndex = 27;
            this.label35.Text = "X速度:";
            this.label35.Click += new System.EventHandler(this.label35_Click);
            // 
            // TbAngle
            // 
            this.TbAngle.Location = new System.Drawing.Point(700, 325);
            this.TbAngle.Name = "TbAngle";
            this.TbAngle.Size = new System.Drawing.Size(61, 21);
            this.TbAngle.TabIndex = 26;
            // 
            // Tbw
            // 
            this.Tbw.Location = new System.Drawing.Point(700, 299);
            this.Tbw.Name = "Tbw";
            this.Tbw.Size = new System.Drawing.Size(61, 21);
            this.Tbw.TabIndex = 25;
            // 
            // TbVelz
            // 
            this.TbVelz.Location = new System.Drawing.Point(758, 257);
            this.TbVelz.Name = "TbVelz";
            this.TbVelz.Size = new System.Drawing.Size(61, 21);
            this.TbVelz.TabIndex = 24;
            // 
            // TbVely
            // 
            this.TbVely.Location = new System.Drawing.Point(758, 230);
            this.TbVely.Name = "TbVely";
            this.TbVely.Size = new System.Drawing.Size(61, 21);
            this.TbVely.TabIndex = 24;
            // 
            // TbVelx
            // 
            this.TbVelx.Location = new System.Drawing.Point(758, 203);
            this.TbVelx.Name = "TbVelx";
            this.TbVelx.Size = new System.Drawing.Size(60, 21);
            this.TbVelx.TabIndex = 23;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(778, 302);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 22;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(823, 229);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 21;
            this.button10.Text = "手臂运动";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button10_MouseDown);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button10_MouseUp);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(603, 234);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 20;
            this.button12.Text = "一键站立";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(522, 234);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 19;
            this.button11.Text = "单轴相对";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(603, 209);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "单轴匀速";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(522, 209);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "单轴点动";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(716, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "开灯";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(716, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "复位";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(635, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "急停";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(554, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "暂停";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "车上使能";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(655, 177);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(53, 16);
            this.radioButton8.TabIndex = 9;
            this.radioButton8.Text = "摆臂4";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(655, 155);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(53, 16);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.Text = "摆臂3";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(655, 133);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(53, 16);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.Text = "摆臂2";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(655, 111);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(53, 16);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.Text = "摆臂1";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(563, 177);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 16);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "驱动轮4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(563, 155);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 16);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "驱动轮3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(563, 133);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 16);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "驱动轮2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(563, 111);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 16);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "驱动轮1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Location = new System.Drawing.Point(264, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            this.groupBox7.Location = new System.Drawing.Point(132, 182);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(100, 150);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "摆4";
            // 
            // SwingArm4ActCur
            // 
            this.SwingArm4ActCur.Location = new System.Drawing.Point(53, 101);
            this.SwingArm4ActCur.Name = "SwingArm4ActCur";
            this.SwingArm4ActCur.Size = new System.Drawing.Size(39, 21);
            this.SwingArm4ActCur.TabIndex = 13;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 104);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(29, 12);
            this.label34.TabIndex = 12;
            this.label34.Text = "电流";
            // 
            // SwingArm4ActPos
            // 
            this.SwingArm4ActPos.Location = new System.Drawing.Point(53, 74);
            this.SwingArm4ActPos.Name = "SwingArm4ActPos";
            this.SwingArm4ActPos.Size = new System.Drawing.Size(39, 21);
            this.SwingArm4ActPos.TabIndex = 5;
            // 
            // SwingArm4ActVel
            // 
            this.SwingArm4ActVel.Location = new System.Drawing.Point(53, 47);
            this.SwingArm4ActVel.Name = "SwingArm4ActVel";
            this.SwingArm4ActVel.Size = new System.Drawing.Size(39, 21);
            this.SwingArm4ActVel.TabIndex = 4;
            // 
            // SwingArm4Enable
            // 
            this.SwingArm4Enable.Location = new System.Drawing.Point(53, 20);
            this.SwingArm4Enable.Name = "SwingArm4Enable";
            this.SwingArm4Enable.Size = new System.Drawing.Size(39, 21);
            this.SwingArm4Enable.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "位置";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "速度";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
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
            this.groupBox8.Location = new System.Drawing.Point(23, 182);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(100, 150);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "摆3";
            // 
            // SwingArm3ActCur
            // 
            this.SwingArm3ActCur.Location = new System.Drawing.Point(53, 101);
            this.SwingArm3ActCur.Name = "SwingArm3ActCur";
            this.SwingArm3ActCur.Size = new System.Drawing.Size(39, 21);
            this.SwingArm3ActCur.TabIndex = 11;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 104);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(29, 12);
            this.label33.TabIndex = 10;
            this.label33.Text = "电流";
            // 
            // SwingArm3ActPos
            // 
            this.SwingArm3ActPos.Location = new System.Drawing.Point(53, 74);
            this.SwingArm3ActPos.Name = "SwingArm3ActPos";
            this.SwingArm3ActPos.Size = new System.Drawing.Size(39, 21);
            this.SwingArm3ActPos.TabIndex = 5;
            // 
            // SwingArm3ActVel
            // 
            this.SwingArm3ActVel.Location = new System.Drawing.Point(53, 47);
            this.SwingArm3ActVel.Name = "SwingArm3ActVel";
            this.SwingArm3ActVel.Size = new System.Drawing.Size(39, 21);
            this.SwingArm3ActVel.TabIndex = 4;
            // 
            // SwingArm3Enable
            // 
            this.SwingArm3Enable.Location = new System.Drawing.Point(53, 20);
            this.SwingArm3Enable.Name = "SwingArm3Enable";
            this.SwingArm3Enable.Size = new System.Drawing.Size(39, 21);
            this.SwingArm3Enable.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "位置";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "速度";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
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
            this.groupBox9.Location = new System.Drawing.Point(132, 21);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(100, 150);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "摆2";
            // 
            // SwingArm2ActCur
            // 
            this.SwingArm2ActCur.Location = new System.Drawing.Point(53, 101);
            this.SwingArm2ActCur.Name = "SwingArm2ActCur";
            this.SwingArm2ActCur.Size = new System.Drawing.Size(39, 21);
            this.SwingArm2ActCur.TabIndex = 9;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 104);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 12);
            this.label30.TabIndex = 8;
            this.label30.Text = "电流";
            // 
            // SwingArm2ActPos
            // 
            this.SwingArm2ActPos.Location = new System.Drawing.Point(53, 74);
            this.SwingArm2ActPos.Name = "SwingArm2ActPos";
            this.SwingArm2ActPos.Size = new System.Drawing.Size(39, 21);
            this.SwingArm2ActPos.TabIndex = 5;
            // 
            // SwingArm2ActVel
            // 
            this.SwingArm2ActVel.Location = new System.Drawing.Point(53, 47);
            this.SwingArm2ActVel.Name = "SwingArm2ActVel";
            this.SwingArm2ActVel.Size = new System.Drawing.Size(39, 21);
            this.SwingArm2ActVel.TabIndex = 4;
            // 
            // SwingArm2Enable
            // 
            this.SwingArm2Enable.Location = new System.Drawing.Point(53, 20);
            this.SwingArm2Enable.Name = "SwingArm2Enable";
            this.SwingArm2Enable.Size = new System.Drawing.Size(39, 21);
            this.SwingArm2Enable.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "位置";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 1;
            this.label22.Text = "速度";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
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
            this.groupBox10.Location = new System.Drawing.Point(23, 21);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(100, 150);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "摆1";
            // 
            // SwingArm1ActCur
            // 
            this.SwingArm1ActCur.Location = new System.Drawing.Point(53, 101);
            this.SwingArm1ActCur.Name = "SwingArm1ActCur";
            this.SwingArm1ActCur.Size = new System.Drawing.Size(39, 21);
            this.SwingArm1ActCur.TabIndex = 9;
            // 
            // SwingArm1ActPos
            // 
            this.SwingArm1ActPos.Location = new System.Drawing.Point(53, 74);
            this.SwingArm1ActPos.Name = "SwingArm1ActPos";
            this.SwingArm1ActPos.Size = new System.Drawing.Size(39, 21);
            this.SwingArm1ActPos.TabIndex = 5;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 104);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 8;
            this.label29.Text = "电流";
            // 
            // SwingArm1ActVel
            // 
            this.SwingArm1ActVel.Location = new System.Drawing.Point(53, 47);
            this.SwingArm1ActVel.Name = "SwingArm1ActVel";
            this.SwingArm1ActVel.Size = new System.Drawing.Size(39, 21);
            this.SwingArm1ActVel.TabIndex = 4;
            // 
            // SwingArm1Enable
            // 
            this.SwingArm1Enable.Location = new System.Drawing.Point(53, 20);
            this.SwingArm1Enable.Name = "SwingArm1Enable";
            this.SwingArm1Enable.Size = new System.Drawing.Size(39, 21);
            this.SwingArm1Enable.TabIndex = 3;
            this.SwingArm1Enable.TextChanged += new System.EventHandler(this.SwingArm1Enable_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 77);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "位置";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 1;
            this.label25.Text = "速度";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 0;
            this.label26.Text = "使能";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.groupBox6.Location = new System.Drawing.Point(132, 182);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(100, 150);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "车轮4";
            // 
            // DrivingWheel4ActCur
            // 
            this.DrivingWheel4ActCur.Location = new System.Drawing.Point(53, 101);
            this.DrivingWheel4ActCur.Name = "DrivingWheel4ActCur";
            this.DrivingWheel4ActCur.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel4ActCur.TabIndex = 9;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 104);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 12);
            this.label32.TabIndex = 8;
            this.label32.Text = "电流";
            // 
            // DrivingWheel4ActPos
            // 
            this.DrivingWheel4ActPos.Location = new System.Drawing.Point(53, 74);
            this.DrivingWheel4ActPos.Name = "DrivingWheel4ActPos";
            this.DrivingWheel4ActPos.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel4ActPos.TabIndex = 5;
            // 
            // DrivingWheel4ActVel
            // 
            this.DrivingWheel4ActVel.Location = new System.Drawing.Point(53, 47);
            this.DrivingWheel4ActVel.Name = "DrivingWheel4ActVel";
            this.DrivingWheel4ActVel.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel4ActVel.TabIndex = 4;
            // 
            // DrivingWheel4Enable
            // 
            this.DrivingWheel4Enable.Location = new System.Drawing.Point(53, 20);
            this.DrivingWheel4Enable.Name = "DrivingWheel4Enable";
            this.DrivingWheel4Enable.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel4Enable.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "位置";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "速度";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
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
            this.groupBox5.Location = new System.Drawing.Point(23, 182);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(100, 150);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "车轮3";
            // 
            // DrivingWheel3ActCur
            // 
            this.DrivingWheel3ActCur.Location = new System.Drawing.Point(53, 101);
            this.DrivingWheel3ActCur.Name = "DrivingWheel3ActCur";
            this.DrivingWheel3ActCur.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel3ActCur.TabIndex = 9;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 104);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 12);
            this.label31.TabIndex = 8;
            this.label31.Text = "电流";
            // 
            // DrivingWheel3ActPos
            // 
            this.DrivingWheel3ActPos.Location = new System.Drawing.Point(53, 74);
            this.DrivingWheel3ActPos.Name = "DrivingWheel3ActPos";
            this.DrivingWheel3ActPos.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel3ActPos.TabIndex = 5;
            // 
            // DrivingWheel3ActVel
            // 
            this.DrivingWheel3ActVel.Location = new System.Drawing.Point(53, 47);
            this.DrivingWheel3ActVel.Name = "DrivingWheel3ActVel";
            this.DrivingWheel3ActVel.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel3ActVel.TabIndex = 4;
            // 
            // DrivingWheel3Enable
            // 
            this.DrivingWheel3Enable.Location = new System.Drawing.Point(53, 20);
            this.DrivingWheel3Enable.Name = "DrivingWheel3Enable";
            this.DrivingWheel3Enable.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel3Enable.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "位置";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "速度";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
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
            this.groupBox4.Location = new System.Drawing.Point(132, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 150);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "车轮2";
            // 
            // DrivingWheel2ActCur
            // 
            this.DrivingWheel2ActCur.Location = new System.Drawing.Point(53, 101);
            this.DrivingWheel2ActCur.Name = "DrivingWheel2ActCur";
            this.DrivingWheel2ActCur.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel2ActCur.TabIndex = 9;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 104);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 8;
            this.label28.Text = "电流";
            // 
            // DrivingWheel2ActPos
            // 
            this.DrivingWheel2ActPos.Location = new System.Drawing.Point(53, 74);
            this.DrivingWheel2ActPos.Name = "DrivingWheel2ActPos";
            this.DrivingWheel2ActPos.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel2ActPos.TabIndex = 5;
            // 
            // DrivingWheel2ActVel
            // 
            this.DrivingWheel2ActVel.Location = new System.Drawing.Point(53, 47);
            this.DrivingWheel2ActVel.Name = "DrivingWheel2ActVel";
            this.DrivingWheel2ActVel.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel2ActVel.TabIndex = 4;
            // 
            // DrivingWheel2Enable
            // 
            this.DrivingWheel2Enable.Location = new System.Drawing.Point(53, 20);
            this.DrivingWheel2Enable.Name = "DrivingWheel2Enable";
            this.DrivingWheel2Enable.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel2Enable.TabIndex = 3;
            this.DrivingWheel2Enable.TextChanged += new System.EventHandler(this.DrivingWheel2Enable_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "位置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "速度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
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
            this.groupBox3.Location = new System.Drawing.Point(23, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 150);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "车轮1";
            // 
            // DrivingWheel1ActCur
            // 
            this.DrivingWheel1ActCur.Location = new System.Drawing.Point(53, 101);
            this.DrivingWheel1ActCur.Name = "DrivingWheel1ActCur";
            this.DrivingWheel1ActCur.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel1ActCur.TabIndex = 7;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 104);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 6;
            this.label27.Text = "电流";
            // 
            // DrivingWheel1ActPos
            // 
            this.DrivingWheel1ActPos.Location = new System.Drawing.Point(53, 74);
            this.DrivingWheel1ActPos.Name = "DrivingWheel1ActPos";
            this.DrivingWheel1ActPos.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel1ActPos.TabIndex = 5;
            this.DrivingWheel1ActPos.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // DrivingWheel1ActVel
            // 
            this.DrivingWheel1ActVel.Location = new System.Drawing.Point(53, 47);
            this.DrivingWheel1ActVel.Name = "DrivingWheel1ActVel";
            this.DrivingWheel1ActVel.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel1ActVel.TabIndex = 4;
            this.DrivingWheel1ActVel.TextChanged += new System.EventHandler(this.DrivingWheel1ActVel_TextChanged);
            // 
            // DrivingWheel1Enable
            // 
            this.DrivingWheel1Enable.Location = new System.Drawing.Point(53, 20);
            this.DrivingWheel1Enable.Name = "DrivingWheel1Enable";
            this.DrivingWheel1Enable.Size = new System.Drawing.Size(39, 21);
            this.DrivingWheel1Enable.TabIndex = 3;
            this.DrivingWheel1Enable.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "位置";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "速度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "使能";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GripVel);
            this.tabPage3.Controls.Add(this.SpinVel);
            this.tabPage3.Controls.Add(this.SmallArmVel);
            this.tabPage3.Controls.Add(this.GripMove);
            this.tabPage3.Controls.Add(this.SpinMove);
            this.tabPage3.Controls.Add(this.SmallArmMove);
            this.tabPage3.Controls.Add(this.MidArmVel);
            this.tabPage3.Controls.Add(this.MidArmMove);
            this.tabPage3.Controls.Add(this.BigArmVel);
            this.tabPage3.Controls.Add(this.BigArmMove);
            this.tabPage3.Controls.Add(this.WaistVel);
            this.tabPage3.Controls.Add(this.WaistMove);
            this.tabPage3.Controls.Add(this.button27);
            this.tabPage3.Controls.Add(this.button26);
            this.tabPage3.Controls.Add(this.button24);
            this.tabPage3.Controls.Add(this.button25);
            this.tabPage3.Controls.Add(this.button23);
            this.tabPage3.Controls.Add(this.button22);
            this.tabPage3.Controls.Add(this.button21);
            this.tabPage3.Controls.Add(this.button20);
            this.tabPage3.Controls.Add(this.button19);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1125, 634);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // GripVel
            // 
            this.GripVel.Location = new System.Drawing.Point(634, 203);
            this.GripVel.Name = "GripVel";
            this.GripVel.Size = new System.Drawing.Size(51, 21);
            this.GripVel.TabIndex = 49;
            // 
            // SpinVel
            // 
            this.SpinVel.Location = new System.Drawing.Point(634, 174);
            this.SpinVel.Name = "SpinVel";
            this.SpinVel.Size = new System.Drawing.Size(51, 21);
            this.SpinVel.TabIndex = 49;
            // 
            // SmallArmVel
            // 
            this.SmallArmVel.Location = new System.Drawing.Point(634, 145);
            this.SmallArmVel.Name = "SmallArmVel";
            this.SmallArmVel.Size = new System.Drawing.Size(51, 21);
            this.SmallArmVel.TabIndex = 49;
            // 
            // GripMove
            // 
            this.GripMove.Location = new System.Drawing.Point(691, 201);
            this.GripMove.Name = "GripMove";
            this.GripMove.Size = new System.Drawing.Size(75, 23);
            this.GripMove.TabIndex = 48;
            this.GripMove.Text = "夹紧";
            this.GripMove.UseVisualStyleBackColor = true;
            this.GripMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GripMove_MouseDown);
            this.GripMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GripMove_MouseUp);
            // 
            // SpinMove
            // 
            this.SpinMove.Location = new System.Drawing.Point(691, 172);
            this.SpinMove.Name = "SpinMove";
            this.SpinMove.Size = new System.Drawing.Size(75, 23);
            this.SpinMove.TabIndex = 48;
            this.SpinMove.Text = "旋转";
            this.SpinMove.UseVisualStyleBackColor = true;
            this.SpinMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpinMove_MouseDown);
            this.SpinMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SpinMove_MouseUp);
            // 
            // SmallArmMove
            // 
            this.SmallArmMove.Location = new System.Drawing.Point(691, 143);
            this.SmallArmMove.Name = "SmallArmMove";
            this.SmallArmMove.Size = new System.Drawing.Size(75, 23);
            this.SmallArmMove.TabIndex = 48;
            this.SmallArmMove.Text = "小臂";
            this.SmallArmMove.UseVisualStyleBackColor = true;
            this.SmallArmMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SmallArmMove_MouseDown);
            this.SmallArmMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SmallArmMove_MouseUp);
            // 
            // MidArmVel
            // 
            this.MidArmVel.Location = new System.Drawing.Point(634, 118);
            this.MidArmVel.Name = "MidArmVel";
            this.MidArmVel.Size = new System.Drawing.Size(51, 21);
            this.MidArmVel.TabIndex = 49;
            // 
            // MidArmMove
            // 
            this.MidArmMove.Location = new System.Drawing.Point(691, 116);
            this.MidArmMove.Name = "MidArmMove";
            this.MidArmMove.Size = new System.Drawing.Size(75, 23);
            this.MidArmMove.TabIndex = 48;
            this.MidArmMove.Text = "中臂";
            this.MidArmMove.UseVisualStyleBackColor = true;
            this.MidArmMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MidArmMove_MouseDown);
            this.MidArmMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MidArmMove_MouseUp);
            // 
            // BigArmVel
            // 
            this.BigArmVel.Location = new System.Drawing.Point(634, 91);
            this.BigArmVel.Name = "BigArmVel";
            this.BigArmVel.Size = new System.Drawing.Size(51, 21);
            this.BigArmVel.TabIndex = 49;
            // 
            // BigArmMove
            // 
            this.BigArmMove.Location = new System.Drawing.Point(691, 89);
            this.BigArmMove.Name = "BigArmMove";
            this.BigArmMove.Size = new System.Drawing.Size(75, 23);
            this.BigArmMove.TabIndex = 48;
            this.BigArmMove.Text = "大臂";
            this.BigArmMove.UseVisualStyleBackColor = true;
            this.BigArmMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BigArmMove_MouseDown);
            this.BigArmMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BigArmMove_MouseUp);
            // 
            // WaistVel
            // 
            this.WaistVel.Location = new System.Drawing.Point(634, 64);
            this.WaistVel.Name = "WaistVel";
            this.WaistVel.Size = new System.Drawing.Size(51, 21);
            this.WaistVel.TabIndex = 49;
            // 
            // WaistMove
            // 
            this.WaistMove.Location = new System.Drawing.Point(691, 62);
            this.WaistMove.Name = "WaistMove";
            this.WaistMove.Size = new System.Drawing.Size(75, 23);
            this.WaistMove.TabIndex = 48;
            this.WaistMove.Text = "腰";
            this.WaistMove.UseVisualStyleBackColor = true;
            this.WaistMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WaistMove_MouseDown);
            this.WaistMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WaistMove_MouseUp);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(169, 165);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 23);
            this.button27.TabIndex = 47;
            this.button27.Text = "step5(1)";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(169, 106);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 23);
            this.button26.TabIndex = 46;
            this.button26.Text = "step2(1)";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(260, 77);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 45;
            this.button24.Text = "归位";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(260, 48);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 23);
            this.button25.TabIndex = 44;
            this.button25.Text = "暂停";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(88, 165);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 16;
            this.button23.Text = "step5";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(88, 48);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 15;
            this.button22.Text = "step1";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(88, 135);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 14;
            this.button21.Text = "step4";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(88, 106);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 13;
            this.button20.Text = "setp3";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(88, 77);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 12;
            this.button19.Text = "step2";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(961, 328);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(17, 12);
            this.label68.TabIndex = 89;
            this.label68.Text = "腰";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(962, 356);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(29, 12);
            this.label69.TabIndex = 89;
            this.label69.Text = "大臂";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(961, 379);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(29, 12);
            this.label70.TabIndex = 89;
            this.label70.Text = "中臂";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(961, 405);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(29, 12);
            this.label71.TabIndex = 89;
            this.label71.Text = "小臂";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(962, 433);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(29, 12);
            this.label76.TabIndex = 89;
            this.label76.Text = "旋转";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(760, 359);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(35, 12);
            this.label77.TabIndex = 89;
            this.label77.Text = "X位置";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(760, 384);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(35, 12);
            this.label78.TabIndex = 89;
            this.label78.Text = "Y位置";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(760, 409);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(35, 12);
            this.label79.TabIndex = 89;
            this.label79.Text = "Z位置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 599);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
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
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox TbAngle;
        private System.Windows.Forms.TextBox Tbw;
        private System.Windows.Forms.TextBox TbVely;
        private System.Windows.Forms.TextBox TbVelx;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox TbPosition;
        private System.Windows.Forms.TextBox TbVelocity;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox ArmVel;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox BigArmActCur;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox BigArmActPos;
        private System.Windows.Forms.TextBox BigArmActVel;
        private System.Windows.Forms.TextBox BigArmEnable;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox WaistActCur;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox WaistActPos;
        private System.Windows.Forms.TextBox WaistActVel;
        private System.Windows.Forms.TextBox WaistEnable;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.Button button19;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tx_handy;
        private System.Windows.Forms.TextBox tx_handx;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.TextBox tx_smallarm;
        private System.Windows.Forms.TextBox tx_middlearm;
        private System.Windows.Forms.TextBox tx_bigarm;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button btnAutoOFF;
        private System.Windows.Forms.Button btnAutoOn;
        private System.Windows.Forms.TextBox SmallArmVel;
        private System.Windows.Forms.Button SmallArmMove;
        private System.Windows.Forms.TextBox MidArmVel;
        private System.Windows.Forms.Button MidArmMove;
        private System.Windows.Forms.TextBox BigArmVel;
        private System.Windows.Forms.Button BigArmMove;
        private System.Windows.Forms.TextBox WaistVel;
        private System.Windows.Forms.Button WaistMove;
        private System.Windows.Forms.TextBox GripVel;
        private System.Windows.Forms.TextBox SpinVel;
        private System.Windows.Forms.Button GripMove;
        private System.Windows.Forms.Button SpinMove;
        private System.Windows.Forms.TextBox tx_waist;
        private System.Windows.Forms.TextBox tx_handz;
        private System.Windows.Forms.TextBox tx_roll;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox TbVelz;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label68;
    }
}

