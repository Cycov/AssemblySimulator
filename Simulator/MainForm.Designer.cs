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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(282, 337);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(75, 23);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(199, 319);
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
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registers";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(217, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memory";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stackDisplay
            // 
            this.stackDisplay.Location = new System.Drawing.Point(496, 15);
            this.stackDisplay.Name = "stackDisplay";
            this.stackDisplay.Size = new System.Drawing.Size(125, 375);
            this.stackDisplay.TabIndex = 4;
            // 
            // registerFLAGS
            // 
            this.registerFLAGS.Location = new System.Drawing.Point(166, 19);
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
            this.registerAX.Name = "registerAX";
            this.registerAX.Readonly = false;
            this.registerAX.RegisterName = "AX";
            this.registerAX.Size = new System.Drawing.Size(75, 14);
            this.registerAX.TabIndex = 0;
            this.registerAX.Value = ((ushort)(0));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stackDisplay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.runBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Intel 8086 Simulator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

