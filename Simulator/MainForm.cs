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
            registerSS.Value = 0xFFF0;
            stackDisplay.Init(coreMemory, registerSS, 4);
            memorySegmentDisplay1.Init(coreMemory, registerDS);
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            coreMemory.SetWord(ushort.Parse(textBox1.Text, System.Globalization.NumberStyles.HexNumber), (ushort)(new Random()).Next());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void memorySegmentDisplay1_Load(object sender, EventArgs e)
        {

        }

        private void stackDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
