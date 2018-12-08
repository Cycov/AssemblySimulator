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
            this.runBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stackDisplay = new Simulator.Controls.StackDisplay();
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
            this.memorySegmentDisplay1 = new Simulator.Controls.MemorySegmentDisplay();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(181, 415);
            this.runBtn.Margin = new System.Windows.Forms.Padding(4);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(100, 28);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(16, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(265, 393);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
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
            this.groupBox1.Location = new System.Drawing.Point(289, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(363, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.memorySegmentDisplay1);
            this.groupBox2.Location = new System.Drawing.Point(289, 228);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(363, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memory";
            // 
            // stackDisplay
            // 
            this.stackDisplay.Location = new System.Drawing.Point(661, 18);
            this.stackDisplay.Margin = new System.Windows.Forms.Padding(5);
            this.stackDisplay.Name = "stackDisplay";
            this.stackDisplay.Size = new System.Drawing.Size(167, 462);
            this.stackDisplay.TabIndex = 4;
            // 
            // registerFLAGS
            // 
            this.registerFLAGS.Location = new System.Drawing.Point(221, 23);
            this.registerFLAGS.Margin = new System.Windows.Forms.Padding(5);
            this.registerFLAGS.Name = "registerFLAGS";
            this.registerFLAGS.Size = new System.Drawing.Size(133, 123);
            this.registerFLAGS.TabIndex = 1;
            this.registerFLAGS.Value = ((ushort)(0));
            // 
            // registerIP
            // 
            this.registerIP.Extended = false;
            this.registerIP.High = ((byte)(0));
            this.registerIP.Location = new System.Drawing.Point(113, 114);
            this.registerIP.Low = ((byte)(0));
            this.registerIP.Margin = new System.Windows.Forms.Padding(5);
            this.registerIP.Name = "registerIP";
            this.registerIP.Readonly = false;
            this.registerIP.RegisterName = "IP";
            this.registerIP.Size = new System.Drawing.Size(100, 17);
            this.registerIP.TabIndex = 0;
            this.registerIP.Value = ((ushort)(0));
            // 
            // registerDI
            // 
            this.registerDI.Extended = false;
            this.registerDI.High = ((byte)(0));
            this.registerDI.Location = new System.Drawing.Point(8, 176);
            this.registerDI.Low = ((byte)(0));
            this.registerDI.Margin = new System.Windows.Forms.Padding(5);
            this.registerDI.Name = "registerDI";
            this.registerDI.Readonly = false;
            this.registerDI.RegisterName = "DI";
            this.registerDI.Size = new System.Drawing.Size(100, 17);
            this.registerDI.TabIndex = 0;
            this.registerDI.Value = ((ushort)(0));
            // 
            // registerSI
            // 
            this.registerSI.Extended = false;
            this.registerSI.High = ((byte)(0));
            this.registerSI.Location = new System.Drawing.Point(8, 155);
            this.registerSI.Low = ((byte)(0));
            this.registerSI.Margin = new System.Windows.Forms.Padding(5);
            this.registerSI.Name = "registerSI";
            this.registerSI.Readonly = false;
            this.registerSI.RegisterName = "SI";
            this.registerSI.Size = new System.Drawing.Size(100, 17);
            this.registerSI.TabIndex = 0;
            this.registerSI.Value = ((ushort)(0));
            // 
            // registerES
            // 
            this.registerES.Extended = false;
            this.registerES.High = ((byte)(0));
            this.registerES.Location = new System.Drawing.Point(113, 85);
            this.registerES.Low = ((byte)(0));
            this.registerES.Margin = new System.Windows.Forms.Padding(5);
            this.registerES.Name = "registerES";
            this.registerES.Readonly = false;
            this.registerES.RegisterName = "ES";
            this.registerES.Size = new System.Drawing.Size(100, 17);
            this.registerES.TabIndex = 0;
            this.registerES.Value = ((ushort)(0));
            // 
            // registerDX
            // 
            this.registerDX.Extended = false;
            this.registerDX.High = ((byte)(0));
            this.registerDX.Location = new System.Drawing.Point(8, 85);
            this.registerDX.Low = ((byte)(0));
            this.registerDX.Margin = new System.Windows.Forms.Padding(5);
            this.registerDX.Name = "registerDX";
            this.registerDX.Readonly = false;
            this.registerDX.RegisterName = "DX";
            this.registerDX.Size = new System.Drawing.Size(100, 17);
            this.registerDX.TabIndex = 0;
            this.registerDX.Value = ((ushort)(0));
            // 
            // registerBP
            // 
            this.registerBP.Extended = false;
            this.registerBP.High = ((byte)(0));
            this.registerBP.Location = new System.Drawing.Point(8, 135);
            this.registerBP.Low = ((byte)(0));
            this.registerBP.Margin = new System.Windows.Forms.Padding(5);
            this.registerBP.Name = "registerBP";
            this.registerBP.Readonly = false;
            this.registerBP.RegisterName = "BP";
            this.registerBP.Size = new System.Drawing.Size(100, 17);
            this.registerBP.TabIndex = 0;
            this.registerBP.Value = ((ushort)(0));
            // 
            // registerSS
            // 
            this.registerSS.Extended = false;
            this.registerSS.High = ((byte)(0));
            this.registerSS.Location = new System.Drawing.Point(113, 64);
            this.registerSS.Low = ((byte)(0));
            this.registerSS.Margin = new System.Windows.Forms.Padding(5);
            this.registerSS.Name = "registerSS";
            this.registerSS.Readonly = false;
            this.registerSS.RegisterName = "SS";
            this.registerSS.Size = new System.Drawing.Size(100, 17);
            this.registerSS.TabIndex = 0;
            this.registerSS.Value = ((ushort)(0));
            // 
            // registerCX
            // 
            this.registerCX.Extended = false;
            this.registerCX.High = ((byte)(0));
            this.registerCX.Location = new System.Drawing.Point(8, 64);
            this.registerCX.Low = ((byte)(0));
            this.registerCX.Margin = new System.Windows.Forms.Padding(5);
            this.registerCX.Name = "registerCX";
            this.registerCX.Readonly = false;
            this.registerCX.RegisterName = "CX";
            this.registerCX.Size = new System.Drawing.Size(100, 17);
            this.registerCX.TabIndex = 0;
            this.registerCX.Value = ((ushort)(0));
            // 
            // registerSP
            // 
            this.registerSP.Extended = false;
            this.registerSP.High = ((byte)(0));
            this.registerSP.Location = new System.Drawing.Point(8, 114);
            this.registerSP.Low = ((byte)(0));
            this.registerSP.Margin = new System.Windows.Forms.Padding(5);
            this.registerSP.Name = "registerSP";
            this.registerSP.Readonly = false;
            this.registerSP.RegisterName = "SP";
            this.registerSP.Size = new System.Drawing.Size(100, 17);
            this.registerSP.TabIndex = 0;
            this.registerSP.Value = ((ushort)(0));
            // 
            // registerDS
            // 
            this.registerDS.Extended = false;
            this.registerDS.High = ((byte)(0));
            this.registerDS.Location = new System.Drawing.Point(113, 44);
            this.registerDS.Low = ((byte)(0));
            this.registerDS.Margin = new System.Windows.Forms.Padding(5);
            this.registerDS.Name = "registerDS";
            this.registerDS.Readonly = false;
            this.registerDS.RegisterName = "DS";
            this.registerDS.Size = new System.Drawing.Size(100, 17);
            this.registerDS.TabIndex = 0;
            this.registerDS.Value = ((ushort)(0));
            // 
            // registerBX
            // 
            this.registerBX.Extended = false;
            this.registerBX.High = ((byte)(0));
            this.registerBX.Location = new System.Drawing.Point(8, 44);
            this.registerBX.Low = ((byte)(0));
            this.registerBX.Margin = new System.Windows.Forms.Padding(5);
            this.registerBX.Name = "registerBX";
            this.registerBX.Readonly = false;
            this.registerBX.RegisterName = "BX";
            this.registerBX.Size = new System.Drawing.Size(100, 17);
            this.registerBX.TabIndex = 0;
            this.registerBX.Value = ((ushort)(0));
            // 
            // registerCS
            // 
            this.registerCS.Extended = false;
            this.registerCS.High = ((byte)(0));
            this.registerCS.Location = new System.Drawing.Point(113, 23);
            this.registerCS.Low = ((byte)(0));
            this.registerCS.Margin = new System.Windows.Forms.Padding(5);
            this.registerCS.Name = "registerCS";
            this.registerCS.Readonly = false;
            this.registerCS.RegisterName = "CS";
            this.registerCS.Size = new System.Drawing.Size(100, 17);
            this.registerCS.TabIndex = 0;
            this.registerCS.Value = ((ushort)(0));
            // 
            // registerAX
            // 
            this.registerAX.Extended = false;
            this.registerAX.High = ((byte)(0));
            this.registerAX.Location = new System.Drawing.Point(8, 23);
            this.registerAX.Low = ((byte)(0));
            this.registerAX.Margin = new System.Windows.Forms.Padding(5);
            this.registerAX.Name = "registerAX";
            this.registerAX.Readonly = false;
            this.registerAX.RegisterName = "AX";
            this.registerAX.Size = new System.Drawing.Size(100, 17);
            this.registerAX.TabIndex = 0;
            this.registerAX.Value = ((ushort)(0));
            // 
            // memorySegmentDisplay1
            // 
            this.memorySegmentDisplay1.Location = new System.Drawing.Point(8, 22);
            this.memorySegmentDisplay1.Name = "memorySegmentDisplay1";
            this.memorySegmentDisplay1.Size = new System.Drawing.Size(346, 151);
            this.memorySegmentDisplay1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 495);
            this.Controls.Add(this.stackDisplay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.runBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Intel 8086 Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
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
    }
}

