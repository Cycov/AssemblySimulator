using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.EvArgs
{
    public class MemoryModifiedEventArgs : System.EventArgs
    {
        public int Adress;
        public byte ValueSize;
        public MemoryModifiedEventArgs(int adress, byte valueSize)
        {
            Adress = adress;
            ValueSize = valueSize;
        }
    }
    public class MemoryByteModifiedEventArgs : System.EventArgs
    {
        public byte Value;
        public int Adress;
        public MemoryByteModifiedEventArgs(int adress, byte value)
        {
            Value = value;
            Adress = adress;
        }
    }
    public class MemoryWordModifiedEventArgs : System.EventArgs
    {
        public ushort Value;
        public int Adress;
        public MemoryWordModifiedEventArgs(int adress, ushort value)
        {
            Value = value;
            Adress = adress;
        }
    }
    public class MemoryDWordModifiedEventArgs : System.EventArgs
    {
        public UInt32 Value;
        public int Adress;
        public MemoryDWordModifiedEventArgs(int adress, UInt32 value)
        {
            Value = value;
            Adress = adress;
        }
    }
    public class MemoryQWordModifiedEventArgs : System.EventArgs
    {
        public UInt64 Value;
        public int Adress;
        public MemoryQWordModifiedEventArgs(int adress, UInt64 value)
        {
            Value = value;
            Adress = adress;
        }
    }
}
