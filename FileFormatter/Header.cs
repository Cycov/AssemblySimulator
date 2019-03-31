using System;
using System.Collections.Generic;
using System.Text;

namespace FileFormatter
{
    [Serializable]
    public struct Header
    {
        public ModelType Model;

        public bool HasData;
        public const int MemorySize = 65536;
        public int StackSize;

        public int DataSegmentStart;
        public int CodeSegmentStart;
        public int StackSegmentStart;

        public int StartAdressOffset;
    }
}
