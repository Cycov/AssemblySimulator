using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulator.EvArgs;

namespace Simulator.Controls
{
    public abstract partial class MemoryDisplay : UserControl
    {
        protected ushort segment;

        protected readonly int lineHeight = 14;
        protected Font boldedFont;

        protected int maxLines;

        protected Memory memory;

        public MemoryDisplay()
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
        public void Init(Memory memory, ushort segment)
        {
            this.segment = segment;
            this.memory = memory;
            this.memory.OnMemoryModified += Memory_OnMemoryModified;
        }

        private void Memory_OnMemoryModified(object sender, EvArgs.MemoryModifiedEventArgs e)
        {
            Invalidate();
        }

        private void MemoryDisplay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.LightGray, 0, 0, Width - 1, Height - 1);
            e.Graphics.FillRectangle(Brushes.LightGray, 0, 0, 50f, Height);
            e.Graphics.FillRectangle(Brushes.LightBlue, 0, 0, Width, 14f);

            e.Graphics.DrawString("Offset", boldedFont, Brushes.Black, 5, 1);
            e.Graphics.DrawString("Value", boldedFont, Brushes.Black, (Width - 50f) / 2 - 10f, 1);

            if (memory == null) //just for the designer
            {
                int offset = 0;
                for (int i = 1; i <= maxLines; i++, offset += 2)
                {
                    //Draw line number
                    e.Graphics.DrawString("0x" + offset.ToString("X4"), Font, Brushes.Black, 2, i * lineHeight);
                    e.Graphics.DrawString("0xFFFF", boldedFont, Brushes.BlueViolet, 60f, i * lineHeight);
                }
            }
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }
    }
}
