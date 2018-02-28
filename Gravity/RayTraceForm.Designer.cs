namespace Gravity
{
	partial class RayTraceForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private global::System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.startStopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxIterationsTxtBox = new System.Windows.Forms.TextBox();
            this.canvas1 = new System.Windows.Forms.PictureBox();
            this.picCanvas1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeIntervalTxtBox = new System.Windows.Forms.TextBox();
            this.FiringAngleTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FiringSpeedTxtBox = new System.Windows.Forms.TextBox();
            this.PayloadHeightDisplayTxtBox = new System.Windows.Forms.TextBox();
            this.PayloadXdisplayTxtBox = new System.Windows.Forms.TextBox();
            this.PayloadYdisplayTxtBox = new System.Windows.Forms.TextBox();
            this.EarthYdisplayTxtBox = new System.Windows.Forms.TextBox();
            this.EarthXdisplayTxtBox = new System.Windows.Forms.TextBox();
            this.EarthHeightDisplayTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StepBtn = new System.Windows.Forms.Button();
            this.PlayRadio = new System.Windows.Forms.RadioButton();
            this.StepRadio = new System.Windows.Forms.RadioButton();
            this.CurrentIterationTxtBox = new System.Windows.Forms.TextBox();
            this.currentIterationLabel = new System.Windows.Forms.Label();
            this.PayloadSpeedTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FiringHeightTxtBox = new System.Windows.Forms.TextBox();
            this.TPlusTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EarthSpeedTxtBox = new System.Windows.Forms.TextBox();
            this.MoonYdisplayTxtBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MoonXdisplayTxtBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MoonSpeedTxtBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MoonHeightDisplayTxtBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ScaleSlider = new System.Windows.Forms.TrackBar();
            this.ScaleTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(3, 9);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(75, 40);
            this.startStopBtn.TabIndex = 1;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(896, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Iterations";
            // 
            // MaxIterationsTxtBox
            // 
            this.MaxIterationsTxtBox.Location = new System.Drawing.Point(975, 3);
            this.MaxIterationsTxtBox.Name = "MaxIterationsTxtBox";
            this.MaxIterationsTxtBox.Size = new System.Drawing.Size(102, 20);
            this.MaxIterationsTxtBox.TabIndex = 3;
            this.MaxIterationsTxtBox.Text = "100000000";
            // 
            // canvas1
            // 
            this.canvas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas1.BackColor = System.Drawing.Color.White;
            this.canvas1.Location = new System.Drawing.Point(3, 159);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(1089, 520);
            this.canvas1.TabIndex = 4;
            this.canvas1.TabStop = false;
            this.canvas1.Resize += new System.EventHandler(this.canvas1_Resize);
            // 
            // picCanvas1
            // 
            this.picCanvas1.Location = new System.Drawing.Point(751, 577);
            this.picCanvas1.Name = "picCanvas1";
            this.picCanvas1.Size = new System.Drawing.Size(100, 50);
            this.picCanvas1.TabIndex = 5;
            this.picCanvas1.TabStop = false;
            this.picCanvas1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time Interval";
            // 
            // TimeIntervalTxtBox
            // 
            this.TimeIntervalTxtBox.Location = new System.Drawing.Point(775, 3);
            this.TimeIntervalTxtBox.Name = "TimeIntervalTxtBox";
            this.TimeIntervalTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TimeIntervalTxtBox.TabIndex = 8;
            this.TimeIntervalTxtBox.Text = "1";
            // 
            // FiringAngleTxtBox
            // 
            this.FiringAngleTxtBox.Location = new System.Drawing.Point(775, 29);
            this.FiringAngleTxtBox.MinimumSize = new System.Drawing.Size(50, 4);
            this.FiringAngleTxtBox.Name = "FiringAngleTxtBox";
            this.FiringAngleTxtBox.Size = new System.Drawing.Size(100, 20);
            this.FiringAngleTxtBox.TabIndex = 12;
            this.FiringAngleTxtBox.Text = "90";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Firing Angle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Firing Speed";
            // 
            // FiringSpeedTxtBox
            // 
            this.FiringSpeedTxtBox.Location = new System.Drawing.Point(775, 55);
            this.FiringSpeedTxtBox.MinimumSize = new System.Drawing.Size(50, 4);
            this.FiringSpeedTxtBox.Name = "FiringSpeedTxtBox";
            this.FiringSpeedTxtBox.Size = new System.Drawing.Size(100, 20);
            this.FiringSpeedTxtBox.TabIndex = 14;
            this.FiringSpeedTxtBox.Text = "7660";
            // 
            // PayloadHeightDisplayTxtBox
            // 
            this.PayloadHeightDisplayTxtBox.Enabled = false;
            this.PayloadHeightDisplayTxtBox.Location = new System.Drawing.Point(45, 98);
            this.PayloadHeightDisplayTxtBox.Name = "PayloadHeightDisplayTxtBox";
            this.PayloadHeightDisplayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PayloadHeightDisplayTxtBox.TabIndex = 16;
            // 
            // PayloadXdisplayTxtBox
            // 
            this.PayloadXdisplayTxtBox.Enabled = false;
            this.PayloadXdisplayTxtBox.Location = new System.Drawing.Point(45, 22);
            this.PayloadXdisplayTxtBox.Name = "PayloadXdisplayTxtBox";
            this.PayloadXdisplayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PayloadXdisplayTxtBox.TabIndex = 18;
            // 
            // PayloadYdisplayTxtBox
            // 
            this.PayloadYdisplayTxtBox.Enabled = false;
            this.PayloadYdisplayTxtBox.Location = new System.Drawing.Point(45, 48);
            this.PayloadYdisplayTxtBox.Name = "PayloadYdisplayTxtBox";
            this.PayloadYdisplayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PayloadYdisplayTxtBox.TabIndex = 20;
            // 
            // EarthYdisplayTxtBox
            // 
            this.EarthYdisplayTxtBox.Enabled = false;
            this.EarthYdisplayTxtBox.Location = new System.Drawing.Point(45, 47);
            this.EarthYdisplayTxtBox.Name = "EarthYdisplayTxtBox";
            this.EarthYdisplayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EarthYdisplayTxtBox.TabIndex = 26;
            // 
            // EarthXdisplayTxtBox
            // 
            this.EarthXdisplayTxtBox.Enabled = false;
            this.EarthXdisplayTxtBox.Location = new System.Drawing.Point(45, 21);
            this.EarthXdisplayTxtBox.Name = "EarthXdisplayTxtBox";
            this.EarthXdisplayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EarthXdisplayTxtBox.TabIndex = 24;
            // 
            // EarthHeightDisplayTxtBox
            // 
            this.EarthHeightDisplayTxtBox.Enabled = false;
            this.EarthHeightDisplayTxtBox.Location = new System.Drawing.Point(45, 97);
            this.EarthHeightDisplayTxtBox.Name = "EarthHeightDisplayTxtBox";
            this.EarthHeightDisplayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EarthHeightDisplayTxtBox.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StepBtn);
            this.groupBox1.Controls.Add(this.PlayRadio);
            this.groupBox1.Controls.Add(this.StepRadio);
            this.groupBox1.Location = new System.Drawing.Point(3, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 87);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // StepBtn
            // 
            this.StepBtn.Location = new System.Drawing.Point(0, 12);
            this.StepBtn.Name = "StepBtn";
            this.StepBtn.Size = new System.Drawing.Size(75, 33);
            this.StepBtn.TabIndex = 2;
            this.StepBtn.Text = "Step";
            this.StepBtn.UseVisualStyleBackColor = true;
            this.StepBtn.Click += new System.EventHandler(this.StepBtn_Click);
            // 
            // PlayRadio
            // 
            this.PlayRadio.AutoSize = true;
            this.PlayRadio.Location = new System.Drawing.Point(59, 51);
            this.PlayRadio.Name = "PlayRadio";
            this.PlayRadio.Size = new System.Drawing.Size(45, 17);
            this.PlayRadio.TabIndex = 1;
            this.PlayRadio.Text = "Play";
            this.PlayRadio.UseVisualStyleBackColor = true;
            // 
            // StepRadio
            // 
            this.StepRadio.AutoSize = true;
            this.StepRadio.Checked = true;
            this.StepRadio.Location = new System.Drawing.Point(6, 51);
            this.StepRadio.Name = "StepRadio";
            this.StepRadio.Size = new System.Drawing.Size(47, 17);
            this.StepRadio.TabIndex = 0;
            this.StepRadio.TabStop = true;
            this.StepRadio.Text = "Step";
            this.StepRadio.UseVisualStyleBackColor = true;
            this.StepRadio.CheckedChanged += new System.EventHandler(this.StepRadio_CheckedChanged);
            // 
            // CurrentIterationTxtBox
            // 
            this.CurrentIterationTxtBox.Enabled = false;
            this.CurrentIterationTxtBox.Location = new System.Drawing.Point(975, 35);
            this.CurrentIterationTxtBox.Name = "CurrentIterationTxtBox";
            this.CurrentIterationTxtBox.Size = new System.Drawing.Size(102, 20);
            this.CurrentIterationTxtBox.TabIndex = 30;
            // 
            // currentIterationLabel
            // 
            this.currentIterationLabel.AutoSize = true;
            this.currentIterationLabel.Location = new System.Drawing.Point(896, 38);
            this.currentIterationLabel.Name = "currentIterationLabel";
            this.currentIterationLabel.Size = new System.Drawing.Size(82, 13);
            this.currentIterationLabel.TabIndex = 29;
            this.currentIterationLabel.Text = "Current Iteration";
            // 
            // PayloadSpeedTxtBox
            // 
            this.PayloadSpeedTxtBox.Enabled = false;
            this.PayloadSpeedTxtBox.Location = new System.Drawing.Point(45, 74);
            this.PayloadSpeedTxtBox.Name = "PayloadSpeedTxtBox";
            this.PayloadSpeedTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PayloadSpeedTxtBox.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(701, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Firing Height";
            // 
            // FiringHeightTxtBox
            // 
            this.FiringHeightTxtBox.Location = new System.Drawing.Point(775, 81);
            this.FiringHeightTxtBox.MinimumSize = new System.Drawing.Size(50, 4);
            this.FiringHeightTxtBox.Name = "FiringHeightTxtBox";
            this.FiringHeightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.FiringHeightTxtBox.TabIndex = 33;
            this.FiringHeightTxtBox.Text = "408000";
            // 
            // TPlusTxtBox
            // 
            this.TPlusTxtBox.Enabled = false;
            this.TPlusTxtBox.Location = new System.Drawing.Point(975, 66);
            this.TPlusTxtBox.Name = "TPlusTxtBox";
            this.TPlusTxtBox.Size = new System.Drawing.Size(102, 20);
            this.TPlusTxtBox.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(933, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "T-plus";
            // 
            // EarthSpeedTxtBox
            // 
            this.EarthSpeedTxtBox.Enabled = false;
            this.EarthSpeedTxtBox.Location = new System.Drawing.Point(45, 73);
            this.EarthSpeedTxtBox.Name = "EarthSpeedTxtBox";
            this.EarthSpeedTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EarthSpeedTxtBox.TabIndex = 38;
            // 
            // MoonYdisplayTxtBox
            // 
            this.MoonYdisplayTxtBox.Enabled = false;
            this.MoonYdisplayTxtBox.Location = new System.Drawing.Point(45, 45);
            this.MoonYdisplayTxtBox.Name = "MoonYdisplayTxtBox";
            this.MoonYdisplayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MoonYdisplayTxtBox.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "y";
            // 
            // MoonXdisplayTxtBox
            // 
            this.MoonXdisplayTxtBox.Enabled = false;
            this.MoonXdisplayTxtBox.Location = new System.Drawing.Point(45, 19);
            this.MoonXdisplayTxtBox.Name = "MoonXdisplayTxtBox";
            this.MoonXdisplayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MoonXdisplayTxtBox.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "x";
            // 
            // MoonSpeedTxtBox
            // 
            this.MoonSpeedTxtBox.Enabled = false;
            this.MoonSpeedTxtBox.Location = new System.Drawing.Point(45, 71);
            this.MoonSpeedTxtBox.Name = "MoonSpeedTxtBox";
            this.MoonSpeedTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MoonSpeedTxtBox.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "speed";
            // 
            // MoonHeightDisplayTxtBox
            // 
            this.MoonHeightDisplayTxtBox.Enabled = false;
            this.MoonHeightDisplayTxtBox.Location = new System.Drawing.Point(45, 97);
            this.MoonHeightDisplayTxtBox.Name = "MoonHeightDisplayTxtBox";
            this.MoonHeightDisplayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MoonHeightDisplayTxtBox.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "height";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MoonXdisplayTxtBox);
            this.groupBox2.Controls.Add(this.MoonHeightDisplayTxtBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.MoonSpeedTxtBox);
            this.groupBox2.Controls.Add(this.MoonYdisplayTxtBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 138);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moon";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.EarthSpeedTxtBox);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.EarthYdisplayTxtBox);
            this.groupBox3.Controls.Add(this.EarthXdisplayTxtBox);
            this.groupBox3.Controls.Add(this.EarthHeightDisplayTxtBox);
            this.groupBox3.Location = new System.Drawing.Point(373, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 138);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Earth";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "x";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "height";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "y";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "speed";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.PayloadXdisplayTxtBox);
            this.groupBox4.Controls.Add(this.PayloadYdisplayTxtBox);
            this.groupBox4.Controls.Add(this.PayloadSpeedTxtBox);
            this.groupBox4.Controls.Add(this.PayloadHeightDisplayTxtBox);
            this.groupBox4.Location = new System.Drawing.Point(537, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 138);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payload";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "x";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "height";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(27, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 13);
            this.label23.TabIndex = 41;
            this.label23.Text = "y";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 13);
            this.label24.TabIndex = 43;
            this.label24.Text = "speed";
            // 
            // ScaleSlider
            // 
            this.ScaleSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleSlider.AutoSize = false;
            this.ScaleSlider.Location = new System.Drawing.Point(1098, 159);
            this.ScaleSlider.MaximumSize = new System.Drawing.Size(20, 0);
            this.ScaleSlider.MinimumSize = new System.Drawing.Size(20, 400);
            this.ScaleSlider.Name = "ScaleSlider";
            this.ScaleSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ScaleSlider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ScaleSlider.RightToLeftLayout = true;
            this.ScaleSlider.Size = new System.Drawing.Size(20, 520);
            this.ScaleSlider.TabIndex = 50;
            this.ScaleSlider.Scroll += new System.EventHandler(this.ScaleSlider_Scroll);
            // 
            // ScaleTxtBox
            // 
            this.ScaleTxtBox.Enabled = false;
            this.ScaleTxtBox.Location = new System.Drawing.Point(1018, 133);
            this.ScaleTxtBox.Name = "ScaleTxtBox";
            this.ScaleTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ScaleTxtBox.TabIndex = 51;
            this.ScaleTxtBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(948, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Scale factor";
            // 
            // RayTraceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 681);
            this.Controls.Add(this.ScaleTxtBox);
            this.Controls.Add(this.ScaleSlider);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TPlusTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FiringHeightTxtBox);
            this.Controls.Add(this.CurrentIterationTxtBox);
            this.Controls.Add(this.currentIterationLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FiringSpeedTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FiringAngleTxtBox);
            this.Controls.Add(this.TimeIntervalTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picCanvas1);
            this.Controls.Add(this.canvas1);
            this.Controls.Add(this.MaxIterationsTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startStopBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RayTraceForm";
            this.Text = "RayTraceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RayTraceForm_FormClosing);
            this.Load += new System.EventHandler(this.RayTraceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		
		private global::System.Windows.Forms.Button startStopBtn;
		private global::System.Windows.Forms.Label label1;
		private global::System.Windows.Forms.TextBox MaxIterationsTxtBox;
		private global::System.Windows.Forms.PictureBox canvas1;
		private global::System.Windows.Forms.PictureBox picCanvas1;
		private global::System.Windows.Forms.Label label2;
		private global::System.Windows.Forms.TextBox TimeIntervalTxtBox;
        private System.Windows.Forms.TextBox FiringAngleTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FiringSpeedTxtBox;
        private System.Windows.Forms.TextBox PayloadHeightDisplayTxtBox;
        private System.Windows.Forms.TextBox PayloadXdisplayTxtBox;
        private System.Windows.Forms.TextBox PayloadYdisplayTxtBox;
        private System.Windows.Forms.TextBox EarthYdisplayTxtBox;
        private System.Windows.Forms.TextBox EarthXdisplayTxtBox;
        private System.Windows.Forms.TextBox EarthHeightDisplayTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StepBtn;
        private System.Windows.Forms.RadioButton PlayRadio;
        private System.Windows.Forms.RadioButton StepRadio;
        private System.Windows.Forms.TextBox CurrentIterationTxtBox;
        private System.Windows.Forms.Label currentIterationLabel;
        private System.Windows.Forms.TextBox PayloadSpeedTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FiringHeightTxtBox;
        private System.Windows.Forms.TextBox TPlusTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EarthSpeedTxtBox;
        private System.Windows.Forms.TextBox MoonYdisplayTxtBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MoonXdisplayTxtBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MoonSpeedTxtBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MoonHeightDisplayTxtBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TrackBar ScaleSlider;
        private System.Windows.Forms.TextBox ScaleTxtBox;
        private System.Windows.Forms.Label label3;
    }
}