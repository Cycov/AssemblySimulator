﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator.Controls
{
    class MemorySegmentDisplay : MemoryDisplay
    {

        protected readonly int bytePadding = 0;

        public MemorySegmentDisplay()
        {
            this.Paint += MemorySegmentDisplay_Paint;
            this.DoubleClick += MemorySegmentDisplay_DoubleClick;
            this.Click += MemorySegmentDisplay_Click;
        }

        private void MemorySegmentDisplay_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).X < valueXMin)
            {
                JumpToAdress jumpBox = new JumpToAdress(segment, SelectedOffset);
                if (jumpBox.ShowDialog() == DialogResult.OK)
                {
                    segment = jumpBox.Segment;
                    baseOffset = jumpBox.Offset % BytesPerLine;
                    SelectedOffset = jumpBox.Offset;
                    Invalidate();
                }
            }
        }

        private void MemorySegmentDisplay_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void MemorySegmentDisplay_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            
        }
    }
}
