using System;
using Simulator.EvArgs;

namespace Simulator
{
    public class Memory
    {
        public byte[] Locations { get; protected set; }
        public readonly int Size = 1048576;

        public event EventHandler<MemoryByteModifiedEventArgs> OnMemoryByteModified;
        public event EventHandler<MemoryWordModifiedEventArgs> OnMemoryWordModified;
        public event EventHandler<MemoryDWordModifiedEventArgs> OnMemoryDWordModified;
        public event EventHandler<MemoryQWordModifiedEventArgs> OnMemoryQWordModified;
        public event EventHandler<MemoryModifiedEventArgs> OnMemoryModified;

        public Memory()
        {
            Locations = new byte[Size];
        }

        public Memory(int size)
        {
            throw new NotImplementedException();
        }

        public void SetByte(int adress, byte value)
        {
            if (adress > Size)
                throw new IndexOutOfRangeException("Adress out of addresable memory: " + adress.ToString());
            Locations[adress] = value;
            OnMemoryByteModified?.Invoke(this, new MemoryByteModifiedEventArgs(adress, value));
            OnMemoryModified?.Invoke(this, new MemoryModifiedEventArgs(adress, 8));
        }

        public void SetWord(int adress, ushort value)
        {
            if (adress > Size)
                throw new IndexOutOfRangeException("Adress out of addresable memory: " + adress.ToString());
            Locations[adress] = (byte)value;
            Locations[adress + 1] = (byte)(value >> 8);
            OnMemoryWordModified?.Invoke(this, new MemoryWordModifiedEventArgs(adress, value));
            OnMemoryModified?.Invoke(this, new MemoryModifiedEventArgs(adress, 16));
        }

        public void SetDWord(int adress, ushort value)
        {
            if (adress > Size)
                throw new IndexOutOfRangeException("Adress out of addresable memory: " + adress.ToString());
            Locations[adress] = (byte)value;
            Locations[adress + 1] = (byte)(value >> 8);
            Locations[adress + 2] = (byte)(value >> 16);
            Locations[adress + 3] = (byte)(value >> 24);
            OnMemoryDWordModified?.Invoke(this, new MemoryDWordModifiedEventArgs(adress, value));
            OnMemoryModified?.Invoke(this, new MemoryModifiedEventArgs(adress, 32));
        }

        public void SetQWord(int adress, ushort value)
        {
            if (adress > Size)
                throw new IndexOutOfRangeException("Adress out of addresable memory: " + adress.ToString());
            Locations[adress] = (byte)value;
            Locations[adress + 1] = (byte)(value >> 8);
            Locations[adress + 2] = (byte)(value >> 16);
            Locations[adress + 3] = (byte)(value >> 24);
            Locations[adress + 4] = (byte)(value >> 32);
            Locations[adress + 5] = (byte)(value >> 40);
            Locations[adress + 6] = (byte)(value >> 48);
            Locations[adress + 7] = (byte)(value >> 56);
            OnMemoryQWordModified?.Invoke(this, new MemoryQWordModifiedEventArgs(adress, value));
            OnMemoryModified?.Invoke(this, new MemoryModifiedEventArgs(adress, 64));
        }

        public byte GetByte(int adress)
        {
            if (adress > Size)
                throw new IndexOutOfRangeException("Adress out of addresable memory: " + adress.ToString());
            return Locations[adress];
        }
        public ushort GetWord(int adress)
        {
            ushort word;
            if (adress > Size)
                throw new IndexOutOfRangeException("Adress out of addresable memory: " + adress.ToString());
            word = (ushort)(Locations[adress] | 
                           (Locations[adress + 1] << 8));
            return word;
        }
        public Int32 GetDWord(int adress)
        {
            Int32 dword;
            if (adress > Size)
                throw new IndexOutOfRangeException("Adress out of addresable memory: " + adress.ToString());
            dword = (Int32)(Locations[adress] |
                           (Locations[adress + 1] << 8) |
                           (Locations[adress + 2] << 16) |
                           (Locations[adress + 3] << 24));
            return dword;
        }
        public Int64 GetQWord(int adress)
        {
            Int64 qword;
            if (adress > Size)
                throw new IndexOutOfRangeException("Adress out of addresable memory: " + adress.ToString());
            qword = (Int64)(Locations[adress] |
                           (Locations[adress + 1] << 8) |
                           (Locations[adress + 2] << 16) |
                           (Locations[adress + 3] << 24) |
                           (Locations[adress + 4] << 32) |
                           (Locations[adress + 5] << 40) |
                           (Locations[adress + 6] << 48) |
                           (Locations[adress + 7] << 56));
            return qword;
        }
    }
}
