namespace Simulator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.runBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registerFLAGS = new Simulator.Controls.Flags.FlagsRegister();
            this.registerIP = new Simulator.Controls.Register();
            this.registerDI = new Simulator.Controls.Register();
            this.registerSI = new Simulator.Controls.Register();
            this.registerES = new Simulator.Controls.Register();
            this.registerDX = new Simulator.Controls.Register();
            this.registerBP = new Simulator.Controls.Register();
            this.registerSS = new Simulator.Controls.Register();
            this.registerCX = new Simulator.Controls.Register();
            this.registerSP = new Simulator.Controls.Register();
            this.registerDS = new Simulator.Controls.Register();
            this.registerBX = new Simulator.Controls.Register();
            this.registerCS = new Simulator.Controls.Register();
            this.registerAX = new Simulator.Controls.Register();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.memorySegmentDisplay1 = new Simulator.Controls.MemorySegmentDisplay();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stackDisplay = new Simulator.Controls.StackDisplay();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initialiseIVTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeroAllMemoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeroRegistersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.codeDisplay1 = new Simulator.Controls.CodeDisplay();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(434, 538);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(75, 23);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registerFLAGS);
            this.groupBox1.Controls.Add(this.registerIP);
            this.groupBox1.Controls.Add(this.registerDI);
            this.groupBox1.Controls.Add(this.registerSI);
            this.groupBox1.Controls.Add(this.registerES);
            this.groupBox1.Controls.Add(this.registerDX);
            this.groupBox1.Controls.Add(this.registerBP);
            this.groupBox1.Controls.Add(this.registerSS);
            this.groupBox1.Controls.Add(this.registerCX);
            this.groupBox1.Controls.Add(this.registerSP);
            this.groupBox1.Controls.Add(this.registerDS);
            this.groupBox1.Controls.Add(this.registerBX);
            this.groupBox1.Controls.Add(this.registerCS);
            this.groupBox1.Controls.Add(this.registerAX);
            this.groupBox1.Location = new System.Drawing.Point(235, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 319);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registers";
            // 
            // registerFLAGS
            // 
            this.registerFLAGS.Location = new System.Drawing.Point(60, 189);
            this.registerFLAGS.Margin = new System.Windows.Forms.Padding(4);
            this.registerFLAGS.Name = "registerFLAGS";
            this.registerFLAGS.Size = new System.Drawing.Size(100, 100);
            this.registerFLAGS.TabIndex = 1;
            this.registerFLAGS.Value = ((ushort)(0));
            // 
            // registerIP
            // 
            this.registerIP.Extended = false;
            this.registerIP.High = ((byte)(0));
            this.registerIP.Location = new System.Drawing.Point(85, 93);
            this.registerIP.Low = ((byte)(0));
            this.registerIP.Margin = new System.Windows.Forms.Padding(4);
            this.registerIP.Name = "registerIP";
            this.registerIP.Readonly = false;
            this.registerIP.RegisterName = "IP";
            this.registerIP.Size = new System.Drawing.Size(75, 14);
            this.registerIP.TabIndex = 0;
            this.registerIP.Value = ((ushort)(0));
            // 
            // registerDI
            // 
            this.registerDI.Extended = false;
            this.registerDI.High = ((byte)(0));
            this.registerDI.Location = new System.Drawing.Point(6, 143);
            this.registerDI.Low = ((byte)(0));
            this.registerDI.Margin = new System.Windows.Forms.Padding(4);
            this.registerDI.Name = "registerDI";
            this.registerDI.Readonly = false;
            this.registerDI.RegisterName = "DI";
            this.registerDI.Size = new System.Drawing.Size(75, 14);
            this.registerDI.TabIndex = 0;
            this.registerDI.Value = ((ushort)(0));
            // 
            // registerSI
            // 
            this.registerSI.Extended = false;
            this.registerSI.High = ((byte)(0));
            this.registerSI.Location = new System.Drawing.Point(6, 126);
            this.registerSI.Low = ((byte)(0));
            this.registerSI.Margin = new System.Windows.Forms.Padding(4);
            this.registerSI.Name = "registerSI";
            this.registerSI.Readonly = false;
            this.registerSI.RegisterName = "SI";
            this.registerSI.Size = new System.Drawing.Size(75, 14);
            this.registerSI.TabIndex = 0;
            this.registerSI.Value = ((ushort)(0));
            // 
            // registerES
            // 
            this.registerES.Extended = false;
            this.registerES.High = ((byte)(0));
            this.registerES.Location = new System.Drawing.Point(85, 69);
            this.registerES.Low = ((byte)(0));
            this.registerES.Margin = new System.Windows.Forms.Padding(4);
            this.registerES.Name = "registerES";
            this.registerES.Readonly = false;
            this.registerES.RegisterName = "ES";
            this.registerES.Size = new System.Drawing.Size(75, 14);
            this.registerES.TabIndex = 0;
            this.registerES.Value = ((ushort)(0));
            // 
            // registerDX
            // 
            this.registerDX.Extended = false;
            this.registerDX.High = ((byte)(0));
            this.registerDX.Location = new System.Drawing.Point(6, 69);
            this.registerDX.Low = ((byte)(0));
            this.registerDX.Margin = new System.Windows.Forms.Padding(4);
            this.registerDX.Name = "registerDX";
            this.registerDX.Readonly = false;
            this.registerDX.RegisterName = "DX";
            this.registerDX.Size = new System.Drawing.Size(75, 14);
            this.registerDX.TabIndex = 0;
            this.registerDX.Value = ((ushort)(0));
            // 
            // registerBP
            // 
            this.registerBP.Extended = false;
            this.registerBP.High = ((byte)(0));
            this.registerBP.Location = new System.Drawing.Point(6, 110);
            this.registerBP.Low = ((byte)(0));
            this.registerBP.Margin = new System.Windows.Forms.Padding(4);
            this.registerBP.Name = "registerBP";
            this.registerBP.Readonly = false;
            this.registerBP.RegisterName = "BP";
            this.registerBP.Size = new System.Drawing.Size(75, 14);
            this.registerBP.TabIndex = 0;
            this.registerBP.Value = ((ushort)(0));
            // 
            // registerSS
            // 
            this.registerSS.Extended = false;
            this.registerSS.High = ((byte)(0));
            this.registerSS.Location = new System.Drawing.Point(85, 52);
            this.registerSS.Low = ((byte)(0));
            this.registerSS.Margin = new System.Windows.Forms.Padding(4);
            this.registerSS.Name = "registerSS";
            this.registerSS.Readonly = false;
            this.registerSS.RegisterName = "SS";
            this.registerSS.Size = new System.Drawing.Size(75, 14);
            this.registerSS.TabIndex = 0;
            this.registerSS.Value = ((ushort)(0));
            // 
            // registerCX
            // 
            this.registerCX.Extended = false;
            this.registerCX.High = ((byte)(0));
            this.registerCX.Location = new System.Drawing.Point(6, 52);
            this.registerCX.Low = ((byte)(0));
            this.registerCX.Margin = new System.Windows.Forms.Padding(4);
            this.registerCX.Name = "registerCX";
            this.registerCX.Readonly = false;
            this.registerCX.RegisterName = "CX";
            this.registerCX.Size = new System.Drawing.Size(75, 14);
            this.registerCX.TabIndex = 0;
            this.registerCX.Value = ((ushort)(0));
            // 
            // registerSP
            // 
            this.registerSP.Extended = false;
            this.registerSP.High = ((byte)(0));
            this.registerSP.Location = new System.Drawing.Point(6, 93);
            this.registerSP.Low = ((byte)(0));
            this.registerSP.Margin = new System.Windows.Forms.Padding(4);
            this.registerSP.Name = "registerSP";
            this.registerSP.Readonly = false;
            this.registerSP.RegisterName = "SP";
            this.registerSP.Size = new System.Drawing.Size(75, 14);
            this.registerSP.TabIndex = 0;
            this.registerSP.Value = ((ushort)(0));
            // 
            // registerDS
            // 
            this.registerDS.Extended = false;
            this.registerDS.High = ((byte)(0));
            this.registerDS.Location = new System.Drawing.Point(85, 36);
            this.registerDS.Low = ((byte)(0));
            this.registerDS.Margin = new System.Windows.Forms.Padding(4);
            this.registerDS.Name = "registerDS";
            this.registerDS.Readonly = false;
            this.registerDS.RegisterName = "DS";
            this.registerDS.Size = new System.Drawing.Size(75, 14);
            this.registerDS.TabIndex = 0;
            this.registerDS.Value = ((ushort)(0));
            // 
            // registerBX
            // 
            this.registerBX.Extended = false;
            this.registerBX.High = ((byte)(0));
            this.registerBX.Location = new System.Drawing.Point(6, 36);
            this.registerBX.Low = ((byte)(0));
            this.registerBX.Margin = new System.Windows.Forms.Padding(4);
            this.registerBX.Name = "registerBX";
            this.registerBX.Readonly = false;
            this.registerBX.RegisterName = "BX";
            this.registerBX.Size = new System.Drawing.Size(75, 14);
            this.registerBX.TabIndex = 0;
            this.registerBX.Value = ((ushort)(0));
            // 
            // registerCS
            // 
            this.registerCS.Extended = false;
            this.registerCS.High = ((byte)(0));
            this.registerCS.Location = new System.Drawing.Point(85, 19);
            this.registerCS.Low = ((byte)(0));
            this.registerCS.Margin = new System.Windows.Forms.Padding(4);
            this.registerCS.Name = "registerCS";
            this.registerCS.Readonly = false;
            this.registerCS.RegisterName = "CS";
            this.registerCS.Size = new System.Drawing.Size(75, 14);
            this.registerCS.TabIndex = 0;
            this.registerCS.Value = ((ushort)(0));
            // 
            // registerAX
            // 
            this.registerAX.Extended = false;
            this.registerAX.High = ((byte)(0));
            this.registerAX.Location = new System.Drawing.Point(6, 19);
            this.registerAX.Low = ((byte)(0));
            this.registerAX.Margin = new System.Windows.Forms.Padding(4);
            this.registerAX.Name = "registerAX";
            this.registerAX.Readonly = false;
            this.registerAX.RegisterName = "AX";
            this.registerAX.Size = new System.Drawing.Size(75, 14);
            this.registerAX.TabIndex = 0;
            this.registerAX.Value = ((ushort)(0));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.memorySegmentDisplay1);
            this.groupBox2.Location = new System.Drawing.Point(12, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memory";
            // 
            // memorySegmentDisplay1
            // 
            this.memorySegmentDisplay1.AutoScroll = true;
            this.memorySegmentDisplay1.BackColor = System.Drawing.Color.White;
            this.memorySegmentDisplay1.BytesPerLine = 12;
            this.memorySegmentDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memorySegmentDisplay1.HeaderBackground = System.Drawing.Color.LightBlue;
            this.memorySegmentDisplay1.HeaderForeground = System.Drawing.Color.Black;
            this.memorySegmentDisplay1.Location = new System.Drawing.Point(3, 16);
            this.memorySegmentDisplay1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memorySegmentDisplay1.Name = "memorySegmentDisplay1";
            this.memorySegmentDisplay1.OffsetsBackground = System.Drawing.Color.LightGray;
            this.memorySegmentDisplay1.OffsetsForeground = System.Drawing.Color.Black;
            this.memorySegmentDisplay1.SelectedOffset = ((ushort)(0));
            this.memorySegmentDisplay1.Size = new System.Drawing.Size(384, 127);
            this.memorySegmentDisplay1.TabIndex = 0;
            this.memorySegmentDisplay1.ValuesBackground = System.Drawing.Color.White;
            this.memorySegmentDisplay1.ValueSelected = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.memorySegmentDisplay1.ValuesForeground = System.Drawing.Color.SteelBlue;
            this.memorySegmentDisplay1.Load += new System.EventHandler(this.memorySegmentDisplay1_Load);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stackDisplay);
            this.groupBox3.Location = new System.Drawing.Point(417, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 471);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stack";
            // 
            // stackDisplay
            // 
            this.stackDisplay.AutoScroll = true;
            this.stackDisplay.BackColor = System.Drawing.Color.White;
            this.stackDisplay.BytesPerLine = 2;
            this.stackDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackDisplay.HeaderBackground = System.Drawing.Color.LightBlue;
            this.stackDisplay.HeaderForeground = System.Drawing.Color.Black;
            this.stackDisplay.Location = new System.Drawing.Point(3, 16);
            this.stackDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.stackDisplay.Name = "stackDisplay";
            this.stackDisplay.OffsetsBackground = System.Drawing.Color.LightGray;
            this.stackDisplay.OffsetsForeground = System.Drawing.Color.Black;
            this.stackDisplay.SelectedOffset = ((ushort)(0));
            this.stackDisplay.Size = new System.Drawing.Size(136, 452);
            this.stackDisplay.TabIndex = 4;
            this.stackDisplay.ValuesBackground = System.Drawing.Color.White;
            this.stackDisplay.ValueSelected = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stackDisplay.ValuesForeground = System.Drawing.Color.SteelBlue;
            this.stackDisplay.Load += new System.EventHandler(this.stackDisplay_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 541);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.stepToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "&Debug";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.runToolStripMenuItem.Text = "&Run";
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.stepToolStripMenuItem.Text = "&Step";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.restartToolStripMenuItem.Text = "Res&tart";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initialiseIVTToolStripMenuItem,
            this.zeroAllMemoryToolStripMenuItem,
            this.zeroRegistersToolStripMenuItem,
            this.dumpToFileToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "D&ata";
            // 
            // initialiseIVTToolStripMenuItem
            // 
            this.initialiseIVTToolStripMenuItem.Name = "initialiseIVTToolStripMenuItem";
            this.initialiseIVTToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.initialiseIVTToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.initialiseIVTToolStripMenuItem.Text = "&Initialise IVT";
            // 
            // zeroAllMemoryToolStripMenuItem
            // 
            this.zeroAllMemoryToolStripMenuItem.Name = "zeroAllMemoryToolStripMenuItem";
            this.zeroAllMemoryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.zeroAllMemoryToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.zeroAllMemoryToolStripMenuItem.Text = "&Zero all memory";
            // 
            // zeroRegistersToolStripMenuItem
            // 
            this.zeroRegistersToolStripMenuItem.Name = "zeroRegistersToolStripMenuItem";
            this.zeroRegistersToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.zeroRegistersToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.zeroRegistersToolStripMenuItem.Text = "Z&ero registers";
            // 
            // dumpToFileToolStripMenuItem
            // 
            this.dumpToFileToolStripMenuItem.Name = "dumpToFileToolStripMenuItem";
            this.dumpToFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dumpToFileToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dumpToFileToolStripMenuItem.Text = "&Dump to file";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.codeDisplay1);
            this.groupBox4.Location = new System.Drawing.Point(11, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 319);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Code";
            // 
            // codeDisplay1
            // 
            this.codeDisplay1.AutoScroll = true;
            this.codeDisplay1.BackColor = System.Drawing.Color.White;
            this.codeDisplay1.BytesPerLine = 2;
            this.codeDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeDisplay1.HeaderBackground = System.Drawing.Color.LightBlue;
            this.codeDisplay1.HeaderForeground = System.Drawing.Color.Black;
            this.codeDisplay1.Location = new System.Drawing.Point(3, 16);
            this.codeDisplay1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeDisplay1.Name = "codeDisplay1";
            this.codeDisplay1.OffsetsBackground = System.Drawing.Color.LightGray;
            this.codeDisplay1.OffsetsForeground = System.Drawing.Color.Black;
            this.codeDisplay1.SelectedOffset = ((ushort)(0));
            this.codeDisplay1.Size = new System.Drawing.Size(212, 300);
            this.codeDisplay1.TabIndex = 0;
            this.codeDisplay1.ValuesBackground = System.Drawing.Color.White;
            this.codeDisplay1.ValueSelected = System.Drawing.Color.Red;
            this.codeDisplay1.ValuesForeground = System.Drawing.Color.BlueViolet;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 587);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Intel 8086 Simulator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.Register registerAX;
        private Controls.Register registerIP;
        private Controls.Register registerDI;
        private Controls.Register registerSI;
        private Controls.Register registerES;
        private Controls.Register registerDX;
        private Controls.Register registerBP;
        private Controls.Register registerSS;
        private Controls.Register registerCX;
        private Controls.Register registerSP;
        private Controls.Register registerDS;
        private Controls.Register registerBX;
        private Controls.Register registerCS;
        private Controls.Flags.FlagsRegister registerFLAGS;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.StackDisplay stackDisplay;
        private Controls.MemorySegmentDisplay memorySegmentDisplay1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initialiseIVTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeroAllMemoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeroRegistersToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem dumpToFileToolStripMenuItem;
        private Controls.CodeDisplay codeDisplay1;
    }
}

