using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator.Controls
{
    public partial class Register : UserControl
    {
        [Category("Definitions")]
        public string RegisterName
        {
            get; set;
        } = "IR";


        [Category("Definitions")]
        public ushort Value
        {
            get => m_value;
            set
            {
                m_value = value;
                Invalidate();
            }
        }
        private ushort m_value = 0;

        [Category("Definitions")]
        public bool Extended
        {
            get; set;
        } = false;

        [Category("Definitions")]
        public bool Readonly
        {
            get; set;
        } = false;

        public byte Low
        {
            get => (byte)m_value;
            set
            {
                m_value = (ushort)((m_value & 0xFF00) | value);
                Invalidate();
            }
        }

        public byte High
        {
            get => (byte)(m_value >> 8);
            set
            {
                m_value = (ushort)((m_value & 0x00FF) | value);
                Invalidate();
            }
        }

        private SolidBrush generalUseBrush;

        public Register()
        {
            InitializeComponent();
            generalUseBrush = new SolidBrush(ForeColor);
            Size = new Size(75, 14);
        }

        private void Register_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(RegisterName + ":", new Font(Font.FontFamily, Font.Size, FontStyle.Bold, Font.Unit), generalUseBrush, 0F, 0F);
            e.Graphics.DrawString(" 0x" + m_value.ToString("X4"), Font, generalUseBrush, Extended ? 45F : 30F, 0F);
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (Readonly)
                return;
            int result;
            if ((result = NumericalValueEditor.ShowDialog(Value)) > -1)
            {
                Value = (ushort)result;
            }
        }
    }
}
