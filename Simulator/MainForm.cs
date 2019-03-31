using System;
using System.Windows.Forms;

namespace Simulator
{
    public partial class MainForm : Form
    {
        Memory coreMemory;
        Microprocessor.MicroprocessorDisplay microprocessorDisplay;

        public MainForm()
        {
            InitializeComponent();
            registerFLAGS.SetFlag(Simulator.Controls.Flags.FlagsRegister.Flags.IF, true);
            registerFLAGS.SetFlag(Simulator.Controls.Flags.FlagsRegister.Flags.DF, true);
            coreMemory = new Memory(65536); //As much as it can be adressed with 16 bits
            registerSS.Value = 0xFFF0;
            stackDisplay.Init(coreMemory, registerSS, 4);
            memorySegmentDisplay1.Init(coreMemory, registerDS);

            microprocessorDisplay = new Microprocessor.MicroprocessorDisplay();
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

        private void microprocessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            microprocessorDisplay.StartPosition = FormStartPosition.Manual;
            microprocessorDisplay.Location = new System.Drawing.Point(Location.X + Width, Location.Y);
            microprocessorDisplay.Show();
            microprocessorDisplay.Invalidate();
            microprocessorDisplay.Update();
        }
    }
}
