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
    public partial class StackDisplay : MemoryDisplay
    {
        [Category("Definitions")]
        public int StackSize
        {
            get { return m_stackSize;  }
        }
        private int m_stackSize = 16;

        public StackDisplay()
        {
            InitializeComponent();
            Size = new Size(125, 375);
            boldedFont = new Font(this.Font, FontStyle.Bold);
            maxLines = Height / lineHeight;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="size">Max size of 1048576</param>
        public void Init(Memory memory, int size, ushort segment)
        {
            if (size >= memory.Size)
                throw new ArgumentOutOfRangeException("The memory is not big enough to support that size");
            if (size % 2 != 0)
                throw new ArgumentException("Please use a even size");
            m_stackSize = size;
            if (m_stackSize / 2 < maxLines)
            {
                vScrollBar.Visible = false;
                maxLines = m_stackSize / 2;
            }
            else
            {
                vScrollBar.Maximum = m_stackSize - 42;
            }

            base.Init(memory, segment);
        }

        private void Memory_OnMemoryModified(object sender, EvArgs.MemoryModifiedEventArgs e)
        {
            Invalidate();
        }

        private void StackDisplay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.LightGray, 0, 0, Width - 1, Height - 1);
            e.Graphics.FillRectangle(Brushes.LightGray, 0, 0, 50f, Height);
            e.Graphics.FillRectangle(Brushes.LightBlue, 0, 0, Width, 14f);

            e.Graphics.DrawString("Offset", boldedFont, Brushes.Black, 5, 1);
            e.Graphics.DrawString("Value", boldedFont, Brushes.Black, 70f, 1);

            if (memory != null) //just for the designer
            {
                int offset = vScrollBar.Value;
                int lines = m_stackSize - offset;
                if (lines > maxLines)
                    lines = maxLines;
                for (int i = 1; i <= lines; i++, offset += 2)
                {
                    //Draw line number
                    e.Graphics.DrawString("0x" + offset.ToString("X4"), Font, Brushes.Black, 2, i * lineHeight);
                    e.Graphics.DrawString("0x" + memory.GetWord((segment << 4) + offset).ToString("X4"), boldedFont, Brushes.BlueViolet, 60f, i * lineHeight);
                }
            }
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }
    }
}
