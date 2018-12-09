using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.EvArgs
{
    public class MemoryModifiedEventArgs : System.EventArgs
    {
        public int Adress { get; }
        public byte ValueSize { get; }
        public MemoryModifiedEventArgs(int adress, byte valueSize)
        {
            Adress = adress;
            ValueSize = valueSize;
        }
    }
    public class MemoryByteModifiedEventArgs : System.EventArgs
    {
        public byte Value { get; }
        public int Adress { get; }
        public MemoryByteModifiedEventArgs(int adress, byte value)
        {
            Value = value;
            Adress = adress;
        }
    }
    public class MemoryWordModifiedEventArgs : System.EventArgs
    {
        public ushort Value { get; }
        public int Adress { get; }
        public MemoryWordModifiedEventArgs(int adress, ushort value)
        {
            Value = value;
            Adress = adress;
        }
    }
    public class MemoryDWordModifiedEventArgs : System.EventArgs
    {
        public UInt32 Value { get; }
        public int Adress { get; }
        public MemoryDWordModifiedEventArgs(int adress, UInt32 value)
        {
            Value = value;
            Adress = adress;
        }
    }
    public class MemoryQWordModifiedEventArgs : System.EventArgs
    {
        public UInt64 Value { get; }
        public int Adress { get; }
        public MemoryQWordModifiedEventArgs(int adress, UInt64 value)
        {
            Value = value;
            Adress = adress;
        }
    }
    public class RegisterModifiedEventArgs : System.EventArgs
    {
        public string Name { get; }
        public ushort Value { get; }
        public RegisterModifiedEventArgs(string name, ushort value)
        {
            Name = name;
            Value = value;
        }
    }
}
