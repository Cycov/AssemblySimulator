using System;
using System.Windows.Forms;

namespace Simulator
{
    public partial class MainForm : Form
    {
        Memory coreMemory;

        public MainForm()
        {
            InitializeComponent();
            registerFLAGS.SetFlag(Simulator.Controls.Flags.FlagsRegister.Flags.IF, true);
            registerFLAGS.SetFlag(Simulator.Controls.Flags.FlagsRegister.Flags.DF, true);
            coreMemory = new Memory();
            registerSP.Value = 0;
            stackDisplay.Init(coreMemory, 5476, registerSP.Value);
            memorySegmentDisplay1.Init(coreMemory, registerSP.Value);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            coreMemory.SetWord(int.Parse(textBox1.Text), (ushort)(new Random()).Next(0, 0xFFFF));
        }
    }
}
