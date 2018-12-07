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
            registerSP.Value = 0x8000;
            stackDisplay.Init(coreMemory, 5476, registerSP.Value);
            memorySegmentDisplay1.Init(coreMemory, registerSP.Value);
        }
    }
}
